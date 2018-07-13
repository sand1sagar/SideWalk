namespace SidewalkPermitWPF.Views
{
    partial class ApprovedPermitReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sWPostDataSet = new SidewalkPermitWPF.SWPostDataSet();
            this.sPPermitRecieptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_PermitRecieptTableAdapter = new SidewalkPermitWPF.SWPostDataSetTableAdapters.SP_PermitRecieptTableAdapter();
            this.SP_PermitRecieptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sWPostDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPermitRecieptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PermitRecieptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SWDataSet";
            reportDataSource1.Value = this.SP_PermitRecieptBindingSource;
            reportDataSource2.Name = "SWDataSet";
            reportDataSource2.Value = this.SP_PermitRecieptBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SidewalkPermitWPF.Reports.PermitReciept.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // sWPostDataSet
            // 
            this.sWPostDataSet.DataSetName = "SWPostDataSet";
            this.sWPostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPPermitRecieptBindingSource
            // 
            this.sPPermitRecieptBindingSource.DataMember = "SP_PermitReciept";
            this.sPPermitRecieptBindingSource.DataSource = this.sWPostDataSet;
            // 
            // sP_PermitRecieptTableAdapter
            // 
            this.sP_PermitRecieptTableAdapter.ClearBeforeFill = true;
            // 
            // SP_PermitRecieptBindingSource
            // 
            this.SP_PermitRecieptBindingSource.DataMember = "SP_PermitReciept";
            this.SP_PermitRecieptBindingSource.DataSource = this.sWPostDataSet;
            // 
            // ApprovedPermitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ApprovedPermitReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApprovedPermitReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ApprovedPermitReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sWPostDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPermitRecieptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PermitRecieptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPPermitRecieptBindingSource;
        private SWPostDataSet sWPostDataSet;
        private SWPostDataSetTableAdapters.SP_PermitRecieptTableAdapter sP_PermitRecieptTableAdapter;
        private System.Windows.Forms.BindingSource SP_PermitRecieptBindingSource;
    }
}