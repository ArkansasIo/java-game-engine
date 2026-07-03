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
	[Desc("Modifies the cash given by cash tricker traits of this actor.")]
	public class CashTricklerMultiplierInfo : ConditionalTraitInfo, Requires<CashTricklerInfo>
	{
		[FieldLoader.Require]
		[Desc("Percentage modifier to apply.")]
		public readonly int Modifier = 100;

		public override object Create(ActorInitializer init) { return new CashTricklerMultiplier(this); }
	}

	public class CashTricklerMultiplier : ConditionalTrait<CashTricklerMultiplierInfo>, ICashTricklerModifier
	{
		public CashTricklerMultiplier(CashTricklerMultiplierInfo info)
			: base(info) { }

		int ICashTricklerModifier.GetCashTricklerModifier()
		{
			return IsTraitDisabled ? 100 : Info.Modifier;
		}
	}
}

