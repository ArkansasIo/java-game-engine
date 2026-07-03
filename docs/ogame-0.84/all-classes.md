# OGame 0.84 All Classes UML

Generated from every PHP file under `game/`. This diagram captures class declarations and inheritance only; procedural functions are indexed in [Source Index](source-index.md).

## Class Diagram

```mermaid
classDiagram
  class Admin_Bans
  Page <|-- Admin_Bans
  class Admin_BattleReport
  Page <|-- Admin_BattleReport
  class Admin_BattleSim
  Page <|-- Admin_BattleSim
  class Admin_Botedit
  Page <|-- Admin_Botedit
  class Admin_Bots
  Page <|-- Admin_Bots
  class Admin_Broadcast
  Page <|-- Admin_Broadcast
  class Admin_Browse
  Page <|-- Admin_Browse
  class Admin_Checksum
  Page <|-- Admin_Checksum
  class Admin_ColonySettings
  Page <|-- Admin_ColonySettings
  class Admin_Coupons
  Page <|-- Admin_Coupons
  class Admin_DB
  Page <|-- Admin_DB
  class Admin_Debug
  Page <|-- Admin_Debug
  class Admin_Errors
  Page <|-- Admin_Errors
  class Admin_Expedition
  Page <|-- Admin_Expedition
  class Admin_Fleetlogs
  Page <|-- Admin_Fleetlogs
  class Admin_GalaxyTool
  Page <|-- Admin_GalaxyTool
  class Admin_Home
  Page <|-- Admin_Home
  class Admin_Loca
  Page <|-- Admin_Loca
  class Admin_Logins
  Page <|-- Admin_Logins
  class Admin_Mods
  Page <|-- Admin_Mods
  class Admin_Planets
  Page <|-- Admin_Planets
  class Admin_Queue
  Page <|-- Admin_Queue
  class Admin_Raksim
  Page <|-- Admin_Raksim
  class Admin_Reports
  Page <|-- Admin_Reports
  class Admin_Uni
  Page <|-- Admin_Uni
  class Admin_Userlogs
  Page <|-- Admin_Userlogs
  class Admin_Users
  Page <|-- Admin_Users
  class B_Building
  Page <|-- B_Building
  class bb_a
  bbcode <|-- bb_a
  class bb_align
  bbcode <|-- bb_align
  class bb_color
  bbcode <|-- bb_color
  class bb_del
  bbcode <|-- bb_del
  class bb_email
  bbcode <|-- bb_email
  class bb_font
  bbcode <|-- bb_font
  class bb_hr
  bbcode <|-- bb_hr
  class bb_i
  bbcode <|-- bb_i
  class bb_img
  bbcode <|-- bb_img
  class bb_quote
  bbcode <|-- bb_quote
  class bb_size
  bbcode <|-- bb_size
  class bb_strong
  bbcode <|-- bb_strong
  class bb_sub
  bbcode <|-- bb_sub
  class bb_sup
  bbcode <|-- bb_sup
  class bb_u
  bbcode <|-- bb_u
  class bbcode
  class BogusMod
  GameMod <|-- BogusMod
  class Buildings
  Page <|-- Buildings
  class DeepSpaceHorror
  GameMod <|-- DeepSpaceHorror
  class GalaxyTool
  GameMod <|-- GalaxyTool
  class GameMod
    <<abstract>>
  class Notizen
  Page <|-- Notizen
  class Overview
  Page <|-- Overview
  class Page
    <<abstract>>
  class Resources
  Page <|-- Resources
  class SpaceStorm
  GameMod <|-- SpaceStorm
  class Techtree
  Page <|-- Techtree
  class Techtreedetails
  Page <|-- Techtreedetails
```

## Class Sources

