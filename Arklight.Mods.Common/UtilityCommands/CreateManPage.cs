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
using System.Reflection;

namespace Arklight.Mods.Common.UtilityCommands
{
	sealed class CreateManPage : IUtilityCommand
	{
		string IUtilityCommand.Name => "--man-page";

		bool IUtilityCommand.ValidateArguments(string[] args)
		{
			return true;
		}

		static void WriteFields(string key, object value)
		{
			var fields = Utility.GetFields(value.GetType());
			foreach (var field in fields)
			{
				if (!Utility.HasAttribute<DescAttribute>(field))
					continue;

				Console.WriteLine(".TP");
				Console.Write($".BR {key}.{field.Name}=");

				var fieldValue = field.GetValue(value)?.ToString();
				if (fieldValue != null && !fieldValue.StartsWith("System.", StringComparison.Ordinal))
					Console.WriteLine($"\\fI{fieldValue}\\fR");
				else
					Console.WriteLine();

				var lines = Utility.GetCustomAttributes<DescAttribute>(field, false).SelectMany(d => d.Lines);
				foreach (var line in lines)
					Console.WriteLine(line);
			}
		}

		[Desc("Create a man page in troff format.")]
		void IUtilityCommand.Run(Utility utility, string[] args)
		{
			Console.WriteLine(".TH Arklight 6");
			Console.WriteLine(".SH NAME");
			Console.WriteLine("Arklight \\- An Open Source modernization of the early 2D Command & Conquer games.");
			Console.WriteLine(".SH SYNOPSIS");
			Console.WriteLine(".B Arklight");
			Console.WriteLine("[\\fB\\Game.Mod=\\fR\\fIra\\fR]");
			Console.WriteLine(".SH DESCRIPTION");
			Console.WriteLine(".B Arklight");
			Console.WriteLine("starts the game.");
			Console.WriteLine(".SH OPTIONS");

			var sections = utility.ModData.ObjectCreator.GetTypesImplementing<SettingsModule>();
			foreach (var type in sections.OrderBy(s => s.Name))
			{
				var attribute = type.GetCustomAttribute<SettingsModule.YamlNodeAttribute>();
				if (attribute == null)
					continue;

				var defaults = (SettingsModule)utility.ModData.ObjectCreator.CreateBasic(type);
				WriteFields(attribute.Key, defaults);
			}

			WriteFields("Launch", new LaunchArguments(new Arguments()));

			Console.WriteLine(".SH FILES");
			Console.WriteLine("Settings are stored in the ~/.Arklight user folder.");
			Console.WriteLine(".SH BUGS");
			Console.WriteLine("Known issues are tracked at https://bugs.Arklight.net");
			Console.WriteLine(".SH COPYRIGHT");
			Console.WriteLine("Copyright (c) The Arklight Developers and Contributors");
			Console.WriteLine("This manual is part of Arklight, which is free software. It is GNU GPL v3 licensed. See COPYING for details.");
		}
	}
}

