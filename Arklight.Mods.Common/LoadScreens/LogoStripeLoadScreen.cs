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

using System.Linq;
using Arklight.FileSystem;
using Arklight.Graphics;
using Arklight.Mods.Common.Widgets;
using Arklight.Primitives;

namespace Arklight.Mods.Common.LoadScreens
{
	public sealed class LogoStripeLoadScreen : SheetLoadScreen
	{
		[FluentReference]
		const string Loading = "loadscreen-loading";

		int loadTick;
		Rectangle stripeRect;
		Rectangle progressFrameRect;
		float2 logoPos;
		Sprite stripe, logo;

		Sheet lastSheet;
		int lastDensity;
		Size lastResolution;

		string[] messages = [];

		public override void Init(Manifest manifest, IReadOnlyFileSystem fileSystem)
		{
			base.Init(manifest, fileSystem);

			messages = FluentProvider.GetMessage(Loading).Split(',').Select(x => x.Trim()).ToArray();
		}

		public override void DisplayInner(Renderer r, Sheet s, int density)
		{
			if (s != lastSheet || density != lastDensity)
			{
				lastSheet = s;
				lastDensity = density;
				logo = CreateSprite(s, density, new Rectangle(0, 0, 256, 256));
				stripe = CreateSprite(s, density, new Rectangle(258, 0, 253, 256));
			}

			if (r.Resolution != lastResolution)
			{
				lastResolution = r.Resolution;
				stripeRect = new Rectangle(0, lastResolution.Height / 2 - 128, lastResolution.Width, 256);
				logoPos = new float2(lastResolution.Width / 2 - 128, lastResolution.Height / 2 - 128);
				progressFrameRect = new Rectangle(lastResolution.Width / 2 - 210, lastResolution.Height / 2 + 152, 420, 18);
			}

			WidgetUtils.FillRectWithColor(new Rectangle(0, 0, lastResolution.Width, lastResolution.Height), Color.FromArgb(255, 2, 8, 23));

			if (stripe != null)
				WidgetUtils.FillRectWithSprite(stripeRect, stripe);

			if (logo != null)
				r.RgbaSpriteRenderer.DrawSprite(logo, logoPos);

			loadTick = ++loadTick % 24;
			DrawLoadingBar(progressFrameRect, loadTick);

			if (r.Fonts != null && messages.Length > 0)
			{
				var text = messages.Random(Game.CosmeticRandom);
				var textSize = r.Fonts["Bold"].Measure(text);
				var textPos = new float2((r.Resolution.Width - textSize.X) / 2, progressFrameRect.Bottom + 12);
				r.Fonts["Bold"].DrawTextWithContrast(text, textPos, Color.FromArgb(230, 235, 255), Color.FromArgb(2, 8, 23), 2);
			}
		}

		static void DrawLoadingBar(Rectangle bounds, int tick)
		{
			WidgetUtils.FillRectWithColor(bounds.InflateBy(2, 2, 2, 2), Color.FromArgb(255, 8, 26, 45));
			WidgetUtils.FillRectWithColor(bounds, Color.FromArgb(255, 6, 22, 40));

			const int blockCount = 16;
			var blockWidth = (bounds.Width - 10) / blockCount;
			for (var i = 0; i < blockCount; i++)
			{
				var lit = (i + tick / 2) % blockCount;
				var color = lit < 9 ? Color.FromArgb(255, 109, 168, 255) : Color.FromArgb(255, 28, 56, 88);
				var x = bounds.X + 5 + i * blockWidth;
				WidgetUtils.FillRectWithColor(new Rectangle(x, bounds.Y + 4, blockWidth - 3, bounds.Height - 8), color);
			}
		}
	}
}

