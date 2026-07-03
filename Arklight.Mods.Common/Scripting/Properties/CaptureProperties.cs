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

using Arklight.Mods.Common.Activities;
using Arklight.Mods.Common.Traits;
using Arklight.Scripting;
using Arklight.Traits;

namespace Arklight.Mods.Common.Scripting
{
	[ScriptPropertyGroup("Ability")]
	public class CaptureProperties : ScriptActorProperties, Requires<CaptureManagerInfo>
	{
		readonly CaptureManager captureManager;

		public CaptureProperties(ScriptContext context, Actor self)
			: base(context, self)
		{
			captureManager = Self.Trait<CaptureManager>();
		}

		[Desc("Captures the target actor.")]
		public void Capture(Actor target)
		{
			if (!CanCapture(target))
				return;

			// NB: Scripted actions get no visible targetlines.
			Self.QueueActivity(new CaptureActor(Self, Target.FromActor(target), null));
		}

		[Desc("Checks if the target actor can be captured.")]
		public bool CanCapture(Actor target)
		{
			var targetManager = target.TraitOrDefault<CaptureManager>();
			return targetManager != null && captureManager.CanTarget(targetManager);
		}
	}
}

