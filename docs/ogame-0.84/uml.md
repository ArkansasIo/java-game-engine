# OGame 0.84 UML

These diagrams are Mermaid UML/flow diagrams derived from `ogamespec/ogame-opensource/game`.

## Request Routing

```mermaid
flowchart TD
  Browser[Browser request] --> Index[game/index.php]
  Index --> Config[config.php]
  Index --> Core[core/core.php]
  Core --> DB[InitDB]
  Core --> Uni[LoadUniverse]
  Index --> Params[CheckParams]
  Params --> Auth[AuthUser or public user]
  Auth --> Mods[ModsInit]
  Mods --> Router[router.json + mod route hooks]
  Router --> Queue[UpdateQueue]
  Queue --> Planet[GetUpdatePlanet + UpdatePlanetActivity]
  Planet --> Route{MVC route?}
  Route -->|yes| PageClass[Page subclass controller/view]
  Route -->|no| Include[Old-style page include]
  PageClass --> Render[PageHeader/BeginContent/PageFooter]
  Include --> Render
```

## Core Package Map

```mermaid
flowchart LR
  index[index.php] --> core[core/core.php]
  core --> db[db.php]
  core --> user[user.php]
  core --> uni[uni.php]
  core --> planet[planet.php]
  core --> prod[prod.php]
  core --> queue[queue.php]
  core --> fleet[fleet.php]
  core --> battle[battle.php + battle_engine.php]
  core --> page[page.php]
  core --> mods[mods.php]
  core --> loca[loca.php]
  pages[pages/*] --> core
  admin[pages_admin/*] --> core
  modsDir[mods/*] --> mods
```

## Page and Mod Classes

```mermaid
classDiagram
  class Page {
    <<abstract>>
    +controller() bool
    +view() void
  }
  class Overview
  class Resources
  class Buildings
  class B_Building
  class Notizen
  class Techtree
  class Techtreedetails
  Page <|-- Overview
  Page <|-- Resources
  Page <|-- Buildings
  Page <|-- B_Building
  Page <|-- Notizen
  Page <|-- Techtree
  Page <|-- Techtreedetails

  class GameMod {
    <<abstract>>
    +install() void
    +uninstall() void
    +init() void
    +route(router) bool
    +update_queue(queue) bool
  }
  class BogusMod
  class GalaxyTool
  class SpaceStorm
  class DeepSpaceHorror
  GameMod <|-- BogusMod
  GameMod <|-- GalaxyTool
  GameMod <|-- SpaceStorm
  GameMod <|-- DeepSpaceHorror
```

## Queue System

```mermaid
flowchart TD
  Action[Player/admin/mod action] --> Enqueue[Queue row inserted]
  Enqueue --> DB[(queue table)]
  PageRequest[Authenticated page request or CRON] --> UpdateQueue[UpdateQueue until now]
  UpdateQueue --> DueRows[Load due rows]
  DueRows --> Dispatch{Queue type}
  Dispatch --> Build[Queue_Build_End]
  Dispatch --> Shipyard[Queue_Shipyard_End]
  Dispatch --> Research[Queue_Research_End]
  Dispatch --> Fleet[Queue_Fleet_End]
  Dispatch --> Admin[Ban/email/stats/cleanup/bot/coupon handlers]
  Dispatch --> ModHook[ModsExec update_queue]
  Build --> State[(planet/user stats)]
  Shipyard --> State
  Research --> State
  Fleet --> State
  Admin --> State
  ModHook --> State
```

## Fleet Mission Logic

```mermaid
flowchart TD
  FleetPage[Fleet pages] --> Availability[FleetAvailableMissions]
  Availability --> Dispatch[DispatchFleet]
  Dispatch --> QueueFleet[Create fleet + queue event]
  QueueFleet --> Arrival[Queue_Fleet_End]
  Arrival --> Mission{Mission type}
  Mission --> Attack[Attack / ACS attack]
  Mission --> Transport[Transport]
  Mission --> Deploy[Deploy]
  Mission --> Hold[ACS hold]
  Mission --> Spy[Espionage]
  Mission --> Colonize[Colonize]
  Mission --> Recycle[Recycle debris]
  Mission --> Destroy[Moon destruction]
  Mission --> Expedition[Expedition]
  Mission --> Missile[Missile attack]
  Attack --> Battle[StartBattle]
  Spy --> Battle
  Battle --> Return[Return or finish fleet]
  Transport --> Return
  Expedition --> Return
```

