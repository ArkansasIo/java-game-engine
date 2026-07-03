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
using System.Linq;

namespace Arklight.Mods.Common.OGame084
{
	public sealed class OGameCombatUnit
	{
		public readonly string Id;
		public readonly int Count;
		public readonly int Attack;
		public readonly int Shield;
		public readonly int Hull;

		public OGameCombatUnit(string id, int count, int attack, int shield, int hull)
		{
			Id = id;
			Count = Math.Max(0, count);
			Attack = Math.Max(0, attack);
			Shield = Math.Max(0, shield);
			Hull = Math.Max(1, hull);
		}
	}

	public sealed class OGameBattleSide
	{
		public readonly string Name;
		public readonly IReadOnlyList<OGameCombatUnit> Units;
		public readonly int WeaponTech;
		public readonly int ShieldTech;
		public readonly int ArmorTech;

		public OGameBattleSide(string name, IReadOnlyList<OGameCombatUnit> units, int weaponTech = 0, int shieldTech = 0, int armorTech = 0)
		{
			Name = name;
			Units = units;
			WeaponTech = Math.Max(0, weaponTech);
			ShieldTech = Math.Max(0, shieldTech);
			ArmorTech = Math.Max(0, armorTech);
		}
	}

	public sealed class OGameBattleResult
	{
		public readonly int Rounds;
		public readonly string Outcome;
		public readonly long AttackerInitialHull;
		public readonly long DefenderInitialHull;
		public readonly long AttackerRemainingHull;
		public readonly long DefenderRemainingHull;
		public readonly OGameResources Debris;

		public OGameBattleResult(
			int rounds,
			string outcome,
			long attackerInitialHull,
			long defenderInitialHull,
			long attackerRemainingHull,
			long defenderRemainingHull,
			OGameResources debris)
		{
			Rounds = rounds;
			Outcome = outcome;
			AttackerInitialHull = attackerInitialHull;
			DefenderInitialHull = defenderInitialHull;
			AttackerRemainingHull = attackerRemainingHull;
			DefenderRemainingHull = defenderRemainingHull;
			Debris = debris;
		}
	}

	public sealed class OGameBattleSimulator
	{
		readonly Random random;

		public OGameBattleSimulator(int seed)
		{
			random = new Random(seed);
		}

		public OGameBattleResult Simulate(OGameUniverseSettings universe, OGameBattleSide attacker, OGameBattleSide defender, int maxRounds = 6)
		{
			var attackerFleet = Expand(attacker);
			var defenderFleet = Expand(defender);
			var attackerInitial = HullTotal(attackerFleet);
			var defenderInitial = HullTotal(defenderFleet);
			var rounds = 0;

			while (rounds < maxRounds && attackerFleet.Count > 0 && defenderFleet.Count > 0)
			{
				rounds++;
				FireRound(attackerFleet, defenderFleet, attacker.WeaponTech);
				if (defenderFleet.Count > 0)
					FireRound(defenderFleet, attackerFleet, defender.WeaponTech);

				RemoveDestroyed(attackerFleet);
				RemoveDestroyed(defenderFleet);
			}

			var attackerRemaining = HullTotal(attackerFleet);
			var defenderRemaining = HullTotal(defenderFleet);
			var outcome = attackerRemaining > 0 && defenderRemaining == 0 ? "AttackerVictory" :
				defenderRemaining > 0 && attackerRemaining == 0 ? "DefenderVictory" : "Draw";
			var lostHull = attackerInitial + defenderInitial - attackerRemaining - defenderRemaining;
			var debris = new OGameResources(lostHull * universe.FleetDebrisPercent / 200, lostHull * universe.FleetDebrisPercent / 200, 0);

			return new OGameBattleResult(rounds, outcome, attackerInitial, defenderInitial, attackerRemaining, defenderRemaining, debris);
		}

		static List<CombatInstance> Expand(OGameBattleSide side)
		{
			var instances = new List<CombatInstance>();
			foreach (var unit in side.Units)
			{
				var hull = (int)Math.Floor(unit.Hull * (1 + side.ArmorTech * 0.1d));
				var shield = (int)Math.Floor(unit.Shield * (1 + side.ShieldTech * 0.1d));
				for (var i = 0; i < unit.Count; i++)
					instances.Add(new CombatInstance(unit.Id, unit.Attack, shield, hull));
			}

			return instances;
		}

		void FireRound(List<CombatInstance> attackers, List<CombatInstance> defenders, int weaponTech)
		{
			var attackMultiplier = 1 + weaponTech * 0.1d;
			foreach (var attacker in attackers.ToArray())
			{
				if (defenders.Count == 0)
					return;

				var target = defenders[random.Next(defenders.Count)];
				var damage = (int)Math.Floor(attacker.Attack * attackMultiplier);
				target.Hit(damage);
			}
		}

		static void RemoveDestroyed(List<CombatInstance> fleet)
		{
			fleet.RemoveAll(u => u.Hull <= 0);
		}

		static long HullTotal(IEnumerable<CombatInstance> fleet)
		{
			return fleet.Sum(u => (long)Math.Max(0, u.Hull));
		}

		sealed class CombatInstance
		{
			public readonly string Id;
			public readonly int Attack;
			int shield;
			public int Hull { get; private set; }

			public CombatInstance(string id, int attack, int shield, int hull)
			{
				Id = id;
				Attack = attack;
				this.shield = shield;
				Hull = hull;
			}

			public void Hit(int damage)
			{
				if (damage <= 0)
					return;

				var absorbed = Math.Min(shield, damage);
				shield -= absorbed;
				Hull -= damage - absorbed;
			}
		}
	}
}

