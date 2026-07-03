#region Copyright & License Information
/*
 * Copyright (c) The OpenRA Developers and Contributors
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using System;
using System.Collections.Generic;

namespace OpenRA.Mods.Common.OGame084
{
	public readonly struct OGameCoordinates
	{
		public readonly int Galaxy;
		public readonly int System;
		public readonly int Position;

		public OGameCoordinates(int galaxy, int system, int position)
		{
			Galaxy = galaxy;
			System = system;
			Position = position;
		}
	}

	public sealed class OGameFleetOrder
	{
		public readonly int OwnerId;
		public readonly OGameCoordinates Origin;
		public readonly OGameCoordinates Target;
		public readonly OGameMissionType Mission;
		public readonly IReadOnlyDictionary<string, int> Ships;
		public readonly OGameResources Cargo;
		public readonly int SpeedPercent;

		public OGameFleetOrder(
			int ownerId,
			OGameCoordinates origin,
			OGameCoordinates target,
			OGameMissionType mission,
			IReadOnlyDictionary<string, int> ships,
			OGameResources cargo,
			int speedPercent = 100)
		{
			OwnerId = ownerId;
			Origin = origin;
			Target = target;
			Mission = mission;
			Ships = ships;
			Cargo = cargo;
			SpeedPercent = Math.Clamp(speedPercent, 10, 100);
		}
	}

	public sealed class OGameFleetPlan
	{
		public readonly OGameFleetOrder Order;
		public readonly int Distance;
		public readonly TimeSpan FlightTime;
		public readonly OGameResources FuelCost;

		public OGameFleetPlan(OGameFleetOrder order, int distance, TimeSpan flightTime, OGameResources fuelCost)
		{
			Order = order;
			Distance = distance;
			FlightTime = flightTime;
			FuelCost = fuelCost;
		}
	}

	public static class OGameFleetLogic
	{
		public static int FlightDistance(OGameCoordinates origin, OGameCoordinates target)
		{
			if (origin.Galaxy != target.Galaxy)
				return 20000 * Math.Abs(origin.Galaxy - target.Galaxy);

			if (origin.System != target.System)
				return 2700 + 95 * Math.Abs(origin.System - target.System);

			if (origin.Position != target.Position)
				return 1000 + 5 * Math.Abs(origin.Position - target.Position);

			return 5;
		}

		public static OGameFleetPlan PlanFleet(OGameUniverseSettings universe, OGameFleetOrder order, int slowestShipSpeed, int totalConsumption)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero(slowestShipSpeed);

			var distance = FlightDistance(order.Origin, order.Target);
			var speedFactor = Math.Max(0.1d, order.SpeedPercent / 100d);
			var seconds = 35000d / universe.FleetSpeed * Math.Sqrt(distance * 10d / slowestShipSpeed) / speedFactor;
			var fuel = (long)Math.Ceiling(totalConsumption * distance / 35000d * Math.Pow(speedFactor + 1d, 2));

			return new OGameFleetPlan(order, distance, TimeSpan.FromSeconds(seconds), new OGameResources(0, 0, fuel));
		}

		public static bool IsMissionAvailable(OGameMissionType mission, bool hasTargetPlanet, bool hasDebris, bool hasMoon, bool acsEnabled)
		{
			switch (mission)
			{
				case OGameMissionType.Attack:
				case OGameMissionType.Transport:
				case OGameMissionType.Deploy:
				case OGameMissionType.Espionage:
				case OGameMissionType.Missile:
					return hasTargetPlanet;
				case OGameMissionType.AcsAttack:
				case OGameMissionType.AcsHold:
					return hasTargetPlanet && acsEnabled;
				case OGameMissionType.Colonize:
					return !hasTargetPlanet;
				case OGameMissionType.Recycle:
					return hasDebris;
				case OGameMissionType.Destroy:
					return hasMoon;
				case OGameMissionType.Expedition:
					return true;
				default:
					return false;
			}
		}
	}
}
