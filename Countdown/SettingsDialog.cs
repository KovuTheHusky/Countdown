using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Countdown.Settings;
using Microsoft.Win32;

namespace Countdown
{
    public partial class SettingsDialog : Form
    {
        Preferences prefs = null;

        public SettingsDialog(Preferences preferences)
        {
            InitializeComponent();
            this.prefs = preferences;
            txtNotifyTitle.Text = preferences.Notification.Title;
            txtNotifyBody.Lines = preferences.Notification.Body;
            switch (preferences.Notification.Method)
            {
                case NotificationMethod.Balloon:
                    radNotificationMethodBalloons.Checked = true;
                    break;
                case NotificationMethod.Dialog:
                    radNotificationMethodDialogs.Checked = true;
                    break;
                case NotificationMethod.Conditional:
                    radNotificationMethodConditional.Checked = true;
                    break;
            }
            switch (preferences.Startup.Method)
            {
                case StartupMethod.Maximized:
                    radStartupMaximized.Checked = true;
                    break;
                case StartupMethod.Minimized:
                    radStartupMinimized.Checked = true;
                    break;
                case StartupMethod.Disabled:
                    radStartupDisabled.Checked = true;
                    break;
            }
            chkCycleEnabled.Checked = preferences.Cycle.Enabled;
            numCycleInterval.Value = (decimal)(preferences.Cycle.Interval / 1000);
            btnApply.Enabled = false;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            prefs.Notification.Title = txtNotifyTitle.Text;
            prefs.Notification.Body = txtNotifyBody.Lines;
            if (radNotificationMethodBalloons.Checked)
                prefs.Notification.Method = NotificationMethod.Balloon;
            else if (radNotificationMethodDialogs.Checked)
                prefs.Notification.Method = NotificationMethod.Dialog;
            else
                prefs.Notification.Method = NotificationMethod.Conditional;
            if (radStartupMaximized.Checked)
                prefs.Startup.Method = StartupMethod.Maximized;
            else if (radStartupMinimized.Checked)
                prefs.Startup.Method = StartupMethod.Minimized;
            else
                prefs.Startup.Method = StartupMethod.Disabled;
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (prefs.Startup.Method != StartupMethod.Disabled)
                key.SetValue("Countdown", "\"" + Application.ExecutablePath + "\" /startup");
            else if (key.GetValue("Countdown") != null)
                key.DeleteValue("Countdown");
            key.Close();
            prefs.Cycle.Enabled = chkCycleEnabled.Checked;
            prefs.Cycle.Interval = (int)numCycleInterval.Value * 1000;
            GenericSerializer.SerializeXML<Preferences>("Countdown.prefs", prefs);
            btnApply.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnApply.PerformClick();
            this.Close();
        }

        private void txtNotifyTitle_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void txtNotifyBody_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void radStartupMaximized_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void radStartupMinimized_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void radStartupDisabled_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void chkCycleEnabled_CheckedChanged(object sender, EventArgs e)
        {
            numCycleInterval.Enabled = chkCycleEnabled.Checked;
            btnApply.Enabled = true;
        }

        private void numCycleInterval_ValueChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void radNotificationMethodConditional_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void radNotificationMethodDialogs_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void radNotificationMethodBalloons_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }
    }
}