## Battle Simulation

```mermaid
flowchart TD
  StartBattle[StartBattle] --> Source[GenBattleSourceData]
  Source --> Engine[BattleEngine / DoBattle]
  Engine --> Init[InitBattle]
  Init --> Rounds{up to max rounds}
  Rounds --> Shoot[UnitShoot]
  Shoot --> RF[RapidFire check]
  RF --> Explode[Explosion chance]
  Explode --> Wipe[WipeExploded]
  Wipe --> Shields[ChargeShields]
  Shields --> Rounds
  Rounds --> Result[Battle result]
  Result --> Post[PostProcessBattleResult]
  Post --> Repair[RepairDefense]
  Post --> Plunder[Plunder]
  Post --> Debris[CalcDebris]
  Post --> Writeback[WritebackBattleResults]
  Writeback --> Report[BattleReport]
```

## Economy and Construction

```mermaid
flowchart TD
  Planet[Planet state] --> Prod[ProdResources]
  User[User/officers/tech] --> Prod
  Uni[Universe speed/settings] --> Prod
  Mods[Mod production hooks] --> Prod
  Prod --> Resources[Metal crystal deuterium energy]
  Resources --> BuildCheck[Can build/research/shipyard]
  BuildCheck --> BuildEnque[BuildEnque or shipyard/research queue]
  BuildEnque --> Queue[Queue handlers]
  Queue --> Apply[Update planet fields and stats]
  Apply --> Planet
```

## Persistence

```mermaid
flowchart LR
  DB[(MySQL)]
  dbphp[core/db.php] --> DB
  user[user.php] --> dbphp
  planet[planet.php] --> dbphp
  queue[queue.php] --> dbphp
  fleet[fleet.php] --> dbphp
  battle[battle.php] --> dbphp
  ally[ally*.php] --> dbphp
  admin[pages_admin/*] --> dbphp
```

## Stellar RTS/4X/MMORPG Campaign Model

This optional design layer extends the OGame reference material with a fictional large-scale campaign structure: 12 acts, 50 chapters per act, 35 required detail elements per chapter, and 90 world-system classes. See [Stellar RTS/4X/MMORPG Campaign and Systems Blueprint](stellar-rts-4x-design.md) for the full 600-chapter grid and class table.

```mermaid
classDiagram
  class Campaign {
    +Act[12] acts
    +ClassTaxonomy taxonomy
    +InterfaceModel ui
  }
  class Act {
    +int actNumber
    +string theme
    +Chapter[50] chapters
  }
  class Chapter {
    +int chapterNumber
    +string title
    +string phase
    +ChapterElement[35] requiredElements
  }
  class ChapterElement {
    +string name
    +string value
    +bool resolved
  }
  Campaign "1" --> "12" Act
  Act "1" --> "50" Chapter
  Chapter "1" --> "35" ChapterElement
```

## 90-Class World-System Taxonomy

