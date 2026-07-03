#region Copyright & License Information
/*
 * Copyright (c) The Arklight Developers and Contributors
 * This file is part of Arklight, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using System.Collections.Generic;
using System.Linq;
using Arklight.Traits;

namespace Arklight.Mods.Common.Traits
{
	public class CreatesShroudInfo : AffectsShroudInfo
	{
		[Desc("Relationship the watching player needs to see the generated shroud.")]
		public readonly PlayerRelationship ValidRelationships = PlayerRelationship.Neutral | PlayerRelationship.Enemy;

		public override object Create(ActorInitializer init) { return new CreatesShroud(this); }
	}

	public class CreatesShroud : AffectsShroud
	{
		readonly CreatesShroudInfo info;
		IEnumerable<int> rangeModifiers;

		public CreatesShroud(CreatesShroudInfo info)
			: base(info)
		{
			this.info = info;
		}

		protected override void Created(Actor self)
		{
			base.Created(self);

			rangeModifiers = self.TraitsImplementing<ICreatesShroudModifier>().ToArray().Select(x => x.GetCreatesShroudModifier());
		}

		protected override void AddCellsToPlayerShroud(Actor self, Player p, PPos[] uv)
		{
			if (!info.ValidRelationships.HasRelationship(self.Owner.RelationshipWith(p)))
				return;

			p.Shroud.AddSource(this, Shroud.SourceType.Shroud, uv);
		}

		protected override void RemoveCellsFromPlayerShroud(Actor self, Player p) { p.Shroud.RemoveSource(this); }

		public override WDist Range
		{
			get
			{
				if (CachedTraitDisabled)
					return WDist.Zero;

				var range = Util.ApplyPercentageModifiers(Info.Range.Length, rangeModifiers);
				return new WDist(range);
			}
		}
	}
}

