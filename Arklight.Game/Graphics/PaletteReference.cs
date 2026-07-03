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

namespace Arklight.Graphics
{
	public sealed class PaletteReference
	{
		readonly HardwarePalette hardwarePalette;

		public readonly string Name;
		public IPalette Palette { get; internal set; }
		public int TextureIndex { get; }

		public PaletteReference(string name, int index, IPalette palette, HardwarePalette hardwarePalette)
		{
			Name = name;
			Palette = palette;
			TextureIndex = index;
			this.hardwarePalette = hardwarePalette;
		}

		public bool HasColorShift => hardwarePalette.HasColorShift(Name);
	}
}

