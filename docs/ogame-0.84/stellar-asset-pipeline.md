# Stellar Asset Pipeline

This document defines the original space RTS/4X asset direction for **UniversCivilization: Empire at War**. It uses OGame-era blue command-table language as inspiration, but all assets must be original.

## Legal Boundary

- Do not copy proprietary browser-game, RTS, 4X, film, or licensed ships, buildings, UI art, icons, sounds, sprites, models, or extracted files.
- Use the existing compatibility content only for testing of the current mods.
- New UniversCivilization gameplay assets live under `mods/stellar/assets` and docs references under `docs/ogame-0.84/assets`.

## Asset Families

| Family | Examples | Primary Format | Runtime Use |
|---|---|---|---|
| Starships | Probe, fighter, cruiser, colony ark, dreadnought | `.glb` plus rendered `.png` previews | 3D fleet views, build cards, combat reports |
| Ground units | Engineer, marine, shield guard, drone | sprite sheets and optional `.glb` | RTS maps and tactical landings |
| Buildings | Command nexus, extractors, shipyard, research spire | isometric sprite sheets and optional `.glb` | Colony surfaces, construction UI, strategic panels |
| Weapons | Rail lance, plasma torpedo, ion beam | icons plus VFX sheets | Tooltips, combat, upgrades |
| Armor | Composite hull, ceramic, void lattice | icons and material presets | Research, unit stats, equipment |
| Defenses | Laser battery, missile silo, shield dome | isometric sprites / `.glb` | Colony defense and battle simulation |
| Planets | Terran, ice, volcanic, barren, gas giant | sphere materials and icon renders | Galaxy, empire overview, colonization |
| Resources | Metal, crystal, deuterium, energy, dark matter | UI icons | Economy bars and tooltips |
| VFX | Warp entry, shield hit, plasma bloom, debris | sprite sheets / particles | Combat and fleet movement |
| Interface | Buttons, panels, windows, radar, tab icons | PNG/SVG atlas | OGame-style command UI |

## Directory Layout

```text
mods/stellar/assets/
  icons/
    armor/
    buildings/
    resources/
    starships/
    units/
    weapons/
  models/
    buildings/
    planets/
    starships/
    units/
  sprites/
    buildings/
    units/
  renders/
    buildings/
    planets/
    starships/
  ui/
  vfx/
    combat/
    space/
```

## Naming Rules

- Use lowercase kebab-case IDs: `ship-light-fighter`, `building-command-nexus`.
- Keep asset paths stable after a gameplay actor references them.
- Use suffixes for variants: `-icon`, `-diffuse`, `-normal`, `-emissive`, `-wreck`, `-damaged`, `-shadow`.
- Keep source art separate from runtime exports when source files exist.

## 2D Rendering Targets

| Target | Size | Notes |
|---|---:|---|
| UI icon | `64x64`, `128x128` | Strong silhouette, no tiny text |
| Build card | `256x160` | Three-quarter render, dark transparent-safe backing |
| Infantry sprite | `32x32` to `64x64` per frame | 8 facings, idle/move/fire/death |
| Vehicle/building sprite | `96x96` to `256x256` per frame | Isometric or top-down depending map layer |
| VFX frame | `64x64` to `256x256` | Additive-friendly bloom, alpha-safe edges |
| UI atlas | power-of-two atlas | Pack related controls and nine-slice panels |

## 3D Rendering Targets

| Target | Format | Notes |
|---|---|---|
| Runtime model | `.glb` | PBR materials, compressed textures where supported |
| Preview render | `.png` | Used in encyclopedia, shipyard, reports |
| Planet material | `.png` maps | Albedo, normal, emission/city lights |
| Starship material | `.png` maps | Dark metal, blue emission, faction accent masks |

Recommended model budgets:

| Class | Triangle Budget | Texture Budget |
|---|---:|---:|
| Small ship / drone | 500-2,000 | `512x512` |
| Cruiser / building | 2,000-8,000 | `1024x1024` |
| Capital ship / orbital | 8,000-25,000 | `2048x2048` |
| Planet | 2,000-10,000 sphere | `2048x2048` or procedural |

## Engine Integration Plan

1. **Current OpenRA path:** keep 2D sprite sheets and YAML actors for compatibility.
2. **Hybrid asset path:** use generated or rendered 3D previews in UI while RTS maps still use sprite sheets.
3. **3D renderer path:** add a `RenderDevice` abstraction, then bind SDL3/Vulkan or a future Three.js-style preview exporter outside runtime.
4. **Model-backed actors:** add render traits that can choose sprite fallback or 3D mesh representation by platform capability.
5. **Asset validation:** add checks for missing icons, model previews, path naming, and atlas size.

## Original Visual Direction

- Deep space background: `#040e1e`.
- OGame-like panels: `#344566` with `#415680` frame lines.
- Holographic selections: `#6DA8FF`.
- Friendly/ready state: `#00FF00`.
- High-value objectives: `#FFD25A`.
- Hostile/critical state: `#FF4A4A`.
- Shapes: orbital rings, command crowns, angular chevrons, lattice shields, fleet silhouettes, planet crescents.

## Concept Reference

Use `assets/stellar/stellar-asset-concept-sheet.png` as the first original art direction sheet for the complete asset family.
