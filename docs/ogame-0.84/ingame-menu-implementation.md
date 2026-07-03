# In-Game Menu Implementation Catalog

This catalog defines the staged UniversCivilization/OGame 0.84 strategy menu that is rendered by `mods/common/chrome/ingame-menu.yaml` and populated by `Arklight.Mods.Common/OGame084/OGameInterfaceModel.cs`.

## Live Window Shell

| Frame | Purpose |
| --- | --- |
| Header | Active map, mode, title, alerts, and command identity. |
| Top Tabs | Empire, galaxy, system, planet, fleet, war, research, market, diplomacy, alliance, character, and system navigation. |
| Left Rail | Submenus for the active strategic section. |
| Center Page | Pages, subpages, planes, subplanes, lists, forms, queues, reports, and grids. |
| Right Inspector | Window frames, selected-object stats, warnings, functions, and backing game logic. |
| Footer | Active Arklight pause actions and strategy-shell status text. |

## Windows, Planes, Subplanes, And Logic

| Window | Planes | Subplanes | Functions | Backing logic |
| --- | --- | --- | --- | --- |
| Empire Dashboard | Resource topbar, alert strip, colony ledger, victory tracker | Metal, crystal, deuterium, energy, dark matter, command capacity | Review empire status, select colony, inspect income, open objectives, jump to crisis | `OGameCatalog.Features`, `OGameEconomy`, `OGameCampaign`, `EmpireCreationCatalog` |
| Galaxy Map | Galaxy, sector, system, expedition | Coordinates, debris fields, moons, pirates, NPC empires, jump points | Browse sectors, inspect systems, plan expeditions, track hostile fleets, open diplomacy target | `OGameFleet`, universe settings, interface transitions |
| Planet Command | Overview, production, construction, defense | Mines, power, storage, population, housing, culture, stability | Manage buildings, queue ships, queue defenses, balance energy, inspect storage | `OGameEconomy`, building queues, shipyard queues |
| Fleet Command | Dispatch, mission, movement, logistics | Attack, transport, deploy, hold, colonize, recycle, expedition, missiles | Dispatch fleets, calculate fuel, resolve arrivals, return fleets, write logs | `OGameFleet`, `OGameMissionType`, `OGameBattle`, ACS |
| War Room | Fronts, armies, battle reports, production | Infantry, vehicles, aircraft, naval, mechs, drones, fortifications, special forces | Review battles, inspect units, compare weapons, track losses, jump to tactical battle | `OGameBattle`, weapon catalog, unit catalog |
| Research Lab | Physics, energy, combat, propulsion | Laser, ion, plasma, hyperspace, computer, espionage, armor, shielding | Inspect requirements, queue research, preview bonuses, open tech details, compare upgrades | Research queues, weapon catalog, shield catalog |
| Market And Civil Systems | Exchange, trade routes, civil services, supply | Import, export, convoys, tariffs, smuggling, shortages, surpluses | Post orders, inspect shortages, assign convoys, review taxes, track storage | `OGameEconomy`, civil systems, empire creation catalog |
| Diplomacy And Alliance | Relations, treaty, alliance roster, espionage | Envoys, trust, threat, sanctions, bans, non-aggression, trade pacts, circular messages | Manage contacts, declare war, negotiate treaties, review ranks, send circular messages | Alliance catalog, message catalog, espionage missions |
| Character And Campaign | Stats, equipment, quest, social | Weapons, shields, armor, talents, reputation, guild, campaign acts, chapter details | Equip commander, review skills, track quests, inspect chapters, open social state | `OGameCampaign`, chapter elements, armor catalog |
| System Menu | Game, audio, display, controls | Resume, save, load, settings, music, abort mission, surrender, restart | Resume, save, load, settings, music, surrender, restart | `IngameMenuLogic`, settings, music, save/load browser |

## Integration Notes

- The active menu remains compatible with the existing Arklight pause buttons.
- The strategy panes are staged as information and layout surfaces until individual gameplay screens receive dedicated interactive chrome logic.
- The catalog is intentionally data-driven so future UI logic can bind buttons, tabs, detail panels, and inspectors to the same section/window definitions.
