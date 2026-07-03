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
using Arklight.Mods.Common.Traits;
using Arklight.Mods.Common.Traits.Render;
using Arklight.Primitives;
using Arklight.Traits;

namespace Arklight.Mods.Cnc.Traits
{
	[Desc("Reveals a decoration sprite to the indicated players when infiltrated.")]
	sealed class InfiltrateForDecorationInfo : WithDecorationInfo
	{
		[Desc("The `TargetTypes` from `Targetable` that are allowed to enter.")]
		public readonly BitSet<TargetableType> Types = default;

		[Desc("Experience to grant to the infiltrating player.")]
		public readonly int PlayerExperience = 0;

		public override object Create(ActorInitializer init) { return new InfiltrateForDecoration(init.Self, this); }
	}

	sealed class InfiltrateForDecoration : WithDecoration, INotifyInfiltrated
	{
		readonly HashSet<Player> infiltrators = [];
		readonly InfiltrateForDecorationInfo info;

		public InfiltrateForDecoration(Actor self, InfiltrateForDecorationInfo info)
			: base(self, info)
		{
			this.info = info;
		}

		void INotifyInfiltrated.Infiltrated(Actor self, Actor infiltrator, BitSet<TargetableType> types)
		{
			if (!info.Types.Overlaps(types))
				return;

			infiltrator.Owner.PlayerActor.TraitOrDefault<PlayerExperience>()?.GiveExperience(info.PlayerExperience);

			infiltrators.Add(infiltrator.Owner);
		}

		protected override bool ShouldRender(Actor self)
		{
			return infiltrators.Any(i => Info.ValidRelationships.HasRelationship(i.RelationshipWith(self.World.RenderPlayer)));
		}
	}
}