```mermaid
classDiagram
  class WorldSystemTaxonomy
  class Weapons {
    +KineticSmallArms
    +KineticHeavyArms
    +DirectedEnergyArms
    +PlasmaWeapons
    +ParticleWeapons
    +MissileWeapons
    +DroneWeapons
    +MeleeWeapons
    +SiegeWeapons
    +OrbitalWeapons
    +ElectronicWarfare
    +Bioweapons
    +PsionicWeapons
    +RelicWeapons
    +ImprovisedWeapons
  }
  class Shields {
    +DeflectorShields
    +EnergyShields
    +KineticShields
    +ThermalShields
    +PointDefenseShields
    +PsionicWards
    +AdaptiveShields
    +VoidShields
    +BioShields
    +PlanetaryShields
  }
  class Armors {
    +CivilFabricArmor
    +CompositeArmor
    +ReactiveArmor
    +CeramicArmor
    +PoweredArmor
    +NanoArmor
    +VoidArmor
    +BioArmor
    +StealthArmor
    +TitanArmor
  }
  class Units {
    +CivilianWorkers
    +Engineers
    +Militia
    +LineInfantry
    +HeavyInfantry
    +ReconUnits
    +SpecialForces
    +Medics
    +ArmorUnits
    +ArtilleryUnits
    +AirUnits
    +NavalUnits
    +SpaceUnits
    +AutonomousUnits
    +HeroUnits
  }
  class MilitarySystems
  class CivilSystems
  class GovernmentSystems
  class Buildings
  WorldSystemTaxonomy --> Weapons
  WorldSystemTaxonomy --> Shields
  WorldSystemTaxonomy --> Armors
  WorldSystemTaxonomy --> Units
  WorldSystemTaxonomy --> MilitarySystems
  WorldSystemTaxonomy --> CivilSystems
  WorldSystemTaxonomy --> GovernmentSystems
  WorldSystemTaxonomy --> Buildings
```

## Hybrid UI Interface

```mermaid
flowchart TD
  Player[Player] --> Shell[Unified Command Shell]
  Shell --> Galaxy[Galaxy 4X View]
  Shell --> System[System View]
  Shell --> Planet[Planet Management View]
  Shell --> Commander[RTS Commander View]
  Shell --> Avatar[MMORPG Character View]
  Shell --> Government[Government View]
  Shell --> Economy[Economy View]
  Shell --> WarRoom[War Room]

  Galaxy --> Diplomacy[Diplomacy, borders, claims, hyperlanes]
  Galaxy --> Fleets[Strategic fleets and exploration]
  System --> Orbitals[Stations, lanes, battles, anomalies]
  Planet --> Districts[Districts, buildings, population, stability]
  Commander --> Units[Selection, control groups, abilities, formations]
  Avatar --> Gear[Class, equipment, quests, guild/faction reputation]
  Government --> Laws[Laws, policies, leaders, espionage]
  Economy --> Markets[Resources, trade, logistics, upkeep]
  WarRoom --> Fronts[Objectives, invasions, occupations, rally points]

  Fleets --> WarRoom
  Districts --> Economy
  Laws --> Economy
  Units --> WarRoom
  Gear --> Commander
```

## UI State Machine

```mermaid
stateDiagram-v2
  [*] --> GalaxyView
  GalaxyView --> SystemView: select star system
  SystemView --> PlanetView: select planet
  SystemView --> CommanderView: enter tactical battle
  PlanetView --> EconomyView: inspect production
  PlanetView --> GovernmentView: inspect policies
  GalaxyView --> DiplomacyView: select empire/faction
  GalaxyView --> WarRoom: active war/crisis
  CommanderView --> CharacterView: select hero/avatar
  CharacterView --> CommanderView: return to command
  EconomyView --> PlanetView: close economy panel
  GovernmentView --> GalaxyView: apply empire policy
  WarRoom --> CommanderView: jump to battle
  WarRoom --> GalaxyView: strategic map
```

## OpenRA C# Scaffold Map

```mermaid
flowchart LR
  Catalog[OGameCatalog] --> Features[Feature Catalog]
  Catalog --> Elements[35 Chapter Elements]
  Catalog --> Classes[90 System Classes]
  Types[OGameTypes] --> Resources[OGameResources]
  Economy[OGameEconomy] --> Production[Production and Building Cost]
  Economy --> Queue[Queue Processor]
  Fleet[OGameFleetLogic] --> Missions[Fleet Distance, Fuel, Missions]
  Battle[OGameBattleSimulator] --> Combat[Round Combat and Debris]
  Campaign[OGameCampaignFactory] --> Acts[12 Acts]
  Acts --> Chapters[600 Chapters]
  Interface[OGameInterfaceModel] --> Views[Hybrid UI Views]
  Interface --> Transitions[UI State Transitions]
```
