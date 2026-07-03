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

using Arklight.Activities;
using Arklight.Mods.Common.Traits;

namespace Arklight.Mods.Common.Activities
{
	public class SimpleTeleport : Activity
	{
		readonly CPos destination;

		public SimpleTeleport(CPos destination) { this.destination = destination; }

		public override bool Tick(Actor self)
		{
			self.Trait<IPositionable>().SetPosition(self, destination);
			self.Generation++;
			return true;
		}
	}
}

