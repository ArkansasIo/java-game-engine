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
using System.Linq;

namespace Arklight.Mods.Common.OGame084
{
	public sealed class OGameMenuSystemDefinition
	{
		public readonly string Id;
		public readonly string Name;
		public readonly string Menu;
		public readonly IReadOnlyList<string> Submenus;
		public readonly IReadOnlyList<string> Frames;
		public readonly IReadOnlyList<string> Planes;
		public readonly IReadOnlyList<string> Subplanes;
		public readonly IReadOnlyList<string> StateFields;
		public readonly IReadOnlyList<string> LogicFunctions;
		public readonly IReadOnlyList<string> Stats;
		public readonly IReadOnlyList<string> Features;

		public OGameMenuSystemDefinition(
			string id,
			string name,
			string menu,
			string[] submenus,
			string[] frames,
			string[] planes,
			string[] subplanes,
			string[] stateFields,
			string[] logicFunctions,
			string[] stats,
			string[] features)
		{
			Id = id;
			Name = name;
			Menu = menu;
			Submenus = submenus;
			Frames = frames;
			Planes = planes;
			Subplanes = subplanes;
			StateFields = stateFields;
			LogicFunctions = logicFunctions;
			Stats = stats;
			Features = features;
		}
	}

	public sealed class OGameMenuTodoDefinition
	{
		public readonly string Id;
		public readonly string Name;
		public readonly IReadOnlyList<string> Items;

		public OGameMenuTodoDefinition(string id, string name, string[] items)
		{
			Id = id;
			Name = name;
			Items = items;
		}
	}

	public sealed class OGameMenuRuntimeState
	{
		public readonly string ActiveCategoryId;
		public readonly string ActiveWindowId;
		public readonly string ActivePageId;
		public readonly string ActiveSubpageId;
		public readonly string SelectedObjectId;
		public readonly string InspectorFocusId;
		public readonly string PendingActionId;

		public OGameMenuRuntimeState(
			string activeCategoryId = "empire",
			string activeWindowId = "empire-dashboard",
			string activePageId = "dashboard",
			string activeSubpageId = "overview",
			string selectedObjectId = "homeworld",
			string inspectorFocusId = "empire-summary",
			string pendingActionId = "")
		{
			ActiveCategoryId = activeCategoryId;
			ActiveWindowId = activeWindowId;
			ActivePageId = activePageId;
			ActiveSubpageId = activeSubpageId;
			SelectedObjectId = selectedObjectId;
			InspectorFocusId = inspectorFocusId;
			PendingActionId = pendingActionId;
		}
	}

	public static class OGameMenuSystemsCatalog
	{
		public static readonly IReadOnlyList<string> FrameOrder =
		[
			"Header",
			"Top tabs",
			"Left rail",
			"Center page",
			"Right inspector",
			"Footer",
			"Modal"
		];

