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

namespace Arklight.Mods.Common.Installer
{
	public interface ISourceResolver
	{
		string FindSourcePath(ModContent.ModSource modSource);
		Availability GetAvailability();
	}
}

