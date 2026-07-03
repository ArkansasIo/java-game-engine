# UniversCivilization: Empire at War - Architecture and Arklight Engine Integration

This document outlines the architecture for *UniversCivilization: Empire at War*, utilizing the Arklight Game Engine. It transitions from legacy OGame 0.84 logic into a modern, data-driven, scalable architecture suited for a Sci-Fi Space Universe Conquest game.


## Architecture Strategy

*UniversCivilization* is built on the Arklight Game Engine. Unlike the legacy PHP OGame architecture, which relied on synchronous page-load processing, *UniversCivilization* adopts a service-oriented approach:

- **Engine Core (Arklight):** Handles low-level rendering, networking, physics, and input.
- **Game Logic Layer (C# / Data-Driven):** Implements RTS/4X systems (resource production, combat simulation, queue management) as high-performance services.
- **Data Model:** Planets, fleets, and players are defined by modular, extensible Arklight traits.
- **UI System:** A modern, reactive UI (reminiscent of Stellaris/OGame) running atop the engine, interacting with the Game Logic Layer via a clean API.
- **Multiplayer/MMORPG:** Servers manage authoritative state, synchronization, and persistent universe events.


## Features and Core Systems

- **Dynamic Universe:** Persistent, evolving galaxy map with hyperlanes, anomalies, and trade routes.
- **RTS/4X Simulation:** Seamless transition from deep-space strategy to tactical planet-level control.
- **Combat Simulation:** High-performance battle engine handling large-scale fleet engagements, orbital bombardment, and planetary defense.
- **Economy:** Complex resource management involving extraction, refinement, trade, and industrial scaling.
- **Social/MMORPG:** Persistent guild/faction systems, player-driven economy, diplomacy, and galactic-scale meta-events.
- **Moddable Architecture:** Designed with the Arklight Mod SDK for deep-level extension of game rules, units, and UI elements.


## Main Runtime Flow

1. Browser requests `game/index.php?page=<route>&session=<session>`.
2. Configuration and core includes load.
3. `InitDB()` connects to MySQL and `LoadUniverse()` loads universe settings.
4. Request parameters are validated by `CheckParams()`.
5. `AuthUser()` loads the current player for session pages.
6. `ModsInit()` loads enabled mods and `ModsExecRef('route', ...)` allows route injection.
7. The router loads required localization packs.
8. For authenticated non-external pages, `UpdateQueue(time())`, `GetUpdatePlanet()`, `UpdatePlanetActivity()`, and `UpdateLastClick()` synchronize delayed game state.
9. The route either instantiates a `Page` subclass and calls `controller()`/`view()`, or includes an old-style page PHP file.
10. Page helpers render header, content, resources, left menu, errors, and footer.

## Game Logic Domains

- Account and session: `core/user.php`, registration pages, validation, password checks, premium/officers, vacation mode, bans, and activity updates.
- Universe and localization: `core/uni.php`, `core/loca.php`, `game/loca` language packs, and route-level locale loading.
- Planets and economy: `core/planet.php`, `core/prod.php`, resources page, buildings page, tech tree pages, and queue events.
- Queue: `core/queue.php` stores delayed operations in the database and processes due rows on page requests or CRON.
- Fleet: `core/fleet.php`, fleet pages, overview/phalanx event renderers, ACS helper functions in `core/acs.php`, and missile/expedition/battle hooks.
- Combat: `core/battle.php` prepares/post-processes battles while `core/battle_engine.php` simulates OGame-style rounds and rapidfire.
- Social: `core/ally.php`, `core/allyapps.php`, `core/allyranks.php`, buddy/messages/notes pages.
- Administration: `pages_admin` tools for users, planets, queues, logs, localization, universe setup, simulation, bots, bans, coupons, and DB/debug pages.
- Mods: `GameMod` hooks let extensions add routes, tabs, menu items, queue behavior, production/fleet/battle bonuses, object images, and custom mission handling.

## Porting and Development Notes

Legacy PHP/OGame logic serves as a functional specification for game rules. Implementation in *UniversCivilization* follows these principles:

- **Modular Domain Models:** Planets, fleets, and players exist as distinct Arklight actors with data-driven components (traits).
- **Scheduled Simulation:** Deterministic events (construction, fleet arrival) utilize a robust, tick-based scheduler rather than request-driven updates.
- **Service-Oriented Engine:** Combat, economy, and diplomacy are architected as decoupled services.
- **Modern UI Shell:** Replaces browser-based controller logic with high-fidelity, data-bound widgets.
- **Extension Surface:** Mods integrate directly with the engine through defined API hooks for rules, assets, and UI behaviors.


