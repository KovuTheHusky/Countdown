namespace Countdown
{
    partial class SettingsDialog
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.grpCycle = new System.Windows.Forms.GroupBox();
            this.btnCycleInterval = new System.Windows.Forms.Label();
            this.numCycleInterval = new System.Windows.Forms.NumericUpDown();
            this.chkCycleEnabled = new System.Windows.Forms.CheckBox();
            this.grpStartup = new System.Windows.Forms.GroupBox();
            this.radStartupDisabled = new System.Windows.Forms.RadioButton();
            this.radStartupMinimized = new System.Windows.Forms.RadioButton();
            this.radStartupMaximized = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.grpCycle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCycleInterval)).BeginInit();
            this.grpStartup.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCycle
            // 
            this.grpCycle.Controls.Add(this.btnCycleInterval);
            this.grpCycle.Controls.Add(this.numCycleInterval);
            this.grpCycle.Controls.Add(this.chkCycleEnabled);
            this.grpCycle.Location = new System.Drawing.Point(12, 12);
            this.grpCycle.Name = "grpCycle";
            this.grpCycle.Size = new System.Drawing.Size(237, 80);
            this.grpCycle.TabIndex = 2;
            this.grpCycle.TabStop = false;
            this.grpCycle.Text = "Event cycling";
            // 
            // btnCycleInterval
            // 
            this.btnCycleInterval.AutoSize = true;
            this.btnCycleInterval.Location = new System.Drawing.Point(6, 41);
            this.btnCycleInterval.Name = "btnCycleInterval";
            this.btnCycleInterval.Size = new System.Drawing.Size(162, 13);
            this.btnCycleInterval.TabIndex = 2;
            this.btnCycleInterval.Text = "&Seconds between each change:";
            // 
            // numCycleInterval
            // 
            this.numCycleInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCycleInterval.Location = new System.Drawing.Point(181, 39);
            this.numCycleInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numCycleInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCycleInterval.Name = "numCycleInterval";
            this.numCycleInterval.Size = new System.Drawing.Size(50, 20);
            this.numCycleInterval.TabIndex = 3;
            this.numCycleInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCycleInterval.ValueChanged += new System.EventHandler(this.numCycleInterval_ValueChanged);
            // 
            // chkCycleEnabled
            // 
            this.chkCycleEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCycleEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCycleEnabled.Checked = true;
            this.chkCycleEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCycleEnabled.Location = new System.Drawing.Point(6, 16);
            this.chkCycleEnabled.Name = "chkCycleEnabled";
            this.chkCycleEnabled.Size = new System.Drawing.Size(225, 17);
            this.chkCycleEnabled.TabIndex = 1;
            this.chkCycleEnabled.Text = "Enable &cycling through events:";
            this.chkCycleEnabled.UseVisualStyleBackColor = true;
            this.chkCycleEnabled.CheckedChanged += new System.EventHandler(this.chkCycleEnabled_CheckedChanged);
            // 
            // grpStartup
            // 
            this.grpStartup.Controls.Add(this.radStartupDisabled);
            this.grpStartup.Controls.Add(this.radStartupMinimized);
            this.grpStartup.Controls.Add(this.radStartupMaximized);
            this.grpStartup.Location = new System.Drawing.Point(12, 98);
            this.grpStartup.Name = "grpStartup";
            this.grpStartup.Size = new System.Drawing.Size(237, 100);
            this.grpStartup.TabIndex = 1;
            this.grpStartup.TabStop = false;
            this.grpStartup.Text = "Startup options";
            // 
            // radStartupDisabled
            // 
            this.radStartupDisabled.AutoSize = true;
            this.radStartupDisabled.Checked = true;
            this.radStartupDisabled.Location = new System.Drawing.Point(6, 65);
            this.radStartupDisabled.Name = "radStartupDisabled";
            this.radStartupDisabled.Size = new System.Drawing.Size(134, 17);
            this.radStartupDisabled.TabIndex = 2;
            this.radStartupDisabled.TabStop = true;
            this.radStartupDisabled.Tag = "";
            this.radStartupDisabled.Text = "Do not open on startu&p";
            this.radStartupDisabled.UseVisualStyleBackColor = true;
            this.radStartupDisabled.CheckedChanged += new System.EventHandler(this.radStartupDisabled_CheckedChanged);
            // 
            // radStartupMinimized
            // 
            this.radStartupMinimized.AutoSize = true;
            this.radStartupMinimized.Location = new System.Drawing.Point(6, 42);
            this.radStartupMinimized.Name = "radStartupMinimized";
            this.radStartupMinimized.Size = new System.Drawing.Size(99, 17);
            this.radStartupMinimized.TabIndex = 1;
            this.radStartupMinimized.Tag = "";
            this.radStartupMinimized.Text = "Open m&inimized";
            this.radStartupMinimized.UseVisualStyleBackColor = true;
            this.radStartupMinimized.CheckedChanged += new System.EventHandler(this.radStartupMinimized_CheckedChanged);
            // 
            // radStartupMaximized
            // 
            this.radStartupMaximized.AutoSize = true;
            this.radStartupMaximized.Location = new System.Drawing.Point(6, 19);
            this.radStartupMaximized.Name = "radStartupMaximized";
            this.radStartupMaximized.Size = new System.Drawing.Size(102, 17);
            this.radStartupMaximized.TabIndex = 0;
            this.radStartupMaximized.Tag = "";
            this.radStartupMaximized.Text = "Open &maximized";
            this.radStartupMaximized.UseVisualStyleBackColor = true;
            this.radStartupMaximized.CheckedChanged += new System.EventHandler(this.radStartupMaximized_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 204);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(174, 204);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(261, 239);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpStartup);
            this.Controls.Add(this.grpCycle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.grpCycle.ResumeLayout(false);
            this.grpCycle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCycleInterval)).EndInit();
            this.grpStartup.ResumeLayout(false);
            this.grpStartup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCycle;
        private System.Windows.Forms.GroupBox grpStartup;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.NumericUpDown numCycleInterval;
        private System.Windows.Forms.CheckBox chkCycleEnabled;
        private System.Windows.Forms.Label btnCycleInterval;
        private System.Windows.Forms.RadioButton radStartupDisabled;
        private System.Windows.Forms.RadioButton radStartupMinimized;
        private System.Windows.Forms.RadioButton radStartupMaximized;
    }
}