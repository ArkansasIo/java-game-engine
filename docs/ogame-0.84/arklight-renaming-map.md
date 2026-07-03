# Arklight Renaming Map

This pass replaces visible legacy RTS names with original UniversCivilization sector names while keeping internal mod IDs stable enough for the current engine, maps, installers, and compatibility content to keep working.

| Legacy visible reference | Arklight / UniversCivilization name | Internal compatibility ID |
|---|---|---|
| Command & Conquer: Red Alert | Arklight: Red Sector | `ra` |
| Command & Conquer: Tiberian Dawn | Arklight: Dawn Sector | `cnc` |
| Dune 2000 | Arklight: Desert Sector | `d2k` |
| Allied campaign | Solar Union campaign | `allies` packages remain compatibility content |
| Soviet campaign | Red Sector campaign | `soviet` packages remain compatibility content |
| GDI campaign | Dawn Concord campaign | `gdi` packages remain compatibility content |
| Nod campaign | Eclipse Order campaign | `nod` packages remain compatibility content |
| C&C desert tileset | Desert Sector tileset | archive filenames remain unchanged |

## Compatibility Rules

- User-facing titles, menus, docs, and campaign language should use Arklight names.
- Folder names such as `ra`, `cnc`, and `d2k` remain engine IDs until a deeper mod migration updates every map, package path, content installer, rules include, and saved-game reference.
- Download URLs, archive names, and installer YAML package paths remain compatibility references when they must match real external file layouts.
- New UniversCivilization assets must be original. Do not copy OGame, legacy RTS, or other proprietary art, sprites, sounds, models, icons, logos, or UI frames.
