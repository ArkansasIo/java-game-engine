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

using Arklight.Mods.Common.Activities;
using Arklight.Mods.Common.Traits;
using Arklight.Scripting;
using Arklight.Traits;

namespace Arklight.Mods.Common.Scripting
{
	[ScriptPropertyGroup("Transports")]
	public class ParadropProperties : ScriptActorProperties, Requires<CargoInfo>, Requires<ParaDropInfo>
	{
		readonly ParaDrop paradrop;

		public ParadropProperties(ScriptContext context, Actor self)
			: base(context, self)
		{
			paradrop = self.Trait<ParaDrop>();
		}

		[ScriptActorPropertyActivity]
		[Desc("Command transport to paradrop passengers near the target cell.")]
		public void Paradrop(CPos cell)
		{
			foreach (var notify in Self.TraitsImplementing<INotifySupportPower>())
				notify.Activated(Self);

			paradrop.SetLZ(cell, true);
			Self.QueueActivity(new Fly(Self, Target.FromCell(Self.World, cell)));
			Self.QueueActivity(new FlyOffMap(Self));
			Self.QueueActivity(new RemoveSelf());
		}
	}
}

