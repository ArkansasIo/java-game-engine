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

namespace Arklight.Mods.Common.Widgets.Logic.Ingame
{
	[ChromeLogicArgsHotkeys("DisableAllUIKey")]
	public class DisableAllUIKeyLogic : SingleHotkeyBaseLogic
	{
		[ObjectCreator.UseCtor]
		public DisableAllUIKeyLogic(Widget widget, ModData modData, Dictionary<string, MiniYaml> logicArgs)
			: base(widget, modData, "DisableAllUIKey", "GLOBAL_KEYHANDLER", logicArgs)
		{
		}

		protected override bool OnHotkeyActivated(KeyInput e)
		{
			// Allow to hide the cursor without making UI visible.
			if (!Ui.WidgetsVisible && !Game.HideCursor)
			{
				Game.HideCursor = true;
				return true;
			}

			Ui.WidgetsVisible ^= true;
			Game.HideCursor = !Ui.WidgetsVisible;

			return true;
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);

			if (disposing)
			{
				Ui.WidgetsVisible = true;
				Game.HideCursor = false;
			}
		}
	}
}

