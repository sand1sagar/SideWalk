using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidewalkWindowsApp.Inspection
{
    public partial class FormInspection : Form
    {
        public FormInspection()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void rdoPour_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoPour.Checked)
            {
                doNotPourSection.Enabled = false;
                pourSection.Enabled = true;
            }
        }

        private void rdoDoNotPour_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoDoNotPour.Checked)
            {
                pourSection.Enabled = false;
                doNotPourSection.Enabled = true;
            }
        }

        private void FormInspection_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
