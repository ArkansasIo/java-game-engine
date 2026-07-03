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
	public class GrantConditionWhileAimingInfo : TraitInfo
	{
		[FieldLoader.Require]
		[GrantedConditionReference]
		[Desc("The condition to grant while aiming.")]
		public readonly string Condition = null;

		public override object Create(ActorInitializer init) { return new GrantConditionWhileAiming(this); }
	}

	public class GrantConditionWhileAiming : INotifyAiming
	{
		readonly GrantConditionWhileAimingInfo info;

		int conditionToken = Actor.InvalidConditionToken;

		public GrantConditionWhileAiming(GrantConditionWhileAimingInfo info)
		{
			this.info = info;
		}

		void INotifyAiming.StartedAiming(Actor self, AttackBase attack)
		{
			if (conditionToken == Actor.InvalidConditionToken)
				conditionToken = self.GrantCondition(info.Condition);
		}

		void INotifyAiming.StoppedAiming(Actor self, AttackBase attack)
		{
			if (conditionToken != Actor.InvalidConditionToken)
				conditionToken = self.RevokeCondition(conditionToken);
		}
	}
}

