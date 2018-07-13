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
    public partial class MarkForFormInspection : Form
    {
        public MarkForFormInspection()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        /// <summary>
        /// This function will load default data in form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarkForFormInspection_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
