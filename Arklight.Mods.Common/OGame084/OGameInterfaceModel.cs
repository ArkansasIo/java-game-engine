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

using System.Collections.Generic;

namespace OpenRA.Mods.Common.OGame084
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
