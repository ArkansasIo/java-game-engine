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
using Arklight.Graphics;
using Arklight.Mods.Common.Lint;
using Arklight.Widgets;

namespace Arklight.Mods.Common.Widgets.Logic.Ingame
{
	[ChromeLogicArgsHotkeys("ResetZoomKey")]
	public class ResetZoomHotkeyLogic : SingleHotkeyBaseLogic
	{
		readonly Viewport viewport;

		[ObjectCreator.UseCtor]
		public ResetZoomHotkeyLogic(Widget widget, ModData modData, WorldRenderer worldRenderer, Dictionary<string, MiniYaml> logicArgs)
			: base(widget, modData, "ResetZoomKey", "WORLD_KEYHANDLER", logicArgs)
		{
			viewport = worldRenderer.Viewport;
		}

		protected override bool OnHotkeyActivated(KeyInput e)
		{
			viewport.ToggleZoom();

			return true;
		}
	}
}

