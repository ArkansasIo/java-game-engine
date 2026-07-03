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

using System.Collections.Immutable;

namespace Arklight
{
	public class AssetBrowser : IGlobalModData
	{
		public readonly ImmutableArray<string> SpriteExtensions = [];
		public readonly ImmutableArray<string> ModelExtensions = [];
		public readonly ImmutableArray<string> AudioExtensions = [];
		public readonly ImmutableArray<string> VideoExtensions = [];
	}
}

