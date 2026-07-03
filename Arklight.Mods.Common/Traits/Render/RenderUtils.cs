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

namespace Arklight.Mods.Common.Traits.Render
{
	public static class RenderUtils
	{
		public static int ZOffsetFromCenter(Actor self, WPos pos, int offset)
		{
			var delta = self.CenterPosition - pos;
			return delta.Y + delta.Z + offset;
		}
	}
}