| Class | Extends | Source |
|---|---|---|
| `bbcode` | `` | `game/core/bbcode.php:10` |
| `bb_a` | `bbcode` | `game/core/bbcode.php:884` |
| `bb_align` | `bbcode` | `game/core/bbcode.php:953` |
| `bb_color` | `bbcode` | `game/core/bbcode.php:984` |
| `bb_del` | `bbcode` | `game/core/bbcode.php:1002` |
| `bb_email` | `bbcode` | `game/core/bbcode.php:1018` |
| `bb_font` | `bbcode` | `game/core/bbcode.php:1056` |
| `bb_hr` | `bbcode` | `game/core/bbcode.php:1078` |
| `bb_i` | `bbcode` | `game/core/bbcode.php:1089` |
| `bb_img` | `bbcode` | `game/core/bbcode.php:1105` |
| `bb_quote` | `bbcode` | `game/core/bbcode.php:1138` |
| `bb_size` | `bbcode` | `game/core/bbcode.php:1151` |
| `bb_strong` | `bbcode` | `game/core/bbcode.php:1185` |
| `bb_sub` | `bbcode` | `game/core/bbcode.php:1201` |
| `bb_sup` | `bbcode` | `game/core/bbcode.php:1217` |
| `bb_u` | `bbcode` | `game/core/bbcode.php:1233` |
| `GameMod` | `` | `game/core/mods.php:8` |
| `Page` | `` | `game/core/page.php:717` |
| `BogusMod` | `GameMod` | `game/mods/BogusMod/main.php:9` |
| `DeepSpaceHorror` | `GameMod` | `game/mods/DeepSpaceHorror/main.php:24` |
| `GalaxyTool` | `GameMod` | `game/mods/GalaxyTool/main.php:11` |
| `Admin_GalaxyTool` | `Page` | `game/mods/GalaxyTool/pages_admin/admin_galaxytool.php:3` |
| `SpaceStorm` | `GameMod` | `game/mods/SpaceStorm/main.php:33` |
| `B_Building` | `Page` | `game/pages/b_building.php:5` |
| `Buildings` | `Page` | `game/pages/buildings.php:5` |
| `Notizen` | `Page` | `game/pages/notizen.php:8` |
| `Overview` | `Page` | `game/pages/overview.php:9` |
| `Resources` | `Page` | `game/pages/resources.php:5` |
| `Techtree` | `Page` | `game/pages/techtree.php:5` |
| `Techtreedetails` | `Page` | `game/pages/techtreedetails.php:5` |
| `Admin_Bans` | `Page` | `game/pages_admin/admin_bans.php:5` |
| `Admin_BattleReport` | `Page` | `game/pages_admin/admin_battle.php:6` |
| `Admin_Botedit` | `Page` | `game/pages_admin/admin_botedit.php:5` |
| `Admin_Bots` | `Page` | `game/pages_admin/admin_bots.php:5` |
| `Admin_Broadcast` | `Page` | `game/pages_admin/admin_broadcast.php:5` |
| `Admin_Browse` | `Page` | `game/pages_admin/admin_browse.php:5` |
| `Admin_Checksum` | `Page` | `game/pages_admin/admin_checksum.php:5` |
| `Admin_ColonySettings` | `Page` | `game/pages_admin/admin_colony_settings.php:5` |
| `Admin_Coupons` | `Page` | `game/pages_admin/admin_coupons.php:5` |
| `Admin_DB` | `Page` | `game/pages_admin/admin_db.php:11` |
| `Admin_Debug` | `Page` | `game/pages_admin/admin_debug.php:5` |
| `Admin_Errors` | `Page` | `game/pages_admin/admin_errors.php:6` |
| `Admin_Expedition` | `Page` | `game/pages_admin/admin_expedition.php:5` |
| `Admin_Fleetlogs` | `Page` | `game/pages_admin/admin_fleetlogs.php:5` |
| `Admin_Home` | `Page` | `game/pages_admin/admin_home.php:5` |
| `Admin_Loca` | `Page` | `game/pages_admin/admin_loca.php:5` |
| `Admin_Logins` | `Page` | `game/pages_admin/admin_logins.php:5` |
| `Admin_Mods` | `Page` | `game/pages_admin/admin_mods.php:5` |
| `Admin_Planets` | `Page` | `game/pages_admin/admin_planets.php:5` |
| `Admin_Queue` | `Page` | `game/pages_admin/admin_queue.php:5` |
| `Admin_Raksim` | `Page` | `game/pages_admin/admin_raksim.php:5` |
| `Admin_Reports` | `Page` | `game/pages_admin/admin_reports.php:5` |
| `Admin_BattleSim` | `Page` | `game/pages_admin/admin_sim.php:5` |
| `Admin_Uni` | `Page` | `game/pages_admin/admin_uni.php:5` |
| `Admin_Userlogs` | `Page` | `game/pages_admin/admin_userlogs.php:5` |
| `Admin_Users` | `Page` | `game/pages_admin/admin_users.php:5` |
