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
using System.Linq;
using Arklight.Mods.Common.Traits.Render;
using Arklight.Server;

namespace Arklight.Mods.Common.Lint
{
	sealed class CheckSpriteBodies : ILintRulesPass, ILintServerMapPass
	{
		void ILintRulesPass.Run(Action<string> emitError, Action<string> emitWarning, ModData modData, Ruleset rules)
		{
			Run(emitError, rules);
		}

		void ILintServerMapPass.Run(Action<string> emitError, Action<string> emitWarning, ModData modData, MapPreview map, Ruleset mapRules)
		{
			Run(emitError, mapRules);
		}

		static void Run(Action<string> emitError, Ruleset rules)
		{
			foreach (var actorInfo in rules.Actors)
			{
				var duplicateNames = actorInfo.Value.TraitInfos<WithSpriteBodyInfo>()
					.GroupBy(wsb => wsb.Name)
					.Where(g => g.Count() > 1)
					.Select(g => g.Key);
				foreach (var duplicateName in duplicateNames)
					emitError($"Actor type `{actorInfo.Key}` has more than one *SpriteBody with Name: {duplicateName}.");
			}
		}
	}
}

