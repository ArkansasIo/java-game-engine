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
using System.Linq;
using Arklight.Mods.Common.OGame084;
using Arklight.Widgets;

namespace Arklight.Mods.Common.Widgets.Logic
{
	sealed class OGameIngameMenuLogic : ChromeLogic
	{
		readonly Widget widget;
		readonly World world;
		readonly IReadOnlyList<OGameNamedValue> views;
		readonly IReadOnlyList<OGameInterfaceSection> sections;
		readonly IReadOnlyList<OGameInterfaceWindow> windows;
		readonly IReadOnlyList<OGameInterfaceTransition> transitions;
		readonly IReadOnlyList<OGameFeature> features;
		static readonly string[] RailLabelIds =
		[
			"RAIL_LIST_A",
			"RAIL_LIST_B",
			"RAIL_LIST_C",
			"RAIL_LIST_D",
			"RAIL_LIST_E",
			"RAIL_LIST_F",
			"RAIL_LIST_G",
			"RAIL_LIST_H",
			"RAIL_LIST_I",
			"RAIL_LIST_J",
			"RAIL_LIST_K",
			"RAIL_LIST_L"
		];

		static readonly string[] PageLabelIds =
		[
			"PAGE_GALAXY",
			"PAGE_PLANET",
			"PAGE_BUILD",
			"PAGE_FLEET",
			"PAGE_COMBAT",
			"PAGE_RESEARCH",
			"PAGE_CIVIL",
			"PAGE_MARKET",
			"PAGE_GOV",
			"PAGE_DIPLO",
			"PAGE_ALLIANCE",
			"PAGE_HERO",
			"PAGE_EQUIP",
			"PAGE_QUEST",
			"PAGE_INTEL",
			"PAGE_ADMIN"
		];

		static readonly string[] StatusLabelIds =
		[
			"STATUS_A",
			"STATUS_B",
			"STATUS_C",
			"STATUS_D",
			"STATUS_E"
		];

		int activeTabIndex;
		int activeRailIndex;

		[ObjectCreator.UseCtor]
		public OGameIngameMenuLogic(Widget widget, World world)
		{
			this.widget = widget;
			this.world = world;
			var systems = OGameMenuSystemsCatalog.Systems;
			views = OGameInterfaceModel.Views;
			features = OGameCatalog.Features;
			sections = OGameInterfaceModel.MenuSections;
			transitions = OGameInterfaceModel.Transitions;
			windows = OGameInterfaceModel.MenuWindows;

			SetText(widget, "WINDOW_TITLE", "STELLAR COMMAND INTERFACE");
			SetText(widget, "RAIL_TITLE", "MENUS / SUB MENUS");
			SetText(widget, "PAGE_TITLE", "PAGES / SUBPAGES / PLANES");
			SetText(widget, "STATUS_TITLE", "WINDOW FRAMES");

			SetupTabButtons();
			SetupRailButtons();
			RefreshContent(systems);
		}

		void SetupTabButtons()
		{
			string[] tabIds =
			[
				"TAB_EMPIRE",
				"TAB_GALAXY",
				"TAB_SYSTEM",
				"TAB_PLANET",
				"TAB_FLEET",
				"TAB_WAR",
				"TAB_RESEARCH",
				"TAB_MARKET",
				"TAB_DIPLOMACY",
				"TAB_ALLIANCE",
				"TAB_CHARACTER"
			];

			string[] tabLabels =
			[
				"Empire", "Galaxy", "System", "Planet", "Fleet", "War", "Research", "Market", "Diplomacy", "Alliance", "Character"
			];

			for (var i = 0; i < tabIds.Length; i++)
			{
				var tabIndex = i;
				var tab = widget.GetOrNull<ButtonWidget>(tabIds[i]);
				if (tab == null)
					continue;

				tab.GetText = () => tabLabels[tabIndex];
				tab.IsHighlighted = () => activeTabIndex == tabIndex;
				tab.OnClick = () =>
				{
					activeTabIndex = tabIndex;
					activeRailIndex = 0;
					RefreshContent(OGameMenuSystemsCatalog.Systems);
				};
			}

			var secondary = widget.GetOrNull<ButtonWidget>("TAB_SECONDARY");
			if (secondary != null)
			{
				secondary.GetText = () => $"Selected mode: {views[activeTabIndex % views.Count].Name.Replace(" View", "")}";
				secondary.IsHighlighted = () => activeTabIndex % 2 == 0;
				secondary.OnClick = () =>
				{
					activeTabIndex = (activeTabIndex + 1) % tabIds.Length;
					activeRailIndex = 0;
					RefreshContent(OGameMenuSystemsCatalog.Systems);
				};
			}
		}

