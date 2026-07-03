<div align="center">

# OpenRA

![Epic Blue](https://img.shields.io/badge/OGame_0.84_Epic_Blue-040e1e?style=for-the-badge)
![Panel](https://img.shields.io/badge/Panel-344566?style=for-the-badge)
![Text](https://img.shields.io/badge/Text-E6EBFB?style=for-the-badge)
![Command](https://img.shields.io/badge/Command_Lime-00ff00?style=for-the-badge)

**A libre real-time strategy game engine for recreating and reimagining classic Westwood-style RTS games.**

</div>

---

## Mission Briefing

OpenRA ships with playable mods inspired by:

| Mod | Status |
|---|---|
| Command & Conquer: Red Alert | ![Available](https://img.shields.io/badge/available-lime?style=flat-square) |
| Command & Conquer: Tiberian Dawn | ![Available](https://img.shields.io/badge/available-lime?style=flat-square) |
| Dune 2000 | ![Available](https://img.shields.io/badge/available-lime?style=flat-square) |

> EA has not endorsed and does not support this project.

## Command Console

| Channel | Link |
|---|---|
| Website | [openra.net](https://www.openra.net) |
| Repository | [github.com/OpenRA/OpenRA](https://github.com/OpenRA/OpenRA) |
| Wiki and FAQ | [OpenRA Wiki](https://github.com/OpenRA/OpenRA/wiki) |
| Issues | [OpenRA Issues](https://github.com/OpenRA/OpenRA/issues) |
| Forum | [forum.openra.net](https://forum.openra.net/) |
| Chat | [Libera IRC](ircs://irc.libera.chat:6697/openra), [web chat](https://web.libera.chat/#openra), [Discord](https://discord.openra.net) |

## Fleet Orders

![Play](https://img.shields.io/badge/play-E6EBFB?labelColor=344566)
![Server](https://img.shields.io/badge/dedicated_server-80a0c0?labelColor=344566)

Use the [Playing the Game](https://github.com/OpenRA/OpenRA/wiki/Playing-the-game) guide for controls, strategy, and multiplayer help.

You can also run your own [dedicated server](https://github.com/OpenRA/OpenRA/wiki/Dedicated-Server).

## Shipyard and Research

![Build](https://img.shields.io/badge/build-lime?labelColor=344566)
![Contribute](https://img.shields.io/badge/contribute-gold?labelColor=344566)
![Review](https://img.shields.io/badge/review-orange?labelColor=344566)

Start with [INSTALL.md](INSTALL.md), then read the [Compiling](https://github.com/OpenRA/OpenRA/wiki/Compiling) guide for platform-specific setup.

Before submitting patches:

- Read [CONTRIBUTING.md](CONTRIBUTING.md).
- Follow the [Code of Conduct](CODE_OF_CONDUCT.md).
- Review the older [Hacking](https://github.com/OpenRA/OpenRA/wiki/Hacking) overview for engine context.

## Navigation Grid

### Mapping

Custom maps can significantly change gameplay through scripts and rules.

- Mapping guide: [Mapping](https://github.com/OpenRA/OpenRA/wiki/Mapping)
- Mission scripting: [Lua API](https://docs.openra.net/en/release/lua/)
- Map sharing: [OpenRA Resource Center](https://resource.openra.net)

### Modding

OpenRA is built around data-driven mods and reusable engine traits.

- Mod SDK: [OpenRA Mod SDK](https://github.com/OpenRA/OpenRAModSDK)
- Modding guide: [Modding Guide](https://github.com/OpenRA/OpenRA/wiki/Modding-Guide)
- Trait reference: [Trait documentation](https://docs.openra.net/en/latest/release/traits/)
- Pixel art notes: [Pixelart](https://github.com/OpenRA/OpenRA/wiki/Pixelart)
- Mod sharing: [OpenRA on Mod DB](https://www.moddb.com/games/openra/mods)

## OGame 0.84 Reference Sector

![Reference](https://img.shields.io/badge/reference-80a0c0?labelColor=040e1e)
![UML](https://img.shields.io/badge/UML-E6EBFB?labelColor=344566)
![Scaffold](https://img.shields.io/badge/CSharp_scaffold-lime?labelColor=344566)
![Campaign](https://img.shields.io/badge/12_acts_600_chapters-gold?labelColor=344566)

This checkout includes local design-reference material using the OGame 0.84 Epic Blue style and color language.

- [OGame 0.84 reference documentation](docs/ogame-0.84/README.md): features, game logic, UML diagrams, source indexes, and a Stellar RTS/4X/MMORPG campaign blueprint derived from `ogamespec/ogame-opensource`.
- [Implementation scaffold](docs/ogame-0.84/implementation-scaffold.md): compiled C# files for feature catalogs, economy, queues, fleet logic, battle logic, campaign generation, and UI state modeling.
- [In-game UI redesign pass](docs/ogame-0.84/ingame-ui-redesign.md): Red Alert HUD and shared menu chrome styled toward Stellaris, OGame, RTS/4X, and MMORPG command systems.
- [Stellaris/OGame menu taxonomy](docs/ogame-0.84/stellaris-menu-taxonomy.md): categories, submenus, pages, subpages, and window-frame layout regions for the strategy UI shell.
- [UML diagrams](docs/ogame-0.84/uml.md): request flow, queue flow, battle flow, campaign model, system taxonomy, and hybrid UI state machine.

These reference documents are not executable OpenRA gameplay. They are planning material for future design or porting work.

## Color Signals

| Signal | OGame-style Color | Usage |
|---|---|---|
| Primary background | `#040e1e` | Deep space / page backdrop |
| Panel background | `#344566` | OGame table and control panels |
| Panel border | `#415680` | OGame frame lines |
| Primary text | `#E6EBFB` | Pale blue-white interface text |
| Friendly / owned | `lime` | Own fleets, safe status, ready actions |
| Federation / alliance | `#33CC00` | ACS/federation style status |
| Hold / neutral | `#80a0C0` | Hold missions and neutral tactical state |
| Espionage / missile | `orange` | Spy, missile, warning action |
| Destruction / critical | `gold` | Destroy missions or high-value alerts |
| Hostile attack | `red` | Enemy attack and danger state |

## Support

The project relies on community infrastructure. If you have bandwidth available, consider sponsoring a [mirror server](https://github.com/OpenRA/OpenRAWebsiteV3/tree/master/packages).

## License

Copyright (c) OpenRA Developers and Contributors.

OpenRA is free software, made available under the GNU General Public License as published by the Free Software Foundation, either version 3 of the License or, at your option, any later version.

See [COPYING](COPYING) for the full license text.

## Sponsors

Free Windows code signing is provided by [SignPath.io](https://about.signpath.io/) with a certificate from the [SignPath Foundation](https://signpath.org/).
