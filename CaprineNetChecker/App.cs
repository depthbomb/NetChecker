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

	CaprineNetChecker/App.cs created at 6/15/2020 00:48
*/
#endregion License
using System;
using System.Linq;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection;

namespace CaprineNetChecker
{
	public class App : ApplicationContext
	{
		private readonly Random Rng;
		private readonly HttpClient Client;
		private readonly System.Timers.Timer CheckTimer;
		private readonly List<string> RequestSubdomains = new List<string>
		{
			"docs",
			"images",
			"maps",
			"mt0",
			"mt1",
			"mt2",
			"mt3",
			"clients1",
			"clients2",
			"clients3",
			"clients4",
			"clients5",
			"clients6",
		};
		private readonly Dictionary<string, IntPtr> Icons = new Dictionary<string, IntPtr>()
		{
			["help"] = Properties.Resources.help.GetHicon(),
			["error"] = Properties.Resources.error.GetHicon(),
			["exclamation"] = Properties.Resources.exclamation.GetHicon(),
			["accept"] = Properties.Resources.accept.GetHicon(),
		};
		private readonly Properties.Settings Settings = Properties.Settings.Default;

		private bool Checking = false;

		public static NotifyIcon TrayIcon;

		public App()
		{
			Rng = new Random();
			Client = new HttpClient();

			SetUpTrayIcon();
			SetUpTrayIconMenus();

			CheckTimer = new System.Timers.Timer
			{
				Interval = Settings.CheckInterval*1000,
				AutoReset = true
			};

			CheckTimer.Elapsed += async (object sender, System.Timers.ElapsedEventArgs e) => await CheckInternet();

			Task.Run(async () => await CheckInternet());

			CheckTimer.Start();
		}

		private void SetUpTrayIcon()
		{
			TrayIcon = new NotifyIcon
			{
				Text = "Starting...",
				Icon = Icon.FromHandle(Icons["help"])
			};

			TrayIcon.DoubleClick += (object sender, EventArgs e) =>
			{
				var settingsWindow = new SettingsWindow();
				settingsWindow.ShowDialog();
			};
		}

		private void SetUpTrayIconMenus()
		{
			var aboutItem = new MenuItem("About", (object sender, EventArgs e) => ShowWindow("AboutWindow"));
			var settingsItem = new MenuItem("Settings", (object sender, EventArgs e) => ShowWindow("SettingsWindow"));
			var exitMenuItem = new MenuItem("Exit", (object sender, EventArgs e) =>
			{
				TrayIcon.Visible = false;
				TrayIcon.Dispose();
				Application.Exit();
			});

			TrayIcon.ContextMenu = new ContextMenu(new MenuItem[]
			{
				aboutItem,
				settingsItem,
				exitMenuItem
			});

			TrayIcon.Visible = true;
		}

		private async Task CheckInternet()
		{
			// To prevent running again if a check is taking a long time
			if (!Checking)
			{
				Checking = true;
				TrayIcon.Text = "Checking";

				if(Settings.ShowCheckFeedback)
				{
					SetIcon("help");
				}

				int n = RequestSubdomains.Count;
				while (n > 1)
				{
					n--;
					int k = Rng.Next(n + 1);
					string value = RequestSubdomains[k];
					RequestSubdomains[k] = RequestSubdomains[n];
					RequestSubdomains[n] = value;
				}

				try
				{
					string subdomain = RequestSubdomains.First();
					var res = await Client.GetAsync($"https://{subdomain}.google.com/generate_204");

					TrayIcon.Text = "Connected to the internet!";
					SetIcon("accept");
				}
				catch
				{
					// TODO: Handle different exceptions accordingly
					TrayIcon.Text = "No Internet connection";
					SetIcon("exclamation");
				}

				Checking = false;
			}
		}

		private void SetIcon(string key)
		{
			TrayIcon.Icon = Icon.FromHandle(Icons[key]);
		}

		/// <summary>
		/// Creates and displays a <see cref="Form">Form</see> if it isn't already instantiated
		/// </summary>
		/// <param name="formName"></param>
		private void ShowWindow(string formName)
		{
			var forms = Application.OpenForms.Cast<Form>(); // Cast because FormCollection by itself doesn't implement IEnumerable<T>
			if (!forms.Any(f => f.Name == formName))
			{
				var ass = Assembly.GetExecutingAssembly();
				var type = ass.GetTypes().First(t => t.Name == formName);
				var formWindow = (Form)Activator.CreateInstance(type);
					formWindow.ShowDialog();
			}
		}
	}
}
