# In-Game Menu Systems TODO

This TODO tracks the work needed to turn the staged UniversCivilization/OGame 0.84 command shell into executable menu systems, gameplay systems, data logic, statistics, and feature screens.

## Engine Integration Status

- [x] Added `OGameMenuSystemsCatalog` with typed definitions for menus, submenus, frames, planes, subplanes, stats, logic functions, features, implementation groups, and staged TODO groups.
- [x] Added `OGameMenuRuntimeState` for active category, selected window, selected page, selected subpage, selected object, inspector focus, and pending action.
- [x] Added runtime gameplay state containers for empire, planet menu, fleet, research, diplomacy, and character data that future logic can persist and simulate.
- [x] Bound the in-game command interface labels to the staged menu systems catalog so the blue command menu reflects the current engine catalog.
- [ ] Replace staged catalog summaries with fully interactive controls, persistence, validation, simulation, and save-game serialization.

## Foundation

- [ ] Define stable IDs for every menu, submenu, window, frame, page, subpage, plane, and subplane in `OGameInterfaceModel`.
- [ ] Split static catalog data from runtime player state so UI definitions can be reused by menus, tests, saves, and tools.
- [ ] Add a menu state controller for active category, submenu, page, subpage, selected object, and inspector focus.
- [ ] Add input routing for top tabs, left rail entries, page rows, inspector actions, close/back buttons, and hotkeys.
- [ ] Add persistence for last opened menu, selected colony, selected fleet, selected research item, and selected campaign act.
- [ ] Add lint coverage for missing labels, duplicate menu IDs, invalid page links, and unbound action IDs.

## Window Frames And Layout

- [ ] Header frame: active map, empire name, commander name, alert count, resource summary, clock, and close/minimize actions.
- [ ] Top tab frame: Empire, Galaxy, System, Planet, Fleet, War, Research, Market, Diplomacy, Alliance, Character, and System Menu.
- [ ] Left rail frame: submenu list, filters, collapsed groups, selected state, disabled state, and tooltip descriptions.
- [ ] Center page frame: reusable list, table, grid, card, form, queue, report, and detail templates.
- [ ] Right inspector frame: selected-object stats, warnings, contextual actions, relationship data, queue details, and preview panels.
- [ ] Footer frame: hotkey hints, queued action status, validation errors, resource warnings, and existing Arklight pause commands.
- [ ] Modal frame: confirmation, save/load, message details, treaty proposal, fleet dispatch warning, and queue cancel dialogs.

## Menu And Submenu Systems

- [ ] Empire Dashboard: overview, alerts, resource ledger, colonies, victory, objectives, empire modifiers, and command capacity.
- [ ] Galaxy Map: sectors, systems, claims, debris fields, moons, NPC empires, pirates, jump points, trade routes, and anomalies.
- [ ] System View: star summary, orbitals, planets, stations, blockades, traffic, sensor range, civilian routes, and combat zones.
- [ ] Planet Command: overview, resources, mines, energy, storage, population, housing, culture, stability, buildings, shipyard, and defenses.
- [ ] Fleet Command: dispatch, missions, movement, logistics, ACS operations, espionage, debris recovery, missiles, and expedition setup.
- [ ] War Room: fronts, armies, battle reports, unit classes, weapons, shields, armor, fortifications, special forces, and loss tracking.
- [ ] Research Lab: physics, energy, combat, propulsion, tech tree, requirements, artifacts, reverse engineering, and upgrade effects.
- [ ] Market And Civil Systems: exchange, orders, contracts, trade routes, tariffs, convoys, supply lines, shortages, and storage.
- [ ] Government Council: laws, policies, budgets, governors, leaders, edicts, crisis directives, and civil stability effects.
- [ ] Diplomacy Desk: contacts, relations, pacts, war declarations, claims, sanctions, trust, threat, envoys, and covert pressure.
- [ ] Alliance Command: roster, members, ranks, permissions, applications, circular messages, shared operations, and alliance tech.
- [ ] Character Command: commander stats, classes, skills, talents, equipment, inventory, reputation, guild, social state, and quest links.
- [ ] Campaign Journal: 12 acts, chapter bands, mission arcs, chapter details, rewards, continuity hooks, and completed objectives.
- [ ] System Menu: resume, save, load, settings, music, audio, display, controls, abort mission, surrender, restart, and editor returns.

## Planes And Subplanes

- [ ] Galaxy plane: coordinates, empire borders, hyperlanes, fleets, trade routes, claims, expedition targets, and hostile warnings.
- [ ] Sector plane: sector filters, discovered systems, fog state, resources, anomalies, stations, and NPC activity.
- [ ] System plane: planets, moons, orbitals, fleet slots, jump lanes, sensor pings, and tactical entry points.
- [ ] Planet plane: colony surface, resource buildings, shipyard, defenses, districts, population, production, and stability.
- [ ] Fleet plane: fleet composition, mission target, speed, fuel, cargo, arrival time, recall state, and battle risk.
- [ ] War plane: front status, army groups, battle report summaries, unit losses, doctrines, and reinforcement needs.
- [ ] Research plane: available tech, locked tech, active research, costs, time, prerequisites, unlocks, and upgrade impact.
- [ ] Diplomacy plane: empire dossiers, treaties, trust, threat, war state, claims, sanctions, envoys, and alliance hooks.
- [ ] Character plane: equipment slots, class skills, talents, attributes, inventory, reputation, and quest state.
- [ ] Admin/system subplane: settings forms, save/load browser, music player, controls, debugging, and accessibility options.

## Data Logic

