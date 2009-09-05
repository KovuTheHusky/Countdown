﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Countdown
{
    public partial class EventDialog : Form
    {
        private EventData evt = null;

        public EventData Event
        {
            get { return evt; }
        }

        public EventDialog(Main main) : this(main, EventData.Empty) { }

        public EventDialog(Main main, EventData evt)
        {
            InitializeComponent();
            cboEventCategory.Items.AddRange(main.GetEventCategories());
            txtEventName.Text = evt.Name;
            cboEventCategory.Text = evt.Category;
            dtpEventDate.Value = evt.Time.Date;
            dtpEventTime.Value = evt.Time;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool returnError = false;
            lblName.ForeColor = Color.Black;
            lblDate.ForeColor = Color.Black;
            lblTime.ForeColor = Color.Black;
            if (txtEventName.Text.Length < 1)
            {
                lblName.ForeColor = Color.Red;
                returnError = true;
            }
            if (dtpEventDate.Value.Date < DateTime.Now.Date)
            {
                lblDate.ForeColor = Color.Red;
                returnError = true;
            }
            if (dtpEventDate.Value.Date == DateTime.Now.Date && dtpEventTime.Value.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                lblTime.ForeColor = Color.Red;
                returnError = true;
            }
            if (returnError)
                return;
            if (cboEventCategory.Text == "")
                cboEventCategory.Text = "Events";
            evt = new EventData(txtEventName.Text, new DateTime(dtpEventDate.Value.Year, dtpEventDate.Value.Month, dtpEventDate.Value.Day, dtpEventTime.Value.Hour, dtpEventTime.Value.Minute, dtpEventTime.Value.Second), cboEventCategory.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}