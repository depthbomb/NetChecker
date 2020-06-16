#region License
/*
	CaprineNetChecker
	Copyright(C) 2020 Caprine Logic
	
	This program is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.
	
	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
	GNU General Public License for more details.
	
	You should have received a copy of the GNU General Public License
	along with this program. If not, see<https://www.gnu.org/licenses/>.

	====================================================================

	CaprineNetChecker/Program.cs created at 6/15/2020 00:47
*/
#endregion License
using System;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CaprineNetChecker
{
	static class Program
	{
		private static readonly string Guid = ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value.ToString();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			using(var mutex = new Mutex(false, string.Format("Global\\{{{0}}}", Guid)))
			{
				if (!mutex.WaitOne(0, false))
				{
					return;
				}

				Application.Run(new App());
			}
		}
	}
}
