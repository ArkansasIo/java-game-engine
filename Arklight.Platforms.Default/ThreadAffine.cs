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

namespace Arklight.Platforms.Default
{
	abstract class ThreadAffine
	{
		volatile int managedThreadId;

		protected ThreadAffine()
		{
			SetThreadAffinity();
		}

		protected void SetThreadAffinity()
		{
			managedThreadId = Environment.CurrentManagedThreadId;
		}

		protected void VerifyThreadAffinity()
		{
			if (managedThreadId != Environment.CurrentManagedThreadId)
				throw new InvalidOperationException("Cross-thread operation not valid: This method must only be called from the thread that owns this object.");
		}
	}
}

