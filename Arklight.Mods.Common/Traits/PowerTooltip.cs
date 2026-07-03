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
	[Desc("Shown power info on the build palette widget.")]
	public class PowerTooltipInfo : TraitInfo
	{
		public override object Create(ActorInitializer init) { return new PowerTooltip(init.Self); }
	}

	public class PowerTooltip : IProvideTooltipInfo, INotifyOwnerChanged
	{
		readonly Actor self;
		PowerManager powerManager;
		DeveloperMode developerMode;

		public PowerTooltip(Actor self)
		{
			this.self = self;
			powerManager = self.Owner.PlayerActor.Trait<PowerManager>();
			developerMode = self.Owner.PlayerActor.Trait<DeveloperMode>();
		}

		public bool IsTooltipVisible(Player forPlayer)
		{
			return forPlayer == self.Owner;
		}

		public string TooltipText => $"Power Usage: {powerManager.PowerDrained}{(developerMode.UnlimitedPower ? "" : "/" + powerManager.PowerProvided)}";

		public void OnOwnerChanged(Actor self, Player oldOwner, Player newOwner)
		{
			powerManager = newOwner.PlayerActor.Trait<PowerManager>();
			developerMode = newOwner.PlayerActor.Trait<DeveloperMode>();
		}
	}
}

