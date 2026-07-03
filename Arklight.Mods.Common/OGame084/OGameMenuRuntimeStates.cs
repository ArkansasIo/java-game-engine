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

using System.Collections.Generic;

namespace Arklight.Mods.Common.OGame084
{
	public sealed class OGameEmpireState
	{
		public readonly OGameResources Resources;
		public readonly IReadOnlyList<string> Colonies;
		public readonly IReadOnlyList<string> Fleets;
		public readonly IReadOnlyList<string> Research;
		public readonly IReadOnlyList<string> Diplomacy;
		public readonly IReadOnlyList<string> Alliance;
		public readonly IReadOnlyList<string> Market;
		public readonly IReadOnlyList<string> Government;
		public readonly IReadOnlyList<string> Campaign;

		public OGameEmpireState(
			OGameResources resources,
			string[] colonies,
			string[] fleets,
			string[] research,
			string[] diplomacy,
			string[] alliance,
			string[] market,
			string[] government,
			string[] campaign)
		{
			Resources = resources;
			Colonies = colonies;
			Fleets = fleets;
			Research = research;
			Diplomacy = diplomacy;
			Alliance = alliance;
			Market = market;
			Government = government;
			Campaign = campaign;
		}
	}

	public sealed class OGamePlanetMenuState
	{
		public readonly string Id;
		public readonly string Name;
		public readonly IReadOnlyList<string> Mines;
		public readonly IReadOnlyList<string> Energy;
		public readonly IReadOnlyList<string> Storage;
		public readonly IReadOnlyList<string> Queues;
		public readonly IReadOnlyList<string> Defenses;
		public readonly IReadOnlyList<string> Population;
		public readonly IReadOnlyList<string> Culture;
		public readonly IReadOnlyList<string> Housing;
		public readonly IReadOnlyList<string> Stability;
		public readonly IReadOnlyList<string> Modifiers;

		public OGamePlanetMenuState(
			string id,
			string name,
			string[] mines,
			string[] energy,
			string[] storage,
			string[] queues,
			string[] defenses,
			string[] population,
			string[] culture,
			string[] housing,
			string[] stability,
			string[] modifiers)
		{
			Id = id;
			Name = name;
			Mines = mines;
			Energy = energy;
			Storage = storage;
			Queues = queues;
			Defenses = defenses;
			Population = population;
			Culture = culture;
			Housing = housing;
			Stability = stability;
			Modifiers = modifiers;
		}
	}

	public sealed class OGameFleetState
	{
		public readonly string Id;
		public readonly string Owner;
		public readonly IReadOnlyList<string> Ships;
		public readonly OGameMissionType Mission;
		public readonly string Target;
		public readonly int SpeedPercent;
		public readonly long Fuel;
		public readonly long Cargo;
		public readonly int DepartureTick;
		public readonly int ArrivalTick;
		public readonly int ReturnTick;
		public readonly bool IsAcsFleet;

		public OGameFleetState(
			string id,
			string owner,
			string[] ships,
			OGameMissionType mission,
			string target,
			int speedPercent,
			long fuel,
			long cargo,
			int departureTick,
			int arrivalTick,
			int returnTick,
			bool isAcsFleet)
		{
			Id = id;
			Owner = owner;
			Ships = ships;
			Mission = mission;
			Target = target;
			SpeedPercent = speedPercent;
			Fuel = fuel;
			Cargo = cargo;
			DepartureTick = departureTick;
			ArrivalTick = arrivalTick;
			ReturnTick = returnTick;
			IsAcsFleet = isAcsFleet;
		}
	}

	public sealed class OGameResearchState
	{
		public readonly string ActiveResearch;
		public readonly IReadOnlyList<string> CompletedTechnologies;
		public readonly IReadOnlyList<string> UnlockedUnits;
		public readonly IReadOnlyList<string> UnlockedBuildings;
		public readonly IReadOnlyList<string> TechBonuses;

		public OGameResearchState(
			string activeResearch,
			string[] completedTechnologies,
			string[] unlockedUnits,
			string[] unlockedBuildings,
			string[] techBonuses)
		{
			ActiveResearch = activeResearch;
			CompletedTechnologies = completedTechnologies;
			UnlockedUnits = unlockedUnits;
			UnlockedBuildings = unlockedBuildings;
			TechBonuses = techBonuses;
		}
	}

	public sealed class OGameDiplomacyState
	{
		public readonly IReadOnlyList<string> Contacts;
		public readonly IReadOnlyList<string> Pacts;
		public readonly IReadOnlyList<string> Wars;
		public readonly IReadOnlyList<string> Claims;
		public readonly IReadOnlyList<string> Trust;
		public readonly IReadOnlyList<string> Threat;
		public readonly IReadOnlyList<string> Sanctions;
		public readonly IReadOnlyList<string> Envoys;
		public readonly IReadOnlyList<string> Espionage;
		public readonly IReadOnlyList<string> Messages;

		public OGameDiplomacyState(
			string[] contacts,
			string[] pacts,
			string[] wars,
			string[] claims,
			string[] trust,
			string[] threat,
			string[] sanctions,
			string[] envoys,
			string[] espionage,
			string[] messages)
		{
			Contacts = contacts;
			Pacts = pacts;
			Wars = wars;
			Claims = claims;
			Trust = trust;
			Threat = threat;
			Sanctions = sanctions;
			Envoys = envoys;
			Espionage = espionage;
			Messages = messages;
		}
	}

	public sealed class OGameCharacterState
	{
		public readonly string Class;
		public readonly int Level;
		public readonly IReadOnlyList<string> Skills;
		public readonly IReadOnlyList<string> Equipment;
		public readonly IReadOnlyList<string> Inventory;
		public readonly IReadOnlyList<string> Reputation;
		public readonly IReadOnlyList<string> Quests;
		public readonly IReadOnlyList<string> SocialAffiliations;

		public OGameCharacterState(
			string characterClass,
			int level,
			string[] skills,
			string[] equipment,
			string[] inventory,
			string[] reputation,
			string[] quests,
			string[] socialAffiliations)
		{
			Class = characterClass;
			Level = level;
			Skills = skills;
			Equipment = equipment;
			Inventory = inventory;
			Reputation = reputation;
			Quests = quests;
			SocialAffiliations = socialAffiliations;
		}
	}
}
