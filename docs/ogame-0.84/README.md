# OGame 0.84 Reference Documentation

This folder documents the external PHP project [`ogamespec/ogame-opensource`](https://github.com/ogamespec/ogame-opensource), described by that project as a revived OGame v0.84 implementation. It is added as a reference package inside this repository; it does not port the PHP browser-game logic into Arklight's C# RTS engine.

Generated from local clone path: `.external/ogame-opensource`.

## Files

- [Architecture](architecture.md): feature map, runtime flow, and major systems.
- [UML](uml.md): Mermaid diagrams for game logic, pages, mods, queue, battle, fleet, economy, and persistence.
- [UniversCivilization Campaign Bible](universcivilization-campaign.md): 12-act `Empire at War` story redesign with chapter bands, factions, missions, fleets, weapons, colonies, and endgame escalation.
- [Empire Creation Systems](empire-creation-systems.md): account creation, 10 races, 10 governments, origins, DLC/expansion packs, patch/info log, and 8-player online multiplayer design.
- [Arklight Renaming Map](arklight-renaming-map.md): visible-name replacement plan for old RTS franchise names while preserving internal compatibility IDs.
- [Stellar RTS/4X/MMORPG Blueprint](stellar-rts-4x-design.md): fictional 12-act, 600-chapter campaign framework with 35 chapter detail elements, 90 system classes, and hybrid strategy/MMORPG UI pillars.
- [In-Game UI Redesign Pass](ingame-ui-redesign.md): Arklight tactical HUD and shared in-game menu chrome updated toward Stellaris/OGame/RTS-4X/MMORPG styling.
- [Stellaris/OGame Menu Taxonomy](stellaris-menu-taxonomy.md): top categories, submenus, pages, subpages, and reusable window-frame regions for the strategy UI shell.
- [Brand Assets](assets/brand/README.md): UniversCivilization key art, SVG emblem, SVG wordmark, and OGame-style sci-fi palette tokens.
- [Stellar Asset Pipeline](stellar-asset-pipeline.md): original unit, starship, building, weapon, armor, planet, VFX, UI, 2D, and 3D asset production plan.
- [Stellar Asset Manifest](stellar-asset-manifest.yaml): canonical IDs and target paths for the original space asset pack.
- [Implementation Scaffold](implementation-scaffold.md): C# files added under `Arklight.Mods.Common/OGame084` for feature catalogs, economy, queues, fleet logic, battle logic, campaign generation, and UI state modeling.
- [All Classes UML](all-classes.md): generated Mermaid class diagram and class source table for every PHP class under `game/`.
- [Source Index](source-index.md): all source files under `game/` with extracted PHP classes/functions where possible.

## Feature Coverage

- Original OGame 0.84 browser-game mechanics and old visual design.
- Fast battle engine with rapidfire, shield recharge, hull destruction, debris, plunder, moon chance, and defense repair.
- CRON-less queue processing with optional CRON support.
- Fleet dispatch, return, ACS attack/hold, transport, deploy, espionage, colonize, recycle, destroy, expedition, and missile handling.
- Planet economy with metal/crystal/deuterium production, storage, energy, officers, bonuses, planet temperature, images, and size logic.
- Buildings, shipyard, defenses, research, tech tree, resources, overview, galaxy, phalanx, messages, notes, buddy, statistics, trader, and admin pages.
- Alliance creation, ranks, applications, ownership transfer, member list, and statistics.
- Multilingual localization through loca packs and route-level locale loading.
- Modification engine with `GameMod` hooks plus bundled `BogusMod`, `GalaxyTool`, `SpaceStorm`, and `DeepSpaceHorror` examples.
- Integrated admin tools for users, planets, queues, logs, universe settings, localization, simulations, bans, coupons, bots, database, and debugging.

## Scope Note

The source is a PHP/MySQL browser game with procedural modules and page controllers. Arklight is a C# real-time strategy engine with trait-driven actors. Treat these docs as design input for a future port, not as executable Arklight gameplay.

