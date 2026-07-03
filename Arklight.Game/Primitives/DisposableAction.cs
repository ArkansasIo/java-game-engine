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

namespace Arklight.Primitives
{
	public sealed class DisposableAction : IDisposable
	{
		public DisposableAction(Action onDispose, Action onFinalize)
		{
			this.onDispose = onDispose;
			this.onFinalize = onFinalize;
		}

		readonly Action onDispose;
		readonly Action onFinalize;
		bool disposed;

		public void Dispose()
		{
			if (disposed)
				return;
			disposed = true;
			onDispose();
			GC.SuppressFinalize(this);
		}

		~DisposableAction()
		{
			onFinalize();
		}
	}
}

