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
using Arklight.Mods.Common.Lint;
using Arklight.Widgets;

namespace Arklight.Mods.Common.Widgets.Logic
{
	[ChromeLogicArgsHotkeys("MuteAudioKey")]
	public class MuteHotkeyLogic : SingleHotkeyBaseLogic
	{
		[FluentReference]
		const string AudioMuted = "label-audio-muted";

		[FluentReference]
		const string AudioUnmuted = "label-audio-unmuted";

		[ObjectCreator.UseCtor]
		public MuteHotkeyLogic(Widget widget, ModData modData, Dictionary<string, MiniYaml> logicArgs)
			: base(widget, modData, "MuteAudioKey", "GLOBAL_KEYHANDLER", logicArgs) { }

		protected override bool OnHotkeyActivated(KeyInput e)
		{
			Game.Settings.Sound.Mute ^= true;

			if (Game.Settings.Sound.Mute)
			{
				Game.Sound.MuteAudio();
				TextNotificationsManager.AddFeedbackLine(FluentProvider.GetMessage(AudioMuted));
			}
			else
			{
				Game.Sound.UnmuteAudio();
				TextNotificationsManager.AddFeedbackLine(FluentProvider.GetMessage(AudioUnmuted));
			}

			return true;
		}
	}
}

