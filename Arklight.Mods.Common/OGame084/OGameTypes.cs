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

using System;
using System.Collections.Generic;

namespace Arklight.Mods.Common.OGame084
{
	public enum OGameResource
	{
		Metal,
		Crystal,
		Deuterium,
		Energy,
		DarkMatter
	}

	public enum OGameQueueType
	{
		Building,
		Shipyard,
		Research,
		Fleet,
		Administration,
		Mod
	}

	public enum OGameMissionType
	{
		Attack,
		AcsAttack,
		Transport,
		Deploy,
		AcsHold,
		Espionage,
		Colonize,
		Recycle,
		Destroy,
		Expedition,
		Missile
	}

	public enum OGameSystemDomain
	{
		Weapons,
		Shields,
		Armors,
		Units,
		MilitarySystems,
		CivilSystems,
		GovernmentSystems,
		Buildings
	}

	public enum OGameChapterPhase
	{
		SetupAndExpansion,
		ConflictAndRisingAction,
		MajorTurningPoint,
		ClimaxBuildUp,
		ActClimaxAndAftermath
	}

	public readonly struct OGameResources : IEquatable<OGameResources>
	{
		public readonly long Metal;
		public readonly long Crystal;
		public readonly long Deuterium;
		public readonly long Energy;
		public readonly long DarkMatter;

		public OGameResources(long metal, long crystal, long deuterium, long energy = 0, long darkMatter = 0)
		{
			Metal = metal;
			Crystal = crystal;
			Deuterium = deuterium;
			Energy = energy;
			DarkMatter = darkMatter;
		}

		public static OGameResources Zero => new(0, 0, 0);

		public bool CanAfford(OGameResources cost)
		{
			return Metal >= cost.Metal && Crystal >= cost.Crystal && Deuterium >= cost.Deuterium &&
				Energy >= cost.Energy && DarkMatter >= cost.DarkMatter;
		}

		public OGameResources Add(OGameResources other)
		{
			return new OGameResources(
				Metal + other.Metal,
				Crystal + other.Crystal,
				Deuterium + other.Deuterium,
				Energy + other.Energy,
				DarkMatter + other.DarkMatter);
		}

		public OGameResources Subtract(OGameResources other)
		{
			return new OGameResources(
				Metal - other.Metal,
				Crystal - other.Crystal,
				Deuterium - other.Deuterium,
				Energy - other.Energy,
				DarkMatter - other.DarkMatter);
		}

		public bool Equals(OGameResources other)
		{
			return Metal == other.Metal && Crystal == other.Crystal && Deuterium == other.Deuterium &&
				Energy == other.Energy && DarkMatter == other.DarkMatter;
		}

		public override bool Equals(object obj)
		{
			return obj is OGameResources other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Metal, Crystal, Deuterium, Energy, DarkMatter);
		}

		public static bool operator ==(OGameResources left, OGameResources right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(OGameResources left, OGameResources right)
		{
			return !left.Equals(right);
		}
	}

	public sealed class OGameNamedValue
	{
		public readonly string Id;
		public readonly string Name;
		public readonly string Description;

		public OGameNamedValue(string id, string name, string description)
		{
			Id = id;
			Name = name;
			Description = description;
		}
	}

	public sealed class OGameFeature
	{
		public readonly string Id;
		public readonly string Name;
		public readonly string SourceModule;
		public readonly string Description;

		public OGameFeature(string id, string name, string sourceModule, string description)
		{
			Id = id;
			Name = name;
			SourceModule = sourceModule;
			Description = description;
		}
	}

	public sealed class OGameSystemClass
	{
		public readonly OGameSystemDomain Domain;
		public readonly string Name;
		public readonly IReadOnlyList<string> Subclasses;

		public OGameSystemClass(OGameSystemDomain domain, string name, params string[] subclasses)
		{
			Domain = domain;
			Name = name;
			Subclasses = subclasses;
		}
	}
}

