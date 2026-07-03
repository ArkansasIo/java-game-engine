# OGame 0.84 Source Index

Generated from `ogamespec/ogame-opensource/game`. Counts: 603 total game files, 409 PHP files, 862 extracted PHP symbols.

## Directory Summary

| Directory | Files |
|---|---:|
| `ainfo.php` | 1 |
| `core` | 34 |
| `cron.php` | 1 |
| `css` | 4 |
| `feed` | 2 |
| `index.php` | 1 |
| `install.php` | 1 |
| `js` | 12 |
| `loca` | 265 |
| `maintenance.php` | 1 |
| `mods` | 20 |
| `pages` | 49 |
| `pages_admin` | 29 |
| `pic.php` | 1 |
| `pranger.php` | 1 |
| `redir.php` | 1 |
| `reg` | 9 |
| `router.json` | 1 |
| `validate.php` | 1 |

## Extracted PHP Symbols

| Kind | Name | Extends | Source |
|---|---|---|---|
| function | `CreateUnion` | `` | `game/core/acs.php:16` |
| function | `LoadUnion` | `` | `game/core/acs.php:46` |
| function | `RemoveUnion` | `` | `game/core/acs.php:59` |
| function | `RenameUnion` | `` | `game/core/acs.php:67` |
| function | `AddUnionMember` | `` | `game/core/acs.php:75` |
| function | `EnumUnion` | `` | `game/core/acs.php:134` |
| function | `EnumUnionFleets` | `` | `game/core/acs.php:155` |
| function | `UpdateUnionTime` | `` | `game/core/acs.php:163` |
| function | `UpdateFleetTime` | `` | `game/core/acs.php:187` |
| function | `GetHoldingFleets` | `` | `game/core/acs.php:197` |
| function | `IsPlayerInUnion` | `` | `game/core/acs.php:207` |
| function | `GetUnionUnitsCount` | `` | `game/core/acs.php:218` |
| function | `GetHoldingUnitsCount` | `` | `game/core/acs.php:241` |
| function | `CreateAlly` | `` | `game/core/ally.php:34` |
| function | `DismissAlly` | `` | `game/core/ally.php:63` |
| function | `EnumerateAlly` | `` | `game/core/ally.php:87` |
| function | `IsAllyTagExist` | `` | `game/core/ally.php:117` |
| function | `LoadAlly` | `` | `game/core/ally.php:127` |
| function | `SearchAllyTag` | `` | `game/core/ally.php:136` |
| function | `CountAllyMembers` | `` | `game/core/ally.php:145` |
| function | `AllyChangeTag` | `` | `game/core/ally.php:154` |
| function | `AllyChangeName` | `` | `game/core/ally.php:168` |
| function | `AllyChangeOwner` | `` | `game/core/ally.php:182` |
| function | `RecalcAllyStats` | `` | `game/core/ally.php:190` |
| function | `RecalcAllyRanks` | `` | `game/core/ally.php:215` |
| function | `AddApplication` | `` | `game/core/allyapps.php:13` |
| function | `RemoveApplication` | `` | `game/core/allyapps.php:21` |
| function | `EnumApplications` | `` | `game/core/allyapps.php:29` |
| function | `GetUserApplication` | `` | `game/core/allyapps.php:37` |
| function | `LoadApplication` | `` | `game/core/allyapps.php:51` |
| function | `AddRank` | `` | `game/core/allyranks.php:16` |
| function | `SetRank` | `` | `game/core/allyranks.php:29` |
| function | `RemoveRank` | `` | `game/core/allyranks.php:37` |
| function | `EnumRanks` | `` | `game/core/allyranks.php:45` |
| function | `SetUserRank` | `` | `game/core/allyranks.php:53` |
| function | `LoadRank` | `` | `game/core/allyranks.php:61` |
| function | `LoadUsersWithRank` | `` | `game/core/allyranks.php:70` |
| function | `RepairDefense` | `` | `game/core/battle.php:17` |
| function | `Plunder` | `` | `game/core/battle.php:82` |
| function | `CalcLosses` | `` | `game/core/battle.php:123` |
| function | `CalcDebris` | `` | `game/core/battle.php:212` |
| function | `GetDebrisTotal` | `` | `game/core/battle.php:286` |
| function | `CargoSummaryLastRound` | `` | `game/core/battle.php:310` |
| function | `WritebackBattleResults` | `` | `game/core/battle.php:341` |
| function | `GenBattleSourceData` | `` | `game/core/battle.php:479` |
| function | `PostProcessBattleResult` | `` | `game/core/battle.php:534` |
| function | `ExecuteBattle` | `` | `game/core/battle.php:606` |
| function | `StartBattle` | `` | `game/core/battle.php:642` |
| function | `hex_array_to_text` | `` | `game/core/battle_engine.php:52` |
| function | `get_packed_word` | `` | `game/core/battle_engine.php:57` |
| function | `set_packed_word` | `` | `game/core/battle_engine.php:65` |
| function | `get_packed_half` | `` | `game/core/battle_engine.php:74` |
| function | `set_packed_half` | `` | `game/core/battle_engine.php:80` |
| function | `InitBattle` | `` | `game/core/battle_engine.php:88` |
| function | `UnitShoot` | `` | `game/core/battle_engine.php:118` |
| function | `WipeExploded` | `` | `game/core/battle_engine.php:191` |
| function | `ChargeShields` | `` | `game/core/battle_engine.php:246` |
| function | `CheckFastDraw` | `` | `game/core/battle_engine.php:267` |
| function | `RapidFire` | `` | `game/core/battle_engine.php:295` |
| function | `DoBattle` | `` | `game/core/battle_engine.php:314` |
| function | `deserialize_slot` | `` | `game/core/battle_engine.php:553` |
| function | `ParseRFTable` | `` | `game/core/battle_engine.php:587` |
| function | `ParseUnitParam` | `` | `game/core/battle_engine.php:648` |
| function | `ParseInput` | `` | `game/core/battle_engine.php:694` |
| function | `BattleEngine` | `` | `game/core/battle_engine.php:752` |
| function | `BattleDebug` | `` | `game/core/battle_engine.php:783` |
| function | `GenSlot` | `` | `game/core/battle_report.php:4` |
| function | `BattleReport` | `` | `game/core/battle_report.php:87` |
| class | `bbcode` | `` | `game/core/bbcode.php:10` |
| function | `__construct` | `` | `game/core/bbcode.php:44` |
| function | `do_bbcode` | `` | `game/core/bbcode.php:48` |
| function | `get_tokens` | `` | `game/core/bbcode.php:73` |
| function | `parse` | `` | `game/core/bbcode.php:150` |
| function | `specialchars` | `` | `game/core/bbcode.php:390` |
| function | `unspecialchars` | `` | `game/core/bbcode.php:401` |
| function | `must_close_tag` | `` | `game/core/bbcode.php:412` |
| function | `normalize_bracket` | `` | `game/core/bbcode.php:422` |
| function | `get_tree` | `` | `game/core/bbcode.php:555` |
| function | `get_syntax` | `` | `game/core/bbcode.php:746` |
| function | `replace_links` | `` | `game/core/bbcode.php:813` |
| function | `get_html` | `` | `game/core/bbcode.php:837` |
| class | `bb_a` | `bbcode` | `game/core/bbcode.php:884` |
| function | `get_html` | `` | `game/core/bbcode.php:893` |
| class | `bb_align` | `bbcode` | `game/core/bbcode.php:953` |
| function | `get_html` | `` | `game/core/bbcode.php:956` |
| class | `bb_color` | `bbcode` | `game/core/bbcode.php:984` |
| function | `get_html` | `` | `game/core/bbcode.php:994` |
| class | `bb_del` | `bbcode` | `game/core/bbcode.php:1002` |
| function | `get_html` | `` | `game/core/bbcode.php:1012` |
| class | `bb_email` | `bbcode` | `game/core/bbcode.php:1018` |
| function | `get_html` | `` | `game/core/bbcode.php:1027` |
| class | `bb_font` | `bbcode` | `game/core/bbcode.php:1056` |
| function | `get_html` | `` | `game/core/bbcode.php:1066` |
| class | `bb_hr` | `bbcode` | `game/core/bbcode.php:1078` |
| function | `get_html` | `` | `game/core/bbcode.php:1083` |
| class | `bb_i` | `bbcode` | `game/core/bbcode.php:1089` |
| function | `get_html` | `` | `game/core/bbcode.php:1099` |
| class | `bb_img` | `bbcode` | `game/core/bbcode.php:1105` |
| function | `get_html` | `` | `game/core/bbcode.php:1108` |
| class | `bb_quote` | `bbcode` | `game/core/bbcode.php:1138` |
| function | `get_html` | `` | `game/core/bbcode.php:1141` |
| class | `bb_size` | `bbcode` | `game/core/bbcode.php:1151` |
| function | `get_html` | `` | `game/core/bbcode.php:1161` |
| class | `bb_strong` | `bbcode` | `game/core/bbcode.php:1185` |
| function | `get_html` | `` | `game/core/bbcode.php:1195` |
| class | `bb_sub` | `bbcode` | `game/core/bbcode.php:1201` |
| function | `get_html` | `` | `game/core/bbcode.php:1211` |
| class | `bb_sup` | `bbcode` | `game/core/bbcode.php:1217` |
| function | `get_html` | `` | `game/core/bbcode.php:1227` |
| class | `bb_u` | `bbcode` | `game/core/bbcode.php:1233` |
| function | `get_html` | `` | `game/core/bbcode.php:1243` |
| function | `bb` | `` | `game/core/bbcode.php:1249` |
| function | `AddBotQueue` | `` | `game/core/bot.php:10` |
| function | `ExecuteBlock` | `` | `game/core/bot.php:16` |
| function | `AddBot` | `` | `game/core/bot.php:134` |
| function | `StartBot` | `` | `game/core/bot.php:153` |
| function | `StopBot` | `` | `game/core/bot.php:164` |
| function | `IsBot` | `` | `game/core/bot.php:175` |
| function | `Queue_Bot_End` | `` | `game/core/bot.php:185` |
| function | `GetVar` | `` | `game/core/bot.php:216` |
| function | `SetVar` | `` | `game/core/bot.php:233` |
| function | `BotIdle` | `` | `game/core/botapi.php:10` |
| function | `BotStrategyExists` | `` | `game/core/botapi.php:15` |
| function | `BotExec` | `` | `game/core/botapi.php:24` |
| function | `BotGetVar` | `` | `game/core/botapi.php:47` |
| function | `BotSetVar` | `` | `game/core/botapi.php:53` |
| function | `BotCanBuild` | `` | `game/core/botapi.php:63` |
| function | `BotBuild` | `` | `game/core/botapi.php:77` |
| function | `BotGetBuild` | `` | `game/core/botapi.php:97` |
| function | `BotResourceSettings` | `` | `game/core/botapi.php:108` |
| function | `BotEnergyAbove` | `` | `game/core/botapi.php:153` |
| function | `BotBuildFleet` | `` | `game/core/botapi.php:171` |
| function | `BotGetResearch` | `` | `game/core/botapi.php:196` |
| function | `BotCanResearch` | `` | `game/core/botapi.php:205` |
| function | `BotResearch` | `` | `game/core/botapi.php:219` |
| function | `AddBuddy` | `` | `game/core/buddy.php:13` |
| function | `RemoveBuddy` | `` | `game/core/buddy.php:34` |
| function | `AcceptBuddy` | `` | `game/core/buddy.php:42` |
| function | `LoadBuddy` | `` | `game/core/buddy.php:50` |
| function | `EnumOutcomeBuddy` | `` | `game/core/buddy.php:59` |
| function | `EnumIncomeBuddy` | `` | `game/core/buddy.php:67` |
| function | `EnumBuddy` | `` | `game/core/buddy.php:75` |
| function | `IsBuddy` | `` | `game/core/buddy.php:83` |
| function | `mail_html` | `` | `game/core/coupon.php:25` |
| function | `LoadCoupon` | `` | `game/core/coupon.php:41` |
| function | `SendCoupon` | `` | `game/core/coupon.php:52` |
| function | `CheckCoupon` | `` | `game/core/coupon.php:63` |
| function | `EnumCoupons` | `` | `game/core/coupon.php:80` |
| function | `TotalCoupons` | `` | `game/core/coupon.php:91` |
| function | `AddCoupon` | `` | `game/core/coupon.php:106` |
| function | `ActivateCoupon` | `` | `game/core/coupon.php:126` |
| function | `DeleteCoupon` | `` | `game/core/coupon.php:147` |
| function | `Queue_Coupon_End` | `` | `game/core/coupon.php:160` |
| function | `dbconnect` | `` | `game/core/db.php:9` |
| function | `dbquery` | `` | `game/core/db.php:25` |
| function | `dbrows` | `` | `game/core/db.php:40` |
| function | `dbarray` | `` | `game/core/db.php:46` |
| function | `dbfree` | `` | `game/core/db.php:57` |
| function | `InitDB` | `` | `game/core/db.php:62` |
| function | `AddDBRow` | `` | `game/core/db.php:73` |
| function | `MDBConnect` | `` | `game/core/db.php:104` |
| function | `MDBQuery` | `` | `game/core/db.php:120` |
| function | `MDBRows` | `` | `game/core/db.php:128` |
| function | `MDBArray` | `` | `game/core/db.php:134` |
| function | `LockTables` | `` | `game/core/db.php:145` |
| function | `UnlockTables` | `` | `game/core/db.php:158` |
| function | `SerializeTable` | `` | `game/core/db.php:163` |
| function | `SerializeDB` | `` | `game/core/db.php:207` |
| function | `DeserExecQuery` | `` | `game/core/db.php:221` |
| function | `DeserializeTable` | `` | `game/core/db.php:227` |
| function | `DeserializeDB` | `` | `game/core/db.php:271` |
| function | `Error` | `` | `game/core/debug.php:6` |
| function | `Debug` | `` | `game/core/debug.php:56` |
| function | `BackTrace` | `` | `game/core/debug.php:77` |
| function | `BrowseHistory` | `` | `game/core/debug.php:95` |
| function | `SecurityCheck` | `` | `game/core/debug.php:110` |
| function | `LogIPAddress` | `` | `game/core/debug.php:117` |
| function | `GetLastRegistrationByIP` | `` | `game/core/debug.php:124` |
| function | `UserLog` | `` | `game/core/debug.php:139` |
| function | `Hacking` | `` | `game/core/debug.php:152` |
| function | `GetSQLQueryLogText` | `` | `game/core/debug.php:180` |
| function | `GetExpeditionsCount` | `` | `game/core/expedition.php:23` |
| function | `LoadExpeditionSettings` | `` | `game/core/expedition.php:32` |
| function | `SaveExpeditionSettings` | `` | `game/core/expedition.php:40` |
| function | `ExpPoints` | `` | `game/core/expedition.php:88` |
| function | `ExpUpperLimit` | `` | `game/core/expedition.php:105` |
| function | `Exp_NothingHappens` | `` | `game/core/expedition.php:127` |
| function | `Logbook` | `` | `game/core/expedition.php:155` |
| function | `Exp_BattleAliens` | `` | `game/core/expedition.php:199` |
| function | `Exp_BattlePirates` | `` | `game/core/expedition.php:243` |
| function | `Exp_DarkMatterFound` | `` | `game/core/expedition.php:288` |
| function | `Exp_LostFleet` | `` | `game/core/expedition.php:349` |
| function | `Exp_DelayFleet` | `` | `game/core/expedition.php:373` |
| function | `Exp_AccelFleet` | `` | `game/core/expedition.php:402` |
| function | `Exp_ResourcesFound` | `` | `game/core/expedition.php:428` |
| function | `Exp_FleetFound` | `` | `game/core/expedition.php:522` |
| function | `Exp_TraderFound` | `` | `game/core/expedition.php:647` |
| function | `ExpeditionArrive` | `` | `game/core/expedition.php:728` |
| function | `Expedition` | `` | `game/core/expedition.php:738` |
| function | `ExpeditionHold` | `` | `game/core/expedition.php:766` |
| function | `WritebackBattleResultsExpedition` | `` | `game/core/expedition_battle.php:4` |
| function | `ExpeditionBattle` | `` | `game/core/expedition_battle.php:62` |
| function | `FleetAvailableMissionsDefault` | `` | `game/core/fleet.php:63` |
| function | `FleetAvailableMissions` | `` | `game/core/fleet.php:139` |
| function | `FlightDistance` | `` | `game/core/fleet.php:163` |
| function | `FlightSpeed` | `` | `game/core/fleet.php:177` |
| function | `FlightCons` | `` | `game/core/fleet.php:190` |
| function | `FlightTime` | `` | `game/core/fleet.php:208` |
| function | `FleetSpeed` | `` | `game/core/fleet.php:215` |
| function | `FleetCargo` | `` | `game/core/fleet.php:267` |
| function | `FleetCargoSummary` | `` | `game/core/fleet.php:274` |
| function | `FleetCons` | `` | `game/core/fleet.php:288` |
| function | `GetMaxFleet` | `` | `game/core/fleet.php:307` |
| function | `AdjustShips` | `` | `game/core/fleet.php:333` |
| function | `DispatchFleet` | `` | `game/core/fleet.php:353` |
| function | `RecallFleet` | `` | `game/core/fleet.php:396` |
| function | `LoadFleet` | `` | `game/core/fleet.php:444` |
| function | `DeleteFleet` | `` | `game/core/fleet.php:453` |
| function | `SetFleet` | `` | `game/core/fleet.php:461` |
| function | `GetMissionNameDebug` | `` | `game/core/fleet.php:475` |
| function | `LaunchRockets` | `` | `game/core/fleet.php:510` |
| function | `FleetList` | `` | `game/core/fleet.php:551` |
| function | `AttackArrive` | `` | `game/core/fleet.php:564` |
| function | `TransportArrive` | `` | `game/core/fleet.php:571` |
| function | `CommonReturn` | `` | `game/core/fleet.php:630` |
| function | `DeployArrive` | `` | `game/core/fleet.php:671` |
| function | `GetHoldingFleetsCount` | `` | `game/core/fleet.php:704` |
| function | `CanStandHold` | `` | `game/core/fleet.php:713` |
| function | `HoldingArrive` | `` | `game/core/fleet.php:721` |
| function | `HoldingHold` | `` | `game/core/fleet.php:733` |
| function | `SpyArrive` | `` | `game/core/fleet.php:744` |
| function | `SpyReturn` | `` | `game/core/fleet.php:934` |
| function | `ColonizationArrive` | `` | `game/core/fleet.php:943` |
| function | `ColonizationReturn` | `` | `game/core/fleet.php:1018` |
| function | `RecycleArrive` | `` | `game/core/fleet.php:1051` |
| function | `DestroyArrive` | `` | `game/core/fleet.php:1094` |
| function | `RocketAttackArrive` | `` | `game/core/fleet.php:1105` |
| function | `Queue_Fleet_End` | `` | `game/core/fleet.php:1110` |
| function | `FleetlogsMissionText` | `` | `game/core/fleet.php:1204` |
| function | `FleetlogsFromPlayer` | `` | `game/core/fleet.php:1224` |
| function | `FleetlogsToPlayer` | `` | `game/core/fleet.php:1242` |
| function | `DumpFleet` | `` | `game/core/fleet.php:1260` |
| function | `GravitonAttack` | `` | `game/core/graviton.php:8` |
| function | `loca` | `` | `game/core/loca.php:55` |
| function | `loca_lang` | `` | `game/core/loca.php:64` |
| function | `loca_add` | `` | `game/core/loca.php:72` |
| class | `GameMod` | `` | `game/core/mods.php:8` |
| function | `install` | `` | `game/core/mods.php:9` |
| function | `uninstall` | `` | `game/core/mods.php:10` |
| function | `init` | `` | `game/core/mods.php:11` |
| function | `route` | `` | `game/core/mods.php:15` |
| function | `route_admin` | `` | `game/core/mods.php:19` |
| function | `update_queue` | `` | `game/core/mods.php:23` |
| function | `add_resources` | `` | `game/core/mods.php:27` |
| function | `add_bonuses` | `` | `game/core/mods.php:31` |
| function | `add_menuitems` | `` | `game/core/mods.php:35` |
| function | `lock_tables` | `` | `game/core/mods.php:39` |
| function | `install_tabs_included` | `` | `game/core/mods.php:43` |
| function | `get_planet_small_image` | `` | `game/core/mods.php:47` |
| function | `get_planet_image` | `` | `game/core/mods.php:51` |
| function | `get_object_image` | `` | `game/core/mods.php:55` |
| function | `begin_content` | `` | `game/core/mods.php:59` |
| function | `end_content` | `` | `game/core/mods.php:63` |
| function | `add_db_row` | `` | `game/core/mods.php:67` |
| function | `can_build` | `` | `game/core/mods.php:71` |
| function | `can_research` | `` | `game/core/mods.php:75` |
| function | `build_end` | `` | `game/core/mods.php:79` |
| function | `research_end` | `` | `game/core/mods.php:83` |
| function | `fleet_available_missions` | `` | `game/core/mods.php:87` |
| function | `fleet_handler` | `` | `game/core/mods.php:91` |
| function | `prod_post_process` | `` | `game/core/mods.php:95` |
| function | `battle_post_process` | `` | `game/core/mods.php:99` |
| function | `page_buildings_get_bonus` | `` | `game/core/mods.php:105` |
| function | `page_flotten1_get_bonus` | `` | `game/core/mods.php:109` |
| function | `page_flotten2_planet_types` | `` | `game/core/mods.php:113` |
| function | `page_flottenversand_ajax_spy_planets` | `` | `game/core/mods.php:117` |
| function | `page_infos` | `` | `game/core/mods.php:121` |
| function | `page_galaxy_custom_object` | `` | `game/core/mods.php:125` |
| function | `page_overview_get_bonus` | `` | `game/core/mods.php:129` |
| function | `page_resources_get_bonus` | `` | `game/core/mods.php:133` |
| function | `bonus_technology` | `` | `game/core/mods.php:139` |
| function | `bonus_prod` | `` | `game/core/mods.php:143` |
| function | `bonus_cons` | `` | `game/core/mods.php:147` |
| function | `bonus_max_fleet` | `` | `game/core/mods.php:151` |
| function | `bonus_fleet_cons` | `` | `game/core/mods.php:155` |
| function | `bonus_fleet_speed` | `` | `game/core/mods.php:159` |
| function | `ModInitOne` | `` | `game/core/mods.php:164` |
| function | `ModsInit` | `` | `game/core/mods.php:187` |
| function | `ModsExec` | `` | `game/core/mods.php:198` |
| function | `ModsExecArr` | `` | `game/core/mods.php:212` |
| function | `ModsExecRef` | `` | `game/core/mods.php:226` |
| function | `ModsExecRefArr` | `` | `game/core/mods.php:240` |
| function | `ModsExecArrRef` | `` | `game/core/mods.php:254` |
| function | `ModsExecRefRef` | `` | `game/core/mods.php:268` |
| function | `ModsExecIntRef` | `` | `game/core/mods.php:282` |
| function | `ModsExecRefStr` | `` | `game/core/mods.php:296` |
| function | `ModsList` | `` | `game/core/mods.php:310` |
| function | `ModsGetInfo` | `` | `game/core/mods.php:338` |
| function | `ModInstallOne` | `` | `game/core/mods.php:383` |
| function | `ModsInstall` | `` | `game/core/mods.php:400` |
| function | `ModsRemove` | `` | `game/core/mods.php:418` |
| function | `ModsMoveUp` | `` | `game/core/mods.php:441` |
| function | `ModsMoveDown` | `` | `game/core/mods.php:462` |
| function | `DeleteExpiredMessages` | `` | `game/core/msg.php:33` |
| function | `DeleteOldestMessage` | `` | `game/core/msg.php:54` |
| function | `SendMessage` | `` | `game/core/msg.php:64` |
| function | `DeleteMessage` | `` | `game/core/msg.php:94` |
| function | `EnumMessages` | `` | `game/core/msg.php:103` |
| function | `UnreadMessages` | `` | `game/core/msg.php:112` |
| function | `MarkMessage` | `` | `game/core/msg.php:128` |
| function | `LoadMessage` | `` | `game/core/msg.php:136` |
| function | `DeleteAllMessages` | `` | `game/core/msg.php:146` |
| function | `GetSharedSpyReport` | `` | `game/core/msg.php:154` |
| function | `TotalMessages` | `` | `game/core/msg.php:173` |
| function | `ReportMessage` | `` | `game/core/msg.php:181` |
| function | `BroadcastMessage` | `` | `game/core/msg.php:217` |
| function | `LoadNote` | `` | `game/core/notes.php:17` |
| function | `AddNote` | `` | `game/core/notes.php:25` |
| function | `UpdateNote` | `` | `game/core/notes.php:45` |
| function | `DelNote` | `` | `game/core/notes.php:68` |
| function | `EnumNotes` | `` | `game/core/notes.php:80` |
| function | `GetObjectImage` | `` | `game/core/page.php:7` |
| function | `GetPlanetSmallImage` | `` | `game/core/page.php:18` |
| function | `GetPlanetImage` | `` | `game/core/page.php:41` |
| function | `UserSkin` | `` | `game/core/page.php:63` |
| function | `PageHeader` | `` | `game/core/page.php:70` |
| function | `DropListHasMoon` | `` | `game/core/page.php:140` |
| function | `PlanetsDropList` | `` | `game/core/page.php:151` |
| function | `LoadJsonFirst` | `` | `game/core/page.php:202` |
| function | `ResourceList` | `` | `game/core/page.php:215` |
| function | `GetOfficerBonus` | `` | `game/core/page.php:303` |
| function | `BonusList` | `` | `game/core/page.php:340` |
| function | `GetBonusesInHeader` | `` | `game/core/page.php:384` |
| function | `LeftMenu` | `` | `game/core/page.php:400` |
| function | `PageFooter` | `` | `game/core/page.php:584` |
| function | `InvalidSessionPage` | `` | `game/core/page.php:658` |
| function | `MyGoto` | `` | `game/core/page.php:684` |
| function | `BeginContent` | `` | `game/core/page.php:693` |
| function | `EndContent` | `` | `game/core/page.php:701` |
| function | `ShowGalaxy` | `` | `game/core/page.php:709` |
| class | `Page` | `` | `game/core/page.php:717` |
| function | `controller` | `` | `game/core/page.php:719` |
| function | `view` | `` | `game/core/page.php:723` |
| function | `CreatePlanet` | `` | `game/core/planet.php:48` |
| function | `EnumPlanets` | `` | `game/core/planet.php:134` |
| function | `EnumPlanetsGalaxy` | `` | `game/core/planet.php:154` |
| function | `EnumCustomPlanetsGalaxy` | `` | `game/core/planet.php:163` |
| function | `LoadPlanet` | `` | `game/core/planet.php:173` |
| function | `LoadPlanetById` | `` | `game/core/planet.php:190` |
| function | `PlanetHasMoon` | `` | `game/core/planet.php:203` |
| function | `RenamePlanet` | `` | `game/core/planet.php:223` |
| function | `DestroyPlanet` | `` | `game/core/planet.php:257` |
| function | `UpdatePlanetActivity` | `` | `game/core/planet.php:266` |
| function | `HasDebris` | `` | `game/core/planet.php:279` |
| function | `CreateDebris` | `` | `game/core/planet.php:290` |
| function | `HarvestDebris` | `` | `game/core/planet.php:305` |
| function | `AddDebris` | `` | `game/core/planet.php:338` |
| function | `GetPlanetType` | `` | `game/core/planet.php:347` |
| function | `CreateColonyPhantom` | `` | `game/core/planet.php:356` |
| function | `CreateAbandonedColony` | `` | `game/core/planet.php:367` |
| function | `HasPlanet` | `` | `game/core/planet.php:384` |
| function | `AdjustResources` | `` | `game/core/planet.php:394` |
| function | `DestroyMoon` | `` | `game/core/planet.php:412` |
| function | `RecalcFields` | `` | `game/core/planet.php:449` |
| function | `CreateOuterSpace` | `` | `game/core/planet.php:464` |
| function | `SetPlanetFleetDefense` | `` | `game/core/planet.php:488` |
| function | `SetPlanetDefense` | `` | `game/core/planet.php:505` |
| function | `SetPlanetBuildings` | `` | `game/core/planet.php:520` |
| function | `SetPlanetDiameter` | `` | `game/core/planet.php:535` |
| function | `AdminPlanetName` | `` | `game/core/planet.php:544` |
| function | `AdminPlanetCoord` | `` | `game/core/planet.php:553` |
| function | `CreateHomePlanet` | `` | `game/core/planet.php:561` |
| function | `LoadColonySettings` | `` | `game/core/planet.php:603` |
| function | `SaveColonySettings` | `` | `game/core/planet.php:612` |
| function | `GetPhalanxRadius` | `` | `game/core/planet.php:624` |
| function | `CanPhalanx` | `` | `game/core/planet.php:629` |
| function | `TechMeetRequirement` | `` | `game/core/prod.php:7` |
| function | `TechPrice` | `` | `game/core/prod.php:38` |
| function | `TechPriceInPoints` | `` | `game/core/prod.php:58` |
| function | `TechDuration` | `` | `game/core/prod.php:69` |
| function | `ResearchNetwork` | `` | `game/core/prod.php:81` |
| function | `IsEnoughResources` | `` | `game/core/prod.php:113` |
| function | `store_capacity` | `` | `game/core/prod.php:137` |
| function | `ProdBonus` | `` | `game/core/prod.php:217` |
| function | `ConsBonus` | `` | `game/core/prod.php:243` |
| function | `ProdResources` | `` | `game/core/prod.php:256` |
| function | `SetDefaultProduction` | `` | `game/core/prod.php:345` |
| function | `GetUpdatePlanet` | `` | `game/core/prod.php:377` |
| function | `PlanetPrice` | `` | `game/core/prod.php:434` |
| function | `FleetPrice` | `` | `game/core/prod.php:484` |
| function | `AddQueue` | `` | `game/core/queue.php:63` |
| function | `LoadQueue` | `` | `game/core/queue.php:71` |
| function | `RemoveQueue` | `` | `game/core/queue.php:80` |
| function | `ProlongQueue` | `` | `game/core/queue.php:90` |
| function | `UpdateQueue` | `` | `game/core/queue.php:98` |
| function | `FlushQueue` | `` | `game/core/queue.php:155` |
| function | `FreezeQueue` | `` | `game/core/queue.php:171` |
| function | `GetBuildQueue` | `` | `game/core/queue.php:201` |
| function | `CanBuild` | `` | `game/core/queue.php:210` |
| function | `PropagateBuildQueue` | `` | `game/core/queue.php:290` |
| function | `BuildEnque` | `` | `game/core/queue.php:353` |
| function | `BuildDeque` | `` | `game/core/queue.php:426` |
| function | `Queue_Build_End` | `` | `game/core/queue.php:473` |
| function | `GetShipyardQueue` | `` | `game/core/queue.php:547` |
| function | `ShipyardLatestTime` | `` | `game/core/queue.php:555` |
| function | `AddShipyard` | `` | `game/core/queue.php:572` |
| function | `Queue_Shipyard_End` | `` | `game/core/queue.php:650` |
| function | `CanResearch` | `` | `game/core/queue.php:707` |
| function | `StartResearch` | `` | `game/core/queue.php:757` |
| function | `StopResearch` | `` | `game/core/queue.php:796` |
| function | `GetResearchQueue` | `` | `game/core/queue.php:835` |
| function | `Queue_Research_End` | `` | `game/core/queue.php:843` |
| function | `AddRecalcPointsEvent` | `` | `game/core/queue.php:882` |
| function | `Queue_RecalcPoints_End` | `` | `game/core/queue.php:897` |
| function | `CanEnableVacation` | `` | `game/core/queue.php:905` |
| function | `AddAllowNameEvent` | `` | `game/core/queue.php:915` |
| function | `CanChangeName` | `` | `game/core/queue.php:932` |
| function | `Queue_AllowName_End` | `` | `game/core/queue.php:942` |
| function | `Queue_UnbanPlayer_End` | `` | `game/core/queue.php:952` |
| function | `Queue_AllowAttacks_End` | `` | `game/core/queue.php:962` |
| function | `AddChangeEmailEvent` | `` | `game/core/queue.php:972` |
| function | `Queue_ChangeEmail_End` | `` | `game/core/queue.php:985` |
| function | `AddUpdateStatsEvent` | `` | `game/core/queue.php:999` |
| function | `Queue_UpdateStats_End` | `` | `game/core/queue.php:1020` |
| function | `AddReloginEvent` | `` | `game/core/queue.php:1037` |
| function | `Queue_Relogin_End` | `` | `game/core/queue.php:1052` |
| function | `AddCleanDebrisEvent` | `` | `game/core/queue.php:1069` |
| function | `Queue_CleanDebris_End` | `` | `game/core/queue.php:1084` |
| function | `AddCleanPlanetsEvent` | `` | `game/core/queue.php:1096` |
| function | `Queue_CleanPlanets_End` | `` | `game/core/queue.php:1111` |
| function | `AddCleanPlayersEvent` | `` | `game/core/queue.php:1146` |
| function | `Queue_CleanPlayers_End` | `` | `game/core/queue.php:1161` |
| function | `AddRecalcAllyPointsEvent` | `` | `game/core/queue.php:1193` |
| function | `Queue_RecalcAllyPoints_End` | `` | `game/core/queue.php:1208` |
| function | `AddDebugEvent` | `` | `game/core/queue.php:1216` |
| function | `Queue_Debug_End` | `` | `game/core/queue.php:1223` |
| function | `GetFleetQueue` | `` | `game/core/queue.php:1231` |
| function | `EnumFleetQueue` | `` | `game/core/queue.php:1241` |
| function | `EnumOwnFleetQueue` | `` | `game/core/queue.php:1253` |
| function | `EnumOwnFleetQueueSpecial` | `` | `game/core/queue.php:1267` |
| function | `EnumPlanetFleets` | `` | `game/core/queue.php:1277` |
| function | `RocketAttackMain` | `` | `game/core/raketen.php:10` |
| function | `RocketAttack` | `` | `game/core/raketen.php:60` |
| function | `GetDestroyedDefenseText` | `` | `game/core/raketen.php:129` |
| function | `IsBuilding` | `` | `game/core/techs.php:82` |
| function | `IsResearch` | `` | `game/core/techs.php:88` |
| function | `IsFleet` | `` | `game/core/techs.php:94` |
| function | `IsDefense` | `` | `game/core/techs.php:100` |
| function | `IsDefenseNoRak` | `` | `game/core/techs.php:107` |
| function | `IsResource` | `` | `game/core/techs.php:114` |
| function | `LoadUniverse` | `` | `game/core/uni.php:6` |
| function | `UpdateNews` | `` | `game/core/uni.php:15` |
| function | `DisableNews` | `` | `game/core/uni.php:24` |
| function | `SetUniParam` | `` | `game/core/uni.php:32` |
| function | `SetExtLinks` | `` | `game/core/uni.php:45` |
| function | `SetMaxUsers` | `` | `game/core/uni.php:57` |
| function | `ResetHackCounter` | `` | `game/core/uni.php:71` |
| function | `IncrementHackCounter` | `` | `game/core/uni.php:79` |
| function | `fixed_date` | `` | `game/core/user.php:76` |
| function | `SendGreetingsMail` | `` | `game/core/user.php:83` |
| function | `SendChangeMail` | `` | `game/core/user.php:113` |
| function | `SendGreetingsMessage` | `` | `game/core/user.php:135` |
| function | `IsUserExist` | `` | `game/core/user.php:150` |
| function | `IsEmailExist` | `` | `game/core/user.php:160` |
| function | `CreateUser` | `` | `game/core/user.php:173` |
| function | `RemoveUser` | `` | `game/core/user.php:235` |
| function | `ValidateUser` | `` | `game/core/user.php:298` |
| function | `CheckPassword` | `` | `game/core/user.php:320` |
| function | `ChangeEmail` | `` | `game/core/user.php:334` |
| function | `ChangeName` | `` | `game/core/user.php:351` |
| function | `ChangeActivationCode` | `` | `game/core/user.php:361` |
| function | `SelectPlanet` | `` | `game/core/user.php:372` |
| function | `GetSelectedPlanet` | `` | `game/core/user.php:401` |
| function | `LoadUser` | `` | `game/core/user.php:409` |
| function | `UpdateLastClick` | `` | `game/core/user.php:425` |
| function | `IsPlayerNewbie` | `` | `game/core/user.php:439` |
| function | `IsPlayerStrong` | `` | `game/core/user.php:455` |
| function | `PremiumStatus` | `` | `game/core/user.php:471` |
| function | `GetOfficerLeft` | `` | `game/core/user.php:492` |
| function | `RecruitOfficer` | `` | `game/core/user.php:502` |
| function | `Logout` | `` | `game/core/user.php:531` |
| function | `AuthUser` | `` | `game/core/user.php:548` |
| function | `Login` | `` | `game/core/user.php:586` |
| function | `RecalcStats` | `` | `game/core/user.php:657` |
| function | `AdjustStats` | `` | `game/core/user.php:722` |
| function | `RecalcRanks` | `` | `game/core/user.php:731` |
| function | `UnloadAll` | `` | `game/core/user.php:766` |
| function | `ChangeSkinPath` | `` | `game/core/user.php:778` |
| function | `EnableSkin` | `` | `game/core/user.php:786` |
| function | `EnumOperators` | `` | `game/core/user.php:795` |
| function | `ReactivateUser` | `` | `game/core/user.php:803` |
| function | `InvalidateUserCache` | `` | `game/core/user.php:826` |
| function | `AdminUserName` | `` | `game/core/user.php:833` |
| function | `BanUser` | `` | `game/core/user.php:864` |
| function | `BanUserAttacks` | `` | `game/core/user.php:880` |
| function | `UnbanUser` | `` | `game/core/user.php:893` |
| function | `UnbanUserAttacks` | `` | `game/core/user.php:905` |
| function | `SetUserFlags` | `` | `game/core/user.php:915` |
| function | `GetUsersCount` | `` | `game/core/user.php:923` |
| function | `GetTop1` | `` | `game/core/user.php:932` |
| function | `FeedActivate` | `` | `game/core/user.php:943` |
| function | `EnableVacation` | `` | `game/core/user.php:972` |
| function | `method` | `` | `game/core/utils.php:5` |
| function | `scriptname` | `` | `game/core/utils.php:9` |
| function | `hostname` | `` | `game/core/utils.php:14` |
| function | `nicenum` | `` | `game/core/utils.php:25` |
| function | `RedirectHome` | `` | `game/core/utils.php:30` |
| function | `va` | `` | `game/core/utils.php:38` |
| function | `sksort` | `` | `game/core/utils.php:52` |
| function | `mail_utf8` | `` | `game/core/utils.php:81` |
| function | `localhost` | `` | `game/core/utils.php:87` |
| function | `SecureText` | `` | `game/core/utils.php:93` |
| function | `CheckParams` | `` | `game/core/utils.php:131` |
| function | `array_insert_after_key` | `` | `game/core/utils.php:178` |
| function | `array_insert_before_key` | `` | `game/core/utils.php:210` |
| function | `gen_trivial_password` | `` | `game/core/utils.php:240` |
| function | `DurationFormat` | `` | `game/core/utils.php:255` |
| function | `RunBackgroundProcess` | `` | `game/core/utils.php:271` |
| function | `FloatEqual` | `` | `game/core/utils.php:284` |
| function | `isValidEmail` | `` | `game/core/utils.php:288` |
| function | `uniurl` | `` | `game/install.php:25` |
| function | `CheckParameters` | `` | `game/install.php:32` |
| class | `BogusMod` | `GameMod` | `game/mods/BogusMod/main.php:9` |
| function | `install` | `` | `game/mods/BogusMod/main.php:11` |
| function | `uninstall` | `` | `game/mods/BogusMod/main.php:32` |
| function | `init` | `` | `game/mods/BogusMod/main.php:50` |
| function | `route` | `` | `game/mods/BogusMod/main.php:55` |
| function | `update_queue` | `` | `game/mods/BogusMod/main.php:63` |
| function | `add_resources` | `` | `game/mods/BogusMod/main.php:79` |
| function | `add_menuitems` | `` | `game/mods/BogusMod/main.php:95` |
| function | `install_tabs_included` | `` | `game/mods/BogusMod/main.php:107` |
| class | `DeepSpaceHorror` | `GameMod` | `game/mods/DeepSpaceHorror/main.php:24` |
| function | `install` | `` | `game/mods/DeepSpaceHorror/main.php:26` |
| function | `uninstall` | `` | `game/mods/DeepSpaceHorror/main.php:63` |
| function | `install_tabs_included` | `` | `game/mods/DeepSpaceHorror/main.php:110` |
| function | `init` | `` | `game/mods/DeepSpaceHorror/main.php:120` |
| function | `get_planet_small_image` | `` | `game/mods/DeepSpaceHorror/main.php:186` |
| function | `get_planet_image` | `` | `game/mods/DeepSpaceHorror/main.php:190` |
| function | `get_object_image` | `` | `game/mods/DeepSpaceHorror/main.php:208` |
| function | `CreateLeviathan` | `` | `game/mods/DeepSpaceHorror/main.php:223` |
| function | `DeterminePortalCoords` | `` | `game/mods/DeepSpaceHorror/main.php:282` |
| function | `DispatchLeviathan` | `` | `game/mods/DeepSpaceHorror/main.php:348` |
| function | `IsPlanetLeviathan` | `` | `game/mods/DeepSpaceHorror/main.php:399` |
| function | `page_flotten2_planet_types` | `` | `game/mods/DeepSpaceHorror/main.php:411` |
| function | `page_flottenversand_ajax_spy_planets` | `` | `game/mods/DeepSpaceHorror/main.php:419` |
| function | `page_galaxy_custom_object` | `` | `game/mods/DeepSpaceHorror/main.php:427` |
| function | `GetLeviathanOverlib` | `` | `game/mods/DeepSpaceHorror/main.php:437` |
| function | `fleet_handler` | `` | `game/mods/DeepSpaceHorror/main.php:465` |
| function | `LeviathanArrive` | `` | `game/mods/DeepSpaceHorror/main.php:474` |
| function | `LeviathanBattle` | `` | `game/mods/DeepSpaceHorror/main.php:522` |
| class | `GalaxyTool` | `GameMod` | `game/mods/GalaxyTool/main.php:11` |
| function | `install` | `` | `game/mods/GalaxyTool/main.php:13` |
| function | `uninstall` | `` | `game/mods/GalaxyTool/main.php:32` |
| function | `init` | `` | `game/mods/GalaxyTool/main.php:48` |
| function | `install_tabs_included` | `` | `game/mods/GalaxyTool/main.php:54` |
| function | `route` | `` | `game/mods/GalaxyTool/main.php:59` |
| function | `update_queue` | `` | `game/mods/GalaxyTool/main.php:68` |
| function | `add_menuitems` | `` | `game/mods/GalaxyTool/main.php:82` |
| function | `GalaxyToolUpdateGalaxy` | `` | `game/mods/GalaxyTool/main.php:99` |
| function | `GalaxyToolUpdateStats` | `` | `game/mods/GalaxyTool/main.php:126` |
| function | `GalaxyToolUpdateAllyStats` | `` | `game/mods/GalaxyTool/main.php:158` |
| function | `GalaxyToolReplaceOldStats` | `` | `game/mods/GalaxyTool/main.php:179` |
| function | `GalaxyToolReplaceOldAllyStats` | `` | `game/mods/GalaxyTool/main.php:186` |
| function | `GalaxyToolUpdate` | `` | `game/mods/GalaxyTool/main.php:193` |
| function | `route_admin` | `` | `game/mods/GalaxyTool/main.php:202` |
| function | `PlayerDetails` | `` | `game/mods/GalaxyTool/pages/galaxytool.php:20` |
| class | `Admin_GalaxyTool` | `Page` | `game/mods/GalaxyTool/pages_admin/admin_galaxytool.php:3` |
| function | `controller` | `` | `game/mods/GalaxyTool/pages_admin/admin_galaxytool.php:5` |
| function | `view` | `` | `game/mods/GalaxyTool/pages_admin/admin_galaxytool.php:26` |
| class | `SpaceStorm` | `GameMod` | `game/mods/SpaceStorm/main.php:33` |
| function | `install` | `` | `game/mods/SpaceStorm/main.php:35` |
| function | `uninstall` | `` | `game/mods/SpaceStorm/main.php:62` |
| function | `install_tabs_included` | `` | `game/mods/SpaceStorm/main.php:84` |
| function | `init` | `` | `game/mods/SpaceStorm/main.php:92` |
| function | `update_queue` | `` | `game/mods/SpaceStorm/main.php:109` |
| function | `get_object_image` | `` | `game/mods/SpaceStorm/main.php:137` |
| function | `add_bonuses` | `` | `game/mods/SpaceStorm/main.php:146` |
| function | `can_build` | `` | `game/mods/SpaceStorm/main.php:209` |
| function | `build_end` | `` | `game/mods/SpaceStorm/main.php:220` |
| function | `page_buildings_get_bonus` | `` | `game/mods/SpaceStorm/main.php:237` |
| function | `page_infos` | `` | `game/mods/SpaceStorm/main.php:253` |
| function | `bonus_technology` | `` | `game/mods/SpaceStorm/main.php:279` |
| function | `NewStorm` | `` | `game/mods/SpaceStorm/main.php:287` |
| function | `GetStorm` | `` | `game/mods/SpaceStorm/main.php:370` |
| function | `SetStorm` | `` | `game/mods/SpaceStorm/main.php:375` |
| function | `CountStormBits` | `` | `game/mods/SpaceStorm/main.php:383` |
| function | `GetStabLevelMask` | `` | `game/mods/SpaceStorm/main.php:394` |
| function | `GetStormQueue` | `` | `game/mods/SpaceStorm/main.php:407` |
| function | `add_db_row` | `` | `game/mods/SpaceStorm/main.php:416` |
| function | `page_flotten1_get_bonus` | `` | `game/mods/SpaceStorm/main.php:459` |
| function | `page_overview_get_bonus` | `` | `game/mods/SpaceStorm/main.php:475` |
| function | `page_resources_get_bonus` | `` | `game/mods/SpaceStorm/main.php:488` |
| function | `GetStormBonuses` | `` | `game/mods/SpaceStorm/main.php:517` |
| function | `bonus_prod` | `` | `game/mods/SpaceStorm/main.php:542` |
| function | `prod_post_process` | `` | `game/mods/SpaceStorm/main.php:557` |
| function | `battle_post_process` | `` | `game/mods/SpaceStorm/main.php:586` |
| function | `bonus_fleet_cons` | `` | `game/mods/SpaceStorm/main.php:632` |
| function | `bonus_fleet_speed` | `` | `game/mods/SpaceStorm/main.php:643` |
| function | `fleet_available_missions` | `` | `game/mods/SpaceStorm/main.php:657` |
| function | `AllyPage_NoAlly` | `` | `game/pages/allianzen.php:13` |
| function | `AllyPage_CreateAlly` | `` | `game/pages/allianzen.php:23` |
| function | `AllyPage_Search` | `` | `game/pages/allianzen.php:34` |
| function | `AllyPage_SearchResult` | `` | `game/pages/allianzen.php:47` |
| function | `AllyPage_Already` | `` | `game/pages/allianzen.php:70` |
| function | `AllyPage_CircularMessage` | `` | `game/pages/allianzen_circular.php:5` |
| function | `AllyPage_Home` | `` | `game/pages/allianzen_main.php:5` |
| function | `PageAlly_MemberList` | `` | `game/pages/allianzen_members.php:5` |
| function | `PageAlly_MemberSettings` | `` | `game/pages/allianzen_members.php:74` |
| function | `PageAlly_Leave` | `` | `game/pages/allianzen_misc.php:6` |
| function | `PageAlly_ChangeTag` | `` | `game/pages/allianzen_misc.php:54` |
| function | `PageAlly_ChangeName` | `` | `game/pages/allianzen_misc.php:98` |
| function | `PageAlly_Dismiss` | `` | `game/pages/allianzen_misc.php:141` |
| function | `AllyPage_Takeover` | `` | `game/pages/allianzen_misc.php:196` |
| function | `PageAlly_Ranks` | `` | `game/pages/allianzen_ranks.php:9` |
| function | `as_sel` | `` | `game/pages/allianzen_settings.php:5` |
| function | `PageAlly_Settings` | `` | `game/pages/allianzen_settings.php:11` |
| class | `B_Building` | `Page` | `game/pages/b_building.php:5` |
| function | `controller` | `` | `game/pages/b_building.php:7` |
| function | `view` | `` | `game/pages/b_building.php:28` |
| function | `t` | `` | `game/pages/b_building.php:42` |
| function | `GetBuildingsBonus` | `` | `game/pages/b_building.php:230` |
| function | `ShowBuildingsBonus` | `` | `game/pages/b_building.php:237` |
| function | `Buddy_Home` | `` | `game/pages/buddy.php:16` |
| function | `Buddy_Income` | `` | `game/pages/buddy.php:78` |
| function | `Buddy_Outcome` | `` | `game/pages/buddy.php:142` |
| function | `Buddy_Request` | `` | `game/pages/buddy.php:193` |
| class | `Buildings` | `Page` | `game/pages/buildings.php:5` |
| function | `controller` | `` | `game/pages/buildings.php:7` |
| function | `view` | `` | `game/pages/buildings.php:77` |
| function | `t` | `` | `game/pages/buildings.php:354` |
| function | `t` | `` | `game/pages/buildings.php:462` |
| function | `xd` | `` | `game/pages/buildings.php:508` |
| function | `GetBuildingsBonus` | `` | `game/pages/buildings.php:570` |
| function | `ShowBuildingsBonus` | `` | `game/pages/buildings.php:594` |
| function | `OverFleet` | `` | `game/pages/event_list.php:5` |
| function | `TitleFleet` | `` | `game/pages/event_list.php:44` |
| function | `PlayerDetails` | `` | `game/pages/event_list.php:80` |
| function | `PlanetFrom` | `` | `game/pages/event_list.php:93` |
| function | `PlanetTo` | `` | `game/pages/event_list.php:102` |
| function | `PlanetOn` | `` | `game/pages/event_list.php:111` |
| function | `Cargo` | `` | `game/pages/event_list.php:119` |
| function | `GetMission` | `` | `game/pages/event_list.php:147` |
| function | `show_input` | `` | `game/pages/fleet_templates.php:69` |
| function | `FleetMissionText` | `` | `game/pages/flotten1.php:14` |
| function | `GetFleetBonuses` | `` | `game/pages/flotten1.php:34` |
| function | `getStorageFaktor` | `` | `game/pages/flotten2.php:21` |
| function | `planettype` | `` | `game/pages/flotten2.php:51` |
| function | `getStorageFaktor` | `` | `game/pages/flotten3.php:34` |
| function | `is_checked` | `` | `game/pages/flotten3.php:102` |
| function | `is_selected` | `` | `game/pages/flotten3.php:110` |
| function | `FleetError` | `` | `game/pages/flottenversand.php:18` |
| function | `AjaxSendError` | `` | `game/pages/flottenversand_ajax.php:20` |
| function | `AjaxSendDone` | `` | `game/pages/flottenversand_ajax.php:28` |
| function | `ShowCustomObjects` | `` | `game/pages/galaxy.php:15` |
| function | `empty_row` | `` | `game/pages/galaxy.php:38` |
| function | `galaxy_submit` | `` | `game/pages/galaxy_js.php:3` |
| function | `fenster` | `` | `game/pages/galaxy_js.php:8` |
| function | `mouseX` | `` | `game/pages/galaxy_js.php:16` |
| function | `mouseY` | `` | `game/pages/galaxy_js.php:23` |
| function | `whenLoading` | `` | `game/pages/galaxy_js.php:37` |
| function | `whenLoaded` | `` | `game/pages/galaxy_js.php:42` |
| function | `whenInteractive` | `` | `game/pages/galaxy_js.php:47` |
| function | `whenResponse` | `` | `game/pages/galaxy_js.php:57` |
| function | `doit` | `` | `game/pages/galaxy_js.php:129` |
| function | `addToTable` | `` | `game/pages/galaxy_js.php:166` |
| function | `changeSlots` | `` | `game/pages/galaxy_js.php:191` |
| function | `setShips` | `` | `game/pages/galaxy_js.php:196` |
| function | `cursorevent` | `` | `game/pages/galaxy_js.php:201` |
| function | `rgnum` | `` | `game/pages/infos.php:20` |
| function | `rapidIn` | `` | `game/pages/infos.php:27` |
| function | `rapidOut` | `` | `game/pages/infos.php:32` |
| function | `rapid` | `` | `game/pages/infos.php:38` |
| function | `IsDefenseShoot` | `` | `game/pages/infos.php:49` |
| function | `OfficerLeft` | `` | `game/pages/micropayment.php:15` |
| class | `Notizen` | `Page` | `game/pages/notizen.php:8` |
| function | `controller` | `` | `game/pages/notizen.php:10` |
| function | `view` | `` | `game/pages/notizen.php:33` |
| function | `CreateNewNote` | `` | `game/pages/notizen.php:93` |
| function | `EditNote` | `` | `game/pages/notizen.php:106` |
| function | `IsChecked` | `` | `game/pages/options.php:15` |
| function | `IsCheckedFlag` | `` | `game/pages/options.php:22` |
| function | `IsSelected` | `` | `game/pages/options.php:29` |
| class | `Overview` | `Page` | `game/pages/overview.php:9` |
| function | `controller` | `` | `game/pages/overview.php:11` |
| function | `view` | `` | `game/pages/overview.php:23` |
| function | `t_building` | `` | `game/pages/overview.php:37` |
| function | `FleetSpanAttack` | `` | `game/pages/overview_events.php:7` |
| function | `FleetSpanAcsAttack` | `` | `game/pages/overview_events.php:20` |
| function | `FleetSpanTransport` | `` | `game/pages/overview_events.php:36` |
| function | `FleetSpanDeploy` | `` | `game/pages/overview_events.php:49` |
| function | `FleetSpanAcsHold` | `` | `game/pages/overview_events.php:59` |
| function | `FleetSpanSpy` | `` | `game/pages/overview_events.php:78` |
| function | `FleetSpanColonize` | `` | `game/pages/overview_events.php:91` |
| function | `FleetSpanRecycle` | `` | `game/pages/overview_events.php:101` |
| function | `FleetSpanDestroy` | `` | `game/pages/overview_events.php:111` |
| function | `FleetSpanAcsAttackHead` | `` | `game/pages/overview_events.php:124` |
| function | `FleetSpanExpedition` | `` | `game/pages/overview_events.php:140` |
| function | `FleetSpanMissile` | `` | `game/pages/overview_events.php:152` |
| function | `FleetSpan` | `` | `game/pages/overview_events.php:166` |
| function | `GetDirectionAssignment` | `` | `game/pages/overview_events.php:228` |
| function | `EventList` | `` | `game/pages/overview_events.php:243` |
| function | `FleetSpanAttack` | `` | `game/pages/phalanx_events.php:8` |
| function | `FleetSpanAcsAttack` | `` | `game/pages/phalanx_events.php:18` |
| function | `FleetSpanTransport` | `` | `game/pages/phalanx_events.php:28` |
| function | `FleetSpanDeploy` | `` | `game/pages/phalanx_events.php:38` |
| function | `FleetSpanAcsHold` | `` | `game/pages/phalanx_events.php:45` |
| function | `FleetSpanSpy` | `` | `game/pages/phalanx_events.php:58` |
| function | `FleetSpanColonize` | `` | `game/pages/phalanx_events.php:68` |
| function | `FleetSpanRecycle` | `` | `game/pages/phalanx_events.php:75` |
| function | `FleetSpanDestroy` | `` | `game/pages/phalanx_events.php:82` |
| function | `FleetSpanAcsAttackHead` | `` | `game/pages/phalanx_events.php:92` |
| function | `FleetSpanExpedition` | `` | `game/pages/phalanx_events.php:102` |
| function | `FleetSpanMissile` | `` | `game/pages/phalanx_events.php:115` |
| function | `FleetSpanCustom` | `` | `game/pages/phalanx_events.php:122` |
| function | `FleetSpan` | `` | `game/pages/phalanx_events.php:132` |
| function | `PhalanxEventList` | `` | `game/pages/phalanx_events.php:184` |
| function | `MyDate` | `` | `game/pages/pranger.php:13` |
| function | `PlanetDestroyMenu` | `` | `game/pages/renameplanet.php:13` |
| class | `Resources` | `Page` | `game/pages/resources.php:5` |
| function | `controller` | `` | `game/pages/resources.php:9` |
| function | `GetResourceBonus` | `` | `game/pages/resources.php:48` |
| function | `view` | `` | `game/pages/resources.php:110` |
| function | `get_prod` | `` | `game/pages/resources.php:255` |
| function | `prod_select` | `` | `game/pages/resources.php:264` |
| function | `nicenum2` | `` | `game/pages/resources.php:286` |
| function | `rgnum` | `` | `game/pages/resources.php:293` |
| function | `DisplayTotalProduction` | `` | `game/pages/resources.php:299` |
| function | `DisplayFacilityProduction` | `` | `game/pages/resources.php:313` |
| function | `DisplayStorages` | `` | `game/pages/resources.php:317` |
| function | `search_selected` | `` | `game/pages/suche.php:13` |
| class | `Techtree` | `Page` | `game/pages/techtree.php:5` |
| function | `controller` | `` | `game/pages/techtree.php:7` |
| function | `view` | `` | `game/pages/techtree.php:11` |
| function | `MeetRequirement` | `` | `game/pages/techtree.php:85` |
| class | `Techtreedetails` | `Page` | `game/pages/techtreedetails.php:5` |
| function | `controller` | `` | `game/pages/techtreedetails.php:13` |
| function | `view` | `` | `game/pages/techtreedetails.php:17` |
| function | `walk_tree` | `` | `game/pages/techtreedetails.php:69` |
| function | `MeetRequirement` | `` | `game/pages/techtreedetails.php:87` |
| function | `CallNewTrader` | `` | `game/pages/trader.php:11` |
| function | `is_selected` | `` | `game/pages/trader.php:198` |
| function | `number_format` | `` | `game/pages/trader.php:232` |
| function | `setStorage` | `` | `game/pages/trader.php:262` |
| function | `setValue` | `` | `game/pages/trader.php:266` |
| function | `getValue` | `` | `game/pages/trader.php:272` |
| function | `calcCosts` | `` | `game/pages/trader.php:280` |
| function | `calcInputFromCosts` | `` | `game/pages/trader.php:284` |
| function | `displayOfferCosts` | `` | `game/pages/trader.php:288` |
| function | `getFreeOfferCosts` | `` | `game/pages/trader.php:292` |
| function | `addOfferCosts` | `` | `game/pages/trader.php:297` |
| function | `checkValue` | `` | `game/pages/trader.php:301` |
| function | `setMaxValue` | `` | `game/pages/trader.php:321` |
| function | `SendNotActivated` | `` | `game/pages/writemessages.php:13` |
| class | `Admin_Bans` | `Page` | `game/pages_admin/admin_bans.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_bans.php:13` |
| function | `view` | `` | `game/pages_admin/admin_bans.php:105` |
| function | `SetClearCheckbox` | `` | `game/pages_admin/admin_bans.php:144` |
| class | `Admin_BattleReport` | `Page` | `game/pages_admin/admin_battle.php:6` |
| function | `controller` | `` | `game/pages_admin/admin_battle.php:8` |
| function | `view` | `` | `game/pages_admin/admin_battle.php:51` |
| class | `Admin_Botedit` | `Page` | `game/pages_admin/admin_botedit.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_botedit.php:7` |
| function | `view` | `` | `game/pages_admin/admin_botedit.php:188` |
| class | `Admin_Bots` | `Page` | `game/pages_admin/admin_bots.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_bots.php:9` |
| function | `view` | `` | `game/pages_admin/admin_bots.php:34` |
| class | `Admin_Broadcast` | `Page` | `game/pages_admin/admin_broadcast.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_broadcast.php:9` |
| function | `view` | `` | `game/pages_admin/admin_broadcast.php:43` |
| class | `Admin_Browse` | `Page` | `game/pages_admin/admin_browse.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_browse.php:7` |
| function | `view` | `` | `game/pages_admin/admin_browse.php:11` |
| class | `Admin_Checksum` | `Page` | `game/pages_admin/admin_checksum.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_checksum.php:149` |
| function | `view` | `` | `game/pages_admin/admin_checksum.php:181` |
| class | `Admin_ColonySettings` | `Page` | `game/pages_admin/admin_colony_settings.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_colony_settings.php:9` |
| function | `view` | `` | `game/pages_admin/admin_colony_settings.php:24` |
| class | `Admin_Coupons` | `Page` | `game/pages_admin/admin_coupons.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_coupons.php:7` |
| function | `view` | `` | `game/pages_admin/admin_coupons.php:54` |
| class | `Admin_DB` | `Page` | `game/pages_admin/admin_db.php:11` |
| function | `controller` | `` | `game/pages_admin/admin_db.php:13` |
| function | `view` | `` | `game/pages_admin/admin_db.php:37` |
| function | `DiffTab` | `` | `game/pages_admin/admin_db.php:138` |
| function | `ListDatabaseBackups` | `` | `game/pages_admin/admin_db.php:166` |
| function | `CreateBackup` | `` | `game/pages_admin/admin_db.php:194` |
| function | `DeleteBackup` | `` | `game/pages_admin/admin_db.php:203` |
| function | `RestoreBackup` | `` | `game/pages_admin/admin_db.php:216` |
| class | `Admin_Debug` | `Page` | `game/pages_admin/admin_debug.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_debug.php:9` |
| function | `view` | `` | `game/pages_admin/admin_debug.php:58` |
| class | `Admin_Errors` | `Page` | `game/pages_admin/admin_errors.php:6` |
| function | `controller` | `` | `game/pages_admin/admin_errors.php:10` |
| function | `view` | `` | `game/pages_admin/admin_errors.php:39` |
| class | `Admin_Expedition` | `Page` | `game/pages_admin/admin_expedition.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_expedition.php:10` |
| function | `view` | `` | `game/pages_admin/admin_expedition.php:102` |
| class | `Admin_Fleetlogs` | `Page` | `game/pages_admin/admin_fleetlogs.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_fleetlogs.php:9` |
| function | `view` | `` | `game/pages_admin/admin_fleetlogs.php:52` |
| class | `Admin_Home` | `Page` | `game/pages_admin/admin_home.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_home.php:7` |
| function | `view` | `` | `game/pages_admin/admin_home.php:11` |
| class | `Admin_Loca` | `Page` | `game/pages_admin/admin_loca.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_loca.php:10` |
| function | `view` | `` | `game/pages_admin/admin_loca.php:39` |
| function | `CompareTwoLocas` | `` | `game/pages_admin/admin_loca.php:95` |
| class | `Admin_Logins` | `Page` | `game/pages_admin/admin_logins.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_logins.php:9` |
| function | `view` | `` | `game/pages_admin/admin_logins.php:87` |
| class | `Admin_Mods` | `Page` | `game/pages_admin/admin_mods.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_mods.php:7` |
| function | `view` | `` | `game/pages_admin/admin_mods.php:41` |
| function | `GenModPanelSource` | `` | `game/pages_admin/admin_mods.php:240` |
| function | `AdminPanel` | `` | `game/pages_admin/admin_panel.php:4` |
| class | `Admin_Planets` | `Page` | `game/pages_admin/admin_planets.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_planets.php:9` |
| function | `view` | `` | `game/pages_admin/admin_planets.php:185` |
| function | `php_str_replace` | `` | `game/pages_admin/admin_planets.php:207` |
| function | `spio` | `` | `game/pages_admin/admin_planets.php:223` |
| function | `reset` | `` | `game/pages_admin/admin_planets.php:288` |
| class | `Admin_Queue` | `Page` | `game/pages_admin/admin_queue.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_queue.php:10` |
| function | `view` | `` | `game/pages_admin/admin_queue.php:60` |
| function | `QueueDesc` | `` | `game/pages_admin/admin_queue.php:162` |
| function | `QueueFrozenDesc` | `` | `game/pages_admin/admin_queue.php:222` |
| class | `Admin_Raksim` | `Page` | `game/pages_admin/admin_raksim.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_raksim.php:13` |
| function | `view` | `` | `game/pages_admin/admin_raksim.php:63` |
| class | `Admin_Reports` | `Page` | `game/pages_admin/admin_reports.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_reports.php:9` |
| function | `view` | `` | `game/pages_admin/admin_reports.php:36` |
| class | `Admin_BattleSim` | `Page` | `game/pages_admin/admin_sim.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_sim.php:20` |
| function | `view` | `` | `game/pages_admin/admin_sim.php:133` |
| function | `toint` | `` | `game/pages_admin/admin_sim.php:151` |
| function | `RecalcAttackersDefendersNum` | `` | `game/pages_admin/admin_sim.php:158` |
| function | `OnChangeSlot` | `` | `game/pages_admin/admin_sim.php:194` |
| function | `OnChangeValue` | `` | `game/pages_admin/admin_sim.php:249` |
| function | `OnChangeTechValue` | `` | `game/pages_admin/admin_sim.php:264` |
| function | `ParseBattleDataSource` | `` | `game/pages_admin/admin_sim.php:420` |
| function | `get_intval` | `` | `game/pages_admin/admin_sim.php:501` |
| function | `SimBattle` | `` | `game/pages_admin/admin_sim.php:511` |
| class | `Admin_Uni` | `Page` | `game/pages_admin/admin_uni.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_uni.php:7` |
| function | `view` | `` | `game/pages_admin/admin_uni.php:80` |
| function | `UniIsSelected` | `` | `game/pages_admin/admin_uni.php:225` |
| function | `UniIsChecked` | `` | `game/pages_admin/admin_uni.php:231` |
| class | `Admin_Userlogs` | `Page` | `game/pages_admin/admin_userlogs.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_userlogs.php:9` |
| function | `view` | `` | `game/pages_admin/admin_userlogs.php:50` |
| class | `Admin_Users` | `Page` | `game/pages_admin/admin_users.php:5` |
| function | `controller` | `` | `game/pages_admin/admin_users.php:25` |
| function | `view` | `` | `game/pages_admin/admin_users.php:149` |
| function | `LinkFleetsFrom` | `` | `game/pages_admin/admin_users.php:564` |
| function | `LinkFleetsTo` | `` | `game/pages_admin/admin_users.php:574` |
| function | `IsChecked` | `` | `game/pages_admin/admin_users.php:584` |
| function | `IsSelected` | `` | `game/pages_admin/admin_users.php:590` |
| function | `EmailExist` | `` | `game/reg/fa_pass.php:21` |
| function | `to_utf8` | `` | `game/reg/login2.php:17` |
| function | `printMessage` | `` | `game/reg/new.php:119` |

