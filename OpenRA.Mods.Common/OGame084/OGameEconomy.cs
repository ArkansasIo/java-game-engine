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
	public sealed class OGameUniverseSettings
	{
		public readonly int EconomySpeed;
		public readonly int FleetSpeed;
		public readonly int DefenseRepairPercent;
		public readonly int FleetDebrisPercent;
		public readonly int DefenseDebrisPercent;
		public readonly bool RapidfireEnabled;

		public OGameUniverseSettings(
			int economySpeed = 1,
			int fleetSpeed = 1,
			int defenseRepairPercent = 70,
			int fleetDebrisPercent = 30,
			int defenseDebrisPercent = 0,
			bool rapidfireEnabled = true)
		{
			EconomySpeed = Math.Max(1, economySpeed);
			FleetSpeed = Math.Max(1, fleetSpeed);
			DefenseRepairPercent = Math.Clamp(defenseRepairPercent, 0, 100);
			FleetDebrisPercent = Math.Clamp(fleetDebrisPercent, 0, 100);
			DefenseDebrisPercent = Math.Clamp(defenseDebrisPercent, 0, 100);
			RapidfireEnabled = rapidfireEnabled;
		}
	}

	public sealed class OGamePlanetState
	{
		public readonly int PlanetId;
		public readonly string Name;
		public readonly int MetalMine;
		public readonly int CrystalMine;
		public readonly int DeuteriumSynthesizer;
		public readonly int SolarPlant;
		public readonly int FusionReactor;
		public readonly int TemperatureMin;
		public readonly int TemperatureMax;
		public readonly OGameResources Stored;

		public OGamePlanetState(
			int planetId,
			string name,
			OGameResources stored,
			int metalMine = 0,
			int crystalMine = 0,
			int deuteriumSynthesizer = 0,
			int solarPlant = 0,
			int fusionReactor = 0,
			int temperatureMin = 20,
			int temperatureMax = 40)
		{
			PlanetId = planetId;
			Name = name;
			Stored = stored;
			MetalMine = Math.Max(0, metalMine);
			CrystalMine = Math.Max(0, crystalMine);
			DeuteriumSynthesizer = Math.Max(0, deuteriumSynthesizer);
			SolarPlant = Math.Max(0, solarPlant);
			FusionReactor = Math.Max(0, fusionReactor);
			TemperatureMin = temperatureMin;
			TemperatureMax = temperatureMax;
		}
	}

	public sealed class OGameProductionResult
	{
		public readonly OGameResources HourlyProduction;
		public readonly int EnergyAvailable;
		public readonly int EnergyUsed;
		public readonly double EnergyRatio;

		public OGameProductionResult(OGameResources hourlyProduction, int energyAvailable, int energyUsed, double energyRatio)
		{
			HourlyProduction = hourlyProduction;
			EnergyAvailable = energyAvailable;
			EnergyUsed = energyUsed;
			EnergyRatio = energyRatio;
		}
	}

	public static class OGameEconomy
	{
		public static OGameProductionResult CalculateHourlyProduction(OGameUniverseSettings universe, OGamePlanetState planet)
		{
			var metalBase = MineProduction(30, planet.MetalMine) * universe.EconomySpeed;
			var crystalBase = MineProduction(20, planet.CrystalMine) * universe.EconomySpeed;
			var deutBase = DeuteriumProduction(planet.DeuteriumSynthesizer, planet.TemperatureMax) * universe.EconomySpeed;

			var energyAvailable = EnergyProduction(planet.SolarPlant, planet.FusionReactor);
			var energyUsed = EnergyUse(planet.MetalMine, planet.CrystalMine, planet.DeuteriumSynthesizer);
			var ratio = energyUsed == 0 ? 1d : Math.Min(1d, energyAvailable / (double)energyUsed);

			return new OGameProductionResult(
				new OGameResources(
					(long)Math.Floor(metalBase * ratio),
					(long)Math.Floor(crystalBase * ratio),
					(long)Math.Floor(deutBase * ratio),
					energyAvailable - energyUsed),
				energyAvailable,
				energyUsed,
				ratio);
		}

		public static OGameResources ProjectStorage(OGameUniverseSettings universe, OGamePlanetState planet, TimeSpan elapsed)
		{
			var prod = CalculateHourlyProduction(universe, planet);
			var hours = elapsed.TotalHours;
			return planet.Stored.Add(new OGameResources(
				(long)Math.Floor(prod.HourlyProduction.Metal * hours),
				(long)Math.Floor(prod.HourlyProduction.Crystal * hours),
				(long)Math.Floor(prod.HourlyProduction.Deuterium * hours),
				prod.HourlyProduction.Energy,
				0));
		}

		public static OGameResources BuildingCost(OGameResources baseCost, int nextLevel, double factor = 1.5)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero(nextLevel);

			var multiplier = Math.Pow(factor, nextLevel - 1);
			return new OGameResources(
				(long)Math.Floor(baseCost.Metal * multiplier),
				(long)Math.Floor(baseCost.Crystal * multiplier),
				(long)Math.Floor(baseCost.Deuterium * multiplier),
				baseCost.Energy,
				baseCost.DarkMatter);
		}

		static int MineProduction(int baseRate, int level)
		{
			return level == 0 ? 0 : (int)Math.Floor(baseRate * level * Math.Pow(1.1, level));
		}

		static int DeuteriumProduction(int level, int maxTemperature)
		{
			if (level == 0)
				return 0;

			return (int)Math.Floor(10 * level * Math.Pow(1.1, level) * (-0.002 * maxTemperature + 1.28));
		}

		static int EnergyProduction(int solarPlant, int fusionReactor)
		{
			var solar = solarPlant == 0 ? 0 : (int)Math.Floor(20 * solarPlant * Math.Pow(1.1, solarPlant));
			var fusion = fusionReactor == 0 ? 0 : (int)Math.Floor(30 * fusionReactor * Math.Pow(1.05, fusionReactor));
			return solar + fusion;
		}

		static int EnergyUse(int metalMine, int crystalMine, int deuteriumSynthesizer)
		{
			var metal = metalMine == 0 ? 0 : (int)Math.Floor(10 * metalMine * Math.Pow(1.1, metalMine));
			var crystal = crystalMine == 0 ? 0 : (int)Math.Floor(10 * crystalMine * Math.Pow(1.1, crystalMine));
			var deut = deuteriumSynthesizer == 0 ? 0 : (int)Math.Floor(20 * deuteriumSynthesizer * Math.Pow(1.1, deuteriumSynthesizer));
			return metal + crystal + deut;
		}
	}

	public sealed class OGameQueueItem
	{
		public readonly long Id;
		public readonly OGameQueueType Type;
		public readonly string Subject;
		public readonly DateTime StartsAtUtc;
		public readonly DateTime CompletesAtUtc;

		public OGameQueueItem(long id, OGameQueueType type, string subject, DateTime startsAtUtc, DateTime completesAtUtc)
		{
			if (completesAtUtc < startsAtUtc)
				throw new ArgumentException("Queue item cannot complete before it starts.", nameof(completesAtUtc));

			Id = id;
			Type = type;
			Subject = subject;
			StartsAtUtc = startsAtUtc;
			CompletesAtUtc = completesAtUtc;
		}
	}

	public sealed class OGameQueueProcessor
	{
		public IReadOnlyList<OGameQueueItem> DueItems(IEnumerable<OGameQueueItem> queue, DateTime untilUtc)
		{
			var due = new List<OGameQueueItem>();
			foreach (var item in queue)
				if (item.CompletesAtUtc <= untilUtc)
					due.Add(item);

			due.Sort((a, b) => a.CompletesAtUtc.CompareTo(b.CompletesAtUtc));
			return due;
		}
	}
}
