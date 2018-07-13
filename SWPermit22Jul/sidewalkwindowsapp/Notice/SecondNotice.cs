using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidewalkWindowsApp.Notice
{
    public partial class SecondNotice : Form
    {
        public SecondNotice()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }
        /// <summary>
        /// This function will load default data in form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecondNotice_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
