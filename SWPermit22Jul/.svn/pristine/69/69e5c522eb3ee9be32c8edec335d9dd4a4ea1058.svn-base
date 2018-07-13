using SidewalkPermitWPF.Model;
using SidewalkPermitWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.MDI;   

namespace SidewalkPermitWPF.Views   
{
    /// <summary>
    /// Description for NewPermit.
    /// </summary>
    public partial class PrintSubmittedPermitView : UserControl
    {
        MainWindow mainWindow;
        MdiContainer _container;
        /// <summary>
        /// Initializes a new instance of the NewPermit class.
        /// </summary>
        public PrintSubmittedPermitView(MdiContainer container)
        {
            InitializeComponent();
            mainWindow = new MainWindow();
            _container = container;
            _reportViewer.Load += ReportViewer_Load;
        }
        private bool _isReportViewerLoaded;

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            if (!_isReportViewerLoaded)
            {
                //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new
                //Microsoft.Reporting.WinForms.ReportDataSource();
                //SWPostDataSet dataset = new SWPostDataSet();
                //dataset.BeginInit();
                //reportDataSource1.Name = "PrintPermitDataSet";
                ////Name of the report dataset in our .RDLC file
                ////reportDataSource1.Value = dataset.Permit;
                //this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                //this._reportViewer.LocalReport.ReportPath = "SidewalkPermitWPF/Reports/PrintSubmittedPermits.rdlc";
                //dataset.EndInit();
                //fill data into WpfApplication4DataSet
                //SWPostDataSetTableAdapters.PermitTableAdapter
                //accountsTableAdapter = new
                //SWPostDataSetTableAdapters.PermitTableAdapter();

                //accountsTableAdapter.ClearBeforeFill = true;
                //accountsTableAdapter.Fill(dataset.Permit);
                _reportViewer.RefreshReport();
                _isReportViewerLoaded = true;
            }
        }
    }
}