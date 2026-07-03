# OGame 0.84 Architecture and Game Logic

## Source Shape

- `game/index.php` is the main request entrypoint. It loads configuration, initializes core systems, authenticates sessions, updates queues and active planet state, then routes to old-style includes or MVC-style `Page` classes.
- `game/core/core.php` acts as the central include hub for database, users, planets, production, queue, fleet, battle, pages, localization, mods, and utility functions.
- `game/router.json` maps page keys to PHP files, locale packs, menu/header behavior, and MVC mode.
- `game/core/page.php` defines page rendering helpers and the base `Page` class used by newer pages.
- `game/core/mods.php` defines `GameMod`, the hook surface used by bundled mods under `game/mods`.
- `game/core/queue.php` is the central deferred event processor for construction, shipyard, research, bans, cleanup, stats, bots, coupons, and custom mod queue rows.
- `game/core/fleet.php` handles fleet validation, mission availability, dispatch, timing, queue completion, mission execution, and fleet logs.
- `game/core/battle.php`, `game/core/battle_engine.php`, and the C engine in `game/battle` cover battle setup, simulation, report data, plunder, debris, moon creation, and result writeback.
- `game/core/prod.php` calculates resource production, energy, officer/mod bonuses, storage, build prices, times, and fleet prices.
- `game/pages` and `game/pages_admin` provide user and admin screens around the core functions.

## Features and Functions

- Original OGame 0.84 mechanics and old browser UI.
- Fast battle engine with fair rapidfire plus PHP backup logic.
- Event queue that can run from normal page traffic or CRON.
- Fleet missions: attack, ACS attack, transport, deploy, ACS hold, espionage, colonize, recycle, destroy, expedition, and missiles.
- Economy: production, storage, energy, officers, planet temperature, planet size, building/research/shipyard timings, and mod bonuses.
- Social systems: alliances, ranks, applications, buddies, messages, notes, and statistics.
- Admin systems: users, planets, queues, logs, universe settings, localization, battle simulation, bots, bans, coupons, database, and debugging.
- Mods: extension hooks for routes, tabs, menu items, queues, production, fleet, battle, images, and custom missions.

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

## Porting Notes for OpenRA

A direct implementation would be a rewrite, not a copy. The useful boundaries for a future OpenRA-side port are:

- Model OGame planets/fleets/resources as a separate rules/domain module instead of OpenRA actors.
- Convert queue rows to deterministic scheduled commands if multiplayer synchronization matters.
- Keep combat as a service-style simulator with deterministic seeded random input.
- Replace PHP page controllers with OpenRA widgets or an external web UI.
- Treat mods as data/hook plugins only after defining an OpenRA-safe extension surface.
