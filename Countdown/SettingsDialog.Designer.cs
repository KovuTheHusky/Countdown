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
            this.grpNotify = new System.Windows.Forms.GroupBox();
            this.lblNotifyBody = new System.Windows.Forms.Label();
            this.txtNotifyBody = new System.Windows.Forms.TextBox();
            this.txtNotifyTitle = new System.Windows.Forms.TextBox();
            this.lblNotifyTitle = new System.Windows.Forms.Label();
            this.lblNotificationMethod = new System.Windows.Forms.Label();
            this.radNotificationMethodConditional = new System.Windows.Forms.RadioButton();
            this.radNotificationMethodDialogs = new System.Windows.Forms.RadioButton();
            this.radNotificationMethodBalloons = new System.Windows.Forms.RadioButton();
            this.grpCycle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCycleInterval)).BeginInit();
            this.grpStartup.SuspendLayout();
            this.grpNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCycle
            // 
            this.grpCycle.Controls.Add(this.btnCycleInterval);
            this.grpCycle.Controls.Add(this.numCycleInterval);
            this.grpCycle.Controls.Add(this.chkCycleEnabled);
            this.grpCycle.Location = new System.Drawing.Point(257, 138);
            this.grpCycle.Name = "grpCycle";
            this.grpCycle.Size = new System.Drawing.Size(225, 120);
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
            this.numCycleInterval.Location = new System.Drawing.Point(169, 39);
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
            this.chkCycleEnabled.Size = new System.Drawing.Size(213, 17);
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
            this.grpStartup.Location = new System.Drawing.Point(260, 12);
            this.grpStartup.Name = "grpStartup";
            this.grpStartup.Size = new System.Drawing.Size(222, 120);
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
            this.radStartupMinimized.Size = new System.Drawing.Size(142, 17);
            this.radStartupMinimized.TabIndex = 1;
            this.radStartupMinimized.Tag = "";
            this.radStartupMinimized.Text = "Open as notification &icon";
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
            this.btnOK.Location = new System.Drawing.Point(245, 264);
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
            this.btnCancel.Location = new System.Drawing.Point(326, 264);
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
            this.btnApply.Location = new System.Drawing.Point(407, 264);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // grpNotify
            // 
            this.grpNotify.Controls.Add(this.radNotificationMethodBalloons);
            this.grpNotify.Controls.Add(this.radNotificationMethodDialogs);
            this.grpNotify.Controls.Add(this.radNotificationMethodConditional);
            this.grpNotify.Controls.Add(this.lblNotificationMethod);
            this.grpNotify.Controls.Add(this.lblNotifyBody);
            this.grpNotify.Controls.Add(this.txtNotifyBody);
            this.grpNotify.Controls.Add(this.txtNotifyTitle);
            this.grpNotify.Controls.Add(this.lblNotifyTitle);
            this.grpNotify.Location = new System.Drawing.Point(12, 12);
            this.grpNotify.Name = "grpNotify";
            this.grpNotify.Size = new System.Drawing.Size(239, 246);
            this.grpNotify.TabIndex = 0;
            this.grpNotify.TabStop = false;
            this.grpNotify.Text = "Notification options";
            // 
            // lblNotifyBody
            // 
            this.lblNotifyBody.AutoSize = true;
            this.lblNotifyBody.Location = new System.Drawing.Point(6, 55);
            this.lblNotifyBody.Name = "lblNotifyBody";
            this.lblNotifyBody.Size = new System.Drawing.Size(79, 13);
            this.lblNotifyBody.TabIndex = 2;
            this.lblNotifyBody.Text = "Message &body:";
            // 
            // txtNotifyBody
            // 
            this.txtNotifyBody.AcceptsReturn = true;
            this.txtNotifyBody.Location = new System.Drawing.Point(6, 71);
            this.txtNotifyBody.Multiline = true;
            this.txtNotifyBody.Name = "txtNotifyBody";
            this.txtNotifyBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotifyBody.Size = new System.Drawing.Size(227, 83);
            this.txtNotifyBody.TabIndex = 3;
            this.txtNotifyBody.Text = "Event name: %n\r\nEvent category: %c\r\nEvent date: %ds\r\nEvent time: %ts";
            this.txtNotifyBody.TextChanged += new System.EventHandler(this.txtNotifyBody_TextChanged);
            // 
            // txtNotifyTitle
            // 
            this.txtNotifyTitle.Location = new System.Drawing.Point(6, 32);
            this.txtNotifyTitle.Name = "txtNotifyTitle";
            this.txtNotifyTitle.Size = new System.Drawing.Size(227, 20);
            this.txtNotifyTitle.TabIndex = 1;
            this.txtNotifyTitle.Text = "%n has occured.";
            this.txtNotifyTitle.TextChanged += new System.EventHandler(this.txtNotifyTitle_TextChanged);
            // 
            // lblNotifyTitle
            // 
            this.lblNotifyTitle.AutoSize = true;
            this.lblNotifyTitle.Location = new System.Drawing.Point(6, 16);
            this.lblNotifyTitle.Name = "lblNotifyTitle";
            this.lblNotifyTitle.Size = new System.Drawing.Size(72, 13);
            this.lblNotifyTitle.TabIndex = 0;
            this.lblNotifyTitle.Text = "Message &title:";
            // 
            // lblNotificationMethod
            // 
            this.lblNotificationMethod.AutoSize = true;
            this.lblNotificationMethod.Location = new System.Drawing.Point(6, 157);
            this.lblNotificationMethod.Name = "lblNotificationMethod";
            this.lblNotificationMethod.Size = new System.Drawing.Size(101, 13);
            this.lblNotificationMethod.TabIndex = 4;
            this.lblNotificationMethod.Text = "Notification method:";
            // 
            // radNotificationMethodConditional
            // 
            this.radNotificationMethodConditional.AutoSize = true;
            this.radNotificationMethodConditional.Checked = true;
            this.radNotificationMethodConditional.Location = new System.Drawing.Point(9, 173);
            this.radNotificationMethodConditional.Name = "radNotificationMethodConditional";
            this.radNotificationMethodConditional.Size = new System.Drawing.Size(223, 17);
            this.radNotificationMethodConditional.TabIndex = 5;
            this.radNotificationMethodConditional.TabStop = true;
            this.radNotificationMethodConditional.Text = "Dialog when maximized, balloon otherwise";
            this.radNotificationMethodConditional.UseVisualStyleBackColor = true;
            this.radNotificationMethodConditional.CheckedChanged += new System.EventHandler(this.radNotificationMethodConditional_CheckedChanged);
            // 
            // radNotificationMethodDialogs
            // 
            this.radNotificationMethodDialogs.AutoSize = true;
            this.radNotificationMethodDialogs.Location = new System.Drawing.Point(9, 196);
            this.radNotificationMethodDialogs.Name = "radNotificationMethodDialogs";
            this.radNotificationMethodDialogs.Size = new System.Drawing.Size(139, 17);
            this.radNotificationMethodDialogs.TabIndex = 6;
            this.radNotificationMethodDialogs.Text = "Show dialogs regardless";
            this.radNotificationMethodDialogs.UseVisualStyleBackColor = true;
            this.radNotificationMethodDialogs.CheckedChanged += new System.EventHandler(this.radNotificationMethodDialogs_CheckedChanged);
            // 
            // radNotificationMethodBalloons
            // 
            this.radNotificationMethodBalloons.AutoSize = true;
            this.radNotificationMethodBalloons.Location = new System.Drawing.Point(9, 219);
            this.radNotificationMethodBalloons.Name = "radNotificationMethodBalloons";
            this.radNotificationMethodBalloons.Size = new System.Drawing.Size(145, 17);
            this.radNotificationMethodBalloons.TabIndex = 7;
            this.radNotificationMethodBalloons.Text = "Show balloons regardless";
            this.radNotificationMethodBalloons.UseVisualStyleBackColor = true;
            this.radNotificationMethodBalloons.CheckedChanged += new System.EventHandler(this.radNotificationMethodBalloons_CheckedChanged);
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(494, 299);
            this.Controls.Add(this.grpNotify);
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
            this.grpNotify.ResumeLayout(false);
            this.grpNotify.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpNotify;
        private System.Windows.Forms.TextBox txtNotifyBody;
        private System.Windows.Forms.TextBox txtNotifyTitle;
        private System.Windows.Forms.Label lblNotifyTitle;
        private System.Windows.Forms.Label lblNotifyBody;
        private System.Windows.Forms.RadioButton radStartupDisabled;
        private System.Windows.Forms.RadioButton radStartupMinimized;
        private System.Windows.Forms.RadioButton radStartupMaximized;
        private System.Windows.Forms.Label lblNotificationMethod;
        private System.Windows.Forms.RadioButton radNotificationMethodBalloons;
        private System.Windows.Forms.RadioButton radNotificationMethodDialogs;
        private System.Windows.Forms.RadioButton radNotificationMethodConditional;
    }
}