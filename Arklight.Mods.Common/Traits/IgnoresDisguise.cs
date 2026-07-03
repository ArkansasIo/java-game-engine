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

using Arklight.Traits;

namespace Arklight.Mods.Common.Traits
{
	[Desc("Allows automatic targeting of disguised actors.")]
	sealed class IgnoresDisguiseInfo : TraitInfo<IgnoresDisguise> { }

	sealed class IgnoresDisguise { }
}

