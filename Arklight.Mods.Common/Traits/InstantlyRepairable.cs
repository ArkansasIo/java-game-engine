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

using Arklight.Primitives;

namespace Arklight.Mods.Common.Traits
{
	public class InstantlyRepairType { }

	[Desc("Eligible for instant repair.")]
	public class InstantlyRepairableInfo : ConditionalTraitInfo
	{
		[Desc("Actors with these Types under EngineerRepair trait can repair me.")]
		public readonly BitSet<InstantlyRepairType> Types = default;

		public override object Create(ActorInitializer init) { return new InstantlyRepairable(this); }
	}

	public class InstantlyRepairable : ConditionalTrait<InstantlyRepairableInfo>
	{
		public InstantlyRepairable(InstantlyRepairableInfo info)
			: base(info) { }
	}
}

