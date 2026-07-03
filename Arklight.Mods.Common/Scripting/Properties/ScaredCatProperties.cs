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

using Arklight.Mods.Common.Traits;
using Arklight.Scripting;
using Arklight.Traits;

namespace Arklight.Mods.Common.Scripting
{
	[ScriptPropertyGroup("Movement")]
	public class ScaredCatProperties : ScriptActorProperties, Requires<ScaredyCatInfo>
	{
		readonly ScaredyCat scaredyCat;

		public ScaredCatProperties(ScriptContext context, Actor self)
			: base(context, self)
		{
			scaredyCat = self.Trait<ScaredyCat>();
		}

		[ScriptActorPropertyActivity]
		[Desc("Makes the unit automatically run around and become faster.")]
		public void Panic()
		{
			scaredyCat.Panic();
		}
	}
}

