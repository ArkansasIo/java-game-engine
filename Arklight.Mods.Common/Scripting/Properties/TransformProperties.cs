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
	[ScriptPropertyGroup("General")]
	public class TransformProperties : ScriptActorProperties, Requires<TransformsInfo>
	{
		readonly Transforms transforms;

		public TransformProperties(ScriptContext context, Actor self)
			: base(context, self)
		{
			transforms = self.Trait<Transforms>();
		}

		[ScriptActorPropertyActivity]
		[Desc("Queue a new transformation.")]
		public void Deploy()
		{
			transforms.DeployTransform(true);
		}
	}
}

