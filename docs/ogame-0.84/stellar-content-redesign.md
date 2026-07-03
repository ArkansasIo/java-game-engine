# Stellar Managed Content Redesign

The legacy managed content flow installs required files into support-directory `Content/...` folders. UniversCivilization now has its own managed-content clone in `mods/stellar-content` and its own original asset workspace in `mods/stellar/assets`.

This redesign keeps compatibility content isolated. It does not copy legacy archives or licensed art. It maps every install-content category into original OGame-style sci-fi MMORPG/4X asset groups:

| Legacy content need | UniversCivilization replacement |
|---|---|
| Common content chrome | Blue command UI, content panels, resource strip, cursors, notification frames |
| Base files | Core shell art, faction-neutral interface, colony command assets |
| Tilesets | Orbital, asteroid, ice, lava, nebula, moon, and colony-surface sets |
| Music | Command ambience, fleet dispatch, diplomacy, market, war, exploration, and campaign themes |
| Speech and notifications | Original commander, fleet, research, diplomacy, market, and alert voice packs |
| Campaign movies | 12-act briefing art, chapter event panels, faction intro screens, loading art |
| Expansion packs | Late-game anomalies, dreadnought war, alliance operations, expedition events, endgame crises |

## Added Content Folders

- `mods/stellar-content`: managed-content clone for original UniversCivilization packages.
- `mods/stellar/assets`: runtime asset target for UI, sprites, icons, models, renders, VFX, and generated concept sheets.
- `mods/stellar/assets/original-content-map.yaml`: package-to-asset redesign map.
- `mods/stellar/assets/renders/concept/ogame-scifi-4x-asset-sheet.png`: generated concept sheet for the first visual pass.

## Asset Direction

- UI uses deep navy backgrounds, blue panel frames, pale command text, lime ready states, gold warnings, and red hostile alerts.
- Buildings read as colony infrastructure first: command nexus, resource mines, storage, labs, shipyards, defenses, housing, culture, and stability structures.
- Fleets follow 4X silhouettes: probes, fighters, cruisers, colony arks, recyclers, transports, bombers, destroyers, dreadnoughts, and expedition craft.
- MMORPG systems are represented through commanders, classes, skills, equipment, reputation, guild/alliance identity, and quest-state icons.
- VFX covers warp entry, shield hits, rail impacts, ion beams, plasma torpedoes, missiles, debris fields, sensor pings, and resource collection.

## Next Production Steps

- Replace concept-sheet placeholders with final sprite sheets and model files.
- Register a playable `stellar` mod once rules, sequences, chrome includes, and maps are ready.
- Add lints for missing package paths, missing icon files, invalid manifest IDs, and mismatched catalog entries.
