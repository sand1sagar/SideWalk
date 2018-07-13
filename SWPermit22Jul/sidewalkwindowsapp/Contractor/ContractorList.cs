using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidewalkWindowsApp.Contractor
{
    public partial class ContractorList : Form
    {
        public ContractorList()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        /// <summary>
        /// /This function will load default data in form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContractorList_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// This button will open new dialog to create new contractor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewContractor newContractor = new NewContractor();
            newContractor.MdiParent = this.MdiParent;
            this.Close();
            newContractor.Show();
        }
    }
}
