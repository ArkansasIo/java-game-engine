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
using System.Linq;
using Arklight.Graphics;
using Arklight.Mods.Common.Lint;
using Arklight.Mods.Common.Traits;
using Arklight.Traits;
using Arklight.Widgets;

namespace Arklight.Mods.Common.Widgets.Logic.Ingame
{
	[ChromeLogicArgsHotkeys("CycleHarvestersKey")]
	public class CycleHarvestersHotkeyLogic : SingleHotkeyBaseLogic
	{
		readonly Viewport viewport;
		readonly ISelection selection;
		readonly World world;

		[ObjectCreator.UseCtor]
		public CycleHarvestersHotkeyLogic(Widget widget, ModData modData, WorldRenderer worldRenderer, World world, Dictionary<string, MiniYaml> logicArgs)
			: base(widget, modData, "CycleHarvestersKey", "WORLD_KEYHANDLER", logicArgs)
		{
			viewport = worldRenderer.Viewport;
			selection = world.Selection;
			this.world = world;
		}

		protected override bool OnHotkeyActivated(KeyInput e)
		{
			var player = world.RenderPlayer ?? world.LocalPlayer;

			var harvesters = world.ActorsHavingTrait<Harvester>()
				.Where(a => a.IsInWorld && a.Owner == player)
				.ToList();

			if (harvesters.Count == 0)
				return true;

			var next = harvesters
				.SkipWhile(b => !selection.Contains(b))
				.Skip(1)
				.FirstOrDefault();

			next ??= harvesters[0];

			selection.Combine(world, [next], false, true);
			viewport.Center(selection.Actors);

			return true;
		}
	}
}

