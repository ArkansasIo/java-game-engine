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

using Arklight.Graphics;
using Arklight.Mods.Common.Traits;
using Arklight.Mods.Common.Traits.Render;
using Arklight.Traits;

namespace Arklight.Mods.Cnc.Traits.Render
{
	sealed class WithSplitAttackPaletteInfantryBodyInfo : WithInfantryBodyInfo
	{
		[PaletteReference]
		[Desc("Palette to use for the split attack rendering.")]
		public readonly string SplitAttackPalette = null;

		[Desc("Sequence suffix to use.")]
		public readonly string SplitAttackSuffix = "muzzle";

		public override object Create(ActorInitializer init) { return new WithSplitAttackPaletteInfantryBody(init, this); }
	}

	sealed class WithSplitAttackPaletteInfantryBody : WithInfantryBody
	{
		readonly WithSplitAttackPaletteInfantryBodyInfo info;
		readonly Animation splitAnimation;
		bool visible;

		public WithSplitAttackPaletteInfantryBody(ActorInitializer init, WithSplitAttackPaletteInfantryBodyInfo info)
			: base(init, info)
		{
			this.info = info;
			var rs = init.Self.Trait<RenderSprites>();
			splitAnimation = new Animation(init.World, rs.GetImage(init.Self), RenderSprites.MakeFacingFunc(init.Self));
			rs.Add(new AnimationWithOffset(splitAnimation, null, () => IsTraitDisabled || !visible), info.SplitAttackPalette);
		}

		protected override void Attacking(Actor self, Armament a, Barrel barrel)
		{
			base.Attacking(self, a, barrel);

			var sequence = DefaultAnimation.CurrentSequence.Name + "-" + info.SplitAttackSuffix;
			if (state == AnimationState.Attacking && splitAnimation.HasSequence(sequence))
			{
				visible = true;
				splitAnimation.PlayThen(sequence, () => visible = false);
			}
		}
	}
}

