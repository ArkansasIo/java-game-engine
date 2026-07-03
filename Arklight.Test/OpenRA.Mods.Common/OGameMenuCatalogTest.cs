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

using System.Linq;
using Arklight.Mods.Common.OGame084;
using NUnit.Framework;

namespace Arklight.Test
{
	[TestFixture]
	sealed class OGameMenuCatalogTest
	{
		[Test]
		public void CatalogSummariesCoverAllStagedMenuStructures()
		{
			Assert.That(OGameMenuSystemsCatalog.Systems.Select(s => s.Id).Distinct().Count(), Is.EqualTo(OGameMenuSystemsCatalog.Systems.Count));
			Assert.That(OGameInterfaceModel.MenuSections.Select(s => s.Id).Distinct().Count(), Is.EqualTo(OGameInterfaceModel.MenuSections.Count));
			Assert.That(OGameInterfaceModel.MenuWindows.Select(s => s.Id).Distinct().Count(), Is.EqualTo(OGameInterfaceModel.MenuWindows.Count));
			Assert.That(OGameInterfaceModel.Transitions.Count, Is.GreaterThan(0));
			Assert.That(OGameMenuSystemsCatalog.BuildSystemSummaryLines(), Has.Count.EqualTo(OGameMenuSystemsCatalog.Systems.Count));
			Assert.That(OGameMenuSystemsCatalog.BuildDetailedSystemLines(), Has.Count.EqualTo(OGameMenuSystemsCatalog.Systems.Count));
			Assert.That(OGameMenuSystemsCatalog.BuildFrameSummaryLines(), Has.Count.EqualTo(OGameMenuSystemsCatalog.FrameOrder.Count));
			Assert.That(OGameMenuSystemsCatalog.BuildFeatureSummaryLines(), Has.Count.EqualTo(OGameCatalog.Features.Count));
			Assert.That(OGameInterfaceModel.BuildSectionSummaryLines(), Has.Count.EqualTo(OGameInterfaceModel.MenuSections.Count));
			Assert.That(OGameInterfaceModel.BuildTransitionSummaryLines(), Has.Count.EqualTo(OGameInterfaceModel.Transitions.Count));
			Assert.That(OGameInterfaceModel.BuildWindowSummaryLines(), Has.Count.EqualTo(OGameInterfaceModel.MenuWindows.Count));
		}

		[Test]
		public void RuntimeStateDefaultsIncludeExtendedMenuCoordinates()
		{
			var state = new OGameMenuRuntimeState();

			Assert.That(state.ActiveCategoryId, Is.EqualTo("empire"));
			Assert.That(state.ActiveWindowId, Is.EqualTo("empire-dashboard"));
			Assert.That(state.ActivePageId, Is.EqualTo("dashboard"));
			Assert.That(state.ActiveSubpageId, Is.EqualTo("overview"));
			Assert.That(state.ActiveFrameId, Is.EqualTo("Header"));
			Assert.That(state.ActivePlaneId, Is.EqualTo("Resource topbar"));
			Assert.That(state.ActiveSubplaneId, Is.EqualTo("Metal"));
			Assert.That(state.SelectedObjectId, Is.EqualTo("homeworld"));
			Assert.That(state.InspectorFocusId, Is.EqualTo("empire-summary"));
			Assert.That(state.PendingActionId, Is.Empty);
			Assert.That(state.SelectedFunctionId, Is.Empty);
			Assert.That(state.SelectedFeatureId, Is.Empty);
			Assert.That(state.ValidationMessage, Is.Empty);
		}
	}
}
