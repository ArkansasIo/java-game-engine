# OGame 0.84 Implementation Scaffold

This repository now contains a compile-time C# scaffold for the OGame 0.84 feature, function, and game-logic model under:

- `OpenRA.Mods.Common/OGame084/OGameTypes.cs`
- `OpenRA.Mods.Common/OGame084/OGameCatalog.cs`
- `OpenRA.Mods.Common/OGame084/OGameEconomy.cs`
- `OpenRA.Mods.Common/OGame084/OGameFleet.cs`
- `OpenRA.Mods.Common/OGame084/OGameBattle.cs`
- `OpenRA.Mods.Common/OGame084/OGameCampaign.cs`
- `OpenRA.Mods.Common/OGame084/OGameInterfaceModel.cs`

## What Is Included

- Feature catalog for OGame 0.84 systems and source modules.
- 35 required chapter/detail elements.
- 90 world-system classes across weapons, shields, armor, units, military systems, civil systems, government systems, and buildings.
- Economy and production calculations for mines, deuterium, energy, storage projection, and building costs.
- Queue item model and due-item processor.
- Fleet coordinate, mission, distance, timing, fuel, and mission-availability logic.
- Deterministic battle simulator scaffold covering attack, shields, hull, up to six rounds, outcomes, and debris estimate.
- 12-act, 600-chapter campaign model generator.
- Hybrid Stellaris-style RTS/4X/MMORPG UI view and transition model.

## What Is Not Included Yet

- No OpenRA actor traits, widgets, commands, map rules, or YAML integration have been wired to these classes.
- No PHP runtime code from `ogamespec/ogame-opensource` has been embedded.
- No database persistence layer has been added.
- The battle simulator is a deterministic scaffold, not a byte-for-byte clone of the PHP/C battle engine.

## Integration Path

1. Add tests around the scaffold values and formulas.
2. Decide whether the OGame layer should be an OpenRA mod, a standalone rules service, or a separate game mode.
3. Add YAML/rules bindings for resources, ships, buildings, researches, missions, and UI pages.
4. Add widgets for galaxy/system/planet/commander/economy/government/war-room views.
5. Replace scaffold formulas with exact parity ports where needed.
6. Wire battle/fleet/queue state into deterministic simulation ticks if multiplayer synchronization is required.
