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

	CaprineNetChecker/AboutWindow.cs created at 6/15/2020 16:41
*/
#endregion License
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CaprineNetChecker
{
	public partial class AboutWindow : Form
	{
		private AboutWindow Self;
		private PictureBox AuthorAvatar;
		private Label VersionLabel;
		private LinkLabel IconsLink;

		public AboutWindow()
		{
			Self = this;

			InitializeComponent();

			AuthorAvatar = Self._authorAvatar;
			VersionLabel = Self._versionLabel;
			IconsLink = Self._iconsLink;

			AuthorAvatar.Image = Properties.Resources.AuthorAvatar;
			VersionLabel.Text = AppVersion.Full;
			IconsLink.Click += (object sender, EventArgs e) => Process.Start("https://codefisher.org/pastel-svg/");
		}
	}
}
