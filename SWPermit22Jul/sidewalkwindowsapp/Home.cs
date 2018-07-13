using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidewalkWindowsApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This will open affidavit screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void affidavitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affidavit.Affidavit affidavit = new Affidavit.Affidavit();
            affidavit.MdiParent = this;
            affidavit.Show();
        }

        public void MDIViewLoad()
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = Color.LightBlue;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MDIViewLoad();
        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This will open side walk repair notice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noticeLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notice.SidewalkRepairNotice notice = new Notice.SidewalkRepairNotice();
            notice.MdiParent = this;
            notice.Show();
        }

        /// <summary>
        /// This will open permit application screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applicantAppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permit.PermitApplication permit = new Permit.PermitApplication();
            permit.MdiParent = this;
            permit.Show();
        }
        /// <summary>
        /// This will open permit review screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void staffReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permit.PermitReview review = new Permit.PermitReview();
            review.MdiParent = this;
            review.Show();
        }
        /// <summary>
        /// this will open sencond notice screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ndNoticeLetterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Notice.SecondNotice secondNotice = new Notice.SecondNotice();
            secondNotice.MdiParent = this;
            secondNotice.Show();
        }
        /// <summary>
        /// This will open mark for form inspection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void markForFormPourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inspection.MarkForFormInspection formInspection = new Inspection.MarkForFormInspection();
            formInspection.MdiParent = this;
            formInspection.Show();
        }
        /// <summary>
        /// This will open mark for final inspection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void markForFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inspection.MarkForFinalInspection finalInspection = new Inspection.MarkForFinalInspection();
            finalInspection.MdiParent = this;
            finalInspection.Show();
        }
        /// <summary>
        /// This will open mark for city inspection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void markAffidavitForCityRepairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityRepair.MarkForCityRepair cityRepair = new CityRepair.MarkForCityRepair();
            cityRepair.MdiParent = this;
            cityRepair.Show();
        }
        /// <summary>
        /// This will open contractor list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contractor.ContractorList contractorList = new Contractor.ContractorList();
            contractorList.MdiParent = this;
            contractorList.Show();
        }
        /// <summary>
        /// This will open city contract screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cityContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityContract.CityContract cityContract = new CityContract.CityContract();
            cityContract.MdiParent = this;
            cityContract.Show();
        }
        /// <summary>
        /// This will open staff list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff.StaffList staffList = new Staff.StaffList();
            staffList.MdiParent = this;
            staffList.Show();
        }
        /// <summary>
        /// This will open permit fee screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void permitFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permit.PermitFee permitFee = new Permit.PermitFee();
            permitFee.MdiParent = this;
            permitFee.Show();
        }

        private void recordCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inspection.FormInspection formInspection = new Inspection.FormInspection();
            formInspection.MdiParent = this;
            formInspection.Show();
        }

        private void recordCommentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inspection.FinalInspection finalInspection = new Inspection.FinalInspection();
            finalInspection.MdiParent = this;
            finalInspection.Show();
        }
    }
}
