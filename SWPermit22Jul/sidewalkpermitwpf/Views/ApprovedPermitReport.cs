using Microsoft.Reporting.WinForms;
using SidewalkPermitWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SidewalkPermitWPF.Views
{
    public partial class ApprovedPermitReport : Form
    {
        string permitID = string.Empty;
        string permitNo = string.Empty;
        string affidavitID = string.Empty;
        Warning[] warnings;
        string[] streamids;
        string mimeType;
        string encoding;
        string filenameExtension;
        Permit permit;


        public ApprovedPermitReport(string _permitID, string _affidavitID)
        {
            permitID = _permitID;
            affidavitID = _affidavitID;
            //permitNo = _permitNo;
            InitializeComponent();
        }

        private void ApprovedPermitReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sWPostDataSet.Permit' table. You can move, or remove it, as needed.
            try
            {
                this.sWPostDataSet.EnforceConstraints = false;
                this.sP_PermitRecieptTableAdapter.Fill(this.sWPostDataSet.SP_PermitReciept, permitID, affidavitID);
                //Will Comment next 7 lines
                byte[] bytes = reportViewer1.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);
               
                //var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                using (FileStream fs = new FileStream(ConfigurationManager.AppSettings["PdfPath"] + affidavitID + ".pdf", FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }

                //using (FileStream fs = new FileStream(@"C:\Users\ssagar\Documents\Sidewalk Permit\PremitPDF\PR" + permitID + ".pdf", FileMode.Create))
                //{
                //    fs.Write(bytes, 0, bytes.Length);
                //}
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