		public static readonly IReadOnlyList<OGameMenuSystemDefinition> Systems =
		[
			new OGameMenuSystemDefinition("empire", "Empire Dashboard", "Empire",
				["Empire Overview", "Alerts", "Resource Ledger", "Colonies", "Victory", "Objectives"],
				["Header", "Top tabs", "Left rail", "Center page", "Right inspector", "Footer"],
				["Resource topbar", "Alert strip", "Colony ledger", "Victory tracker"],
				["Metal", "Crystal", "Deuterium", "Energy", "Dark Matter", "Command Capacity"],
				["Resources", "Colonies", "Fleets", "Research", "Diplomacy", "Alliance", "Market", "Government", "Campaign"],
				["Review empire status", "Select colony", "Inspect income", "Open objectives", "Jump to crisis"],
				["Total production", "Resource delta", "Storage fill", "Colonies", "Fleets", "Research level", "Score", "Rank", "Victory progress"],
				["Empire modifiers", "Command capacity", "Alerts", "Objective routing"]),
			new OGameMenuSystemDefinition("galaxy", "Galaxy Map", "Galaxy",
				["Galaxy Map", "Sector Browser", "Claims", "Trade Routes", "Anomalies"],
				["Header", "Strategic map", "Route overlay", "Claims overlay", "Inspector", "Footer"],
				["Galaxy plane", "Sector plane", "System plane", "Expedition plane"],
				["Coordinates", "Empire borders", "Hyperlanes", "Fleets", "Debris Fields", "Moons", "Pirates", "NPC Empires", "Jump Points"],
				["Sectors", "Systems", "Claims", "Fleets", "TradeRoutes", "Anomalies", "FogState"],
				["Browse sectors", "Inspect systems", "Plan expeditions", "Track hostile fleets", "Open diplomacy target"],
				["Discovered systems", "Claim pressure", "Route safety", "Hostile warnings", "Sensor coverage"],
				["Map filters", "Expedition targets", "NPC activity", "Jump lane display"]),
			new OGameMenuSystemDefinition("system", "System View", "System",
				["System Overview", "Orbital Lanes", "Stations", "Contacts", "Tactical View"],
				["Header", "System map", "Orbit list", "Traffic overlay", "Inspector", "Footer"],
				["Star plane", "Planet orbit plane", "Station plane", "Tactical entry plane"],
				["Planets", "Moons", "Orbitals", "Fleet Slots", "Jump Lanes", "Sensor Pings", "Civilian Routes", "Combat Zones"],
				["Star", "Planets", "Moons", "Stations", "Traffic", "Blockades", "SensorRange"],
				["Select planet", "Inspect station", "Open blockade", "Enter tactical battle", "Open civilian route"],
				["Planet count", "Station count", "Traffic volume", "Blockades", "Sensor range", "Combat risk"],
				["Orbital lanes", "Tactical entry points", "Civilian route warnings"]),
			new OGameMenuSystemDefinition("planet", "Planet Command", "Planet",
				["Planet Overview", "Resources", "Buildings", "Shipyard", "Defenses", "Population", "Stability"],
				["Planet header", "Resource cards", "Build queue", "Shipyard queue", "Defense grid", "Inspector"],
				["Overview plane", "Production plane", "Construction plane", "Defense plane"],
				["Mines", "Power", "Storage", "Population", "Housing", "Culture", "Stability", "Districts"],
				["Mines", "Energy", "Storage", "Queues", "Defenses", "Population", "Culture", "Housing", "Modifiers"],
				["Manage buildings", "Queue ships", "Queue defenses", "Balance energy", "Inspect storage"],
				["Mine output", "Energy balance", "Build time", "Defense power", "Population", "Stability", "Housing", "Culture", "Queue state"],
				["Resource production", "Queue processing", "Building logic", "Defense logic"]),
			new OGameMenuSystemDefinition("fleet", "Fleet Command", "Fleet",
				["Fleet Dispatch", "Movement", "ACS Operations", "Espionage", "Debris Recovery", "Missiles", "Expeditions"],
				["Fleet selector", "Mission picker", "Target selector", "Cargo panel", "Timing panel", "Result footer"],
				["Dispatch plane", "Mission plane", "Movement plane", "Logistics plane"],
				["Attack", "Transport", "Deploy", "Hold", "Colonize", "Recycle", "Expedition", "Missiles"],
				["Ships", "Cargo", "Mission", "Target", "Speed", "Fuel", "Departure", "Arrival", "Return", "ACS", "Owner"],
				["Validate mission", "Calculate fuel", "Calculate ETA", "Dispatch fleet", "Resolve arrival", "Recall fleet", "Write mission logs"],
				["Ship count", "Combat value", "Cargo capacity", "Fuel consumption", "Speed", "Mission risk", "Arrival time", "Recall state"],
				["Fleet dispatch", "Fleet resolution", "ACS attack", "Espionage", "Missile missions"]),
			new OGameMenuSystemDefinition("war", "War Room", "War",
				["Military Doctrine", "Unit Classes", "Weapons", "Shields", "Armor", "Battle Reports", "Loss Tracking"],
				["War header", "Front list", "Unit catalog", "Battle report viewer", "Loss inspector", "Action footer"],
				["Fronts plane", "Armies plane", "Battle report plane", "Production plane"],
				["Infantry", "Vehicles", "Aircraft", "Naval", "Mechs", "Drones", "Fortifications", "Special Forces"],
				["Fronts", "ArmyGroups", "BattleReports", "UnitLosses", "Doctrines", "Reinforcements"],
				["Review battles", "Inspect units", "Compare weapons", "Track losses", "Jump to tactical battle"],
				["Active fronts", "Army strength", "Losses", "Battle outcomes", "Doctrine bonuses", "Defense coverage", "Enemy threat"],
				["Rapidfire", "Shield recharge", "Armor damage", "Hull destruction", "Debris", "Plunder", "Moon chance"]),
			new OGameMenuSystemDefinition("research", "Research Lab", "Research",
				["Research Lab", "Tech Tree", "Upgrades", "Artifacts", "Reverse Engineering"],
				["Lab header", "Tech tree", "Requirement frame", "Queue frame", "Effect inspector", "Footer"],
				["Physics plane", "Energy plane", "Combat plane", "Propulsion plane"],
				["Laser", "Ion", "Plasma", "Hyperspace", "Computer", "Espionage", "Armor", "Shielding"],
				["ActiveResearch", "CompletedTech", "UnlockedUnits", "UnlockedBuildings", "TechBonuses"],
				["Inspect requirements", "Queue research", "Preview bonuses", "Open tech details", "Compare upgrades"],
				["Prerequisites", "Unlocks", "Cost", "Duration", "Active bonuses", "Level effects", "Missing requirements"],
				["Research prerequisites", "Cost scaling", "Lab bonuses", "Unlocks", "Stat modifiers"]),
			new OGameMenuSystemDefinition("market", "Market And Civil Systems", "Market",
				["Exchange", "Orders", "Contracts", "Trade Routes", "Tariffs", "Convoys", "Supply Lines", "Storage"],
				["Market header", "Orders table", "Route list", "Civil system list", "Storage inspector", "Footer"],
				["Exchange plane", "Trade route plane", "Civil services plane", "Supply plane"],
				["Import", "Export", "Convoys", "Tariffs", "Smuggling", "Shortages", "Surpluses"],
				["Orders", "Contracts", "Routes", "Tariffs", "Convoys", "Shortages", "Surpluses", "StoragePressure"],
				["Post order", "Inspect shortage", "Assign convoy", "Review taxes", "Track storage", "Fulfill contract"],
				["Price", "Volume", "Route safety", "Convoy capacity", "Tariff rate", "Shortages", "Surpluses", "Storage pressure"],
				["Trade routes", "Market orders", "Civil systems", "Supply lines"]),
			new OGameMenuSystemDefinition("government", "Government Council", "Government",
				["Laws", "Policies", "Budgets", "Governors", "Leaders", "Edicts", "Crisis Directives"],
				["Government header", "Law table", "Policy forms", "Leader roster", "Budget inspector", "Footer"],
				["Laws plane", "Policy plane", "Budget plane", "Crisis plane"],
				["Authority", "Unity", "Civil Stability", "Edicts", "Governors", "Budgets", "Directives"],
				["Laws", "Policies", "Budgets", "Governors", "Leaders", "Edicts", "CrisisDirectives"],
				["Apply law", "Change policy", "Assign governor", "Set budget", "Issue directive"],
				["Civil stability", "Budget pressure", "Policy effect", "Leader bonus", "Crisis readiness"],
				["Government modifiers", "Civil stability effects", "Leader assignments"]),
			new OGameMenuSystemDefinition("diplomacy", "Diplomacy Desk", "Diplomacy",
				["Contacts", "Relations", "Pacts", "War Declarations", "Claims", "Sanctions", "Envoys", "Espionage"],
				["Diplomacy header", "Contact list", "Treaty form", "Claim map", "Intel inspector", "Footer"],
				["Relations plane", "Treaty plane", "Claim plane", "Espionage plane"],
				["Envoys", "Trust", "Threat", "Sanctions", "Bans", "Non-Aggression", "Trade Pacts", "Covert Pressure"],
				["Contacts", "Pacts", "Wars", "Claims", "Trust", "Threat", "Sanctions", "Envoys", "Espionage", "Messages"],
				["Manage contact", "Declare war", "Negotiate treaty", "Assign envoy", "Launch espionage"],
				["Relation score", "Trust", "Threat", "Pacts", "Claims", "Sanctions", "Wars", "Envoys", "Espionage level"],
				["Treaty proposals", "War state", "Sanctions", "Espionage missions"]),
			new OGameMenuSystemDefinition("alliance", "Alliance Command", "Alliance",
				["Alliance Overview", "Roster", "Members", "Ranks", "Permissions", "Applications", "Circular Messages", "Shared Operations"],
				["Alliance header", "Roster table", "Rank editor", "Application queue", "Message inspector", "Footer"],
				["Roster plane", "Permissions plane", "Diplomacy plane", "Operations plane"],
				["Founder", "Officers", "Wings", "Applications", "Circular Messages", "Alliance Tech", "Shared Operations"],
				["Members", "Ranks", "Permissions", "Applications", "Messages", "Operations", "AllianceTech"],
				["Review roster", "Change rank", "Review application", "Send circular message", "Open shared operation"],
				["Member count", "Rank permissions", "Pending applications", "Operation status", "Alliance standing"],
				["Alliance ranks", "Applications", "Ownership transfer", "Shared operations"]),
			new OGameMenuSystemDefinition("character", "Character Command", "Character",
				["Character Sheet", "Classes", "Skills", "Talents", "Equipment", "Inventory", "Reputation", "Guild", "Social"],
				["Character header", "Equipment slots", "Skill tree", "Inventory grid", "Reputation inspector", "Footer"],
				["Stats plane", "Equipment plane", "Quest plane", "Social plane"],
				["Weapons", "Shields", "Armor", "Talents", "Reputation", "Guild", "Campaign Acts", "Chapter Details"],
				["Class", "Level", "Skills", "Equipment", "Inventory", "Reputation", "Quests", "SocialAffiliations"],
				["Equip commander", "Review skills", "Track quests", "Inspect chapters", "Open social state"],
				["Health", "Armor", "Shields", "Weapons", "Skills", "Talents", "Class", "Level", "Reputation", "Quest progress"],
				["Experience", "Levels", "Skill unlocks", "Equipment effects", "Quest rewards"]),
			new OGameMenuSystemDefinition("campaign", "Campaign Journal", "Campaign",
				["Acts", "Chapter Bands", "Mission Arcs", "Chapter Details", "Rewards", "Continuity Hooks"],
				["Campaign header", "Act list", "Chapter list", "Mission detail", "Reward inspector", "Footer"],
				["Act plane", "Chapter plane", "Mission plane", "Reward plane"],
				["12 Acts", "Chapter Bands", "Mission Arcs", "Objectives", "Rewards", "Continuity Hooks", "Failure States"],
				["Acts", "Chapters", "Objectives", "Rewards", "ContinuityHooks", "FailureStates"],
				["Open act", "Inspect chapter", "Track objective", "Claim reward", "Read briefing"],
				["Act progress", "Chapter progress", "Objective completion", "Reward status", "Mission readiness"],
				["Act unlocks", "Mission rewards", "Continuity hooks", "Briefing text"]),
			new OGameMenuSystemDefinition("system-menu", "System Menu", "System Menu",
				["Resume", "Save", "Load", "Settings", "Music", "Audio", "Display", "Controls", "Abort Mission", "Surrender", "Restart"],
				["Pause command panel", "Settings window", "Save/load browser", "Music window", "Confirmation modal", "Footer"],
				["Game plane", "Audio plane", "Display plane", "Controls plane"],
				["Resume", "Save", "Load", "Settings", "Music", "Abort Mission", "Surrender", "Restart", "Back To Editor"],
				["SettingsProfile", "SaveAge", "MapMetadata", "ModVersion", "HotkeyContext", "PerfLinks"],
				["Resume game", "Save game", "Load game", "Open settings", "Open music", "Surrender", "Restart"],
				["FPS", "Save age", "Map metadata", "Mod version", "Settings profile", "Active hotkey context"],
				["Settings", "Save/load", "Music", "Restart", "Surrender", "Editor state"])
		];

