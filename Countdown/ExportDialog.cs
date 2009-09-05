using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Countdown
{
    public partial class ExportDialog : Form
    {
        private string cat;

        public string Category
        {
            get { return cat; }
        }

        public ExportDialog(Main main)
        {
            InitializeComponent();
            cboEventCategory.Items.AddRange(main.GetEventCategories());
            cboEventCategory.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cat = cboEventCategory.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
