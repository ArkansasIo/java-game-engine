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

using Arklight.Widgets;

namespace Arklight
{
	public class NullInputHandler : IInputHandler
	{
		// ignore all input
		public void ModifierKeys(Modifiers mods) { }
		public void OnKeyInput(KeyInput input) { }
		public void OnTextInput(string text) { }
		public void OnMouseInput(MouseInput input) { }
	}

	public class DefaultInputHandler : IInputHandler
	{
		readonly World world;
		public DefaultInputHandler(World world)
		{
			this.world = world;
		}

		public void ModifierKeys(Modifiers mods)
		{
			Game.HandleModifierKeys(mods);
		}

		public void OnKeyInput(KeyInput input)
		{
			Sync.RunUnsynced(world, () => Ui.HandleKeyPress(input));
		}

		public void OnTextInput(string text)
		{
			Sync.RunUnsynced(world, () => Ui.HandleTextInput(text));
		}

		public void OnMouseInput(MouseInput input)
		{
			Sync.RunUnsynced(world, () => Ui.HandleInput(input));
		}
	}
}

