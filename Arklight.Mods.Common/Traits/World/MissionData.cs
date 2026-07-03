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
	[Desc("Defines the FMVs that can be played by missions.")]
	[TraitLocation(SystemActors.World)]
	public class MissionDataInfo : TraitInfo<MissionData>
	{
		[FluentReference(optional: true)]
		[Desc("Briefing text displayed in the mission browser.")]
		public readonly string Briefing;

		[Desc("Played by the \"Background Info\" button in the mission browser.")]
		public readonly string BackgroundVideo;

		[Desc("Played by the \"Briefing\" button in the mission browser.")]
		public readonly string BriefingVideo;

		[Desc("Automatically played before starting the mission.")]
		public readonly string StartVideo;

		[Desc("Automatically played when the player wins the mission.")]
		public readonly string WinVideo;

		[Desc("Automatically played when the player loses the mission.")]
		public readonly string LossVideo;
	}

	public class MissionData { }
}

