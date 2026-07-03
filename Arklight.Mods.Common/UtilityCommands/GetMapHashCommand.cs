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
using Arklight.FileSystem;

namespace Arklight.Mods.Common.UtilityCommands
{
	sealed class GetMapHashCommand : IUtilityCommand
	{
		string IUtilityCommand.Name => "--map-hash";

		bool IUtilityCommand.ValidateArguments(string[] args)
		{
			return args.Length >= 2;
		}

		[Desc("MAPFILE", "Generate hash of specified oramap file.")]
		void IUtilityCommand.Run(Utility utility, string[] args)
		{
			using (var package = new Folder(Platform.EngineDir).OpenPackage(args[1], utility.ModData.ModFiles))
				Console.WriteLine(Map.ComputeUID(package));
		}
	}
}

