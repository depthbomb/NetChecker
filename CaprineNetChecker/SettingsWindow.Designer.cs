namespace CaprineNetChecker
{
	partial class SettingsWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
			this._checkInterval = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this._intervalDisplay = new System.Windows.Forms.Label();
			this._showCheckFeedback = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._saveButton = new System.Windows.Forms.Button();
			this._enableStartup = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this._checkInterval)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _checkInterval
			// 
			this._checkInterval.Location = new System.Drawing.Point(6, 111);
			this._checkInterval.Maximum = 60;
			this._checkInterval.Minimum = 1;
			this._checkInterval.Name = "_checkInterval";
			this._checkInterval.Size = new System.Drawing.Size(344, 45);
			this._checkInterval.TabIndex = 2;
			this._checkInterval.Value = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Check Interval";
			// 
			// _intervalDisplay
			// 
			this._intervalDisplay.AutoSize = true;
			this._intervalDisplay.Location = new System.Drawing.Point(288, 95);
			this._intervalDisplay.Name = "_intervalDisplay";
			this._intervalDisplay.Size = new System.Drawing.Size(62, 13);
			this._intervalDisplay.TabIndex = 4;
			this._intervalDisplay.Text = "60 seconds";
			// 
			// _showCheckFeedback
			// 
			this._showCheckFeedback.AutoSize = true;
			this._showCheckFeedback.Location = new System.Drawing.Point(6, 19);
			this._showCheckFeedback.Name = "_showCheckFeedback";
			this._showCheckFeedback.Size = new System.Drawing.Size(162, 17);
			this._showCheckFeedback.TabIndex = 5;
			this._showCheckFeedback.Text = "Change icon when checking";
			this._showCheckFeedback.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._enableStartup);
			this.groupBox1.Controls.Add(this._showCheckFeedback);
			this.groupBox1.Controls.Add(this._intervalDisplay);
			this.groupBox1.Controls.Add(this._checkInterval);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(356, 162);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			// 
			// _saveButton
			// 
			this._saveButton.Image = global::CaprineNetChecker.Properties.Resources.disk;
			this._saveButton.Location = new System.Drawing.Point(12, 180);
			this._saveButton.Name = "_saveButton";
			this._saveButton.Size = new System.Drawing.Size(356, 35);
			this._saveButton.TabIndex = 0;
			this._saveButton.Text = "Save";
			this._saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._saveButton.UseVisualStyleBackColor = true;
			// 
			// _enableStartup
			// 
			this._enableStartup.AutoSize = true;
			this._enableStartup.Location = new System.Drawing.Point(6, 43);
			this._enableStartup.Name = "_enableStartup";
			this._enableStartup.Size = new System.Drawing.Size(117, 17);
			this._enableStartup.TabIndex = 6;
			this._enableStartup.Text = "Start with Windows";
			this._enableStartup.UseVisualStyleBackColor = true;
			// 
			// SettingsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 227);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this._saveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsWindow";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NetChecker";
			((System.ComponentModel.ISupportInitialize)(this._checkInterval)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _saveButton;
		private System.Windows.Forms.TrackBar _checkInterval;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label _intervalDisplay;
		private System.Windows.Forms.CheckBox _showCheckFeedback;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox _enableStartup;
	}
}