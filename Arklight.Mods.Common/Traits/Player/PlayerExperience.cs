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
	[TraitLocation(SystemActors.Player)]
	[Desc("This trait can be used to track player experience based on units killed with the `" + nameof(GivesExperience) + "` trait.",
		"It can also be used as a point score system in scripted maps, for example.",
		"Attach this to the player actor.")]
	public class PlayerExperienceInfo : TraitInfo
	{
		public override object Create(ActorInitializer init) { return new PlayerExperience(); }
	}

	public class PlayerExperience : ISync
	{
		[VerifySync]
		public int Experience { get; private set; }

		public void GiveExperience(int num)
		{
			Experience += num;
		}
	}
}