- [ ] Define `OGameMenuState` for active view, selected window, selected page, selected subpage, selected object, and pending action.
- [ ] Define `OGameEmpireState` for resources, colonies, fleets, research, diplomacy, alliance, market, government, and campaign state.
- [ ] Define `OGamePlanetState` for mines, energy, storage, queues, defenses, population, culture, housing, stability, and modifiers.
- [ ] Define `OGameFleetState` for ships, cargo, mission, target, speed, fuel, departure, arrival, return, ACS, and owner.
- [ ] Define `OGameResearchState` for active research, completed technologies, unlocked units, unlocked buildings, and tech bonuses.
- [ ] Define `OGameDiplomacyState` for contacts, pacts, wars, claims, trust, threat, sanctions, envoys, espionage, and messages.
- [ ] Define `OGameCharacterState` for class, level, skills, equipment, inventory, reputation, quests, and social affiliations.
- [ ] Add deterministic serialization for menu state and gameplay state.
- [ ] Add save-game migration hooks for future field additions.

## Gameplay Logic And Functions

- [ ] Resource production: metal, crystal, deuterium, energy, dark matter, storage caps, shortages, upkeep, bonuses, and modifiers.
- [ ] Queue processing: buildings, shipyard, defenses, research, fleet events, admin events, mod events, cancellation, and completion.
- [ ] Fleet dispatch: mission validation, target validation, cargo validation, speed selection, fuel cost, capacity, and ETA.
- [ ] Fleet resolution: attack, ACS attack, transport, deploy, ACS hold, espionage, colonize, recycle, destroy, expedition, and missile.
- [ ] Battle logic: rapidfire, shield recharge, armor damage, hull destruction, debris generation, plunder, moon chance, and reports.
- [ ] Research logic: prerequisites, cost scaling, lab bonuses, unlocks, stat modifiers, queue timing, and conflict rules.
- [ ] Building logic: resource mines, power structures, storage, shipyard, lab, defenses, command buildings, and special structures.
- [ ] Diplomacy logic: treaty proposals, acceptance, cancellation, war declaration, alliance membership, rank permissions, and sanctions.
- [ ] Market logic: buy/sell orders, trade routes, tariffs, convoys, shortages, surpluses, smuggling, and contract fulfillment.
- [ ] Character logic: experience, levels, skill unlocks, equipment effects, reputation gains/losses, quest rewards, and party/guild links.
- [ ] Campaign logic: act unlocks, chapter objectives, mission rewards, continuity hooks, failure states, and briefing text.
- [ ] System settings logic: audio, display, input, hotkeys, save/load, music, restart, surrender, abort, and editor state.

## Stats And Inspectors

- [ ] Empire stats: total production, resource delta, storage fill, colonies, fleets, research level, score, rank, and victory progress.
- [ ] Planet stats: mine output, energy balance, build time, defense power, population, stability, housing, culture, and queue state.
- [ ] Fleet stats: ship count, combat value, cargo capacity, fuel consumption, speed, mission risk, arrival time, and recall state.
- [ ] War stats: active fronts, army strength, losses, battle outcomes, doctrine bonuses, defense coverage, and enemy threat.
- [ ] Research stats: prerequisites, unlocks, cost, duration, active bonuses, level effects, and missing requirements.
- [ ] Diplomacy stats: relation score, trust, threat, pacts, claims, sanctions, wars, envoys, espionage level, and alliance standing.
- [ ] Character stats: health, armor, shields, weapons, skills, talents, class, level, reputation, quest progress, and equipment bonuses.
- [ ] Market stats: price, volume, route safety, convoy capacity, tariff rate, shortages, surpluses, and storage pressure.
- [ ] System stats: FPS/perf links, save age, map metadata, mod version, settings profile, and active hotkey context.

## UI Binding And Interaction

- [ ] Replace static labels in `ingame-menu.yaml` with reusable row templates and data-bound text.
- [ ] Add button widgets for top tabs and rail rows with selected/hover/disabled states.
- [ ] Add scroll panels for long submenus, long reports, long tech trees, and long inventory lists.
- [ ] Add tooltips for every menu action, stat row, warning, disabled action, and resource icon.
- [ ] Add confirmation flows for destructive actions: cancel queue, recall fleet, surrender, restart, abort mission, and delete save.
- [ ] Add notification hooks for queue complete, fleet arrival, attack warning, diplomacy proposal, alliance message, and quest update.
- [ ] Add keyboard/gamepad navigation across frames, pages, rows, inspector actions, and modal buttons.
- [ ] Add accessibility hooks for contrast, text scale, reduced animation, and tooltip delay.

## Tests And Validation

- [ ] Unit-test menu catalog ID uniqueness and page/subpage link validity.
- [ ] Unit-test resource production, storage caps, energy shortages, and queue costs.
- [ ] Unit-test fleet dispatch validation, fuel cost, cargo capacity, ETA, and mission availability.
- [ ] Unit-test battle reports, plunder, debris, rapidfire, shield recharge, and hull destruction.
- [ ] Unit-test research prerequisites, unlocks, bonuses, and queue timing.
- [ ] Unit-test diplomacy treaty state, war state, alliance ranks, and message routing.
- [ ] Lint-test Fluent labels and chrome references for all menu widgets.
- [ ] Save/load-test all new state containers.
- [ ] Manual-test Red Sector title screen, loading bar, in-game pause menu, settings, save/load, and music flows.

## Implementation Order

1. Lock the catalog schema and IDs.
2. Add runtime state containers and serialization.
3. Bind the existing in-game menu to selectable tabs and rails.
4. Implement Empire, Planet, Fleet, Research, and System Menu first.
5. Implement War, Diplomacy, Alliance, Market, Character, and Campaign next.
6. Add stats inspectors and notification hooks.
7. Add save/load migration and tests.
8. Replace placeholder labels with full interactive pages.
