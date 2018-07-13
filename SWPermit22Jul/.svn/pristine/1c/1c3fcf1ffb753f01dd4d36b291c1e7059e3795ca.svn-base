using SidewalkPermitWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidewalkPermitWPF.Views
{
    public partial class CancelDialog : Form
    {
        object parent;
        public CancelDialog(object param)
        {
            parent = param;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelDialog_Load(object sender, EventArgs e)
        {
            txtComment.Enabled = false;
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)

        {
            ReviewModifyTransferPermitViewModel obj = (ReviewModifyTransferPermitViewModel)parent;
            if (cmbCancelReason.SelectedIndex>-1)
            {
                if (cmbCancelReason.SelectedItem.Equals("Other"))
                {
                    if (!string.IsNullOrEmpty(txtComment.Text))
                    {
                        obj.CancelDialog(txtComment.Text);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Please enter your comments in comment box.", "Information", MessageBoxButtons.OKCancel);
                }
                else
                {
                    obj.CancelDialog(cmbCancelReason.SelectedItem.ToString());
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please selece atleast one option.", "Information", MessageBoxButtons.OKCancel);

        }

        private void cmbCancelReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCancelReason.SelectedIndex > 0 && cmbCancelReason.SelectedItem.Equals("Other"))
                txtComment.Enabled = true;
            else if (cmbCancelReason.SelectedIndex > 0 && cmbCancelReason.SelectedItem.ToString() != "Other")
                txtComment.Enabled = false;
            else
                txtComment.Enabled = false;

        }
    }
}
