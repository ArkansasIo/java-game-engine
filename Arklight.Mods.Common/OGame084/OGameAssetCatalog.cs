#region Copyright & License Information
/*
 * Copyright (c) The Arklight Developers and Contributors
 * This file is part of Arklight, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using System.Collections.Generic;

namespace Arklight.Mods.Common.OGame084
{
	public enum StellarAssetKind
	{
		Unit,
		Starship,
		Building,
		Weapon,
		Armor,
		Defense,
		Planet,
		Resource,
		Effect,
		Interface
	}

	public enum StellarRenderMode
	{
		Sprite2D,
		IsometricSprite,
		Billboard3D,
		Mesh3D,
		ParticleEffect,
		UiIcon
	}

	public sealed class StellarAssetDefinition
	{
		public readonly string Id;
		public readonly string Name;
		public readonly StellarAssetKind Kind;
		public readonly StellarRenderMode RenderMode;
		public readonly string Role;
		public readonly string VisualDirection;
		public readonly string PrimaryAssetPath;
		public readonly string ModelAssetPath;
		public readonly string IconAssetPath;

		public StellarAssetDefinition(
			string id,
			string name,
			StellarAssetKind kind,
			StellarRenderMode renderMode,
			string role,
			string visualDirection,
			string primaryAssetPath,
			string modelAssetPath = "",
			string iconAssetPath = "")
		{
			Id = id;
			Name = name;
			Kind = kind;
			RenderMode = renderMode;
			Role = role;
			VisualDirection = visualDirection;
			PrimaryAssetPath = primaryAssetPath;
			ModelAssetPath = modelAssetPath;
			IconAssetPath = iconAssetPath;
		}
	}

	public static class StellarAssetCatalog
	{
		const string Root = "mods/stellar/assets";

		public static readonly IReadOnlyList<StellarAssetDefinition> Units =
		[
			new StellarAssetDefinition("unit-orbital-engineer", "Orbital Engineer", StellarAssetKind.Unit, StellarRenderMode.IsometricSprite,
				"Builder and field repair unit.", "Compact pressure suit, cyan visor, backpack manipulators, lime repair beam.",
				$"{Root}/sprites/units/orbital-engineer.png", "", $"{Root}/icons/units/orbital-engineer.png"),
			new StellarAssetDefinition("unit-vacuum-marine", "Vacuum Marine", StellarAssetKind.Unit, StellarRenderMode.IsometricSprite,
				"Baseline infantry for stations and moons.", "Dark composite armor, pale blue rank lights, compact rail rifle.",
				$"{Root}/sprites/units/vacuum-marine.png", "", $"{Root}/icons/units/vacuum-marine.png"),
			new StellarAssetDefinition("unit-phalanx-guard", "Phalanx Guard", StellarAssetKind.Unit, StellarRenderMode.IsometricSprite,
				"Shield infantry and chokepoint holder.", "Tower shield emitter, blue hex shield surface, gold command crest.",
				$"{Root}/sprites/units/phalanx-guard.png", "", $"{Root}/icons/units/phalanx-guard.png"),
			new StellarAssetDefinition("unit-sentinel-drone", "Sentinel Drone", StellarAssetKind.Unit, StellarRenderMode.Billboard3D,
				"Fast scout and detector.", "Tri-wing hovering drone with sensor eye and thin engine arcs.",
				$"{Root}/sprites/units/sentinel-drone.png", $"{Root}/models/units/sentinel-drone.glb", $"{Root}/icons/units/sentinel-drone.png")
		];

		public static readonly IReadOnlyList<StellarAssetDefinition> Starships =
		[
			new StellarAssetDefinition("ship-probe", "Deep Probe", StellarAssetKind.Starship, StellarRenderMode.Mesh3D,
				"Espionage and reconnaissance craft.", "Needle hull, folded antenna petals, dim blue navigation lights.",
				$"{Root}/renders/starships/deep-probe.png", $"{Root}/models/starships/deep-probe.glb", $"{Root}/icons/starships/deep-probe.png"),
			new StellarAssetDefinition("ship-light-fighter", "Light Fighter", StellarAssetKind.Starship, StellarRenderMode.Mesh3D,
				"Cheap strike craft.", "Arrowhead interceptor, twin engine flares, white-blue hull panels.",
				$"{Root}/renders/starships/light-fighter.png", $"{Root}/models/starships/light-fighter.glb", $"{Root}/icons/starships/light-fighter.png"),
			new StellarAssetDefinition("ship-cruiser", "Cruiser", StellarAssetKind.Starship, StellarRenderMode.Mesh3D,
				"Balanced line ship.", "Long armored spine, side weapon pods, command-blue illumination.",
				$"{Root}/renders/starships/cruiser.png", $"{Root}/models/starships/cruiser.glb", $"{Root}/icons/starships/cruiser.png"),
			new StellarAssetDefinition("ship-colony-ark", "Colony Ark", StellarAssetKind.Starship, StellarRenderMode.Mesh3D,
				"Colonization and civilian transport.", "Cylindrical habitat spine, rotating colony rings, warm window grids.",
				$"{Root}/renders/starships/colony-ark.png", $"{Root}/models/starships/colony-ark.glb", $"{Root}/icons/starships/colony-ark.png"),
			new StellarAssetDefinition("ship-dreadnought", "Dreadnought", StellarAssetKind.Starship, StellarRenderMode.Mesh3D,
				"Capital siege platform.", "Cathedral-scale armored prow, gold command fins, spinal plasma lance.",
				$"{Root}/renders/starships/dreadnought.png", $"{Root}/models/starships/dreadnought.glb", $"{Root}/icons/starships/dreadnought.png")
		];

		public static readonly IReadOnlyList<StellarAssetDefinition> Buildings =
		[
			new StellarAssetDefinition("building-command-nexus", "Command Nexus", StellarAssetKind.Building, StellarRenderMode.IsometricSprite,
				"Primary colony control building.", "Tiered command tower, orbital crown shape, blue glass panels.",
				$"{Root}/sprites/buildings/command-nexus.png", $"{Root}/models/buildings/command-nexus.glb", $"{Root}/icons/buildings/command-nexus.png"),
			new StellarAssetDefinition("building-metal-extractor", "Metal Extractor", StellarAssetKind.Building, StellarRenderMode.IsometricSprite,
				"Metal production.", "Surface mine head, conveyor pylons, orange hazard lights.",
				$"{Root}/sprites/buildings/metal-extractor.png", $"{Root}/models/buildings/metal-extractor.glb", $"{Root}/icons/buildings/metal-extractor.png"),
			new StellarAssetDefinition("building-crystal-array", "Crystal Array", StellarAssetKind.Building, StellarRenderMode.IsometricSprite,
				"Crystal production.", "Blue crystal pylons under transparent shield arcs.",
				$"{Root}/sprites/buildings/crystal-array.png", $"{Root}/models/buildings/crystal-array.glb", $"{Root}/icons/buildings/crystal-array.png"),
			new StellarAssetDefinition("building-deuterium-refinery", "Deuterium Refinery", StellarAssetKind.Building, StellarRenderMode.IsometricSprite,
				"Fuel production.", "Cryogenic tanks, vapor condensers, teal piping.",
				$"{Root}/sprites/buildings/deuterium-refinery.png", $"{Root}/models/buildings/deuterium-refinery.glb", $"{Root}/icons/buildings/deuterium-refinery.png"),
			new StellarAssetDefinition("building-orbital-shipyard", "Orbital Shipyard", StellarAssetKind.Building, StellarRenderMode.Mesh3D,
				"Starship construction.", "Orbital ring dock, gantry arms, holographic build grid.",
				$"{Root}/renders/buildings/orbital-shipyard.png", $"{Root}/models/buildings/orbital-shipyard.glb", $"{Root}/icons/buildings/orbital-shipyard.png"),
			new StellarAssetDefinition("building-research-spire", "Research Spire", StellarAssetKind.Building, StellarRenderMode.IsometricSprite,
				"Research unlocks.", "Tall antenna spire, data fins, violet-blue lab glow.",
				$"{Root}/sprites/buildings/research-spire.png", $"{Root}/models/buildings/research-spire.glb", $"{Root}/icons/buildings/research-spire.png")
		];

		public static readonly IReadOnlyList<StellarAssetDefinition> WeaponsAndArmor =
		[
			new StellarAssetDefinition("weapon-rail-lance", "Rail Lance", StellarAssetKind.Weapon, StellarRenderMode.UiIcon,
				"Kinetic anti-armor weapon.", "Long barrel, blue magnetic coil rings, white muzzle streak.",
				$"{Root}/icons/weapons/rail-lance.png"),
			new StellarAssetDefinition("weapon-plasma-torpedo", "Plasma Torpedo", StellarAssetKind.Weapon, StellarRenderMode.UiIcon,
				"Slow high-damage anti-capital projectile.", "Glowing contained plasma core with gold caution bands.",
				$"{Root}/icons/weapons/plasma-torpedo.png"),
			new StellarAssetDefinition("weapon-ion-beam", "Ion Beam", StellarAssetKind.Weapon, StellarRenderMode.ParticleEffect,
				"Shield-stripping beam.", "Thin blue-white beam with ionized bloom and HUD targeting ticks.",
				$"{Root}/vfx/weapons/ion-beam.png"),
			new StellarAssetDefinition("armor-composite-hull", "Composite Hull", StellarAssetKind.Armor, StellarRenderMode.UiIcon,
				"Baseline hull armor.", "Layered dark plates with pale blue edge lines.",
				$"{Root}/icons/armor/composite-hull.png"),
			new StellarAssetDefinition("armor-ablative-ceramic", "Ablative Ceramic", StellarAssetKind.Armor, StellarRenderMode.UiIcon,
				"Thermal armor.", "White ceramic plates with heat scoring and orange warning edge.",
				$"{Root}/icons/armor/ablative-ceramic.png"),
			new StellarAssetDefinition("armor-void-lattice", "Void Lattice", StellarAssetKind.Armor, StellarRenderMode.UiIcon,
				"Late-game exotic armor.", "Black-blue lattice mesh, lime anomaly nodes.",
				$"{Root}/icons/armor/void-lattice.png")
		];

		public static readonly IReadOnlyList<StellarAssetDefinition> PlanetsAndEffects =
		[
			new StellarAssetDefinition("planet-terran", "Terran Colony World", StellarAssetKind.Planet, StellarRenderMode.Mesh3D,
				"Habitable empire planet.", "Blue oceans, city lights, orbital grid overlay.",
				$"{Root}/renders/planets/terran-colony.png", $"{Root}/models/planets/terran-colony.glb", $"{Root}/icons/planets/terran-colony.png"),
			new StellarAssetDefinition("planet-ice", "Ice Resource World", StellarAssetKind.Planet, StellarRenderMode.Mesh3D,
				"Deuterium-rich colony target.", "Frozen surface, cyan fissures, dark polar storms.",
				$"{Root}/renders/planets/ice-resource-world.png", $"{Root}/models/planets/ice-resource-world.glb", $"{Root}/icons/planets/ice-resource-world.png"),
			new StellarAssetDefinition("effect-warp-entry", "Warp Entry", StellarAssetKind.Effect, StellarRenderMode.ParticleEffect,
				"Fleet arrival visual.", "Blue gate ring, stretched star streaks, lime coordinate lock.",
				$"{Root}/vfx/space/warp-entry.png"),
			new StellarAssetDefinition("effect-shield-hit", "Shield Hit", StellarAssetKind.Effect, StellarRenderMode.ParticleEffect,
				"Impact feedback.", "Hexagonal blue shield ripple with white impact spark.",
				$"{Root}/vfx/combat/shield-hit.png"),
			new StellarAssetDefinition("ui-resource-strip", "Resource Strip", StellarAssetKind.Interface, StellarRenderMode.UiIcon,
				"Metal, crystal, deuterium, energy, dark matter UI set.", "Five compact holographic resource icons.",
				$"{Root}/ui/resource-strip.png")
		];
	}
}
