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
using Arklight.Mods.Common.Graphics;
using Arklight.Traits;

namespace Arklight.Mods.Common.Traits.Render
{
	public class WithFacingSpriteBodyInfo : WithSpriteBodyInfo, Requires<BodyOrientationInfo>, Requires<IFacingInfo>
	{
		public override object Create(ActorInitializer init) { return new WithFacingSpriteBody(init, this); }

		public override IEnumerable<IActorPreview> RenderPreviewSprites(ActorPreviewInitializer init, string image, int facings, PaletteReference p)
		{
			if (!EnabledByDefault)
				yield break;

			var anim = new Animation(init.World, image, init.GetFacing());
			anim.PlayRepeating(RenderSprites.NormalizeSequence(anim, init.GetDamageState(), Sequence));

			yield return new SpriteActorPreview(anim, () => WVec.Zero, () => 0, p);
		}
	}

	public class WithFacingSpriteBody : WithSpriteBody
	{
		public WithFacingSpriteBody(ActorInitializer init, WithFacingSpriteBodyInfo info)
			: base(init, info, RenderSprites.MakeFacingFunc(init.Self)) { }
	}
}

