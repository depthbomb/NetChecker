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

	CaprineNetChecker/SettingsWindow.cs created at 6/15/2020 12:00
*/
#endregion License
using System;
using System.Diagnostics;
using System.Windows.Forms;

using Microsoft.Win32;

namespace CaprineNetChecker
{
	internal partial class SettingsWindow : Form
	{
		private SettingsWindow Self;

		private CheckBox ShowCheckFeedback;
		private CheckBox RunAtStartup;
		private TrackBar CheckIntervalTrackBar;
		private Label CheckIntervalDisplay;
		private Button SaveButton;

		private bool HandleStartup = false; // If the user changes the checkbox state
		private Properties.Settings Settings = Properties.Settings.Default;
		private RegistryKey StartupKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);

		public SettingsWindow()
		{
			Self = this;

			InitializeComponent();

			ShowCheckFeedback = Self._showCheckFeedback;
			RunAtStartup = Self._enableStartup;
			CheckIntervalTrackBar = Self._checkInterval;
			CheckIntervalDisplay = Self._intervalDisplay;
			SaveButton = Self._saveButton;

			ShowCheckFeedback.Checked = Settings.ShowCheckFeedback;
			RunAtStartup.Checked = StartupKey.GetValue("NetChecker") != null;
			CheckIntervalTrackBar.Value = Settings.CheckInterval;
			CheckIntervalDisplay.Text = $"{Settings.CheckInterval} {(Settings.CheckInterval > 1 ? "seconds" : "second")}";

			ShowCheckFeedback.HelpRequested += (object sender, HelpEventArgs e) =>
			{
				MessageBox.Show("This option changes the tray icon to an indeterminate icon for the duration of each check NetChecker performs. However, the check is usually so quick that it might not even appear that the icon is changing.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
			};
			RunAtStartup.CheckedChanged += (object sender, EventArgs e) => HandleStartup = true;
			RunAtStartup.HelpRequested += (object sender, HelpEventArgs e) =>
			{
				MessageBox.Show("This option registers NetChecker to run when Windows starts up.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
			};
			CheckIntervalTrackBar.HelpRequested += (object sender, HelpEventArgs e) =>
			{
				MessageBox.Show("This option sets the interval at which NetChecker will check for Internet connectivity.\nNetChecker will need to be restarted if you change this setting.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
			};
			CheckIntervalTrackBar.ValueChanged += CheckIntervalTrackBar_ValueChanged;
			SaveButton.Click += SaveButton_Click;
			SaveButton.HelpRequested += (object sender, HelpEventArgs e) =>
			{
				MessageBox.Show("This saves all changes made and closes the settings window. Settings will not be saved until this button is clicked.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
			};
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			bool restart = CheckIntervalTrackBar.Value != Settings.CheckInterval;

			Settings.ShowCheckFeedback = ShowCheckFeedback.Checked;
			Settings.CheckInterval = CheckIntervalTrackBar.Value;

			Settings.Save();

			if (HandleStartup)
			{
				string exePath = Application.ExecutablePath;
				if (RunAtStartup.Checked)
				{
					StartupKey.SetValue("NetChecker", exePath);
				}
				else
				{
					// So we don't crash if the value is already deleted/nonexistent
					try
					{
						StartupKey.DeleteValue("NetChecker");
					}
					catch { }
				}
			}

			if (restart)
			{
				DialogResult result = MessageBox.Show("NetChecker needs to be restarted for your changes to take effect.\nWould you like to restart it now?", "NetChecker Restart Required", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
				if (result == DialogResult.Yes)
				{
					Process.Start("NetChecker.exe");
					App.TrayIcon.Visible = false;
					App.TrayIcon.Dispose();
					Application.Exit();
				}
			}

			Self.Dispose();
		}

		/// <summary>
		/// Update the interval display because WinForms doesn't have an option for that in TrackBar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckIntervalTrackBar_ValueChanged(object sender, EventArgs e)
		{
			int value = CheckIntervalTrackBar.Value;
			CheckIntervalDisplay.Text = $"{value} {(value > 1 ? "seconds" : "second")}";
		}
	}
}
