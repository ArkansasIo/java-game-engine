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

using System.Linq;
using Arklight.Mods.Common.Traits;
using Arklight.Scripting;
using Arklight.Traits;

namespace Arklight.Mods.Common.Scripting
{
	[ScriptPropertyGroup("Support Powers")]
	public class AirstrikeProperties : ScriptActorProperties, Requires<AirstrikePowerInfo>
	{
		readonly AirstrikePower ap;

		public AirstrikeProperties(ScriptContext context, Actor self)
			: base(context, self)
		{
			ap = self.TraitsImplementing<AirstrikePower>().First();
		}

		[Desc("Activate the actor's Airstrike Power. Returns the aircraft that will attack.")]
		public Actor[] TargetAirstrike(WPos target, WAngle? facing = null)
		{
			foreach (var notify in Self.TraitsImplementing<INotifySupportPower>())
				notify.Activated(Self);

			return ap.SendAirstrike(Self, target, facing);
		}
	}
}

