#region Copyright & License Information
/*
 * Copyright (c) The OpenRA Developers and Contributors
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using System.Collections.Generic;

namespace OpenRA.Mods.Common.OGame084
{
	public sealed class OGameCampaignAct
	{
		public readonly int Number;
		public readonly string Name;
		public readonly string Theme;
		public readonly IReadOnlyList<OGameCampaignChapter> Chapters;

		public OGameCampaignAct(int number, string name, string theme, IReadOnlyList<OGameCampaignChapter> chapters)
		{
			Number = number;
			Name = name;
			Theme = theme;
			Chapters = chapters;
		}
	}

	public sealed class OGameCampaignChapter
	{
		public readonly int Number;
		public readonly string Title;
		public readonly OGameChapterPhase Phase;
		public readonly IReadOnlyList<OGameNamedValue> RequiredElements;

		public OGameCampaignChapter(int number, string title, OGameChapterPhase phase, IReadOnlyList<OGameNamedValue> requiredElements)
		{
			Number = number;
			Title = title;
			Phase = phase;
			RequiredElements = requiredElements;
		}
	}

	public static class OGameCampaignFactory
	{
		static readonly string[] ChapterBeats =
		[
			"Opening Status", "Signal Event", "Local Friction", "First Decision", "Resource Pressure",
			"Civilian Impact", "Military Probe", "Faction Contact", "Political Demand", "Setup Reversal",
			"Border Incident", "Economic Shock", "Spy Discovery", "Council Vote", "Prototype Test",
			"Raid Window", "Alliance Offer", "Moral Compromise", "Countermove", "Rising Cost",
			"Revelation", "Failed Treaty", "Strategic Loss", "Hidden Asset", "Civil Unrest",
			"Fleet Maneuver", "Heroic Choice", "Betrayal Trace", "Ancient Clue", "Midpoint Break",
			"Mobilization", "Deep Strike", "Supply Crisis", "Public Panic", "Doctrine Shift",
			"Enemy Escalation", "Sacrifice", "System Siege", "Last Negotiation", "Climax Gate",
			"Battle Line", "Command Fracture", "Relic Activation", "Civilian Evacuation", "Final Assault",
			"Victory Cost", "Power Vacuum", "Truth Record", "Aftermath Choice", "Next Horizon"
		];

		static readonly (string Name, string Theme)[] Acts =
		[
			("Origins", "Foundations, first colonies, lost signals, and discovery of ancient infrastructure"),
			("Rise of Factions", "Houses, unions, corporations, sects, fleets, and border laws take shape"),
			("First Great War", "First interstellar war, prototype fleets, espionage, and logistics collapse"),
			("Age of Expansion", "Colonization, trade corridors, megastructures, and frontier diplomacy"),
			("Shadow Conspiracy", "Hidden councils, sabotage, black fleets, and manipulated succession"),
			("Fall of Empires", "Imperial collapse, refugees, civil war, and planetary secession"),
			("Rebirth", "New federations, rebuilt economies, doctrines, and contested legitimacy"),
			("Second Great War", "Total war with super-units, orbital control, and industrial mobilization"),
			("Age of Heroes", "Legendary commanders, heroic raids, relic hunts, and symbolic victories"),
			("Cosmic Awakening", "Ancient entities, dimensional breaches, forbidden sciences, and cosmic resources"),
			("Final Cataclysm", "Reality-scale war, system loss, evacuation arcs, and final alliances"),
			("New Dawn", "Reconstruction, constitutional order, memorial worlds, and future hooks")
		];

		public static IReadOnlyList<OGameCampaignAct> CreateDefaultCampaign()
		{
			var acts = new List<OGameCampaignAct>();
			for (var actIndex = 0; actIndex < Acts.Length; actIndex++)
			{
				var chapters = new List<OGameCampaignChapter>();
				for (var chapter = 1; chapter <= 50; chapter++)
				{
					var title = $"{actIndex + 1}.{chapter:00} - {ChapterBeats[chapter - 1]}";
					chapters.Add(new OGameCampaignChapter(chapter, title, PhaseForChapter(chapter), OGameCatalog.ChapterElements));
				}

				acts.Add(new OGameCampaignAct(actIndex + 1, Acts[actIndex].Name, Acts[actIndex].Theme, chapters));
			}

			return acts;
		}

		static OGameChapterPhase PhaseForChapter(int chapter)
		{
			if (chapter <= 10)
				return OGameChapterPhase.SetupAndExpansion;
			if (chapter <= 20)
				return OGameChapterPhase.ConflictAndRisingAction;
			if (chapter <= 30)
				return OGameChapterPhase.MajorTurningPoint;
			if (chapter <= 40)
				return OGameChapterPhase.ClimaxBuildUp;

			return OGameChapterPhase.ActClimaxAndAftermath;
		}
	}
}
