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

using Arklight.Traits;

namespace Arklight.Mods.Common.Traits
{
	[Desc("This actor deflects missiles.")]
	public class JamsMissilesInfo : ConditionalTraitInfo
	{
		[Desc("Range of the deflection.")]
		public readonly WDist Range = WDist.Zero;

		[Desc("What player relationships are affected.")]
		public readonly PlayerRelationship DeflectionRelationships = PlayerRelationship.Ally | PlayerRelationship.Neutral | PlayerRelationship.Enemy;

		[Desc("Chance of deflecting missiles.")]
		public readonly int Chance = 100;

		public override object Create(ActorInitializer init) { return new JamsMissiles(this); }
	}

	public class JamsMissiles : ConditionalTrait<JamsMissilesInfo>
	{
		public WDist Range => IsTraitDisabled ? WDist.Zero : Info.Range;
		public PlayerRelationship DeflectionStances => Info.DeflectionRelationships;
		public int Chance => Info.Chance;

		public JamsMissiles(JamsMissilesInfo info)
			: base(info) { }
	}
}

