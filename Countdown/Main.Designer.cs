namespace Countdown
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label5 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctxMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemoveEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.miOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.tmrCycle = new System.Windows.Forms.Timer(this.components);
            this.ofdImporter = new System.Windows.Forms.OpenFileDialog();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.sfdExporter = new System.Windows.Forms.SaveFileDialog();
            this.ctxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "seconds";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeconds
            // 
            this.lblSeconds.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeconds.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(562, 39);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(124, 87);
            this.lblSeconds.TabIndex = 26;
            this.lblSeconds.Text = "0";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "minutes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutes
            // 
            this.lblMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMinutes.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(432, 39);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(124, 87);
            this.lblMinutes.TabIndex = 24;
            this.lblMinutes.Text = "0";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "hours";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHours.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(302, 39);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(124, 87);
            this.lblHours.TabIndex = 22;
            this.lblHours.Text = "0";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDays
            // 
            this.lblDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDays.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(48, 39);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(248, 87);
            this.lblDays.TabIndex = 21;
            this.lblDays.Text = "0";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "days";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctxMain
            // 
            this.ctxMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddEvent,
            this.miEditEvent,
            this.miRemoveEvent,
            this.miOptions,
            this.miExit});
            this.ctxMain.Name = "ctxMain";
            this.ctxMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ctxMain.Size = new System.Drawing.Size(153, 136);
            this.ctxMain.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMain_Opening);
            this.ctxMain.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.ctxMain_Closing);
            // 
            // miAddEvent
            // 
            this.miAddEvent.Image = global::Countdown.Properties.Resources.Add;
            this.miAddEvent.Name = "miAddEvent";
            this.miAddEvent.Size = new System.Drawing.Size(152, 22);
            this.miAddEvent.Text = "Add Event";
            this.miAddEvent.Click += new System.EventHandler(this.miAddEvent_Click);
            // 
            // miEditEvent
            // 
            this.miEditEvent.Enabled = false;
            this.miEditEvent.Image = global::Countdown.Properties.Resources.Edit;
            this.miEditEvent.Name = "miEditEvent";
            this.miEditEvent.Size = new System.Drawing.Size(152, 22);
            this.miEditEvent.Text = "Edit Event";
            this.miEditEvent.Click += new System.EventHandler(this.miEditEvent_Click);
            // 
            // miRemoveEvent
            // 
            this.miRemoveEvent.Enabled = false;
            this.miRemoveEvent.Image = global::Countdown.Properties.Resources.Remove;
            this.miRemoveEvent.Name = "miRemoveEvent";
            this.miRemoveEvent.Size = new System.Drawing.Size(152, 22);
            this.miRemoveEvent.Text = "Remove Event";
            this.miRemoveEvent.Click += new System.EventHandler(this.miRemoveEvent_Click);
            // 
            // miOptions
            // 
            this.miOptions.Image = global::Countdown.Properties.Resources.Options;
            this.miOptions.Name = "miOptions";
            this.miOptions.Size = new System.Drawing.Size(152, 22);
            this.miOptions.Text = "Options...";
            this.miOptions.Click += new System.EventHandler(this.miOptions_Click);
            // 
            // miExit
            // 
            this.miExit.Image = global::Countdown.Properties.Resources.Exit;
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(152, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // niMain
            // 
            this.niMain.ContextMenuStrip = this.ctxMain;
            this.niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niMain.Icon")));
            this.niMain.Text = "Countdown";
            this.niMain.Visible = true;
            this.niMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niMain_MouseDoubleClick);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(48, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(638, 19);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "There are no events. Displaying the current system time.";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCycle
            // 
            this.tmrCycle.Enabled = true;
            this.tmrCycle.Interval = 10000;
            this.tmrCycle.Tick += new System.EventHandler(this.tmrCycle_Tick);
            // 
            // ofdImporter
            // 
            this.ofdImporter.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.ofdImporter.Multiselect = true;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = global::Countdown.Properties.Resources.Next;
            this.btnNext.Location = new System.Drawing.Point(692, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 140);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Image = global::Countdown.Properties.Resources.Previous;
            this.btnPrev.Location = new System.Drawing.Point(12, 12);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 140);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // sfdExporter
            // 
            this.sfdExporter.DefaultExt = "xml";
            this.sfdExporter.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 166);
            this.ContextMenuStrip = this.ctxMain;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 200);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ctxMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip ctxMain;
        private System.Windows.Forms.ToolStripMenuItem miAddEvent;
        private System.Windows.Forms.ToolStripMenuItem miOptions;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.ToolStripMenuItem miRemoveEvent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer tmrCycle;
        private System.Windows.Forms.OpenFileDialog ofdImporter;
        private System.Windows.Forms.ToolStripMenuItem miEditEvent;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.SaveFileDialog sfdExporter;

    }
}

