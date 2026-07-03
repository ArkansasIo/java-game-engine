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
	[IncludeStaticFluentReferences(typeof(WidgetUtils))]
	public class BackgroundWidget : Widget
	{
		public readonly bool ClickThrough = false;
		public string Background = "dialog";

		public override void Draw()
		{
			WidgetUtils.DrawPanel(Background, RenderBounds);
		}

		public BackgroundWidget() { }

		public override bool HandleMouseInput(MouseInput mi)
		{
			return !ClickThrough && EventBounds.Contains(mi.Location);
		}

		protected BackgroundWidget(BackgroundWidget other)
			: base(other)
		{
			Background = other.Background;
			ClickThrough = other.ClickThrough;
		}

		public override BackgroundWidget Clone() { return new BackgroundWidget(this); }
	}
}

