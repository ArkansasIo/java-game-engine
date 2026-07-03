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
	public static class OGameCatalog
	{
		public static readonly IReadOnlyList<OGameFeature> Features =
		[
			new OGameFeature("accounts", "Accounts and Sessions", "game/core/user.php",
				"Registration, validation, login, sessions, vacation mode, bans, premium/officer flags, and activity tracking."),
			new OGameFeature("universe", "Universe Settings", "game/core/uni.php",
				"Universe speed, fleet speed, ACS, debris, defense repair, galaxy/system limits, language, and battle-engine settings."),
			new OGameFeature("localization", "Localization", "game/core/loca.php",
				"Multilingual locale loading for common strings, technology names, pages, debug text, and mods."),
			new OGameFeature("planets", "Planets and Moons", "game/core/planet.php",
				"Planet generation, selected planet state, activity, images, temperature, moons, debris fields, and ownership."),
			new OGameFeature("production", "Resource Production", "game/core/prod.php",
				"Metal, crystal, deuterium, energy, storage, economy bonuses, build costs, build times, and fleet prices."),
			new OGameFeature("queue", "Deferred Queue", "game/core/queue.php",
				"Construction, shipyard, research, fleet, cleanup, ban, stats, bot, coupon, and mod queue processing."),
			new OGameFeature("fleet", "Fleet Missions", "game/core/fleet.php",
				"Fleet dispatch, speed, consumption, mission availability, return, ACS, logs, and mission completion."),
			new OGameFeature("acs", "Alliance Combat System", "game/core/acs.php", "Union creation, members, holding fleets, ACS timing, and combined attacks/defense."),
			new OGameFeature("battle", "Battle Simulation", "game/core/battle.php; game/core/battle_engine.php",
				"Battle source generation, six-round combat, rapidfire, shields, armor, debris, plunder, reports, and writeback."),
			new OGameFeature("alliances", "Alliances", "game/core/ally*.php",
				"Alliance creation, ranks, applications, ownership changes, member lists, and alliance statistics."),
			new OGameFeature("messages", "Messages and Notes", "game/core/msg.php; game/core/notes.php",
				"User messages, reports, notes, priorities, and notification pages."),
			new OGameFeature("admin", "Administration", "game/pages_admin",
				"Universe, users, planets, queues, logs, localization, bots, bans, coupons, battle simulation, database, and debug tools."),
			new OGameFeature("mods", "Modification Engine", "game/core/mods.php",
				"GameMod hooks for routes, UI, queue, production, fleet, battle, images, buildings, research, and custom data rows."),
			new OGameFeature("ui", "Browser UI Pages", "game/pages; game/router.json",
				"Route-driven old-style PHP pages and MVC-style Page subclasses for gameplay and admin workflows."),
			new OGameFeature("stellar-blueprint", "Stellar RTS/4X/MMORPG Blueprint",
				"docs/ogame-0.84/stellar-rts-4x-design.md",
				"12-act, 600-chapter design layer, 35 chapter details, 90 classes, and hybrid UI pillars.")
		];

		public static readonly IReadOnlyList<OGameNamedValue> ChapterElements =
		[
			new OGameNamedValue("setting", "Setting", "Location details."),
			new OGameNamedValue("weather", "Weather", "Environmental state."),
			new OGameNamedValue("time-period", "Time Period", "Era or timeline placement."),
			new OGameNamedValue("political-context", "Political Context", "Power balance and policy context."),
			new OGameNamedValue("economic-state", "Economic State", "Shortage, growth, crash, or trade status."),
			new OGameNamedValue("cultural-tension", "Cultural Tension", "Civic, ethnic, or faction pressure."),
			new OGameNamedValue("religious-influence", "Religious Influence", "Faith, ideology, cult, or doctrine pressure."),
			new OGameNamedValue("technology-level", "Technological Level", "Available science and industry tier."),
			new OGameNamedValue("special-power-system", "Special Power System", "Magic, psionics, relics, anomalies, or equivalent."),
			new OGameNamedValue("military-presence", "Military Presence", "Visible forces and command posture."),
			new OGameNamedValue("civilian-life", "Civilian Life", "Population impact."),
			new OGameNamedValue("government-stance", "Government Stance", "Official response."),
			new OGameNamedValue("key-character", "Key Character", "Primary viewpoint or actor."),
			new OGameNamedValue("character-motivation", "Character Motivation", "Immediate goal."),
			new OGameNamedValue("character-conflict", "Character Conflict", "Internal or external opposition."),
			new OGameNamedValue("allies", "Allies", "Friendly forces."),
			new OGameNamedValue("enemies", "Enemies", "Hostile forces."),
			new OGameNamedValue("neutral-parties", "Neutral Parties", "Unaligned actors."),
			new OGameNamedValue("primary-event", "Primary Event", "Main chapter beat."),
			new OGameNamedValue("secondary-event", "Secondary Event", "Supporting beat."),
			new OGameNamedValue("twist", "Twist", "Unexpected change."),
			new OGameNamedValue("lore-reveal", "Lore Reveal", "New setting truth."),
			new OGameNamedValue("artifact", "Artifact", "Important object."),
			new OGameNamedValue("weapon", "Weapon", "Important weapon or class."),
			new OGameNamedValue("unit-type", "Unit Type", "Relevant unit class."),
			new OGameNamedValue("creature-or-entity", "Creature Or Entity", "Nonstandard actor."),
			new OGameNamedValue("building", "Building", "Relevant structure."),
			new OGameNamedValue("resource", "Resource", "Material or strategic resource."),
			new OGameNamedValue("transportation", "Transportation", "Travel or logistics method."),
			new OGameNamedValue("communication", "Communication", "Information channel."),
			new OGameNamedValue("conflict-escalation", "Conflict Escalation", "How the stakes rise."),
			new OGameNamedValue("resolution-attempt", "Resolution Attempt", "What is tried."),
			new OGameNamedValue("failure-point", "Failure Point", "Why it fails or costs more."),
			new OGameNamedValue("cliffhanger", "Cliffhanger", "Ending hook."),
			new OGameNamedValue("continuity-hook", "Continuity Hook", "Thread into later chapters.")
		];

		public static readonly IReadOnlyList<OGameSystemClass> SystemClasses =
		[
			new OGameSystemClass(OGameSystemDomain.Weapons, "Kinetic Small Arms", "Rifles", "Pistols", "Shotguns"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Kinetic Heavy Arms", "Railguns", "Autocannons", "Mass Drivers"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Directed Energy Arms", "Lasers", "Lances", "Beam Carbines"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Plasma Weapons", "Plasma Rifles", "Fusion Cutters"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Particle Weapons", "Ion Sprayers", "Neutron Projectors"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Missile Weapons", "Torpedoes", "Rockets", "Smart Missiles"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Drone Weapons", "Loiter Munitions", "Hunter-Killers"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Melee Weapons", "Monoblades", "Shock Mauls"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Siege Weapons", "Planet Crackers", "Bunker Mortars"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Orbital Weapons", "Kinetic Rods", "Defense Grids"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Electronic Warfare", "Jammers", "Spoofers", "EMP"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Bioweapons", "Spores", "Tailored Pathogens"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Psionic Weapons", "Mind Lances", "Panic Fields"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Relic Weapons", "Precursor Cannons", "Null Spears"),
			new OGameSystemClass(OGameSystemDomain.Weapons, "Improvised Weapons", "Mining Lasers", "Cargo Bombs"),

			new OGameSystemClass(OGameSystemDomain.Shields, "Deflector Shields", "Projectile Deflection"),
			new OGameSystemClass(OGameSystemDomain.Shields, "Energy Shields", "Laser Absorption", "Plasma Absorption"),
			new OGameSystemClass(OGameSystemDomain.Shields, "Kinetic Shields", "Mass-Impact Dampening"),
			new OGameSystemClass(OGameSystemDomain.Shields, "Thermal Shields", "Heat Bloom Resistance"),
			new OGameSystemClass(OGameSystemDomain.Shields, "Point Defense Shields", "Micro Interception"),
			new OGameSystemClass(OGameSystemDomain.Shields, "Psionic Wards", "Mental Defense", "Anomaly Defense"),
			new OGameSystemClass(OGameSystemDomain.Shields, "Adaptive Shields", "Threat-Learning Harmonics"),
			new OGameSystemClass(OGameSystemDomain.Shields, "Void Shields", "Dimensional Shear Screens"),
			new OGameSystemClass(OGameSystemDomain.Shields, "Bio-Shields", "Living Ablative Barriers"),
			new OGameSystemClass(OGameSystemDomain.Shields, "Planetary Shields", "City Domes", "World Domes"),

			new OGameSystemClass(OGameSystemDomain.Armors, "Civil Fabric Armor", "Worker Protection", "Militia Protection"),
			new OGameSystemClass(OGameSystemDomain.Armors, "Composite Armor", "Infantry Plates"),
			new OGameSystemClass(OGameSystemDomain.Armors, "Reactive Armor", "Vehicle Blast Tiles"),
			new OGameSystemClass(OGameSystemDomain.Armors, "Ceramic Armor", "Thermal Resistance", "Beam Resistance"),
			new OGameSystemClass(OGameSystemDomain.Armors, "Powered Armor", "Assault Exosuits"),
			new OGameSystemClass(OGameSystemDomain.Armors, "Nano Armor", "Self-Repairing Shells"),
			new OGameSystemClass(OGameSystemDomain.Armors, "Void Armor", "Anomaly-Hardened Plating"),
			new OGameSystemClass(OGameSystemDomain.Armors, "Bio Armor", "Grown Carapace Systems"),
			new OGameSystemClass(OGameSystemDomain.Armors, "Stealth Armor", "Sensor-Absorbent Suits"),
			new OGameSystemClass(OGameSystemDomain.Armors, "Titan Armor", "Capital Armor", "Megastructure Armor"),

			new OGameSystemClass(OGameSystemDomain.Units, "Civilian Workers", "Miners", "Farmers", "Technicians"),
			new OGameSystemClass(OGameSystemDomain.Units, "Engineers", "Repair", "Build", "Bridge", "Breach"),
			new OGameSystemClass(OGameSystemDomain.Units, "Militia", "Local Defense Troops"),
			new OGameSystemClass(OGameSystemDomain.Units, "Line Infantry", "Standard Combat Squads"),
			new OGameSystemClass(OGameSystemDomain.Units, "Heavy Infantry", "Shielded Assault Teams"),
			new OGameSystemClass(OGameSystemDomain.Units, "Recon Units", "Scouts", "Pathfinders", "Observers"),
			new OGameSystemClass(OGameSystemDomain.Units, "Special Forces", "Saboteurs", "Commandos"),
			new OGameSystemClass(OGameSystemDomain.Units, "Medics", "Field Hospitals", "Evac Teams"),
			new OGameSystemClass(OGameSystemDomain.Units, "Armor Units", "Tanks", "Walkers", "Crawlers"),
			new OGameSystemClass(OGameSystemDomain.Units, "Artillery Units", "Rockets", "Rail Mortars"),
			new OGameSystemClass(OGameSystemDomain.Units, "Air Units", "Fighters", "Bombers", "Transports"),
			new OGameSystemClass(OGameSystemDomain.Units, "Naval Units", "Sea Fleets", "Submersibles"),
			new OGameSystemClass(OGameSystemDomain.Units, "Space Units", "Corvettes", "Cruisers", "Titans"),
			new OGameSystemClass(OGameSystemDomain.Units, "Autonomous Units", "Drones", "Bots", "Swarm Nodes"),
			new OGameSystemClass(OGameSystemDomain.Units, "Hero Units", "Commanders", "Paragons", "Champions"),

			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Command Hierarchy", "Rank", "Delegation", "Command Points"),
			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Doctrine System", "Fleet", "Ground", "Insurgency"),
			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Logistics System", "Supply", "Fuel", "Munitions"),
			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Training System", "Experience", "Academies"),
			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Intelligence System", "Spies", "Sensors", "Decrypts"),
			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Morale System", "Fear", "Fatigue", "Cohesion"),
			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Fortification System", "Bunkers", "Bastions", "Minefields"),
			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Mobilization System", "Reserves", "Drafts", "Industry"),
			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Fleet Command System", "Admirals", "Task Forces", "Stances"),
			new OGameSystemClass(OGameSystemDomain.MilitarySystems, "Occupation System", "Garrisons", "Unrest", "Compliance"),

			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Agriculture", "Food Chains", "Habitat Farms"),
			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Industry", "Factories", "Refineries"),
			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Trade", "Markets", "Routes", "Tariffs"),
			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Education", "Schools", "Research Culture"),
			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Healthcare", "Clinics", "Plague Control"),
			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Transportation", "Roads", "Hyperlanes", "Ports"),
			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Communication", "Nets", "Relays", "Propaganda"),
			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Energy", "Reactors", "Grids", "Batteries"),
			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Water And Life Support", "Hydro Systems", "Atmosphere Systems"),
			new OGameSystemClass(OGameSystemDomain.CivilSystems, "Culture", "Media", "Rituals", "Prestige"),

			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Monarchy", "Dynasties", "Succession"),
			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Republic", "Senates", "Elections"),
			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Empire", "Central Authority", "Provinces"),
			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Theocracy", "Priesthood", "Doctrine"),
			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Technocracy", "Expert Councils", "Algorithms"),
			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Magocracy Psionocracy", "Power Users Rule"),
			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Military Junta", "General Staff Government"),
			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Corporate State", "Boards", "Shares", "Contracts"),
			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Hive Governance", "Collective", "Gestalt"),
			new OGameSystemClass(OGameSystemDomain.GovernmentSystems, "Federation", "Member States", "Charters"),

			new OGameSystemClass(OGameSystemDomain.Buildings, "Command Center", "Planetary Control Hub"),
			new OGameSystemClass(OGameSystemDomain.Buildings, "Habitat District", "Housing", "Amenities"),
			new OGameSystemClass(OGameSystemDomain.Buildings, "Industrial District", "Manufacturing Slots"),
			new OGameSystemClass(OGameSystemDomain.Buildings, "Research Complex", "Labs", "Archives"),
			new OGameSystemClass(OGameSystemDomain.Buildings, "Military Barracks", "Troop Training"),
			new OGameSystemClass(OGameSystemDomain.Buildings, "Shipyard", "Orbital Production"),
			new OGameSystemClass(OGameSystemDomain.Buildings, "Defense Platform", "Turrets", "Shields"),
			new OGameSystemClass(OGameSystemDomain.Buildings, "Trade Hub", "Market", "Logistics"),
			new OGameSystemClass(OGameSystemDomain.Buildings, "Government Forum", "Laws", "Unity"),
			new OGameSystemClass(OGameSystemDomain.Buildings, "Megastructure", "Ring", "Gate", "Forge", "Dyson Class")
		];
	}
}

