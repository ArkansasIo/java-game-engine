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
using Arklight.Mods.Common.Traits;
using Arklight.Widgets;

namespace Arklight.Mods.Common.Widgets.Logic.Ingame
{
	[ChromeLogicArgsHotkeys("JumpToLastEventKey")]
	public class JumpToLastEventHotkeyLogic : SingleHotkeyBaseLogic
	{
		readonly Viewport viewport;
		readonly RadarPings radarPings;

		[ObjectCreator.UseCtor]
		public JumpToLastEventHotkeyLogic(Widget widget, ModData modData, WorldRenderer worldRenderer, World world, Dictionary<string, MiniYaml> logicArgs)
			: base(widget, modData, "JumpToLastEventKey", "WORLD_KEYHANDLER", logicArgs)
		{
			viewport = worldRenderer.Viewport;
			radarPings = world.WorldActor.TraitOrDefault<RadarPings>();
		}

		protected override bool OnHotkeyActivated(KeyInput e)
		{
			if (radarPings == null || radarPings.LastPingPosition == null)
				return true;

			viewport.Center(radarPings.LastPingPosition.Value);

			return true;
		}
	}
}

