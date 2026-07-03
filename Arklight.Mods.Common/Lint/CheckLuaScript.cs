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
using Arklight.Mods.Common.Scripting;

namespace Arklight.Mods.Common.Lint
{
	public class CheckLuaScript : ILintMapPass
	{
		void ILintMapPass.Run(Action<string> emitError, Action<string> emitWarning, ModData modData, Map map)
		{
			var luaScriptInfo = map.Rules.Actors[SystemActors.World].TraitInfoOrDefault<LuaScriptInfo>();
			if (luaScriptInfo == null)
				return;

			// We aren't running this lint on servers as they don't create map packages.
			foreach (var script in luaScriptInfo.Scripts)
				if (!map.Package.Contains(script) && !modData.DefaultFileSystem.Exists(script))
					emitError($"Lua script `{script}` does not exist.");
		}
	}
}