		void SetupRailButtons()
		{
			var railIds = RailLabelIds;
			var railNames = sections.Select(section => section.Name).ToArray();
			for (var i = 0; i < railIds.Length; i++)
			{
				var railIndex = i;
				var rail = widget.GetOrNull<ButtonWidget>(railIds[i]);
				if (rail == null)
					continue;

				var name = i < railNames.Length ? railNames[i] : $"Rail {i + 1}";
				rail.GetText = () => name;
				rail.IsHighlighted = () => activeRailIndex == railIndex;
				rail.OnClick = () =>
				{
					activeRailIndex = railIndex;
					RefreshContent(OGameMenuSystemsCatalog.Systems);
				};
			}
		}

		void RefreshContent(IReadOnlyList<OGameMenuSystemDefinition> systems)
		{
			var selectedView = views[activeTabIndex % views.Count];
			var selectedSection = sections[activeRailIndex % sections.Count];
			var selectedWindow = windows[activeRailIndex % windows.Count];
			var selectedSystem = systems[activeRailIndex % systems.Count];
			var selectedFeature = features[activeTabIndex % features.Count];

			SetText(widget, "WINDOW_SUBTITLE",
				$"{world.Map.Title} / {world.Type} / {selectedView.Name} / {selectedSection.Name} / {selectedWindow.Name}");
			SetText(widget, "TAB_SECONDARY", $"Active view: {selectedView.Name} | feature: {selectedFeature.Name}");
			SetText(widget, "LABEL_MODE_STRIP", string.Join(" / ", sections.Select(s => s.Name)));

			var sectionLabels = sections
				.Select((section, index) => index == activeRailIndex
					? $"> {section.Name}: {string.Join(" / ", section.Submenus.Take(4))}"
					: $"{section.Name}: {string.Join(" / ", section.Submenus.Take(4))}")
				.ToArray();
			BindLabels(widget, RailLabelIds, sectionLabels);

			var pageLabels = selectedSystem.Planes
				.Select((plane, index) => index == 0
					? $"{selectedSystem.Menu}: {plane}"
					: plane)
				.Concat(new[]
				{
					$"Subplanes: {string.Join(" / ", selectedSystem.Subplanes)}",
					$"Logic: {string.Join(" / ", selectedSystem.LogicFunctions.Take(4))}",
					$"Stats: {string.Join(" / ", selectedSystem.Stats.Take(4))}"
				})
				.ToArray();
			BindLabels(widget, PageLabelIds, pageLabels);

			SetText(widget, "SUBPAGE_DETAIL",
				$"{selectedSystem.Name}: frames {string.Join(" / ", selectedWindow.Frames.Take(4))} | functions {string.Join(" / ", selectedWindow.Functions.Take(4))} | game logic {string.Join(" / ", selectedWindow.GameLogic.Take(4))}");

			var regionLabels = windows
				.Select((window, index) =>
					index == activeRailIndex
						? $"> {window.Name}: frames {string.Join(" / ", window.Frames)} | planes {string.Join(" / ", window.Planes)}"
						: $"{window.Name}: frames {string.Join(" / ", window.Frames)} | planes {string.Join(" / ", window.Planes)}")
				.Chunk(2)
				.Select(chunk => string.Join(" || ", chunk))
				.ToArray();
			BindLabels(widget, StatusLabelIds, regionLabels);

			var logicSummary = string.Join("; ", transitions.Select(transition =>
				$"{transition.From} -> {transition.To}: {transition.Trigger}"));
			var firstFrame = selectedWindow.Frames.Count > 0 ? selectedWindow.Frames[0] : "n/a";
			var firstPlane = selectedSystem.Planes.Count > 0 ? selectedSystem.Planes[0] : "n/a";
			logicSummary += $"; feature {selectedFeature.Name}; frame {firstFrame}; plane {firstPlane}";
			SetText(widget, "STATUS_F", logicSummary);
			SetText(widget, "FOOTER_NOTE",
				$"OpenRA pause actions remain active; catalog staged {OGameMenuSystemsCatalog.Systems.Count} systems, {OGameMenuSystemsCatalog.LogicFunctionCount} functions, {OGameMenuSystemsCatalog.StatCount} stats, {OGameMenuSystemsCatalog.FeatureCount} features, and {windows.Count} window shells.");
		}

		static void BindLabels(Widget widget, IEnumerable<string> ids, IReadOnlyList<string> values)
		{
			var i = 0;
			foreach (var id in ids)
			{
				if (i >= values.Count)
					break;

				SetText(widget, id, values[i++]);
			}
		}

		static void SetText(Widget widget, string id, string text)
		{
			var button = widget.GetOrNull<ButtonWidget>(id);
			if (button != null)
			{
				var buttonText = text;
				button.GetText = () => buttonText;
				return;
			}

			var label = widget.GetOrNull<LabelWidget>(id);
			if (label == null)
				return;

			var value = text;
			label.GetText = () => value;
		}
	}
}
