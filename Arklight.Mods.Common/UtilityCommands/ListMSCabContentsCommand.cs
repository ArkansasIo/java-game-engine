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
using System.IO;
using Arklight.Mods.Common.FileFormats;

namespace Arklight.Mods.Common.UtilityCommands
{
	sealed class ListMSCabContentsCommand : IUtilityCommand
	{
		string IUtilityCommand.Name => "--list-mscab";

		bool IUtilityCommand.ValidateArguments(string[] args)
		{
			return args.Length == 2;
		}

		[Desc("ARCHIVE.CAB", "Lists the filenames contained within a MSCAB file")]
		void IUtilityCommand.Run(Utility utility, string[] args)
		{
			var package = new MSCabCompression(File.OpenRead(args[1]));
			foreach (var file in package.Contents)
				Console.WriteLine("{0}", file);
		}
	}
}

