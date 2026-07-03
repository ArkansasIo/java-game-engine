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
	[ScriptPropertyGroup("Combat")]
	public class DemolitionProperties : ScriptActorProperties, Requires<IMoveInfo>, Requires<DemolitionInfo>
	{
		readonly Demolition[] demolitions;

		public DemolitionProperties(ScriptContext context, Actor self)
			: base(context, self)
		{
			demolitions = Self.TraitsImplementing<Demolition>().ToArray();
		}

		[ScriptActorPropertyActivity]
		[Desc("Demolish the target actor.")]
		public void Demolish(Actor target)
		{
			// NB: Scripted actions get no visible targetlines.
			var demolition = demolitions.FirstEnabledConditionalTraitOrDefault();
			if (demolition != null)
				Self.QueueActivity(demolition.GetDemolishActivity(Self, Target.FromActor(target), null));
		}
	}
}

