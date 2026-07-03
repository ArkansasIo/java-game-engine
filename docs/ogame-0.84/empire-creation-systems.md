# Empire Creation, DLC, Account, and Multiplayer Systems

This document defines the first playable shell for `UniversCivilization: Empire at War`: account creation on launch, new empire creation, ten races, ten governments, DLC/expansion toggles, patch/info log, and up to eight-player online empire campaigns.

## Start Game Flow

| Step | Menu | Purpose |
|---|---|---|
| 1 | Account Creation | Create or select a local/online commander profile before entering menus. |
| 2 | Stellar Command | Main menu with New Empire, Load Empire, Online 8 Player, DLC/Expansions, Patch and Info Log, Settings, and Exit. |
| 3 | New Empire | Choose race, government, origin, home system, flag, colors, commander class, galaxy rules, and difficulty. |
| 4 | Galaxy Preview | Show hyperlanes, player slots, AI empires, fallen powers, crisis timing, resource density, and DLC rule locks. |
| 5 | Launch | Start single-player, host online, or save the empire preset to the library. |

## Ten Playable Races

| Race | Role | Main Bonus |
|---|---|---|
| Solar Humans | Adaptive republic builders | Construction speed and envoy flexibility |
| Aurelian Ascendancy | Energy aristocrats | Strong energy economy and shields |
| Kaidran Clans | Desert survival raiders | Armor and hostile-world mining |
| Nyxian Synod | Covert psionic diplomats | Espionage and infiltration |
| Vorik Combine | Cybernetic megacorporation | Trade and market control |
| Thalassid Tides | Aquatic colony engineers | Life support and terraforming |
| Ornyx Legion | Carrier-focused militarists | Fighters and strike craft |
| Mycelian Chorus | Distributed biological collective | Population recovery and colony growth |
| Synthari Continuum | Machine civilization | Automation and worker output |
| Elyrian Remnants | Ancient gate descendants | Ruin research and anomaly rewards |

## Ten Empire Governments

| Government | Authority | Playstyle |
|---|---|---|
| Imperial Throne | Imperial | Command capacity, vassals, fast mobilization |
| Stellar Republic | Democratic | Trust, unity, elections, diplomacy |
| Military Junta | Authoritarian | Fleet fire rate, defense wars, martial law |
| Technocracy | Oligarchic | Research, anomalies, specialist economy |
| Corporate Charter | Corporate | Trade routes, contracts, market income |
| Theocratic Oracle | Spiritual | Morale, unity, psionic defense |
| Federated League | Federated | Alliance operations and federation votes |
| Hive Consensus | Gestalt | Population coordination and defense repair |
| Machine Directive | Gestalt Machine | Automation and logistics efficiency |
| Frontier Confederacy | Decentralized | Outposts, frontier colonies, rebel absorption |

## DLC and Expansion Model

DLC and expansions are defined as rule packs rather than hardcoded engine forks. A host selects which packs are active before a galaxy starts, and every client must match that enabled set for multiplayer.

| Pack | Type | Adds |
|---|---|---|
| Void Lattice Crisis | Expansion | Machine crisis, relic weapons, megastructures, act 8 variants |
| Desert Sector Exodus | Story Pack | Mobile bases, harsh-world clans, raider contracts, new origin |
| Dawn Accord | Species Pack | Research diplomacy, quantum labs, science advisors |
| Eclipse Shadow War | Story Pack | Espionage operations, stealth fleets, covert endings |
| Commander Vault | Cosmetic DLC | Portraits, titles, banners, ship colors, lobby badges |

## Patch and Info Log

The Patch and Info Log screen should show:

- Patch notes with version, release date, balance changes, and migration warnings.
- Engine updates for renderer, audio, input, networking, storage, and mod loader changes.
- Game systems updates for economy, battle, fleet, research, government, diplomacy, and account creation.
- Known issues with save compatibility, mods, multiplayer, and DLC rule mismatches.
- Server news for master-server status, maintenance windows, ranked seasons, and events.

## Online 8 Player Requirements

- Eight human player empires maximum.
- Spectators with host approval and fog-safe delayed vision.
- Host-locked DLC/expansion rules.
- Deterministic simulation for economy ticks, fleet travel, battle results, and RTS commands.
- Save/resume with checksums, player identity checks, and DLC rule verification.
- Disconnect policy: pause, wait, surrender, AI substitute, or host migration later.
- Ranked mode stays disabled until online accounts, anti-cheat policy, replay upload, and version locks exist.

## Engine Systems To Wire Later

| System | Needed Work |
|---|---|
| Account Service | Local profile storage now, online identity and entitlement service later |
| Empire Presets | Serialize race, government, origin, flag, colors, and commander choices |
| DLC Manager | Installed-pack scan, host rule lock, entitlement check, and mod compatibility report |
| Lobby | Eight empire slots, observers, ready checks, passwords, region filters, and checksum validation |
| Info Log | Local changelog data, server notices, mod warnings, and update prompts |
| Save/Resume | Deterministic state snapshots, autosaves, multiplayer checksums, and migration metadata |
