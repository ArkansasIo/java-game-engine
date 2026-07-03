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

namespace Arklight.Mods.Common.Traits.Render
{
	[Desc("Invisible during games.")]
	sealed class RenderSpritesEditorOnlyInfo : RenderSpritesInfo
	{
		public override object Create(ActorInitializer init) { return new RenderSpritesEditorOnly(init, this); }
	}

	sealed class RenderSpritesEditorOnly : RenderSprites
	{
		public RenderSpritesEditorOnly(ActorInitializer init, RenderSpritesEditorOnlyInfo info)
			: base(init, info) { }

		public override IEnumerable<IRenderable> Render(Actor self, WorldRenderer wr) { return SpriteRenderable.None; }
	}
}

