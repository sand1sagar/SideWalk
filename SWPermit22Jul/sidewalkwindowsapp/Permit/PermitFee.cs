using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidewalkWindowsApp.Permit
{
    public partial class PermitFee : Form
    {
        public PermitFee()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        /// <summary>
        /// This function will load default data in form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PermitFee_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// This button will create new rate and update existing one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createRate_Click(object sender, EventArgs e)
        {
            NewActionRate newAction = new NewActionRate();
            newAction.Show();
        }
    }
}
