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

using Arklight.Primitives;
using Arklight.Traits;

namespace Arklight.Mods.Common.Traits
{
	[Desc("Visualize the progress of this actor being captured.")]
	sealed class CaptureProgressBarInfo : ConditionalTraitInfo, Requires<CapturesInfo>
	{
		public readonly Color Color = Color.Orange;

		public override object Create(ActorInitializer init) { return new CaptureProgressBar(this); }
	}

	sealed class CaptureProgressBar : ConditionalTrait<CaptureProgressBarInfo>, ISelectionBar, ICaptureProgressWatcher
	{
		int current;
		int total;

		public CaptureProgressBar(CaptureProgressBarInfo info)
			: base(info) { }

		void ICaptureProgressWatcher.Update(Actor self, Actor captor, Actor target, int current, int total)
		{
			if (self != captor)
				return;

			this.current = current;
			this.total = total;
		}

		float ISelectionBar.GetValue()
		{
			if (IsTraitDisabled || total == 0)
				return 0f;

			return (float)current / total;
		}

		Color ISelectionBar.GetColor() { return Info.Color; }
		bool ISelectionBar.DisplayWhenEmpty => false;
	}
}

