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

namespace Arklight.Mods.Common.Traits
{
	[AttributeUsage(AttributeTargets.Field)]
	public sealed class VoiceSetReferenceAttribute : Attribute { }

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class VoiceReferenceAttribute : Attribute { }

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class LocomotorReferenceAttribute : Attribute { }

	[AttributeUsage(AttributeTargets.Field)]
	public sealed class NotificationReferenceAttribute(string type = null, string typeFromField = null) : Attribute
	{
		public readonly string NotificationTypeFieldName = typeFromField;
		public readonly string NotificationType = type;
	}
}

