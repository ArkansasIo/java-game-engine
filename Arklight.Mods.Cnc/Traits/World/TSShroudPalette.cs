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
using Arklight.Mods.Common.Traits;
using Arklight.Traits;

namespace Arklight.Mods.Cnc.Traits
{
	[TraitLocation(SystemActors.World | SystemActors.EditorWorld)]
	[Desc("Adds the hard-coded shroud palette to the game")]
	sealed class TSShroudPaletteInfo : TraitInfo
	{
		[PaletteDefinition]
		[FieldLoader.Require]
		[Desc("Internal palette name")]
		public readonly string Name = "shroud";

		public override object Create(ActorInitializer init) { return new TSShroudPalette(this); }
	}

	sealed class TSShroudPalette : ILoadsPalettes, IProvidesAssetBrowserPalettes
	{
		readonly TSShroudPaletteInfo info;

		public TSShroudPalette(TSShroudPaletteInfo info) { this.info = info; }

		public void LoadPalettes(WorldRenderer wr)
		{
			static uint MakeColor(int i)
			{
				if (i < 128)
					return (uint)(int2.Lerp(255, 0, i, 127) << 24);
				return 0;
			}

			wr.AddPalette(info.Name, new ImmutablePalette(Enumerable.Range(0, Palette.Size).Select(MakeColor)));
		}

		public IEnumerable<string> PaletteNames { get { yield return info.Name; } }
	}
}

