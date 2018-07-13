using Sidewalk.Logic;
using Sidewalk.Logic.Database;
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
    public partial class Affidavit : Form
    {
        //Variables declaration 
        AffidavitLogic affidavitLogic = new AffidavitLogic();
       // Sidewalk.Logic.Database.Affidavit affidavitModel = new Sidewalk.Logic.Database.Affidavit();
        public Affidavit()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        /// <summary>
        /// At the time of loading of this screen data will fatch with default last affidavit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Affidavit_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                //FillFormControls(affidavitLogic.GetAffidavitDetails(string.Empty));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtFOIAdditionalNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This button will open window to change status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            ChangeStatus changeStatus = new ChangeStatus();
            changeStatus.Show();
        }

        private void btnFINext_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This button will update owner information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOwner1.Text) && !string.IsNullOrEmpty(txtOwner2.Text) && !string.IsNullOrEmpty(txtOwner3.Text) && !string.IsNullOrEmpty(txtOwner4.Text) && !string.IsNullOrEmpty(txtOwner5.Text) && !string.IsNullOrEmpty(txtSt.Text) && !string.IsNullOrEmpty(txtZip.Text))
            {

            }
            else
            {
                MessageBox.Show("Please enter all information to update owner!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Costs & Notes":
                    {
                        costNotesOriginalGrid.DataSource = new List<CostNotesGridModel>();
                        costNotesRevisionGrid.DataSource = new List<CostNotesGridModel>();
                        break;
                    }
                case "City Repair":
                    {
                        cityRepairItemGrid.DataSource = new List<CostNotesGridModel>();
                        break;
                    }
                case "Status History":
                    {
                        statusHistoryGrid.DataSource = new List<StatusHistoryGrid>();
                        break;
                    }
                case "Form Inspection":
                    {
                        break;
                    }
                case "Final Inspection":
                    {
                        break;
                    }

                default:
                    break;
            }
        }

        private void btnNextAffidavit_Click(object sender, EventArgs e)
        {
            //FillFormControls(affidavitLogic.GetAffidavitDetails(txtAffidavit.Text));
        }
        #region Form controls fill function
        //private void FillFormControls(Sidewalk.Logic.Database.Affidavit model)
        //{
        //    #region Databinding in Search
        //    txtAffidavit.Text = model.AffidavitID;
        //    txtPropertyAddress.Text = model.SiteAddress;
        //    txtStatus.Text = model.Status;
        //    txtInspector.Text = model.Inspector.Staff.FirstName + " " + model.Inspector.Staff.LastName;
        //    txtInspectionDate.Text = model.InspectionDate.Value.ToShortDateString();
        //    #endregion
        //    #region Databinding in Inspection
        //    txtTrackIT.Text = model.TrackIT;
        //    txtRnum.Text = model.RNO;
        //    txtPropertyID.Text = model.PropertyID;
        //    txtLegalDesc.Text = model.LegalDesc;
        //    #endregion
        //    #region Databinding in Owner Information
        //    txtOwner1.Text = model.Owner1;
        //    txtOwner2.Text = model.Owner2;
        //    txtOwner3.Text = model.Owner3;
        //    txtOwner4.Text = model.OwnerAddress;
        //    txtOwner5.Text = model.OwnerCity;
        //    txtSt.Text = model.OwnerState;
        //    txtZip.Text = model.OwnerZip;
        //    #endregion
        //    #region Databinding in Permit Information
        //    //if (model.ContractorRepair.Equals("Y"))
        //    //    rdoContractor.Checked = true;
        //    //if (model.CityRepair.Equals("Y"))
        //    //    rdoOther.Checked = true;
        //    //if (model.OwnerRepair.Equals("Y"))
        //    //    rdoPropertyOwner.Checked = true;
        //    if (model.date_issued != null)
        //        txtIssueDate.Text = model.date_issued.Value.ToShortDateString();
        //    if (model.date_expired != null)
        //        txtExpirationDate.Text = model.date_expired.Value.ToShortDateString();

        //    #endregion
        //    #region Databinding in Permit Information
        //    if (model.RepairNoticeSentDate != null)
        //        txtRepairNoticSent.Text = model.RepairNoticeSentDate.Value.ToShortDateString();
        //    if (model.RepairDueDate != null)
        //        txtRepairDueDate.Text = model.RepairDueDate.Value.ToShortDateString();
        //    if (model.InspectionDate != null)
        //        txtFormInspection.Text = model.InspectionDate.Value.ToShortDateString();
        //    txtFormInspectionBy.Text = model.Inspector.Staff.FirstName + " " + model.Inspector.Staff.LastName;
        //    if (model.ContractorRepair.Equals("Y"))
        //        rdoAffidavitContractor.Checked = true;
        //    if (model.CityRepair.Equals("Y"))
        //        rdoAffidavitCity.Checked = true;
        //    if (model.OwnerRepair.Equals("Y"))
        //        rdoAffidavitPropertyOwner.Checked = true;
        //    if (model.date_cancelled != null)
        //        txtAffidavitCancelDate.Text = model.date_cancelled.Value.ToShortDateString();
        //    txtAffidavitCancelBy.Text = model.cancelled_by;
        //    if (model.HoldUntilDate != null)
        //        txtAffidavitHoldUntil.Text = model.HoldUntilDate.Value.ToShortDateString();
        //    txtAffidavitHoldUntilBy.Text = model.HoldUntilBy;

        //    #endregion
        //    affidavitActivityHistoryGrid.DataSource = (from info in model.AffidavitActivity
        //                                               select new AffidavitActivityHistoryGridModel()
        //                                               {
        //                                                   Type = info.DocType,
        //                                                   Date = info.DocDate.ToShortDateString(),
        //                                                   Status = info.DocAction,
        //                                                   User = info.DocUserID
        //                                               }).ToList<AffidavitActivityHistoryGridModel>();
        //    //affidavitDocHistoryGrid.Columns[0].Visible = false;

        //    costNotesOriginalGrid.DataSource = new List<CostNotesGridModel>();
        //    costNotesRevisionGrid.DataSource = new List<CostNotesGridModel>();
        //}
        #endregion
        private void btnNextAffidavit_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
