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
	public enum OGameInterfaceView
	{
		Galaxy,
		System,
		Planet,
		Commander,
		Character,
		Government,
		Economy,
		WarRoom,
		Diplomacy
	}

	public sealed class OGameInterfaceTransition
	{
		public readonly OGameInterfaceView From;
		public readonly OGameInterfaceView To;
		public readonly string Trigger;

		public OGameInterfaceTransition(OGameInterfaceView from, OGameInterfaceView to, string trigger)
		{
			From = from;
			To = to;
			Trigger = trigger;
		}
	}

	public sealed class OGameInterfaceSection
	{
		public readonly string Id;
		public readonly string Name;
		public readonly IReadOnlyList<string> Submenus;
		public readonly IReadOnlyList<string> Pages;
		public readonly IReadOnlyList<string> Subpages;

		public OGameInterfaceSection(string id, string name, string[] submenus, string[] pages, string[] subpages)
		{
			Id = id;
			Name = name;
			Submenus = submenus;
			Pages = pages;
			Subpages = subpages;
		}
	}

	public sealed class OGameInterfaceWindow
	{
		public readonly string Id;
		public readonly string Name;
		public readonly IReadOnlyList<string> Planes;
		public readonly IReadOnlyList<string> Subplanes;
		public readonly IReadOnlyList<string> Frames;
		public readonly IReadOnlyList<string> Functions;
		public readonly IReadOnlyList<string> GameLogic;

		public OGameInterfaceWindow(
			string id,
			string name,
			string[] planes,
			string[] subplanes,
			string[] frames,
			string[] functions,
			string[] gameLogic)
		{
			Id = id;
			Name = name;
			Planes = planes;
			Subplanes = subplanes;
			Frames = frames;
			Functions = functions;
			GameLogic = gameLogic;
		}
	}

	public static class OGameInterfaceModel
	{
		public static readonly IReadOnlyList<OGameNamedValue> Views =
		[
			new OGameNamedValue("galaxy", "Galaxy 4X View",
				"Empire borders, hyperlanes, fleets, anomalies, claims, trade routes, and war fronts."),
			new OGameNamedValue("system", "System View", "Planets, stations, orbital lanes, tactical fleets, civilian traffic, and combat zones."),
			new OGameNamedValue("planet", "Planet Management View", "Districts, buildings, population, stability, production, defense, culture, and missions."),
			new OGameNamedValue("commander", "RTS Commander View",
				"Unit selection, control groups, abilities, stances, formations, build queues, and tactical overlays."),
			new OGameNamedValue("character", "MMORPG Character View", "Avatar class tree, equipment, quests, guilds, faction reputation, and social actions."),
			new OGameNamedValue("government", "Government View", "Laws, policies, budgets, diplomacy, espionage, leader assignments, and crisis directives."),
			new OGameNamedValue("economy", "Economy View", "Resource flows, shortages, trade, industry, logistics, upkeep, and market orders."),
			new OGameNamedValue("war-room", "War Room", "Fronts, objectives, armies, fleets, intel, rally points, invasions, and occupation status."),
			new OGameNamedValue("diplomacy", "Diplomacy View", "Treaties, rivals, federation votes, claims, envoys, and covert pressure.")
		];

		public static readonly IReadOnlyList<OGameInterfaceTransition> Transitions =
		[
			new OGameInterfaceTransition(OGameInterfaceView.Galaxy, OGameInterfaceView.System, "Select star system"),
			new OGameInterfaceTransition(OGameInterfaceView.System, OGameInterfaceView.Planet, "Select planet"),
			new OGameInterfaceTransition(OGameInterfaceView.System, OGameInterfaceView.Commander, "Enter tactical battle"),
			new OGameInterfaceTransition(OGameInterfaceView.Planet, OGameInterfaceView.Economy, "Inspect production"),
			new OGameInterfaceTransition(OGameInterfaceView.Planet, OGameInterfaceView.Government, "Inspect policies"),
			new OGameInterfaceTransition(OGameInterfaceView.Galaxy, OGameInterfaceView.Diplomacy, "Select empire or faction"),
			new OGameInterfaceTransition(OGameInterfaceView.Galaxy, OGameInterfaceView.WarRoom, "Open active war or crisis"),
			new OGameInterfaceTransition(OGameInterfaceView.Commander, OGameInterfaceView.Character, "Select hero or avatar"),
			new OGameInterfaceTransition(OGameInterfaceView.Character, OGameInterfaceView.Commander, "Return to command"),
			new OGameInterfaceTransition(OGameInterfaceView.Economy, OGameInterfaceView.Planet, "Close economy panel"),
			new OGameInterfaceTransition(OGameInterfaceView.Government, OGameInterfaceView.Galaxy, "Apply empire policy"),
			new OGameInterfaceTransition(OGameInterfaceView.WarRoom, OGameInterfaceView.Commander, "Jump to battle"),
			new OGameInterfaceTransition(OGameInterfaceView.WarRoom, OGameInterfaceView.Galaxy, "Return to strategic map")
		];

		public static readonly IReadOnlyList<OGameInterfaceSection> MenuSections =
		[
			new OGameInterfaceSection("empire", "Empire",
				["Empire Overview", "Alerts", "Resource Ledger", "Colonies", "Victory"],
				["Dashboard", "Resources", "Expansion", "Objectives"],
				["Metal", "Crystal", "Deuterium", "Energy", "Dark Matter", "Command Capacity"]),
			new OGameInterfaceSection("galaxy", "Galaxy",
				["Galaxy Map", "Sector Browser", "Claims", "Trade Routes", "Anomalies"],
				["Map", "Sectors", "Systems", "Expeditions"],
				["Coordinates", "Debris Fields", "Moons", "Pirates", "NPC Empires", "Jump Points"]),
			new OGameInterfaceSection("system", "System",
				["System Overview", "Orbital Lanes", "Stations", "Contacts", "Tactical View"],
				["Star", "Planets", "Fleets", "Stations"],
				["Orbitals", "Traffic", "Blockades", "Sensor Range", "Combat Zones", "Civilian Routes"]),
			new OGameInterfaceSection("planet", "Planet",
				["Planet Overview", "Resources", "Buildings", "Shipyard", "Defenses"],
				["Overview", "Production", "Construction", "Defense Grid"],
				["Mines", "Power", "Storage", "Population", "Housing", "Culture", "Stability"]),
			new OGameInterfaceSection("fleet", "Fleet",
				["Fleet Dispatch", "Movement", "ACS Operations", "Espionage", "Debris Recovery"],
				["Dispatch", "Missions", "Movement", "Logistics"],
				["Attack", "Transport", "Deploy", "Hold", "Colonize", "Recycle", "Expedition", "Missiles"]),
			new OGameInterfaceSection("war", "War Room",
				["Military Doctrine", "Unit Classes", "Weapons", "Shields", "Armor"],
				["Fronts", "Armies", "Battle Reports", "Production"],
				["Infantry", "Vehicles", "Aircraft", "Naval", "Mechs", "Drones", "Fortifications", "Special Forces"]),
			new OGameInterfaceSection("research", "Research",
				["Research Lab", "Tech Tree", "Upgrades", "Artifacts", "Reverse Engineering"],
				["Physics", "Energy", "Combat", "Propulsion"],
				["Laser", "Ion", "Plasma", "Hyperspace", "Computer", "Espionage", "Armor", "Shielding"]),
			new OGameInterfaceSection("market", "Market",
				["Trade", "Contracts", "Auction", "Logistics", "Supply Lines"],
				["Exchange", "Routes", "Orders", "Storage"],
				["Import", "Export", "Convoys", "Tariffs", "Smuggling", "Shortages", "Surpluses"]),
			new OGameInterfaceSection("diplomacy", "Diplomacy",
				["Contacts", "Treaties", "War Declarations", "Federation", "Espionage"],
				["Relations", "Pacts", "Claims", "Intel"],
				["Envoys", "Trust", "Threat", "Sanctions", "Bans", "Non-Aggression", "Trade Pacts"]),
			new OGameInterfaceSection("alliance", "Alliance",
				["Alliance Overview", "Members", "Ranks", "Applications", "Shared Operations"],
				["Roster", "Permissions", "Diplomacy", "Operations"],
				["Founder", "Officers", "Wings", "Applications", "Circular Messages", "Alliance Tech"]),
			new OGameInterfaceSection("character", "Character",
				["Character Sheet", "Classes", "Skills", "Inventory", "Quests"],
				["Stats", "Equipment", "Progression", "Social"],
				["Weapons", "Shields", "Armor", "Units", "Talents", "Reputation", "Guild", "Campaign Acts"]),
			new OGameInterfaceSection("system-menu", "System Menu",
				["Resume", "Save", "Load", "Settings", "Music"],
				["Game", "Audio", "Display", "Controls"],
				["Abort Mission", "Surrender", "Restart", "Back To Editor", "Exit Editor"])
		];

		public static readonly IReadOnlyList<OGameInterfaceWindow> MenuWindows =
		[
			new OGameInterfaceWindow("empire-dashboard", "Empire Dashboard",
				["Resource topbar", "Alert strip", "Colony ledger", "Victory tracker"],
				["Metal", "Crystal", "Deuterium", "Energy", "Dark Matter", "Command Capacity"],
				["Header", "Top tabs", "Left empire rail", "Center summary grid", "Right alert inspector", "Footer actions"],
				["Review empire status", "Select colony", "Inspect resource income", "Open objectives", "Jump to crisis"],
				["OGameCatalog.Features", "OGameEconomy", "OGameCampaign", "EmpireCreationCatalog"]),
			new OGameInterfaceWindow("galaxy-map", "Galaxy Map",
				["Galaxy plane", "Sector plane", "System plane", "Expedition plane"],
				["Coordinates", "Debris fields", "Moons", "Pirates", "NPC empires", "Jump points"],
				["Header alerts", "Strategic map", "Claims overlay", "Route overlay", "Inspector", "Command footer"],
				["Browse sectors", "Inspect systems", "Plan expeditions", "Track hostile fleets", "Open diplomacy target"],
				["OGameFleet", "OGameCatalog universe", "OGameInterfaceModel.Transitions"]),
			new OGameInterfaceWindow("planet-command", "Planet Command",
				["Overview plane", "Production plane", "Construction plane", "Defense plane"],
				["Mines", "Power", "Storage", "Population", "Housing", "Culture", "Stability"],
				["Planet header", "Resource cards", "Build queue", "Shipyard queue", "Defense grid", "Inspector"],
				["Manage buildings", "Queue ships", "Queue defenses", "Balance energy", "Inspect storage"],
				["OGameEconomy", "OGameQueueType.Building", "OGameQueueType.Shipyard"]),
			new OGameInterfaceWindow("fleet-command", "Fleet Command",
				["Dispatch plane", "Mission plane", "Movement plane", "Logistics plane"],
				["Attack", "Transport", "Deploy", "Hold", "Colonize", "Recycle", "Expedition", "Missiles"],
				["Fleet selector", "Mission picker", "Target selector", "Cargo panel", "Timing panel", "Result footer"],
				["Dispatch fleets", "Calculate fuel", "Resolve arrivals", "Return fleets", "Write mission logs"],
				["OGameFleet", "OGameMissionType", "OGameBattle", "ACS"]),
			new OGameInterfaceWindow("war-room", "War Room",
				["Fronts plane", "Armies plane", "Battle report plane", "Production plane"],
				["Infantry", "Vehicles", "Aircraft", "Naval", "Mechs", "Drones", "Fortifications", "Special forces"],
				["War header", "Front list", "Unit catalog", "Battle report viewer", "Right losses inspector", "Action footer"],
				["Review battles", "Inspect units", "Compare weapons", "Track losses", "Jump to tactical battle"],
				["OGameBattle", "OGameSystemDomain.Weapons", "OGameSystemDomain.Units"]),
			new OGameInterfaceWindow("research-lab", "Research Lab",
				["Physics plane", "Energy plane", "Combat plane", "Propulsion plane"],
				["Laser", "Ion", "Plasma", "Hyperspace", "Computer", "Espionage", "Armor", "Shielding"],
				["Lab header", "Tech tree", "Requirement frame", "Queue frame", "Effect inspector", "Footer actions"],
				["Inspect requirements", "Queue research", "Preview bonuses", "Open tech details", "Compare upgrades"],
				["OGameQueueType.Research", "OGameSystemDomain.Weapons", "OGameSystemDomain.Shields"]),
			new OGameInterfaceWindow("market-and-civil", "Market And Civil Systems",
				["Exchange plane", "Trade route plane", "Civil services plane", "Supply plane"],
				["Import", "Export", "Convoys", "Tariffs", "Smuggling", "Shortages", "Surpluses"],
				["Market header", "Orders table", "Route list", "Civil system list", "Storage inspector", "Footer actions"],
				["Post orders", "Inspect shortages", "Assign convoys", "Review taxes", "Track storage"],
				["OGameEconomy", "OGameSystemDomain.CivilSystems", "EmpireCreationCatalog"]),
			new OGameInterfaceWindow("diplomacy-alliance", "Diplomacy And Alliance",
				["Relations plane", "Treaty plane", "Alliance roster plane", "Espionage plane"],
				["Envoys", "Trust", "Threat", "Sanctions", "Bans", "Non-Aggression", "Trade pacts", "Circular messages"],
				["Diplomacy header", "Contact list", "Treaty form", "Alliance roster", "Intel inspector", "Footer actions"],
				["Manage contacts", "Declare war", "Negotiate treaties", "Review alliance ranks", "Send circular messages"],
				["OGameCatalog alliances", "OGameCatalog messages", "OGameMissionType.Espionage"]),
			new OGameInterfaceWindow("character-campaign", "Character And Campaign",
				["Stats plane", "Equipment plane", "Quest plane", "Social plane"],
				["Weapons", "Shields", "Armor", "Talents", "Reputation", "Guild", "Campaign acts", "Chapter details"],
				["Character header", "Equipment slots", "Skill tree", "Quest journal", "Reputation inspector", "Footer actions"],
				["Equip commander", "Review skills", "Track quests", "Inspect chapters", "Open social state"],
				["OGameCampaign", "OGameCatalog.ChapterElements", "OGameSystemDomain.Armors"]),
			new OGameInterfaceWindow("system-menu", "System Menu",
				["Game plane", "Audio plane", "Display plane", "Controls plane"],
				["Resume", "Save", "Load", "Settings", "Music", "Abort Mission", "Surrender", "Restart"],
				["Pause command panel", "Settings window", "Save/load browser", "Music window", "Confirmation windows", "Footer hints"],
				["Resume game", "Save game", "Load game", "Open settings", "Open music", "Surrender or restart"],
				["IngameMenuLogic", "SettingsLogic", "MusicPlayerLogic", "GameSaveBrowserLogic"])
		];

		public static readonly IReadOnlyList<OGameNamedValue> WindowRegions =
		[
			new OGameNamedValue("header", "Header", "Title, active mode, alert strip, empire identity, and close/minimize actions."),
			new OGameNamedValue("top-tabs", "Top Category Tabs",
				"Primary Stellaris-style navigation across empire, galaxy, system, planet, fleet, war, diplomacy, alliance, and character sections."),
			new OGameNamedValue("left-rail", "Left Submenu Rail", "Local section navigation, filters, and page families."),
			new OGameNamedValue("center-page", "Center Page", "Main page and subpage content such as grids, forms, reports, and management lists."),
			new OGameNamedValue("right-inspector", "Right Inspector", "Selected object details, stats, alerts, and contextual actions."),
			new OGameNamedValue("footer", "Footer", "Current actions, hotkey hints, status text, and warning messages.")
		];
	}
}

