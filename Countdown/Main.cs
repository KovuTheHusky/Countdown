using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Countdown.Settings;

namespace Countdown
{
    public partial class Main : Form
    {
        private List<EventData> events = GenericSerializer.DeserializeXML<List<EventData>>("Events.xml", false) ?? new List<EventData>();
        private Preferences prefs = GenericSerializer.DeserializeXML<Preferences>("Countdown.prefs", false) ?? new Preferences();
        private int index = 0;
        private bool exitClicked = false;

        public Main()
        {
            InitializeComponent();
            tmrCycle.Interval = prefs.Cycle.Interval;
            tmrCycle.Enabled = prefs.Cycle.Enabled;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitClicked)
                this.Visible = !(e.Cancel = true);
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            List<EventData> evts = null;
            FileInfo fi = null;
            foreach (string filename in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if ((fi = new FileInfo(filename)).Extension == ".xml")
                {
                    if ((evts = GenericSerializer.DeserializeXML<List<EventData>>(filename, false)) != null)
                        events.AddRange(evts);
                }
            }
            GenericSerializer.SerializeXML<List<EventData>>("Events.xml", events);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tmrCycle.Enabled = false;
            if (--index < 0)
                index = (events.Count > 0) ? events.Count - 1 : 0;
            tmrCycle.Enabled = prefs.Cycle.Enabled;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tmrCycle.Enabled = false;
            if (++index > events.Count - 1)
                index = 0;
            tmrCycle.Enabled = prefs.Cycle.Enabled;
        }

        private void miAddEvent_Click(object sender, EventArgs e)
        {
            EventDialog ed = new EventDialog(this);
            ed.ShowDialog();
            if (ed.DialogResult == DialogResult.OK)
            {
                events.Add(ed.Event);
                ed.Dispose();
                ed = null;
                tmrCycle.Enabled = false;
                if (++index > events.Count - 1)
                    index = 0;
                tmrCycle.Enabled = prefs.Cycle.Enabled;
                GenericSerializer.SerializeXML<List<EventData>>("Events.xml", events);
            }
        }

        private void miEditEvent_Click(object sender, EventArgs e)
        {
            EventData temp = events[index];
            EventDialog ed = new EventDialog(this, temp);
            ed.ShowDialog();
            if (ed.DialogResult == DialogResult.OK)
            {
                events.Add(ed.Event);
                events.Remove(temp);
                ed.Dispose();
                ed = null;
                tmrCycle.Enabled = false;
                if (++index > events.Count - 1)
                    index = 0;
                tmrCycle.Enabled = prefs.Cycle.Enabled;
                GenericSerializer.SerializeXML<List<EventData>>("Events.xml", events);
            }
        }

        private void miRemoveEvent_Click(object sender, EventArgs e)
        {
            events.RemoveAt(index);
            tmrCycle.Enabled = false;
            if (++index > events.Count - 1)
                index = 0;
            tmrCycle.Enabled = prefs.Cycle.Enabled;
            GenericSerializer.SerializeXML<List<EventData>>("Events.xml", events);
        }

        private void miImportEvents_Click(object sender, EventArgs e)
        {
            ofdImporter.ShowDialog();
        }

        private void ofdImporter_FileOk(object sender, CancelEventArgs e)
        {
            List<EventData> evts = null;
            FileInfo fi = null;
            foreach (string filename in ofdImporter.FileNames)
            {
                if ((fi = new FileInfo(filename)).Extension == ".xml")
                {
                    if ((evts = GenericSerializer.DeserializeXML<List<EventData>>(filename, false)) != null)
                        events.AddRange(evts);
                }
            }
            GenericSerializer.SerializeXML<List<EventData>>("Events.xml", events);
        }

        private void miExportEvents_Click(object sender, EventArgs e)
        {
            ExportDialog ed = new ExportDialog(this);
            ed.ShowDialog();
            if (ed.DialogResult == DialogResult.OK)
            {
                List<EventData> evts = new List<EventData>();
                foreach (EventData evt in events)
                {
                    if (evt.Category == ed.Category)
                        evts.Add(evt);
                }
                GenericSerializer.SerializeXML<List<EventData>>("Events.tmp", evts);
                sfdExporter.ShowDialog();
            }
        }

        private void sfdExporter_FileOk(object sender, CancelEventArgs e)
        {
            File.Move("Events.tmp", sfdExporter.FileName);
        }

        private void miOptions_Click(object sender, EventArgs e)
        {
            new SettingsDialog(prefs).ShowDialog();
            tmrCycle.Interval = prefs.Cycle.Interval;
            tmrCycle.Enabled = prefs.Cycle.Enabled;
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            exitClicked = true;
            this.Close();
        }

        private void niMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void ctxMain_Opening(object sender, CancelEventArgs e)
        {
            tmrCycle.Enabled = false;
            if (events.Count > 0 && this.Visible == true)
            {
                miEditEvent.Enabled = true;
                miRemoveEvent.Enabled = true;
            }
        }

        private void ctxMain_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            miEditEvent.Enabled = false;
            miRemoveEvent.Enabled = false;
            tmrCycle.Enabled = prefs.Cycle.Enabled;
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            tmrMain.Enabled = false;
            if (events.Count > 0)
            {
                if (index < 0)
                    index = (events.Count > 0) ? index : 0;
                else if (index > events.Count - 1)
                    index = 0;
                lblName.Text = events[index].Category + ": " + events[index].Name;
                TimeSpan t = events[index].Time.Subtract(DateTime.Now);
                lblDays.Text = t.Days.ToString();
                lblHours.Text = t.Hours.ToString();
                lblMinutes.Text = t.Minutes.ToString();
                lblSeconds.Text = t.Seconds.ToString();
            }
            else
            {
                lblName.Text = "There are no events. Displaying the current system time.";
                DateTime t = DateTime.Now;
                lblDays.Text = t.DayOfYear.ToString();
                lblHours.Text = t.Hour.ToString();
                lblMinutes.Text = t.Minute.ToString();
                lblSeconds.Text = t.Second.ToString();
            }
            tmrMain.Enabled = true;
        }

        private void tmrCycle_Tick(object sender, EventArgs e)
        {
            tmrCycle.Enabled = false;
            if (++index > events.Count - 1)
                index = 0;
            tmrCycle.Enabled = true;
        }

        public string[] GetEventNames()
        {
            List<string> ls = new List<string>();
            foreach (EventData evt in events)
            {
                if (!ls.Contains(evt.Name))
                    ls.Add(evt.Name);
            }
            return ls.ToArray();
        }

        public string[] GetEventCategories()
        {
            List<string> ls = new List<string>();
            foreach (EventData evt in events)
            {
                if (!ls.Contains(evt.Category))
                    ls.Add(evt.Category);
            }
            return ls.ToArray();
        }
    }
}