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

using Eluant;
using Arklight.Mods.Common.Activities;
using Arklight.Mods.Common.Traits;
using Arklight.Scripting;
using Arklight.Traits;

namespace Arklight.Mods.Common.Scripting
{
	[ScriptPropertyGroup("Ability")]
	public class CarryallProperties : ScriptActorProperties, Requires<CarryallInfo>
	{
		readonly Carryall carryall;

		public CarryallProperties(ScriptContext context, Actor self)
			: base(context, self)
		{
			carryall = Self.Trait<Carryall>();
		}

		[ScriptActorPropertyActivity]
		[Desc("Pick up the target actor.")]
		public void PickupCarryable(Actor target)
		{
			var carryable = target.TraitOrDefault<Carryable>();
			if (carryable == null)
				throw new LuaException($"Actor '{Self}' cannot carry actor '{target}'!");

			Self.QueueActivity(new PickupUnit(Self, target, carryall.Info.BeforeLoadDelay, null));
		}

		[ScriptActorPropertyActivity]
		[Desc("Drop the actor being carried at the target location.")]
		public void DeliverCarryable(CPos target)
		{
			Self.QueueActivity(new DeliverUnit(Self, Target.FromCell(Self.World, target), carryall.Info.DropRange, null));
		}
	}
}

