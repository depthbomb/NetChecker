namespace CaprineNetChecker
{
	partial class AboutWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
			this._authorAvatar = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this._versionLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._iconsLink = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._authorAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// _authorAvatar
			// 
			this._authorAvatar.InitialImage = global::CaprineNetChecker.Properties.Resources.AuthorAvatar;
			this._authorAvatar.Location = new System.Drawing.Point(12, 12);
			this._authorAvatar.Name = "_authorAvatar";
			this._authorAvatar.Size = new System.Drawing.Size(72, 72);
			this._authorAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this._authorAvatar.TabIndex = 0;
			this._authorAvatar.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(90, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "NetChecker";
			// 
			// _versionLabel
			// 
			this._versionLabel.AutoSize = true;
			this._versionLabel.Location = new System.Drawing.Point(223, 21);
			this._versionLabel.Name = "_versionLabel";
			this._versionLabel.Size = new System.Drawing.Size(45, 13);
			this._versionLabel.TabIndex = 2;
			this._versionLabel.Text = "Loading";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "A project by depthbomb";
			// 
			// _iconsLink
			// 
			this._iconsLink.AutoSize = true;
			this._iconsLink.LinkArea = new System.Windows.Forms.LinkArea(0, 11);
			this._iconsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this._iconsLink.Location = new System.Drawing.Point(210, 71);
			this._iconsLink.Name = "_iconsLink";
			this._iconsLink.Size = new System.Drawing.Size(60, 13);
			this._iconsLink.TabIndex = 4;
			this._iconsLink.TabStop = true;
			this._iconsLink.Text = "Codefisher.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(95, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Pastel SVG Icon Set by";
			// 
			// AboutWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 98);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._iconsLink);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._versionLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._authorAvatar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutWindow";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About NetChecker";
			((System.ComponentModel.ISupportInitialize)(this._authorAvatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox _authorAvatar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label _versionLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel _iconsLink;
		private System.Windows.Forms.Label label3;
	}
}