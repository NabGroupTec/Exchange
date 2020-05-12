namespace Exchange.App.Pages.ReportPage
{
    partial class AccountReviewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountReviewPage));
            Janus.Windows.GridEX.GridEXLayout dgv_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.btnTackReport = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ToDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.dgv = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.btnTackReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTackReport
            // 
            resources.ApplyResources(this.btnTackReport, "btnTackReport");
            this.btnTackReport.Name = "btnTackReport";
            this.btnTackReport.Click += new System.EventHandler(this.btnTackReport_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            resources.ApplyResources(this.radGroupBox1, "radGroupBox1");
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.ToDate);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.fromDate);
            this.radGroupBox1.Controls.Add(this.btnTackReport);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ToDate
            // 
            resources.ApplyResources(this.ToDate, "ToDate");
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.Name = "ToDate";
            this.ToDate.TabStop = false;
            this.ToDate.Value = new System.DateTime(2019, 7, 2, 12, 58, 48, 375);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // fromDate
            // 
            resources.ApplyResources(this.fromDate, "fromDate");
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Name = "fromDate";
            this.fromDate.TabStop = false;
            this.fromDate.Value = new System.DateTime(2019, 7, 2, 12, 58, 48, 375);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            resources.ApplyResources(this.radGroupBox2, "radGroupBox2");
            this.radGroupBox2.Controls.Add(this.dgv);
            this.radGroupBox2.Name = "radGroupBox2";
            // 
            // dgv
            // 
            resources.ApplyResources(dgv_DesignTimeLayout, "dgv_DesignTimeLayout");
            this.dgv.DesignTimeLayout = dgv_DesignTimeLayout;
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.Name = "dgv";
            // 
            // AccountReviewPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "AccountReviewPage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.BalanceSheetPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnTackReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnTackReport;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDateTimePicker fromDate;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDateTimePicker ToDate;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Janus.Windows.GridEX.GridEX dgv;
    }
}