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
using Arklight.Traits;

namespace Arklight.Mods.Common.Orders
{
	public class BeaconOrderGenerator : OrderGenerator
	{
		protected override MouseActionType ActionType => MouseActionType.PlaceBuilding;

		public BeaconOrderGenerator(World world)
			: base(world) { }

		protected override IEnumerable<Order> OrderInner(World world, CPos cell, int2 worldPixel, MouseInput mi)
		{
			world.CancelInputMode();
			yield return new Order("PlaceBeacon", world.LocalPlayer.PlayerActor, Target.FromCell(world, cell), false) { SuppressVisualFeedback = true };
		}

		protected override IEnumerable<IRenderable> Render(WorldRenderer wr, World world) { yield break; }
		protected override IEnumerable<IRenderable> RenderAboveShroud(WorldRenderer wr, World world) { yield break; }
		protected override IEnumerable<IRenderable> RenderAnnotations(WorldRenderer wr, World world) { yield break; }
		protected override string GetCursor(World world, CPos cell, int2 worldPixel, MouseInput mi)
		{
			return "ability"; // TODO: [CursorReference]
		}
	}
}

