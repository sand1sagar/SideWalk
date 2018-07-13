using Sidewalk.Logic;
using SidewalkWindowsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidewalkWindowsApp.CityContract
{
    public partial class CityContract : Form
    {
        RepairItemLogic repairLogic = new RepairItemLogic();
        public CityContract()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        /// <summary>
        /// This functionn will load default values in form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityContract_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if(string.IsNullOrEmpty(cmbContract.Text))
            {
                repairItemGrid.DataSource = repairLogic.GetRepairItems();
            }
        }
    }
}
