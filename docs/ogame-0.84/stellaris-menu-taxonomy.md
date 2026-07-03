# Stellaris/OGame Menu Taxonomy

This document defines the in-game menu hierarchy staged by `mods/common/chrome/ingame-menu.yaml` and mirrored in `OpenRA.Mods.Common/OGame084/OGameInterfaceModel.cs`.

## Window Frame

| Region | Purpose |
| --- | --- |
| Header | Window title, active mode, empire identity, alerts, close/minimize actions. |
| Top Tabs | Primary categories in a Stellaris-style strategy bar. |
| Left Rail | Section-specific submenus and filters. |
| Center Page | Active page and subpage content. |
| Right Inspector | Selected object details, stats, warnings, and context actions. |
| Footer | Hotkey hints, state text, queue warnings, and active OpenRA actions. |

## Categories

| Category | Submenus | Pages | Subpages |
| --- | --- | --- | --- |
| Empire | Empire Overview, Alerts, Resource Ledger, Colonies, Victory | Dashboard, Resources, Expansion, Objectives | Metal, Crystal, Deuterium, Energy, Dark Matter, Command Capacity |
| Galaxy | Galaxy Map, Sector Browser, Claims, Trade Routes, Anomalies | Map, Sectors, Systems, Expeditions | Coordinates, Debris Fields, Moons, Pirates, NPC Empires, Jump Points |
| System | System Overview, Orbital Lanes, Stations, Contacts, Tactical View | Star, Planets, Fleets, Stations | Orbitals, Traffic, Blockades, Sensor Range, Combat Zones, Civilian Routes |
| Planet | Planet Overview, Resources, Buildings, Shipyard, Defenses | Overview, Production, Construction, Defense Grid | Mines, Power, Storage, Population, Housing, Culture, Stability |
| Fleet | Fleet Dispatch, Movement, ACS Operations, Espionage, Debris Recovery | Dispatch, Missions, Movement, Logistics | Attack, Transport, Deploy, Hold, Colonize, Recycle, Expedition, Missiles |
| War Room | Military Doctrine, Unit Classes, Weapons, Shields, Armor | Fronts, Armies, Battle Reports, Production | Infantry, Vehicles, Aircraft, Naval, Mechs, Drones, Fortifications, Special Forces |
| Research | Research Lab, Tech Tree, Upgrades, Artifacts, Reverse Engineering | Physics, Energy, Combat, Propulsion | Laser, Ion, Plasma, Hyperspace, Computer, Espionage, Armor, Shielding |
| Market | Trade, Contracts, Auction, Logistics, Supply Lines | Exchange, Routes, Orders, Storage | Import, Export, Convoys, Tariffs, Smuggling, Shortages, Surpluses |
| Diplomacy | Contacts, Treaties, War Declarations, Federation, Espionage | Relations, Pacts, Claims, Intel | Envoys, Trust, Threat, Sanctions, Bans, Non-Aggression, Trade Pacts |
| Alliance | Alliance Overview, Members, Ranks, Applications, Shared Operations | Roster, Permissions, Diplomacy, Operations | Founder, Officers, Wings, Applications, Circular Messages, Alliance Tech |
| Character | Character Sheet, Classes, Skills, Inventory, Quests | Stats, Equipment, Progression, Social | Weapons, Shields, Armor, Units, Talents, Reputation, Guild, Campaign Acts |
| System Menu | Resume, Save, Load, Settings, Music | Game, Audio, Display, Controls | Abort Mission, Surrender, Restart, Back To Editor, Exit Editor |

## Layout Rules

- Top tabs should stay compact and stable at every game resolution.
- Left rail entries should switch center-page content once logic is added.
- Center pages should support reusable sub-layouts: resource cards, queue rows, fleet slots, diplomacy dossiers, character equipment, quest chapters, battle reports, and settings forms.
- Right inspector panes should show the selected planet, fleet, building, unit, technology, character item, faction, or quest.
- Existing OpenRA pause-menu buttons remain active until each staged page receives dedicated chrome logic.
