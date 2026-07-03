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
	public enum EmpireOriginKind
	{
		Homeworld,
		Voidborne,
		MachineAwakening,
		RefugeeFleet,
		AncientGate,
		CorporateExodus,
		FrontierColony,
		PsionicSchism,
		WarRemnant,
		TerraformerSeed
	}

	public enum EmpireCreationStep
	{
		Account,
		Profile,
		Race,
		Government,
		Origin,
		HomeSystem,
		FlagAndColors,
		Commander,
		Difficulty,
		Multiplayer
	}

	public sealed class PlayableRaceDefinition
	{
		public readonly string Id;
		public readonly string Name;
		public readonly string Archetype;
		public readonly string Trait;
		public readonly string Bonus;
		public readonly string Drawback;
		public readonly string VisualDirection;

		public PlayableRaceDefinition(string id, string name, string archetype, string trait, string bonus, string drawback, string visualDirection)
		{
			Id = id;
			Name = name;
			Archetype = archetype;
			Trait = trait;
			Bonus = bonus;
			Drawback = drawback;
			VisualDirection = visualDirection;
		}
	}

	public sealed class GovernmentDefinition
	{
		public readonly string Id;
		public readonly string Name;
		public readonly string Authority;
		public readonly string Civic;
		public readonly string Bonus;
		public readonly string Constraint;

		public GovernmentDefinition(string id, string name, string authority, string civic, string bonus, string constraint)
		{
			Id = id;
			Name = name;
			Authority = authority;
			Civic = civic;
			Bonus = bonus;
			Constraint = constraint;
		}
	}

	public sealed class AccountCreationField
	{
		public readonly string Id;
		public readonly string Name;
		public readonly string Requirement;

		public AccountCreationField(string id, string name, string requirement)
		{
			Id = id;
			Name = name;
			Requirement = requirement;
		}
	}

	public sealed class ExpansionDefinition
	{
		public readonly string Id;
		public readonly string Name;
		public readonly string Type;
		public readonly string Includes;
		public readonly bool MultiplayerCompatible;

		public ExpansionDefinition(string id, string name, string type, string includes, bool multiplayerCompatible)
		{
			Id = id;
			Name = name;
			Type = type;
			Includes = includes;
			MultiplayerCompatible = multiplayerCompatible;
		}
	}

	public sealed class MultiplayerRuleDefinition
	{
		public readonly string Id;
		public readonly string Name;
		public readonly string Value;
		public readonly string Description;

		public MultiplayerRuleDefinition(string id, string name, string value, string description)
		{
			Id = id;
			Name = name;
			Value = value;
			Description = description;
		}
	}

	public static class EmpireCreationCatalog
	{
		public static readonly IReadOnlyList<AccountCreationField> AccountFields =
		[
			new AccountCreationField("commander-name", "Commander Name", "Required display name for single-player profiles and online lobbies."),
			new AccountCreationField("account-id", "Arklight Account ID", "Optional offline ID now; required later for ranked multiplayer, cloud saves, and DLC entitlements."),
			new AccountCreationField("email", "Recovery Email", "Optional until online services are connected."),
			new AccountCreationField("region", "Region", "Used for server browser filtering and recommended relay selection."),
			new AccountCreationField("consent", "Terms And Privacy Consent", "Required before online multiplayer, account sync, telemetry, or cloud profile services."),
			new AccountCreationField("avatar", "Commander Avatar", "Profile portrait, title, emblem, and account color.")
		];

		public static readonly IReadOnlyList<OGameNamedValue> CreationSteps =
		[
			new OGameNamedValue("account", "Account Creation", "Create or select the local/online commander profile before starting a new empire."),
			new OGameNamedValue("profile", "Profile Setup", "Choose commander name, portrait, title, region, accessibility defaults, and autosave policy."),
			new OGameNamedValue("race", "Race Selection", "Pick one of ten playable species with distinct economy, combat, diplomacy, and colony traits."),
			new OGameNamedValue("government", "Government", "Pick one of ten empire governments with authority, civics, bonuses, and policy limits."),
			new OGameNamedValue("origin", "Origin", "Choose a starting story such as homeworld, voidborne fleet, refugee convoy, or ancient gate awakening."),
			new OGameNamedValue("home-system", "Home System", "Tune star type, homeworld biome, moon count, resource bias, hazards, and neighboring rivals."),
			new OGameNamedValue("flag-colors", "Flag And Colors", "Set banner, emblem, ship livery, UI accent, advisor voice, and fleet prefix."),
			new OGameNamedValue("commander", "Commander Class", "Choose admiral, governor, scientist, diplomat, agent, industrialist, or warlord starting perks."),
			new OGameNamedValue("difficulty", "Difficulty And Galaxy", "Set AI aggression, crisis timing, galaxy size, tech speed, economy speed, and fog-of-war rules."),
			new OGameNamedValue("multiplayer", "Online Multiplayer", "Host, join, or reserve up to eight player empires with spectators, passwords, mods, and DLC rules.")
		];

		public static readonly IReadOnlyList<PlayableRaceDefinition> Races =
		[
			new PlayableRaceDefinition("race-solar-human", "Solar Humans", "Adaptive republic builders", "Versatile", "+8% construction speed and +1 envoy", "No extreme-environment bonus", "Clean blue-white ships, civic banners, mixed civilian districts."),
			new PlayableRaceDefinition("race-aurelian", "Aurelian Ascendancy", "Radiant energy aristocrats", "Photonic", "+12% energy output and stronger shields", "-8% ground infantry health", "Gold solar sails, luminous armor, cathedral reactors."),
			new PlayableRaceDefinition("race-kaidran", "Kaidran Clans", "Survivalist desert raiders", "Hardworlders", "+10% armor and better hostile-world mining", "-10% diplomacy trust growth", "Sand-dark hulls, rugged colony crawlers, clan hazard markings."),
			new PlayableRaceDefinition("race-nyxian", "Nyxian Synod", "Covert psionic diplomats", "Veiled Minds", "+15% espionage strength and faster infiltration", "-8% raw industry", "Violet sensor halos, stealth fins, ceremonial masks."),
			new PlayableRaceDefinition("race-vorik", "Vorik Combine", "Corporate cybernetic merchants", "Contract Logic", "+10% trade value and cheaper market orders", "-10% unity from non-commercial policies", "Chrome cargo spines, neon trade glyphs, modular stations."),
			new PlayableRaceDefinition("race-thalassid", "Thalassid Tides", "Aquatic colony engineers", "Oceanic Adaptation", "+12% food/life-support stability and terraforming speed", "-8% desert-world habitability", "Fluid hull curves, blue-green biolights, water-shield domes."),
			new PlayableRaceDefinition("race-ornyx", "Ornyx Legion", "Militarized avian fleet culture", "Strike Wings", "+12% fighter damage and carrier capacity", "-8% civilian growth", "Angular winged ships, red command talons, high-altitude spires."),
			new PlayableRaceDefinition("race-mycelian", "Mycelian Chorus", "Distributed fungal collective", "Spore Network", "+10% population growth and colony recovery", "-10% leader individuality bonuses", "Organic colony mats, soft bioluminescence, living armor plates."),
			new PlayableRaceDefinition("race-synthari", "Synthari Continuum", "Awakened machine civilization", "Synthetic Labor", "+15% worker output and no food need", "-12% diplomacy with spiritual empires", "Matte black machines, lime logic nodes, precise modular fleets."),
			new PlayableRaceDefinition("race-elyrian", "Elyrian Remnants", "Ancient gate descendants", "Relic Memory", "+10% research from ruins and faster anomaly study", "-8% starting population", "Ancient blue stone-metal hulls, gate sigils, crystalline archives.")
		];

		public static readonly IReadOnlyList<GovernmentDefinition> Governments =
		[
			new GovernmentDefinition("gov-imperial-throne", "Imperial Throne", "Imperial", "Centralized vassal rule", "+10% command capacity and faster war mobilization", "Leader succession crises can trigger unrest."),
			new GovernmentDefinition("gov-stellar-republic", "Stellar Republic", "Democratic", "Elected senate", "+10% diplomacy trust and unity from happy colonies", "Policy changes require longer cooldowns."),
			new GovernmentDefinition("gov-military-junta", "Military Junta", "Authoritarian", "General staff rule", "+12% fleet fire rate during defensive wars", "Civilian stability penalties after long wars."),
			new GovernmentDefinition("gov-technocracy", "Technocracy", "Oligarchic", "Research directorates", "+12% research speed and anomaly rewards", "Higher consumer and specialist upkeep."),
			new GovernmentDefinition("gov-corporate-charter", "Corporate Charter", "Corporate", "Board ownership", "+15% trade, contracts, and market income", "Higher penalties when trade routes are blockaded."),
			new GovernmentDefinition("gov-theocratic-oracle", "Theocratic Oracle", "Spiritual", "Doctrine councils", "+10% morale, unity, and psionic defense", "Slower adoption of machine or synthetic policies."),
			new GovernmentDefinition("gov-federated-league", "Federated League", "Federated", "Member-state charter", "+2 alliance operation slots and stronger federation votes", "Lower central tax and slower emergency decrees."),
			new GovernmentDefinition("gov-hive-consensus", "Hive Consensus", "Gestalt", "Collective mind", "+12% population coordination and defense repair", "Cannot use normal faction politics or elections."),
			new GovernmentDefinition("gov-machine-directive", "Machine Directive", "Gestalt Machine", "Core logic protocol", "+15% automation and logistics efficiency", "High energy upkeep and organic diplomacy friction."),
			new GovernmentDefinition("gov-frontier-confederacy", "Frontier Confederacy", "Decentralized", "Colony compacts", "+10% outpost build speed and rebel absorption", "Lower capital-world bonuses and slower central fleets.")
		];

		public static readonly IReadOnlyList<OGameNamedValue> EmpireCreationMenus =
		[
			new OGameNamedValue("new-empire", "New Empire", "Single-player start flow for account/profile, race, government, origin, galaxy, and difficulty."),
			new OGameNamedValue("load-empire", "Load Empire", "Saved empires, autosaves, cloud saves, and ironman slots."),
			new OGameNamedValue("empire-library", "Empire Library", "Saved race/government presets, flags, commanders, AI personality templates, and random empire pool."),
			new OGameNamedValue("online-lobby", "Online 8 Player Lobby", "Host or join a synchronized empire campaign with up to eight player empires."),
			new OGameNamedValue("dlc-expansions", "DLC And Expansions", "Installed content, enabled expansion rules, compatibility locks, and entitlement state."),
			new OGameNamedValue("patch-infolog", "Patch And Info Log", "Version notes, balance changes, known issues, mod warnings, and server notices.")
		];

		public static readonly IReadOnlyList<ExpansionDefinition> Expansions =
		[
			new ExpansionDefinition("exp-void-lattice", "Void Lattice Crisis", "Expansion", "Machine crisis chain, relic weapons, late-game megastructures, and act 8 variants.", true),
			new ExpansionDefinition("exp-desert-sector", "Desert Sector Exodus", "Story Pack", "Harsh-world clans, mobile bases, crawler units, raider contracts, and new origin.", true),
			new ExpansionDefinition("exp-dawn-accord", "Dawn Accord", "Species Pack", "Dawn Concord advisors, research events, quantum labs, and science diplomacy.", true),
			new ExpansionDefinition("exp-eclipse-war", "Eclipse Shadow War", "Story Pack", "Espionage operations, stealth fleets, covert victory path, and infiltration missions.", true),
			new ExpansionDefinition("dlc-commander-vault", "Commander Vault", "Cosmetic DLC", "Portraits, titles, banners, ship liveries, UI accent packs, and lobby badges.", true)
		];

		public static readonly IReadOnlyList<MultiplayerRuleDefinition> MultiplayerRules =
		[
			new MultiplayerRuleDefinition("max-players", "Max Players", "8", "Online empire campaigns support up to eight human player empires."),
			new MultiplayerRuleDefinition("spectators", "Spectators", "Enabled", "Observers can join with host approval and delayed fog-safe vision."),
			new MultiplayerRuleDefinition("dlc-lockstep", "DLC Rule Sync", "Host Locked", "All clients must use the host's enabled expansion rule set before launch."),
			new MultiplayerRuleDefinition("determinism", "Simulation Sync", "Lockstep", "Economy ticks, fleet combat, and battle commands must remain deterministic across clients."),
			new MultiplayerRuleDefinition("turn-pause", "Strategic Pause", "Host Configurable", "The host can allow pause votes, real-time only, or timed strategic pauses."),
			new MultiplayerRuleDefinition("drop-policy", "Disconnect Handling", "AI Substitute", "Disconnected empires can pause, surrender, wait for reconnect, or be driven by AI."),
			new MultiplayerRuleDefinition("ranked", "Ranked Mode", "Disabled Until Account Services", "Ranked requires online accounts, version locks, anti-cheat policy, and replay upload."),
			new MultiplayerRuleDefinition("save-resume", "Save And Resume", "Enabled", "Hosted campaigns can save, verify checksum, and resume with the same players later.")
		];

		public static readonly IReadOnlyList<OGameNamedValue> PatchInfoCategories =
		[
			new OGameNamedValue("patch-notes", "Patch Notes", "Version number, release date, headline changes, balance notes, and migration warnings."),
			new OGameNamedValue("engine-updates", "Engine Updates", "Renderer, audio, input, storage, networking, mod loader, and crash-reporting changes."),
			new OGameNamedValue("game-systems", "Game Systems", "Economy, fleet, battle, diplomacy, government, research, account, and empire-creation changes."),
			new OGameNamedValue("known-issues", "Known Issues", "Open bugs, mod compatibility warnings, save migration limits, and multiplayer restrictions."),
			new OGameNamedValue("server-news", "Server News", "Master-server status, maintenance windows, ranked-season notices, and community events.")
		];
	}
}
