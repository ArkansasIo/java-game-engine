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
using Arklight.Mods.Common.OGame084;
using Arklight.Widgets;

namespace Arklight.Mods.Common.Widgets.Logic
{
	sealed class OGameIngameMenuLogic : ChromeLogic
	{
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

		[ObjectCreator.UseCtor]
		public OGameIngameMenuLogic(Widget widget, World world)
		{
			var systems = OGameMenuSystemsCatalog.Systems;
			var views = OGameInterfaceModel.Views;
			var features = OGameCatalog.Features;

			SetLabel(widget, "WINDOW_TITLE", "STELLAR COMMAND INTERFACE");
			SetLabel(widget, "WINDOW_SUBTITLE", $"{world.Map.Title} / {world.Type} / OGame 0.84 systems");
			SetLabel(widget, "TAB_SECONDARY", string.Join(" / ", systems.Select(s => s.Menu)));
			SetLabel(widget, "RAIL_TITLE", "MENUS / SUB MENUS");
			SetLabel(widget, "PAGE_TITLE", "PAGES / SUBPAGES / PLANES");
			SetLabel(widget, "STATUS_TITLE", "WINDOW FRAMES");
			SetLabel(widget, "FOOTER_NOTE",
				$"OpenRA pause actions remain active; catalog staged {systems.Count} systems, {OGameMenuSystemsCatalog.LogicFunctionCount} functions, {OGameMenuSystemsCatalog.StatCount} stats, and {OGameMenuSystemsCatalog.FeatureCount} features.");
			SetLabel(widget, "LABEL_MODE_STRIP", string.Join(" / ", views.Select(v => v.Name.Replace(" View", ""))));

			var sectionLabels = systems
				.Select(s => $"{s.Menu}: {string.Join(" / ", s.Submenus.Take(3))}")
				.ToArray();
			BindLabels(widget, RailLabelIds, sectionLabels);

			var pageLabels = systems
				.Select(s => $"{s.Name}: {string.Join(" / ", s.Planes.Take(4))}")
				.Concat(systems.Select(s => $"{s.Menu} stats: {string.Join(" / ", s.Stats.Take(4))}"))
				.ToArray();
			BindLabels(widget, PageLabelIds, pageLabels);

			var subpageDetail = string.Join("; ", systems.Take(4).Select(s =>
				$"{s.Name} functions: {string.Join(", ", s.LogicFunctions.Take(3))}"));
			SetLabel(widget, "SUBPAGE_DETAIL", subpageDetail);

			var regionLabels = systems.Take(5)
				.Select(s => $"{s.Name}: {string.Join(" / ", s.Frames.Take(3))}")
				.ToArray();
			BindLabels(widget, StatusLabelIds, regionLabels);

			var logicSummary = string.Join("; ", systems.Skip(5).Take(4).Select(s =>
				$"{s.Name}: {string.Join(", ", s.Features.Take(2))}"));
			logicSummary += $"; source features: {string.Join(", ", features.Take(4).Select(f => f.Name))}";
			SetLabel(widget, "STATUS_F", logicSummary);
		}

		static void BindLabels(Widget widget, IEnumerable<string> ids, IReadOnlyList<string> values)
		{
			var i = 0;
			foreach (var id in ids)
			{
				if (i >= values.Count)
					break;

				SetLabel(widget, id, values[i++]);
			}
		}

		static void SetLabel(Widget widget, string id, string text)
		{
			var label = widget.GetOrNull<LabelWidget>(id);
			if (label == null)
				return;

			var value = text;
			label.GetText = () => value;
		}
	}
}
