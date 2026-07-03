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

using Arklight.Widgets;

namespace Arklight.Mods.Common.Widgets.Logic
{
	public class MuteIndicatorLogic : ChromeLogic
	{
		[ObjectCreator.UseCtor]
		public MuteIndicatorLogic(Widget widget)
		{
			var gs = Game.Settings.Sound;
			widget.IsVisible = () => gs.Mute;
		}
	}
}