		public static readonly IReadOnlyList<OGameMenuTodoDefinition> TodoGroups =
		[
			new OGameMenuTodoDefinition("foundation", "Foundation",
				["Stable IDs", "Static catalog and runtime state split", "Menu state controller", "Input routing", "Persistence", "Lint coverage"]),
			new OGameMenuTodoDefinition("frames", "Window Frames And Layout", FrameOrder.ToArray()),
			new OGameMenuTodoDefinition("data-logic", "Data Logic",
				["OGameMenuState", "OGameEmpireState", "OGamePlanetMenuState", "OGameFleetState", "OGameResearchState", "OGameDiplomacyState", "OGameCharacterState", "Serialization", "Save-game migration"]),
			new OGameMenuTodoDefinition("gameplay-functions", "Gameplay Logic And Functions",
				["Resource production", "Queue processing", "Fleet dispatch", "Fleet resolution", "Battle logic", "Research logic", "Building logic", "Diplomacy logic", "Market logic", "Character logic", "Campaign logic", "System settings logic"]),
			new OGameMenuTodoDefinition("ui-binding", "UI Binding And Interaction",
				["Data-bound labels", "Selectable tabs", "Scroll panels", "Tooltips", "Confirmations", "Notifications", "Keyboard/gamepad navigation", "Accessibility"]),
			new OGameMenuTodoDefinition("tests", "Tests And Validation",
				["Catalog ID tests", "Economy tests", "Fleet tests", "Battle tests", "Research tests", "Diplomacy tests", "Fluent/chrome lint", "Save/load tests", "Manual Red Sector smoke test"])
		];

		public static readonly IReadOnlyList<string> ImplementationOrder =
		[
			"Lock the catalog schema and IDs.",
			"Add runtime state containers and serialization.",
			"Bind the existing in-game menu to selectable tabs and rails.",
			"Implement Empire, Planet, Fleet, Research, and System Menu first.",
			"Implement War, Diplomacy, Alliance, Market, Character, and Campaign next.",
			"Add stats inspectors and notification hooks.",
			"Add save/load migration and tests.",
			"Replace placeholder labels with full interactive pages."
		];

		public static int LogicFunctionCount => Systems.Sum(s => s.LogicFunctions.Count);

		public static int StatCount => Systems.Sum(s => s.Stats.Count);

		public static int FeatureCount => Systems.Sum(s => s.Features.Count);
	}
}
