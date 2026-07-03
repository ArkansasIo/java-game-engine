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

using System;
using Arklight.Primitives;
using Arklight.Widgets;

namespace Arklight.Mods.Common.Widgets
{
	public class GradientColorBlockWidget : Widget
	{
		public Color TopLeftColor { get; set; }
		public Color TopRightColor { get; set; }
		public Color BottomRightColor { get; set; }
		public Color BottomLeftColor { get; set; }

		public Func<Color> GetTopLeftColor;
		public Func<Color> GetTopRightColor;
		public Func<Color> GetBottomRightColor;
		public Func<Color> GetBottomLeftColor;

		public GradientColorBlockWidget()
		{
			GetTopLeftColor = () => TopLeftColor;
			GetTopRightColor = () => TopRightColor;
			GetBottomRightColor = () => BottomRightColor;
			GetBottomLeftColor = () => BottomLeftColor;
		}

		protected GradientColorBlockWidget(GradientColorBlockWidget widget)
			: base(widget)
		{
			GetTopLeftColor = widget.GetTopLeftColor;
			GetTopRightColor = widget.GetTopRightColor;
			GetBottomRightColor = widget.GetBottomRightColor;
			GetBottomLeftColor = widget.GetBottomLeftColor;
		}

		public override GradientColorBlockWidget Clone()
		{
			return new GradientColorBlockWidget(this);
		}

		public override void Draw()
		{
			WidgetUtils.FillRectWithColor(RenderBounds, GetTopLeftColor(), GetTopRightColor(), GetBottomRightColor(), GetBottomLeftColor());
		}
	}
}

