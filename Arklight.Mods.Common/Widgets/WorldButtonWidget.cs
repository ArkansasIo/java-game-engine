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

namespace Arklight.Mods.Common.Widgets
{
	public class WorldButtonWidget : ButtonWidget
	{
		readonly World world;

		[ObjectCreator.UseCtor]
		public WorldButtonWidget(ModData modData, World world)
			: base(modData)
		{
			this.world = world;
		}

		protected WorldButtonWidget(WorldButtonWidget other)
			: base(other)
		{
			world = other.world;
		}

		public override void MouseEntered()
		{
			if (TooltipContainer == null || GetTooltipText() == null)
				return;

			tooltipContainer.Value.SetTooltip(TooltipTemplate,
				new WidgetArgs { { "button", this }, { "getText", GetTooltipText }, { "getDesc", GetTooltipDesc }, { "world", world } });
		}

		public override WorldButtonWidget Clone() { return new WorldButtonWidget(this); }
	}
}

