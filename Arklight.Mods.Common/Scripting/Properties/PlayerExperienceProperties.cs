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

using Arklight.Mods.Common.Traits;
using Arklight.Scripting;
using Arklight.Traits;

namespace Arklight.Mods.Common.Scripting
{
	[ScriptPropertyGroup("Player")]
	public class PlayerExperienceProperties : ScriptPlayerProperties, Requires<PlayerExperienceInfo>
	{
		readonly PlayerExperience exp;

		public PlayerExperienceProperties(ScriptContext context, Player player)
			: base(context, player)
		{
			exp = player.PlayerActor.Trait<PlayerExperience>();
		}

		[Desc("Get or set the current experience.")]
		public int Experience
		{
			get => exp.Experience;

			set => exp.GiveExperience(value - exp.Experience);
		}
	}
}

