using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidewalkWindowsApp.Affidavit
{
    public partial class ChangeStatus : Form
    {
        public ChangeStatus()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This button will close dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This will load default values in form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeStatus_Load(object sender, EventArgs e)
        {
            txtNewStatusDate.Text = DateTime.Now.ToShortDateString();
            txtNewStatusDate.ReadOnly = true;
        }
    }
}