## All Game Files

| File | Type | Lines | Symbols |
|---|---|---:|---|
| `game/.gitignore` | `gitignore` | 0 |  |
| `game/.htaccess` | `htaccess` | 0 |  |
| `game/ainfo.php` | `php` | 11 |  |
| `game/battle/.htaccess` | `htaccess` | 0 |  |
| `game/battle/battle.cpp` | `cpp` | 0 |  |
| `game/battle/battle.h` | `h` | 0 |  |
| `game/battle/file.cpp` | `cpp` | 0 |  |
| `game/battle/file.h` | `h` | 0 |  |
| `game/battle/rand.cpp` | `cpp` | 0 |  |
| `game/battle/rand.h` | `h` | 0 |  |
| `game/battle/test/.htaccess` | `htaccess` | 0 |  |
| `game/battle/test/battledata/.htaccess` | `htaccess` | 0 |  |
| `game/battle/test/battledata/battle_1.txt` | `txt` | 21 |  |
| `game/battle/test/battledata/battle_2.txt` | `txt` | 22 |  |
| `game/battle/test/battledata/battle_3.txt` | `txt` | 8 |  |
| `game/battle/test/battleresult/.htaccess` | `htaccess` | 0 |  |
| `game/battle/test/battleresult/battle_1.txt` | `txt` | 1 |  |
| `game/battle/test/battleresult/battle_2.txt` | `txt` | 1 |  |
| `game/battle/test/battleresult/battle_3.txt` | `txt` | 1 |  |
| `game/battle/test/Readme.md` | `md` | 5 |  |
| `game/battle/VS2022/.gitignore` | `gitignore` | 0 |  |
| `game/battle/VS2022/.htaccess` | `htaccess` | 0 |  |
| `game/battle/VS2022/BattleEngine.sln` | `sln` | 0 |  |
| `game/battle/VS2022/BattleEngine.vcxproj` | `vcxproj` | 0 |  |
| `game/battle/VS2022/BattleEngine.vcxproj.filters` | `filters` | 0 |  |
| `game/battle/VS2022/BattleEngine.vcxproj.user` | `user` | 0 |  |
| `game/battle/VS2022/Readme.md` | `md` | 5 |  |
| `game/battledata/.gitignore` | `gitignore` | 0 |  |
| `game/battledata/.htaccess` | `htaccess` | 0 |  |
| `game/battleresult/.gitignore` | `gitignore` | 0 |  |
| `game/battleresult/.htaccess` | `htaccess` | 0 |  |
| `game/core/.htaccess` | `htaccess` | 0 |  |
| `game/core/acs.php` | `php` | 272 | `CreateUnion`, `LoadUnion`, `RemoveUnion`, `RenameUnion`, `AddUnionMember`, `EnumUnion`, `EnumUnionFleets`, `UpdateUnionTime`, `UpdateFleetTime`, `GetHoldingFleets`, `IsPlayerInUnion`, `GetUnionUnitsCount`, `GetHoldingUnitsCount` |
| `game/core/ally.php` | `php` | 241 | `CreateAlly`, `DismissAlly`, `EnumerateAlly`, `IsAllyTagExist`, `LoadAlly`, `SearchAllyTag`, `CountAllyMembers`, `AllyChangeTag`, `AllyChangeName`, `AllyChangeOwner`, `RecalcAllyStats`, `RecalcAllyRanks` |
| `game/core/allyapps.php` | `php` | 59 | `AddApplication`, `RemoveApplication`, `EnumApplications`, `GetUserApplication`, `LoadApplication` |
| `game/core/allyranks.php` | `php` | 78 | `AddRank`, `SetRank`, `RemoveRank`, `EnumRanks`, `SetUserRank`, `LoadRank`, `LoadUsersWithRank` |
| `game/core/battle.php` | `php` | 888 | `RepairDefense`, `Plunder`, `CalcLosses`, `CalcDebris`, `GetDebrisTotal`, `CargoSummaryLastRound`, `WritebackBattleResults`, `GenBattleSourceData`, `PostProcessBattleResult`, `ExecuteBattle`, `StartBattle` |
| `game/core/battle_engine.php` | `php` | 880 | `hex_array_to_text`, `get_packed_word`, `set_packed_word`, `get_packed_half`, `set_packed_half`, `InitBattle`, `UnitShoot`, `WipeExploded`, `ChargeShields`, `CheckFastDraw`, `RapidFire`, `DoBattle`, `deserialize_slot`, `ParseRFTable`, `ParseUnitParam`, `ParseInput`, `BattleEngine`, `BattleDebug` |
| `game/core/battle_report.php` | `php` | 212 | `GenSlot`, `BattleReport` |
| `game/core/bbcode.php` | `php` | 1255 | `bbcode`, `__construct`, `do_bbcode`, `get_tokens`, `parse`, `specialchars`, `unspecialchars`, `must_close_tag`, `normalize_bracket`, `get_tree`, `get_syntax`, `replace_links`, `get_html`, `bb_a`, `get_html`, `bb_align`, `get_html`, `bb_color`, `get_html`, `bb_del`, `get_html`, `bb_email`, `get_html`, `bb_font`, `get_html`, `bb_hr`, `get_html`, `bb_i`, `get_html`, `bb_img`, `get_html`, `bb_quote`, `get_html`, `bb_size`, `get_html`, `bb_strong`, `get_html`, `bb_sub`, `get_html`, `bb_sup`, `get_html`, `bb_u`, `get_html`, `bb` |
| `game/core/bot.php` | `php` | 249 | `AddBotQueue`, `ExecuteBlock`, `AddBot`, `StartBot`, `StopBot`, `IsBot`, `Queue_Bot_End`, `GetVar`, `SetVar` |
| `game/core/botapi.php` | `php` | 242 | `BotIdle`, `BotStrategyExists`, `BotExec`, `BotGetVar`, `BotSetVar`, `BotCanBuild`, `BotBuild`, `BotGetBuild`, `BotResourceSettings`, `BotEnergyAbove`, `BotBuildFleet`, `BotGetResearch`, `BotCanResearch`, `BotResearch` |
| `game/core/buddy.php` | `php` | 92 | `AddBuddy`, `RemoveBuddy`, `AcceptBuddy`, `LoadBuddy`, `EnumOutcomeBuddy`, `EnumIncomeBuddy`, `EnumBuddy`, `IsBuddy` |
| `game/core/core.php` | `php` | 42 |  |
| `game/core/coupon.php` | `php` | 185 | `mail_html`, `LoadCoupon`, `SendCoupon`, `CheckCoupon`, `EnumCoupons`, `TotalCoupons`, `AddCoupon`, `ActivateCoupon`, `DeleteCoupon`, `Queue_Coupon_End` |
| `game/core/db.php` | `php` | 280 | `dbconnect`, `dbquery`, `dbrows`, `dbarray`, `dbfree`, `InitDB`, `AddDBRow`, `MDBConnect`, `MDBQuery`, `MDBRows`, `MDBArray`, `LockTables`, `UnlockTables`, `SerializeTable`, `SerializeDB`, `DeserExecQuery`, `DeserializeTable`, `DeserializeDB` |
| `game/core/debug.php` | `php` | 246 | `Error`, `Debug`, `BackTrace`, `BrowseHistory`, `SecurityCheck`, `LogIPAddress`, `GetLastRegistrationByIP`, `UserLog`, `Hacking`, `GetSQLQueryLogText` |
| `game/core/defs.php` | `php` | 157 |  |
| `game/core/expedition.php` | `php` | 832 | `GetExpeditionsCount`, `LoadExpeditionSettings`, `SaveExpeditionSettings`, `ExpPoints`, `ExpUpperLimit`, `Exp_NothingHappens`, `Logbook`, `Exp_BattleAliens`, `Exp_BattlePirates`, `Exp_DarkMatterFound`, `Exp_LostFleet`, `Exp_DelayFleet`, `Exp_AccelFleet`, `Exp_ResourcesFound`, `Exp_FleetFound`, `Exp_TraderFound`, `ExpeditionArrive`, `Expedition`, `ExpeditionHold` |
| `game/core/expedition_battle.php` | `php` | 252 | `WritebackBattleResultsExpedition`, `ExpeditionBattle` |
| `game/core/fleet.php` | `php` | 1271 | `FleetAvailableMissionsDefault`, `FleetAvailableMissions`, `FlightDistance`, `FlightSpeed`, `FlightCons`, `FlightTime`, `FleetSpeed`, `FleetCargo`, `FleetCargoSummary`, `FleetCons`, `GetMaxFleet`, `AdjustShips`, `DispatchFleet`, `RecallFleet`, `LoadFleet`, `DeleteFleet`, `SetFleet`, `GetMissionNameDebug`, `LaunchRockets`, `FleetList`, `AttackArrive`, `TransportArrive`, `CommonReturn`, `DeployArrive`, `GetHoldingFleetsCount`, `CanStandHold`, `HoldingArrive`, `HoldingHold`, `SpyArrive`, `SpyReturn`, `ColonizationArrive`, `ColonizationReturn`, `RecycleArrive`, `DestroyArrive`, `RocketAttackArrive`, `Queue_Fleet_End`, `FleetlogsMissionText`, `FleetlogsFromPlayer`, `FleetlogsToPlayer`, `DumpFleet` |
| `game/core/graviton.php` | `php` | 115 | `GravitonAttack` |
| `game/core/install_tabs.php` | `php` | 298 |  |
| `game/core/loca.php` | `php` | 96 | `loca`, `loca_lang`, `loca_add` |
| `game/core/mods.php` | `php` | 483 | `GameMod`, `install`, `uninstall`, `init`, `route`, `route_admin`, `update_queue`, `add_resources`, `add_bonuses`, `add_menuitems`, `lock_tables`, `install_tabs_included`, `get_planet_small_image`, `get_planet_image`, `get_object_image`, `begin_content`, `end_content`, `add_db_row`, `can_build`, `can_research`, `build_end`, `research_end`, `fleet_available_missions`, `fleet_handler`, `prod_post_process`, `battle_post_process`, `page_buildings_get_bonus`, `page_flotten1_get_bonus`, `page_flotten2_planet_types`, `page_flottenversand_ajax_spy_planets`, `page_infos`, `page_galaxy_custom_object`, `page_overview_get_bonus`, `page_resources_get_bonus`, `bonus_technology`, `bonus_prod`, `bonus_cons`, `bonus_max_fleet`, `bonus_fleet_cons`, `bonus_fleet_speed`, `ModInitOne`, `ModsInit`, `ModsExec`, `ModsExecArr`, `ModsExecRef`, `ModsExecRefArr`, `ModsExecArrRef`, `ModsExecRefRef`, `ModsExecIntRef`, `ModsExecRefStr`, `ModsList`, `ModsGetInfo`, `ModInstallOne`, `ModsInstall`, `ModsRemove`, `ModsMoveUp`, `ModsMoveDown` |
| `game/core/msg.php` | `php` | 237 | `DeleteExpiredMessages`, `DeleteOldestMessage`, `SendMessage`, `DeleteMessage`, `EnumMessages`, `UnreadMessages`, `MarkMessage`, `LoadMessage`, `DeleteAllMessages`, `GetSharedSpyReport`, `TotalMessages`, `ReportMessage`, `BroadcastMessage` |
| `game/core/notes.php` | `php` | 93 | `LoadNote`, `AddNote`, `UpdateNote`, `DelNote`, `EnumNotes` |
| `game/core/page.php` | `php` | 727 | `GetObjectImage`, `GetPlanetSmallImage`, `GetPlanetImage`, `UserSkin`, `PageHeader`, `DropListHasMoon`, `PlanetsDropList`, `LoadJsonFirst`, `ResourceList`, `GetOfficerBonus`, `BonusList`, `GetBonusesInHeader`, `LeftMenu`, `PageFooter`, `InvalidSessionPage`, `MyGoto`, `BeginContent`, `EndContent`, `ShowGalaxy`, `Page`, `controller`, `view` |
| `game/core/planet.php` | `php` | 642 | `CreatePlanet`, `EnumPlanets`, `EnumPlanetsGalaxy`, `EnumCustomPlanetsGalaxy`, `LoadPlanet`, `LoadPlanetById`, `PlanetHasMoon`, `RenamePlanet`, `DestroyPlanet`, `UpdatePlanetActivity`, `HasDebris`, `CreateDebris`, `HarvestDebris`, `AddDebris`, `GetPlanetType`, `CreateColonyPhantom`, `CreateAbandonedColony`, `HasPlanet`, `AdjustResources`, `DestroyMoon`, `RecalcFields`, `CreateOuterSpace`, `SetPlanetFleetDefense`, `SetPlanetDefense`, `SetPlanetBuildings`, `SetPlanetDiameter`, `AdminPlanetName`, `AdminPlanetCoord`, `CreateHomePlanet`, `LoadColonySettings`, `SaveColonySettings`, `GetPhalanxRadius`, `CanPhalanx` |
| `game/core/prod.php` | `php` | 505 | `TechMeetRequirement`, `TechPrice`, `TechPriceInPoints`, `TechDuration`, `ResearchNetwork`, `IsEnoughResources`, `store_capacity`, `ProdBonus`, `ConsBonus`, `ProdResources`, `SetDefaultProduction`, `GetUpdatePlanet`, `PlanetPrice`, `FleetPrice` |
| `game/core/queue.php` | `php` | 1287 | `AddQueue`, `LoadQueue`, `RemoveQueue`, `ProlongQueue`, `UpdateQueue`, `FlushQueue`, `FreezeQueue`, `GetBuildQueue`, `CanBuild`, `PropagateBuildQueue`, `BuildEnque`, `BuildDeque`, `Queue_Build_End`, `GetShipyardQueue`, `ShipyardLatestTime`, `AddShipyard`, `Queue_Shipyard_End`, `CanResearch`, `StartResearch`, `StopResearch`, `GetResearchQueue`, `Queue_Research_End`, `AddRecalcPointsEvent`, `Queue_RecalcPoints_End`, `CanEnableVacation`, `AddAllowNameEvent`, `CanChangeName`, `Queue_AllowName_End`, `Queue_UnbanPlayer_End`, `Queue_AllowAttacks_End`, `AddChangeEmailEvent`, `Queue_ChangeEmail_End`, `AddUpdateStatsEvent`, `Queue_UpdateStats_End`, `AddReloginEvent`, `Queue_Relogin_End`, `AddCleanDebrisEvent`, `Queue_CleanDebris_End`, `AddCleanPlanetsEvent`, `Queue_CleanPlanets_End`, `AddCleanPlayersEvent`, `Queue_CleanPlayers_End`, `AddRecalcAllyPointsEvent`, `Queue_RecalcAllyPoints_End`, `AddDebugEvent`, `Queue_Debug_End`, `GetFleetQueue`, `EnumFleetQueue`, `EnumOwnFleetQueue`, `EnumOwnFleetQueueSpecial`, `EnumPlanetFleets` |
| `game/core/raketen.php` | `php` | 158 | `RocketAttackMain`, `RocketAttack`, `GetDestroyedDefenseText` |
| `game/core/techs.php` | `php` | 348 | `IsBuilding`, `IsResearch`, `IsFleet`, `IsDefense`, `IsDefenseNoRak`, `IsResource` |
| `game/core/uni.php` | `php` | 86 | `LoadUniverse`, `UpdateNews`, `DisableNews`, `SetUniParam`, `SetExtLinks`, `SetMaxUsers`, `ResetHackCounter`, `IncrementHackCounter` |
| `game/core/user.php` | `php` | 1009 | `fixed_date`, `SendGreetingsMail`, `SendChangeMail`, `SendGreetingsMessage`, `IsUserExist`, `IsEmailExist`, `CreateUser`, `RemoveUser`, `ValidateUser`, `CheckPassword`, `ChangeEmail`, `ChangeName`, `ChangeActivationCode`, `SelectPlanet`, `GetSelectedPlanet`, `LoadUser`, `UpdateLastClick`, `IsPlayerNewbie`, `IsPlayerStrong`, `PremiumStatus`, `GetOfficerLeft`, `RecruitOfficer`, `Logout`, `AuthUser`, `Login`, `RecalcStats`, `AdjustStats`, `RecalcRanks`, `UnloadAll`, `ChangeSkinPath`, `EnableSkin`, `EnumOperators`, `ReactivateUser`, `InvalidateUserCache`, `AdminUserName`, `BanUser`, `BanUserAttacks`, `UnbanUser`, `UnbanUserAttacks`, `SetUserFlags`, `GetUsersCount`, `GetTop1`, `FeedActivate`, `EnableVacation` |
| `game/core/utils.php` | `php` | 292 | `method`, `scriptname`, `hostname`, `nicenum`, `RedirectHome`, `va`, `sksort`, `mail_utf8`, `localhost`, `SecureText`, `CheckParams`, `array_insert_after_key`, `array_insert_before_key`, `gen_trivial_password`, `DurationFormat`, `RunBackgroundProcess`, `FloatEqual`, `isValidEmail` |
| `game/cron.php` | `php` | 29 |  |
| `game/css/combox.css` | `css` | 33 |  |
| `game/css/default.css` | `css` | 372 |  |
| `game/css/formate.css` | `css` | 432 |  |
| `game/css/registration.css` | `css` | 24 |  |
| `game/feed/show.php` | `php` | 140 |  |
| `game/feed/viewitem.php` | `php` | 76 |  |
| `game/img/admin_ban.png` | `png` | 0 |  |
| `game/img/admin_battle.png` | `png` | 0 |  |
| `game/img/admin_botedit.png` | `png` | 0 |  |
| `game/img/admin_bots.png` | `png` | 0 |  |
| `game/img/admin_broadcast.png` | `png` | 0 |  |
| `game/img/admin_browse.png` | `png` | 0 |  |
| `game/img/admin_checksum.png` | `png` | 0 |  |
| `game/img/admin_colony_settings.png` | `png` | 0 |  |
| `game/img/admin_coupons.png` | `png` | 0 |  |
| `game/img/admin_db.png` | `png` | 0 |  |
| `game/img/admin_debug.png` | `png` | 0 |  |
| `game/img/admin_error.png` | `png` | 0 |  |
| `game/img/admin_fleetlogs.png` | `png` | 0 |  |
| `game/img/admin_loca.png` | `png` | 0 |  |
| `game/img/admin_logins.png` | `png` | 0 |  |
| `game/img/admin_mods.png` | `png` | 0 |  |
| `game/img/admin_planets.png` | `png` | 0 |  |
| `game/img/admin_queue.png` | `png` | 0 |  |
| `game/img/admin_raksim.png` | `png` | 0 |  |
| `game/img/admin_report.png` | `png` | 0 |  |
| `game/img/admin_sim.png` | `png` | 0 |  |
| `game/img/admin_uni.png` | `png` | 0 |  |
| `game/img/admin_userlogs.png` | `png` | 0 |  |
| `game/img/admin_users.png` | `png` | 0 |  |
| `game/img/admiral_ikon.gif` | `gif` | 0 |  |
| `game/img/admiral_ikon_un.gif` | `gif` | 0 |  |
| `game/img/background.jpg` | `jpg` | 0 |  |
| `game/img/bg1.gif` | `gif` | 0 |  |
| `game/img/bg2.gif` | `gif` | 0 |  |
| `game/img/commander_ikon.gif` | `gif` | 0 |  |
| `game/img/commander_ikon_un.gif` | `gif` | 0 |  |
| `game/img/commander_stern_gross.jpg` | `jpg` | 0 |  |
| `game/img/dm_klein_1.jpg` | `jpg` | 0 |  |
| `game/img/dm_klein_2.jpg` | `jpg` | 0 |  |
| `game/img/DMaterie.jpg` | `jpg` | 0 |  |
| `game/img/geologe_ikon.gif` | `gif` | 0 |  |
| `game/img/geologe_ikon_un.gif` | `gif` | 0 |  |
| `game/img/ingenieur_ikon.gif` | `gif` | 0 |  |
| `game/img/ingenieur_ikon_un.gif` | `gif` | 0 |  |
| `game/img/install.png` | `png` | 0 |  |
| `game/img/kasino_600x120.jpg` | `jpg` | 0 |  |
| `game/img/loader.gif` | `gif` | 0 |  |
| `game/img/maintenance-background.jpg` | `jpg` | 0 |  |
| `game/img/noimage.png` | `png` | 0 |  |
| `game/img/ogame_admiral.jpg` | `jpg` | 0 |  |
| `game/img/ogame_geologe.jpg` | `jpg` | 0 |  |
| `game/img/ogame_ingenieur.jpg` | `jpg` | 0 |  |
| `game/img/ogame_technokrat.jpg` | `jpg` | 0 |  |
| `game/img/page_bg.png` | `png` | 0 |  |
| `game/img/preload.gif` | `gif` | 0 |  |
| `game/img/r1.png` | `png` | 0 |  |
| `game/img/r2.png` | `png` | 0 |  |
| `game/img/r3.png` | `png` | 0 |  |
| `game/img/r4.png` | `png` | 0 |  |
| `game/img/r5.png` | `png` | 0 |  |
| `game/img/r6.png` | `png` | 0 |  |
| `game/img/r7.png` | `png` | 0 |  |
| `game/img/r8.png` | `png` | 0 |  |
| `game/img/r9.png` | `png` | 0 |  |
| `game/img/technokrat_ikon.gif` | `gif` | 0 |  |
| `game/img/technokrat_ikon_un.gif` | `gif` | 0 |  |
| `game/index.php` | `php` | 220 |  |
| `game/install.php` | `php` | 358 | `uniurl`, `CheckParameters` |
| `game/js/chart.js` | `js` | 16172 |  |
| `game/js/cntchar.js` | `js` | 14 |  |
| `game/js/flotten.js` | `js` | 638 |  |
| `game/js/functions.js` | `js` | 138 |  |
| `game/js/go.js` | `js` | 1682 |  |
| `game/js/go-game.js` | `js` | 349 |  |
| `game/js/ocnt.js` | `js` | 41 |  |
| `game/js/overLib/overlib.js` | `js` | 1491 |  |
| `game/js/registration.js` | `js` | 141 |  |
| `game/js/tw-sack.js` | `js` | 133 |  |
| `game/js/utilities.js` | `js` | 111 |  |
| `game/js/win.js` | `js` | 5 |  |
| `game/loca/.htaccess` | `htaccess` | 0 |  |
| `game/loca/de_de/.htaccess` | `htaccess` | 0 |  |
| `game/loca/de_de/admin.php` | `php` | 521 |  |
| `game/loca/de_de/ainfo.php` | `php` | 12 |  |
| `game/loca/de_de/ally.php` | `php` | 233 |  |
| `game/loca/de_de/battlereport.php` | `php` | 61 |  |
| `game/loca/de_de/buddy.php` | `php` | 33 |  |
| `game/loca/de_de/build.php` | `php` | 74 |  |
| `game/loca/de_de/changelog.php` | `php` | 788 |  |
| `game/loca/de_de/common.php` | `php` | 51 |  |
| `game/loca/de_de/coupons.php` | `php` | 9 |  |
| `game/loca/de_de/debug.php` | `php` | 49 |  |
| `game/loca/de_de/empire.php` | `php` | 20 |  |
| `game/loca/de_de/espionage.php` | `php` | 22 |  |
| `game/loca/de_de/events.php` | `php` | 54 |  |
| `game/loca/de_de/expedition.php` | `php` | 116 |  |
| `game/loca/de_de/fleet.php` | `php` | 139 |  |
| `game/loca/de_de/fleetmsg.php` | `php` | 45 |  |
| `game/loca/de_de/fleetorder.php` | `php` | 18 |  |
| `game/loca/de_de/galaxy.php` | `php` | 131 |  |
| `game/loca/de_de/graviton.php` | `php` | 44 |  |
| `game/loca/de_de/infos.php` | `php` | 61 |  |
| `game/loca/de_de/install.php` | `php` | 69 |  |
| `game/loca/de_de/jumpgate.php` | `php` | 20 |  |
| `game/loca/de_de/maintain.php` | `php` | 11 |  |
| `game/loca/de_de/menu.php` | `php` | 56 |  |
| `game/loca/de_de/messages.php` | `php` | 53 |  |
| `game/loca/de_de/notes.php` | `php` | 36 |  |
| `game/loca/de_de/options.php` | `php` | 96 |  |
| `game/loca/de_de/overview.php` | `php` | 22 |  |
| `game/loca/de_de/phalanx.php` | `php` | 11 |  |
| `game/loca/de_de/pranger.php` | `php` | 17 |  |
| `game/loca/de_de/premium.php` | `php` | 54 |  |
| `game/loca/de_de/raketen.php` | `php` | 13 |  |
| `game/loca/de_de/reg.php` | `php` | 140 |  |
| `game/loca/de_de/renameplanet.php` | `php` | 22 |  |
| `game/loca/de_de/resources.php` | `php` | 17 |  |
| `game/loca/de_de/search.php` | `php` | 26 |  |
| `game/loca/de_de/statistics.php` | `php` | 24 |  |
| `game/loca/de_de/techlong.php` | `php` | 105 |  |
| `game/loca/de_de/technames.php` | `php` | 67 |  |
| `game/loca/de_de/techshort.php` | `php` | 67 |  |
| `game/loca/de_de/techtree.php` | `php` | 15 |  |
| `game/loca/de_de/trader.php` | `php` | 22 |  |
| `game/loca/de_de/union.php` | `php` | 13 |  |
| `game/loca/en_en/.htaccess` | `htaccess` | 0 |  |
| `game/loca/en_en/admin.php` | `php` | 521 |  |
| `game/loca/en_en/ainfo.php` | `php` | 12 |  |
| `game/loca/en_en/ally.php` | `php` | 233 |  |
| `game/loca/en_en/battlereport.php` | `php` | 61 |  |
| `game/loca/en_en/buddy.php` | `php` | 33 |  |
| `game/loca/en_en/build.php` | `php` | 74 |  |
| `game/loca/en_en/changelog.php` | `php` | 781 |  |
| `game/loca/en_en/common.php` | `php` | 51 |  |
| `game/loca/en_en/coupons.php` | `php` | 9 |  |
| `game/loca/en_en/debug.php` | `php` | 49 |  |
| `game/loca/en_en/empire.php` | `php` | 20 |  |
| `game/loca/en_en/espionage.php` | `php` | 22 |  |
| `game/loca/en_en/events.php` | `php` | 54 |  |
| `game/loca/en_en/expedition.php` | `php` | 112 |  |
| `game/loca/en_en/fleet.php` | `php` | 137 |  |
| `game/loca/en_en/fleetmsg.php` | `php` | 44 |  |
| `game/loca/en_en/fleetorder.php` | `php` | 18 |  |
| `game/loca/en_en/galaxy.php` | `php` | 131 |  |
| `game/loca/en_en/graviton.php` | `php` | 43 |  |
| `game/loca/en_en/infos.php` | `php` | 61 |  |
| `game/loca/en_en/install.php` | `php` | 69 |  |
| `game/loca/en_en/jumpgate.php` | `php` | 19 |  |
| `game/loca/en_en/maintain.php` | `php` | 11 |  |
| `game/loca/en_en/menu.php` | `php` | 58 |  |
| `game/loca/en_en/messages.php` | `php` | 53 |  |
| `game/loca/en_en/notes.php` | `php` | 38 |  |
| `game/loca/en_en/options.php` | `php` | 96 |  |
| `game/loca/en_en/overview.php` | `php` | 22 |  |
| `game/loca/en_en/phalanx.php` | `php` | 11 |  |
| `game/loca/en_en/pranger.php` | `php` | 17 |  |
| `game/loca/en_en/premium.php` | `php` | 54 |  |
| `game/loca/en_en/raketen.php` | `php` | 13 |  |
| `game/loca/en_en/reg.php` | `php` | 140 |  |
| `game/loca/en_en/renameplanet.php` | `php` | 22 |  |
| `game/loca/en_en/resources.php` | `php` | 19 |  |
| `game/loca/en_en/search.php` | `php` | 26 |  |
| `game/loca/en_en/statistics.php` | `php` | 24 |  |
| `game/loca/en_en/techlong.php` | `php` | 92 |  |
| `game/loca/en_en/technames.php` | `php` | 67 |  |
| `game/loca/en_en/techshort.php` | `php` | 67 |  |
| `game/loca/en_en/techtree.php` | `php` | 15 |  |
| `game/loca/en_en/trader.php` | `php` | 22 |  |
| `game/loca/en_en/union.php` | `php` | 13 |  |
| `game/loca/es_es/.htaccess` | `htaccess` | 0 |  |
| `game/loca/es_es/admin.php` | `php` | 519 |  |
| `game/loca/es_es/ainfo.php` | `php` | 12 |  |
| `game/loca/es_es/ally.php` | `php` | 233 |  |
| `game/loca/es_es/battlereport.php` | `php` | 61 |  |
| `game/loca/es_es/buddy.php` | `php` | 34 |  |
| `game/loca/es_es/build.php` | `php` | 73 |  |
| `game/loca/es_es/changelog.php` | `php` | 781 |  |
| `game/loca/es_es/common.php` | `php` | 51 |  |
| `game/loca/es_es/coupons.php` | `php` | 9 |  |
| `game/loca/es_es/debug.php` | `php` | 49 |  |
| `game/loca/es_es/empire.php` | `php` | 20 |  |
| `game/loca/es_es/espionage.php` | `php` | 22 |  |
| `game/loca/es_es/events.php` | `php` | 54 |  |
| `game/loca/es_es/expedition.php` | `php` | 112 |  |
| `game/loca/es_es/fleet.php` | `php` | 136 |  |
| `game/loca/es_es/fleetmsg.php` | `php` | 44 |  |
| `game/loca/es_es/fleetorder.php` | `php` | 18 |  |
| `game/loca/es_es/galaxy.php` | `php` | 131 |  |
| `game/loca/es_es/graviton.php` | `php` | 43 |  |
| `game/loca/es_es/infos.php` | `php` | 61 |  |
| `game/loca/es_es/install.php` | `php` | 68 |  |
| `game/loca/es_es/jumpgate.php` | `php` | 19 |  |
| `game/loca/es_es/maintain.php` | `php` | 11 |  |
| `game/loca/es_es/menu.php` | `php` | 58 |  |
| `game/loca/es_es/messages.php` | `php` | 53 |  |
| `game/loca/es_es/notes.php` | `php` | 38 |  |
| `game/loca/es_es/options.php` | `php` | 96 |  |
| `game/loca/es_es/overview.php` | `php` | 22 |  |
| `game/loca/es_es/phalanx.php` | `php` | 11 |  |
| `game/loca/es_es/pranger.php` | `php` | 17 |  |
| `game/loca/es_es/premium.php` | `php` | 54 |  |
| `game/loca/es_es/raketen.php` | `php` | 13 |  |
| `game/loca/es_es/reg.php` | `php` | 140 |  |
| `game/loca/es_es/renameplanet.php` | `php` | 22 |  |
| `game/loca/es_es/resources.php` | `php` | 19 |  |
| `game/loca/es_es/search.php` | `php` | 26 |  |
| `game/loca/es_es/statistics.php` | `php` | 24 |  |
| `game/loca/es_es/techlong.php` | `php` | 92 |  |
| `game/loca/es_es/technames.php` | `php` | 67 |  |
| `game/loca/es_es/techshort.php` | `php` | 67 |  |
| `game/loca/es_es/techtree.php` | `php` | 15 |  |
| `game/loca/es_es/trader.php` | `php` | 22 |  |
| `game/loca/es_es/union.php` | `php` | 13 |  |
| `game/loca/fr_fr/.htaccess` | `htaccess` | 0 |  |
| `game/loca/fr_fr/admin.php` | `php` | 209 |  |
| `game/loca/fr_fr/ainfo.php` | `php` | 12 |  |
| `game/loca/fr_fr/ally.php` | `php` | 231 |  |
| `game/loca/fr_fr/battlereport.php` | `php` | 61 |  |
| `game/loca/fr_fr/buddy.php` | `php` | 33 |  |
| `game/loca/fr_fr/build.php` | `php` | 21 |  |
| `game/loca/fr_fr/changelog.php` | `php` | 0 |  |
| `game/loca/fr_fr/common.php` | `php` | 51 |  |
| `game/loca/fr_fr/coupons.php` | `php` | 9 |  |
| `game/loca/fr_fr/debug.php` | `php` | 18 |  |
| `game/loca/fr_fr/empire.php` | `php` | 20 |  |
| `game/loca/fr_fr/espionage.php` | `php` | 22 |  |
| `game/loca/fr_fr/events.php` | `php` | 54 |  |
| `game/loca/fr_fr/expedition.php` | `php` | 113 |  |
| `game/loca/fr_fr/fleet.php` | `php` | 134 |  |
| `game/loca/fr_fr/fleetmsg.php` | `php` | 44 |  |
| `game/loca/fr_fr/fleetorder.php` | `php` | 18 |  |
| `game/loca/fr_fr/galaxy.php` | `php` | 131 |  |
| `game/loca/fr_fr/graviton.php` | `php` | 43 |  |
| `game/loca/fr_fr/infos.php` | `php` | 0 |  |
| `game/loca/fr_fr/install.php` | `php` | 68 |  |
| `game/loca/fr_fr/jumpgate.php` | `php` | 19 |  |
| `game/loca/fr_fr/maintain.php` | `php` | 11 |  |
| `game/loca/fr_fr/menu.php` | `php` | 34 |  |
| `game/loca/fr_fr/messages.php` | `php` | 53 |  |
| `game/loca/fr_fr/notes.php` | `php` | 38 |  |
| `game/loca/fr_fr/options.php` | `php` | 93 |  |
| `game/loca/fr_fr/overview.php` | `php` | 22 |  |
| `game/loca/fr_fr/phalanx.php` | `php` | 11 |  |
| `game/loca/fr_fr/pranger.php` | `php` | 0 |  |
| `game/loca/fr_fr/premium.php` | `php` | 0 |  |
| `game/loca/fr_fr/raketen.php` | `php` | 13 |  |
| `game/loca/fr_fr/reg.php` | `php` | 23 |  |
| `game/loca/fr_fr/renameplanet.php` | `php` | 0 |  |
| `game/loca/fr_fr/resources.php` | `php` | 17 |  |
| `game/loca/fr_fr/search.php` | `php` | 25 |  |
| `game/loca/fr_fr/statistics.php` | `php` | 0 |  |
| `game/loca/fr_fr/techlong.php` | `php` | 0 |  |
| `game/loca/fr_fr/technames.php` | `php` | 67 |  |
| `game/loca/fr_fr/techshort.php` | `php` | 67 |  |
| `game/loca/fr_fr/techtree.php` | `php` | 15 |  |
| `game/loca/fr_fr/trader.php` | `php` | 0 |  |
| `game/loca/fr_fr/union.php` | `php` | 13 |  |
| `game/loca/it_it/.htaccess` | `htaccess` | 0 |  |
| `game/loca/it_it/admin.php` | `php` | 209 |  |
| `game/loca/it_it/ainfo.php` | `php` | 12 |  |
| `game/loca/it_it/ally.php` | `php` | 232 |  |
| `game/loca/it_it/battlereport.php` | `php` | 62 |  |
| `game/loca/it_it/buddy.php` | `php` | 33 |  |
| `game/loca/it_it/build.php` | `php` | 45 |  |
| `game/loca/it_it/changelog.php` | `php` | 891 |  |
| `game/loca/it_it/common.php` | `php` | 51 |  |
| `game/loca/it_it/coupons.php` | `php` | 8 |  |
| `game/loca/it_it/debug.php` | `php` | 18 |  |
| `game/loca/it_it/empire.php` | `php` | 20 |  |
| `game/loca/it_it/espionage.php` | `php` | 23 |  |
| `game/loca/it_it/events.php` | `php` | 54 |  |
| `game/loca/it_it/expedition.php` | `php` | 112 |  |
| `game/loca/it_it/fleet.php` | `php` | 134 |  |
| `game/loca/it_it/fleetmsg.php` | `php` | 44 |  |
| `game/loca/it_it/fleetorder.php` | `php` | 17 |  |
| `game/loca/it_it/galaxy.php` | `php` | 131 |  |
| `game/loca/it_it/graviton.php` | `php` | 43 |  |
| `game/loca/it_it/infos.php` | `php` | 60 |  |
| `game/loca/it_it/install.php` | `php` | 68 |  |
| `game/loca/it_it/jumpgate.php` | `php` | 19 |  |
| `game/loca/it_it/maintain.php` | `php` | 11 |  |
| `game/loca/it_it/menu.php` | `php` | 58 |  |
| `game/loca/it_it/messages.php` | `php` | 53 |  |
| `game/loca/it_it/notes.php` | `php` | 38 |  |
| `game/loca/it_it/options.php` | `php` | 93 |  |
| `game/loca/it_it/overview.php` | `php` | 22 |  |
| `game/loca/it_it/phalanx.php` | `php` | 11 |  |
| `game/loca/it_it/pranger.php` | `php` | 17 |  |
| `game/loca/it_it/premium.php` | `php` | 42 |  |
| `game/loca/it_it/raketen.php` | `php` | 13 |  |
| `game/loca/it_it/reg.php` | `php` | 142 |  |
| `game/loca/it_it/renameplanet.php` | `php` | 21 |  |
| `game/loca/it_it/resources.php` | `php` | 17 |  |
| `game/loca/it_it/search.php` | `php` | 26 |  |
| `game/loca/it_it/statistics.php` | `php` | 24 |  |
| `game/loca/it_it/techlong.php` | `php` | 102 |  |
| `game/loca/it_it/technames.php` | `php` | 69 |  |
| `game/loca/it_it/techshort.php` | `php` | 67 |  |
| `game/loca/it_it/techtree.php` | `php` | 15 |  |
| `game/loca/it_it/trader.php` | `php` | 22 |  |
| `game/loca/it_it/union.php` | `php` | 13 |  |
| `game/loca/jp_jp/common.php` | `php` | 51 |  |
| `game/loca/jp_jp/events.php` | `php` | 54 |  |
| `game/loca/jp_jp/fleetorder.php` | `php` | 18 |  |
| `game/loca/jp_jp/menu.php` | `php` | 34 |  |
| `game/loca/jp_jp/overview.php` | `php` | 22 |  |
| `game/loca/jp_jp/reg.php` | `php` | 139 |  |
| `game/loca/jp_jp/technames.php` | `php` | 67 |  |
| `game/loca/ru_ru/.htaccess` | `htaccess` | 0 |  |
| `game/loca/ru_ru/admin.php` | `php` | 550 |  |
| `game/loca/ru_ru/ainfo.php` | `php` | 12 |  |
| `game/loca/ru_ru/ally.php` | `php` | 231 |  |
| `game/loca/ru_ru/battlereport.php` | `php` | 61 |  |
| `game/loca/ru_ru/buddy.php` | `php` | 33 |  |
| `game/loca/ru_ru/build.php` | `php` | 70 |  |
| `game/loca/ru_ru/changelog.php` | `php` | 891 |  |
| `game/loca/ru_ru/common.php` | `php` | 51 |  |
| `game/loca/ru_ru/coupons.php` | `php` | 18 |  |
| `game/loca/ru_ru/debug.php` | `php` | 49 |  |
| `game/loca/ru_ru/empire.php` | `php` | 20 |  |
| `game/loca/ru_ru/espionage.php` | `php` | 23 |  |
| `game/loca/ru_ru/events.php` | `php` | 54 |  |
| `game/loca/ru_ru/expedition.php` | `php` | 112 |  |
| `game/loca/ru_ru/fleet.php` | `php` | 138 |  |
| `game/loca/ru_ru/fleetmsg.php` | `php` | 43 |  |
| `game/loca/ru_ru/fleetorder.php` | `php` | 18 |  |
| `game/loca/ru_ru/galaxy.php` | `php` | 131 |  |
| `game/loca/ru_ru/graviton.php` | `php` | 42 |  |
| `game/loca/ru_ru/infos.php` | `php` | 60 |  |
| `game/loca/ru_ru/install.php` | `php` | 69 |  |
| `game/loca/ru_ru/jumpgate.php` | `php` | 19 |  |
| `game/loca/ru_ru/maintain.php` | `php` | 11 |  |
| `game/loca/ru_ru/menu.php` | `php` | 58 |  |
| `game/loca/ru_ru/messages.php` | `php` | 53 |  |
| `game/loca/ru_ru/notes.php` | `php` | 38 |  |
| `game/loca/ru_ru/options.php` | `php` | 96 |  |
| `game/loca/ru_ru/overview.php` | `php` | 22 |  |
| `game/loca/ru_ru/phalanx.php` | `php` | 11 |  |
| `game/loca/ru_ru/pranger.php` | `php` | 17 |  |
| `game/loca/ru_ru/premium.php` | `php` | 54 |  |
| `game/loca/ru_ru/raketen.php` | `php` | 13 |  |
| `game/loca/ru_ru/reg.php` | `php` | 139 |  |
| `game/loca/ru_ru/renameplanet.php` | `php` | 21 |  |
| `game/loca/ru_ru/resources.php` | `php` | 17 |  |
| `game/loca/ru_ru/search.php` | `php` | 26 |  |
| `game/loca/ru_ru/statistics.php` | `php` | 24 |  |
| `game/loca/ru_ru/techlong.php` | `php` | 67 |  |
| `game/loca/ru_ru/technames.php` | `php` | 69 |  |
| `game/loca/ru_ru/techshort.php` | `php` | 67 |  |
| `game/loca/ru_ru/techtree.php` | `php` | 15 |  |
| `game/loca/ru_ru/trader.php` | `php` | 22 |  |
| `game/loca/ru_ru/union.php` | `php` | 14 |  |
| `game/maintenance.php` | `php` | 118 |  |
| `game/mods/.gitignore` | `gitignore` | 0 |  |
| `game/mods/BogusMod/img/bg.png` | `png` | 0 |  |
| `game/mods/BogusMod/img/tritium.png` | `png` | 0 |  |
| `game/mods/BogusMod/loca/.htaccess` | `htaccess` | 0 |  |
| `game/mods/BogusMod/loca/ru_ru/.htaccess` | `htaccess` | 0 |  |
| `game/mods/BogusMod/loca/ru_ru/bogusmod.php` | `php` | 7 |  |
| `game/mods/BogusMod/main.php` | `php` | 113 | `BogusMod`, `install`, `uninstall`, `init`, `route`, `update_queue`, `add_resources`, `add_menuitems`, `install_tabs_included` |
| `game/mods/BogusMod/manifest.json` | `json` | 7 |  |
| `game/mods/BogusMod/pages/.htaccess` | `htaccess` | 0 |  |
| `game/mods/BogusMod/pages/tipoftheday.php` | `php` | 1 |  |
| `game/mods/BogusMod/Readme.md` | `md` | 17 |  |
| `game/mods/DeepSpaceHorror/img/1.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/10.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/11.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/12.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/13.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/14.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/15.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/16.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/17.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/18.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/2.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/3.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/4.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/5.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/6.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/7.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/8.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/9.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/ameoba_defeat.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/amoeba.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/bg.png` | `png` | 0 |  |
| `game/mods/DeepSpaceHorror/img/bg1.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/bg2.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/bg3.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/bg4.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/guardian.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/guardian_defeat.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/leviathan.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/leviathan_defeat.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/img/portal.jpg` | `jpg` | 0 |  |
| `game/mods/DeepSpaceHorror/loca/.htaccess` | `htaccess` | 0 |  |
| `game/mods/DeepSpaceHorror/loca/ru_ru/.htaccess` | `htaccess` | 0 |  |
| `game/mods/DeepSpaceHorror/loca/ru_ru/leviathans.php` | `php` | 44 |  |
| `game/mods/DeepSpaceHorror/main.php` | `php` | 742 | `DeepSpaceHorror`, `install`, `uninstall`, `install_tabs_included`, `init`, `get_planet_small_image`, `get_planet_image`, `get_object_image`, `CreateLeviathan`, `DeterminePortalCoords`, `DispatchLeviathan`, `IsPlanetLeviathan`, `page_flotten2_planet_types`, `page_flottenversand_ajax_spy_planets`, `page_galaxy_custom_object`, `GetLeviathanOverlib`, `fleet_handler`, `LeviathanArrive`, `LeviathanBattle` |
| `game/mods/DeepSpaceHorror/manifest.json` | `json` | 7 |  |
| `game/mods/DeepSpaceHorror/Readme.md` | `md` | 667 |  |
| `game/mods/GalaxyTool/img/1.jpg` | `jpg` | 0 |  |
| `game/mods/GalaxyTool/img/admin_galaxytool.png` | `png` | 0 |  |
| `game/mods/GalaxyTool/img/bg.jpg` | `jpg` | 0 |  |
| `game/mods/GalaxyTool/img/bg.png` | `png` | 0 |  |
| `game/mods/GalaxyTool/loca/.htaccess` | `htaccess` | 0 |  |
| `game/mods/GalaxyTool/loca/de_de/.htaccess` | `htaccess` | 0 |  |
| `game/mods/GalaxyTool/loca/de_de/galaxytool.php` | `php` | 22 |  |
| `game/mods/GalaxyTool/loca/en_en/.htaccess` | `htaccess` | 0 |  |
| `game/mods/GalaxyTool/loca/en_en/galaxytool.php` | `php` | 22 |  |
| `game/mods/GalaxyTool/loca/es_es/.htaccess` | `htaccess` | 0 |  |
| `game/mods/GalaxyTool/loca/es_es/galaxytool.php` | `php` | 22 |  |
| `game/mods/GalaxyTool/loca/fr_fr/.htaccess` | `htaccess` | 0 |  |
| `game/mods/GalaxyTool/loca/fr_fr/galaxytool.php` | `php` | 22 |  |
| `game/mods/GalaxyTool/loca/it_it/.htaccess` | `htaccess` | 0 |  |
| `game/mods/GalaxyTool/loca/it_it/galaxytool.php` | `php` | 22 |  |
| `game/mods/GalaxyTool/loca/ru_ru/.htaccess` | `htaccess` | 0 |  |
| `game/mods/GalaxyTool/loca/ru_ru/galaxytool.php` | `php` | 25 |  |
| `game/mods/GalaxyTool/main.php` | `php` | 212 | `GalaxyTool`, `install`, `uninstall`, `init`, `install_tabs_included`, `route`, `update_queue`, `add_menuitems`, `GalaxyToolUpdateGalaxy`, `GalaxyToolUpdateStats`, `GalaxyToolUpdateAllyStats`, `GalaxyToolReplaceOldStats`, `GalaxyToolReplaceOldAllyStats`, `GalaxyToolUpdate`, `route_admin` |
| `game/mods/GalaxyTool/manifest.json` | `json` | 7 |  |
| `game/mods/GalaxyTool/pages/.htaccess` | `htaccess` | 0 |  |
| `game/mods/GalaxyTool/pages/galaxytool.php` | `php` | 236 | `PlayerDetails` |
| `game/mods/GalaxyTool/pages_admin/.htaccess` | `htaccess` | 0 |  |
| `game/mods/GalaxyTool/pages_admin/admin_galaxytool.php` | `php` | 45 | `Admin_GalaxyTool`, `controller`, `view` |
| `game/mods/SpaceStorm/img/bg.png` | `png` | 0 |  |
| `game/mods/SpaceStorm/img/reality_stab.png` | `png` | 0 |  |
| `game/mods/SpaceStorm/img/reality_stab_orig.png` | `png` | 0 |  |
| `game/mods/SpaceStorm/img/storm_ikon.png` | `png` | 0 |  |
| `game/mods/SpaceStorm/img/storm_ikon_un.png` | `png` | 0 |  |
| `game/mods/SpaceStorm/loca/.htaccess` | `htaccess` | 0 |  |
| `game/mods/SpaceStorm/loca/ru_ru/.htaccess` | `htaccess` | 0 |  |
| `game/mods/SpaceStorm/loca/ru_ru/space_storm.php` | `php` | 67 |  |
| `game/mods/SpaceStorm/main.php` | `php` | 686 | `SpaceStorm`, `install`, `uninstall`, `install_tabs_included`, `init`, `update_queue`, `get_object_image`, `add_bonuses`, `can_build`, `build_end`, `page_buildings_get_bonus`, `page_infos`, `bonus_technology`, `NewStorm`, `GetStorm`, `SetStorm`, `CountStormBits`, `GetStabLevelMask`, `GetStormQueue`, `add_db_row`, `page_flotten1_get_bonus`, `page_overview_get_bonus`, `page_resources_get_bonus`, `GetStormBonuses`, `bonus_prod`, `prod_post_process`, `battle_post_process`, `bonus_fleet_cons`, `bonus_fleet_speed`, `fleet_available_missions` |
| `game/mods/SpaceStorm/manifest.json` | `json` | 7 |  |
| `game/mods/SpaceStorm/Readme.md` | `md` | 310 |  |
| `game/pages/.htaccess` | `htaccess` | 0 |  |
| `game/pages/ainfo.php` | `php` | 41 |  |
| `game/pages/allianzdepot.php` | `php` | 65 |  |
| `game/pages/allianzen.php` | `php` | 198 | `AllyPage_NoAlly`, `AllyPage_CreateAlly`, `AllyPage_Search`, `AllyPage_SearchResult`, `AllyPage_Already` |
| `game/pages/allianzen_circular.php` | `php` | 99 | `AllyPage_CircularMessage` |
| `game/pages/allianzen_main.php` | `php` | 81 | `AllyPage_Home` |
| `game/pages/allianzen_members.php` | `php` | 197 | `PageAlly_MemberList`, `PageAlly_MemberSettings` |
| `game/pages/allianzen_misc.php` | `php` | 312 | `PageAlly_Leave`, `PageAlly_ChangeTag`, `PageAlly_ChangeName`, `PageAlly_Dismiss`, `AllyPage_Takeover` |
| `game/pages/allianzen_ranks.php` | `php` | 144 | `PageAlly_Ranks` |
| `game/pages/allianzen_settings.php` | `php` | 146 | `as_sel`, `PageAlly_Settings` |
| `game/pages/b_building.php` | `php` | 251 | `B_Building`, `controller`, `view`, `t`, `GetBuildingsBonus`, `ShowBuildingsBonus` |
| `game/pages/bericht.php` | `php` | 45 |  |
| `game/pages/bewerben.php` | `php` | 72 |  |
| `game/pages/bewerbungen.php` | `php` | 128 |  |
| `game/pages/buddy.php` | `php` | 271 | `Buddy_Home`, `Buddy_Income`, `Buddy_Outcome`, `Buddy_Request` |
| `game/pages/buildings.php` | `php` | 607 | `Buildings`, `controller`, `view`, `t`, `t`, `xd`, `GetBuildingsBonus`, `ShowBuildingsBonus` |
| `game/pages/changelog.php` | `php` | 42 |  |
| `game/pages/event_list.php` | `php` | 155 | `OverFleet`, `TitleFleet`, `PlayerDetails`, `PlanetFrom`, `PlanetTo`, `PlanetOn`, `Cargo`, `GetMission` |
| `game/pages/fleet_templates.php` | `php` | 152 | `show_input` |
| `game/pages/flotten1.php` | `php` | 423 | `FleetMissionText`, `GetFleetBonuses` |
| `game/pages/flotten2.php` | `php` | 231 | `getStorageFaktor`, `planettype` |
| `game/pages/flotten3.php` | `php` | 299 | `getStorageFaktor`, `is_checked`, `is_selected` |
| `game/pages/flottenversand.php` | `php` | 402 | `FleetError` |
| `game/pages/flottenversand_ajax.php` | `php` | 197 | `AjaxSendError`, `AjaxSendDone` |
| `game/pages/galaxy.php` | `php` | 580 | `ShowCustomObjects`, `empty_row` |
| `game/pages/galaxy_js.php` | `php` | 222 | `galaxy_submit`, `fenster`, `mouseX`, `mouseY`, `whenLoading`, `whenLoaded`, `whenInteractive`, `whenResponse`, `doit`, `addToTable`, `changeSlots`, `setShips`, `cursorevent` |
| `game/pages/imperium.php` | `php` | 493 |  |
| `game/pages/infos.php` | `php` | 533 | `rgnum`, `rapidIn`, `rapidOut`, `rapid`, `IsDefenseShoot` |
| `game/pages/leftmenu.json` | `json` | 194 |  |
| `game/pages/logout.php` | `php` | 24 |  |
| `game/pages/messages.php` | `php` | 277 |  |
| `game/pages/micropayment.php` | `php` | 269 | `OfficerLeft` |
| `game/pages/notizen.php` | `php` | 132 | `Notizen`, `controller`, `view`, `CreateNewNote`, `EditNote` |
| `game/pages/options.php` | `php` | 632 | `IsChecked`, `IsCheckedFlag`, `IsSelected` |
| `game/pages/overview.php` | `php` | 212 | `Overview`, `controller`, `view`, `t_building` |
| `game/pages/overview_events.php` | `php` | 462 | `FleetSpanAttack`, `FleetSpanAcsAttack`, `FleetSpanTransport`, `FleetSpanDeploy`, `FleetSpanAcsHold`, `FleetSpanSpy`, `FleetSpanColonize`, `FleetSpanRecycle`, `FleetSpanDestroy`, `FleetSpanAcsAttackHead`, `FleetSpanExpedition`, `FleetSpanMissile`, `FleetSpan`, `GetDirectionAssignment`, `EventList` |
| `game/pages/payment.php` | `php` | 93 |  |
| `game/pages/phalanx.php` | `php` | 115 |  |
| `game/pages/phalanx_events.php` | `php` | 366 | `FleetSpanAttack`, `FleetSpanAcsAttack`, `FleetSpanTransport`, `FleetSpanDeploy`, `FleetSpanAcsHold`, `FleetSpanSpy`, `FleetSpanColonize`, `FleetSpanRecycle`, `FleetSpanDestroy`, `FleetSpanAcsAttackHead`, `FleetSpanExpedition`, `FleetSpanMissile`, `FleetSpanCustom`, `FleetSpan`, `PhalanxEventList` |
| `game/pages/pranger.php` | `php` | 63 | `MyDate` |
| `game/pages/renameplanet.php` | `php` | 141 | `PlanetDestroyMenu` |
| `game/pages/res_panel.json` | `json` | 40 |  |
| `game/pages/resources.php` | `php` | 325 | `Resources`, `controller`, `GetResourceBonus`, `view`, `get_prod`, `prod_select`, `nicenum2`, `rgnum`, `DisplayTotalProduction`, `DisplayFacilityProduction`, `DisplayStorages` |
| `game/pages/sprungtor.php` | `php` | 84 |  |
| `game/pages/statistics.php` | `php` | 290 |  |
| `game/pages/suche.php` | `php` | 183 | `search_selected` |
| `game/pages/techtree.php` | `php` | 92 | `Techtree`, `controller`, `view`, `MeetRequirement` |
| `game/pages/techtreedetails.php` | `php` | 94 | `Techtreedetails`, `controller`, `view`, `walk_tree`, `MeetRequirement` |
| `game/pages/trader.php` | `php` | 501 | `CallNewTrader`, `is_selected`, `number_format`, `setStorage`, `setValue`, `getValue`, `calcCosts`, `calcInputFromCosts`, `displayOfferCosts`, `getFreeOfferCosts`, `addOfferCosts`, `checkValue`, `setMaxValue` |
| `game/pages/writemessages.php` | `php` | 110 | `SendNotActivated` |
| `game/pages_admin/.htaccess` | `htaccess` | 0 |  |
| `game/pages_admin/admin.php` | `php` | 71 |  |
| `game/pages_admin/admin_bans.php` | `php` | 205 | `Admin_Bans`, `controller`, `view`, `SetClearCheckbox` |
| `game/pages_admin/admin_battle.php` | `php` | 67 | `Admin_BattleReport`, `controller`, `view` |
| `game/pages_admin/admin_botedit.php` | `php` | 262 | `Admin_Botedit`, `controller`, `view` |
| `game/pages_admin/admin_bots.php` | `php` | 86 | `Admin_Bots`, `controller`, `view` |
| `game/pages_admin/admin_broadcast.php` | `php` | 80 | `Admin_Broadcast`, `controller`, `view` |
| `game/pages_admin/admin_browse.php` | `php` | 46 | `Admin_Browse`, `controller`, `view` |
| `game/pages_admin/admin_checksum.php` | `php` | 265 | `Admin_Checksum`, `controller`, `view` |
| `game/pages_admin/admin_colony_settings.php` | `php` | 75 | `Admin_ColonySettings`, `controller`, `view` |
| `game/pages_admin/admin_coupons.php` | `php` | 145 | `Admin_Coupons`, `controller`, `view` |
| `game/pages_admin/admin_db.php` | `php` | 229 | `Admin_DB`, `controller`, `view`, `DiffTab`, `ListDatabaseBackups`, `CreateBackup`, `DeleteBackup`, `RestoreBackup` |
| `game/pages_admin/admin_debug.php` | `php` | 100 | `Admin_Debug`, `controller`, `view` |
| `game/pages_admin/admin_errors.php` | `php` | 85 | `Admin_Errors`, `controller`, `view` |
| `game/pages_admin/admin_expedition.php` | `php` | 251 | `Admin_Expedition`, `controller`, `view` |
| `game/pages_admin/admin_fleetlogs.php` | `php` | 199 | `Admin_Fleetlogs`, `controller`, `view` |
| `game/pages_admin/admin_home.php` | `php` | 59 | `Admin_Home`, `controller`, `view` |
| `game/pages_admin/admin_loca.php` | `php` | 158 | `Admin_Loca`, `controller`, `view`, `CompareTwoLocas` |
| `game/pages_admin/admin_logins.php` | `php` | 116 | `Admin_Logins`, `controller`, `view` |
| `game/pages_admin/admin_mods.php` | `php` | 270 | `Admin_Mods`, `controller`, `view`, `GenModPanelSource` |
| `game/pages_admin/admin_panel.php` | `php` | 38 | `AdminPanel` |
| `game/pages_admin/admin_planets.php` | `php` | 562 | `Admin_Planets`, `controller`, `view`, `php_str_replace`, `spio`, `reset` |
| `game/pages_admin/admin_queue.php` | `php` | 232 | `Admin_Queue`, `controller`, `view`, `QueueDesc`, `QueueFrozenDesc` |
| `game/pages_admin/admin_raksim.php` | `php` | 143 | `Admin_Raksim`, `controller`, `view` |
| `game/pages_admin/admin_reports.php` | `php` | 75 | `Admin_Reports`, `controller`, `view` |
| `game/pages_admin/admin_router.json` | `json` | 139 |  |
| `game/pages_admin/admin_sim.php` | `php` | 591 | `Admin_BattleSim`, `controller`, `view`, `toint`, `RecalcAttackersDefendersNum`, `OnChangeSlot`, `OnChangeValue`, `OnChangeTechValue`, `ParseBattleDataSource`, `get_intval`, `SimBattle` |
| `game/pages_admin/admin_uni.php` | `php` | 238 | `Admin_Uni`, `controller`, `view`, `UniIsSelected`, `UniIsChecked` |
| `game/pages_admin/admin_userlogs.php` | `php` | 104 | `Admin_Userlogs`, `controller`, `view` |
| `game/pages_admin/admin_users.php` | `php` | 597 | `Admin_Users`, `controller`, `view`, `LinkFleetsFrom`, `LinkFleetsTo`, `IsChecked`, `IsSelected` |
| `game/pic.php` | `php` | 29 |  |
| `game/pranger.php` | `php` | 11 |  |
| `game/redir.php` | `php` | 26 |  |
| `game/reg/check_registration.php` | `php` | 15 |  |
| `game/reg/errorpage.php` | `php` | 67 |  |
| `game/reg/fa_pass.php` | `php` | 80 | `EmailExist` |
| `game/reg/formate.css` | `css` | 29 |  |
| `game/reg/login.jpg` | `jpg` | 0 |  |
| `game/reg/login.php` | `php` | 73 |  |
| `game/reg/login2.php` | `php` | 40 | `to_utf8` |
| `game/reg/mail.php` | `php` | 48 |  |
| `game/reg/new.php` | `php` | 252 | `printMessage` |
| `game/reg/newredirect.php` | `php` | 70 |  |
| `game/reg/stinger-me.jpg` | `jpg` | 0 |  |
| `game/router.json` | `json` | 180 |  |
| `game/temp/.htaccess` | `htaccess` | 0 |  |
| `game/temp/engine.md5` | `md5` | 0 |  |
| `game/temp/page.md5` | `md5` | 0 |  |
| `game/temp/page_admin.md5` | `md5` | 0 |  |
| `game/temp/reg.md5` | `md5` | 0 |  |
| `game/validate.php` | `php` | 22 |  |
