namespace Exchange.App.Pages.ReportPage
{
    partial class ReportViewerPage
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
            this.dataSetAccountSideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_AccountSide = new Exchange.App.DataSets.DataSet_AccountSide();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerDaily = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAccountSideBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_AccountSide)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetAccountSideBindingSource
            // 
            this.dataSetAccountSideBindingSource.DataSource = this.dataSet_AccountSide;
            this.dataSetAccountSideBindingSource.Position = 0;
            // 
            // dataSet_AccountSide
            // 
            this.dataSet_AccountSide.DataSetName = "DataSet_AccountSide";
            this.dataSet_AccountSide.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataSetAccountSideBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Exchange.App.Pages.Report.AccountSideReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(952, 584);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Visible = false;
            // 
            // reportViewerDaily
            // 
            this.reportViewerDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerDaily.LocalReport.ReportEmbeddedResource = "Exchange.App.Pages.Report.DailyReport.rdlc";
            this.reportViewerDaily.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDaily.Name = "reportViewerDaily";
            this.reportViewerDaily.ServerReport.BearerToken = null;
            this.reportViewerDaily.Size = new System.Drawing.Size(952, 584);
            this.reportViewerDaily.TabIndex = 1;
            this.reportViewerDaily.Visible = false;
            // 
            // ReportViewerPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(952, 584);
            this.Controls.Add(this.reportViewerDaily);
            this.Controls.Add(this.reportViewer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Name = "ReportViewerPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportViewer";
            this.Load += new System.EventHandler(this.ReportViewerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAccountSideBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_AccountSide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource dataSetAccountSideBindingSource;
        private DataSets.DataSet_AccountSide dataSet_AccountSide;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDaily;
    }
}