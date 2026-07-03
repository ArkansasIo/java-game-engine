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
using Arklight.Mods.Common.Activities;
using Arklight.Mods.Common.Traits;
using Arklight.Scripting;
using Arklight.Traits;

namespace Arklight.Mods.Common.Scripting
{
	[ScriptPropertyGroup("Ability")]
	public class InstantlyRepairsProperties : ScriptActorProperties, Requires<IMoveInfo>, Requires<InstantlyRepairsInfo>
	{
		readonly InstantlyRepairs[] instantlyRepairs;

		public InstantlyRepairsProperties(ScriptContext context, Actor self)
			: base(context, self)
		{
			instantlyRepairs = Self.TraitsImplementing<InstantlyRepairs>().ToArray();
		}

		[ScriptActorPropertyActivity]
		[Desc("Enter the target actor to repair it instantly.")]
		public void InstantlyRepair(Actor target)
		{
			// NB: Scripted actions get no visible targetlines.
			var repair = instantlyRepairs.FirstEnabledConditionalTraitOrDefault();
			if (repair != null)
				Self.QueueActivity(new InstantRepair(Self, Target.FromActor(target), repair.Info, null));
		}
	}
}

