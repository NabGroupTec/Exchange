namespace Exchange.App.Pages.ReportPage
{
    partial class AccountSideReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSideReportPage));
            Janus.Windows.GridEX.GridEXLayout dgvEx_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.lblAccountCode = new System.Windows.Forms.Label();
            this.txtEntity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintReport = new DevComponents.DotNetBar.ButtonX();
            this.btnExpoerExcel = new DevComponents.DotNetBar.ButtonX();
            this.dgvEx = new Janus.Windows.GridEX.GridEX();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEx)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountCode
            // 
            resources.ApplyResources(this.lblAccountCode, "lblAccountCode");
            this.lblAccountCode.BackColor = System.Drawing.Color.White;
            this.lblAccountCode.ForeColor = System.Drawing.Color.Black;
            this.lblAccountCode.Name = "lblAccountCode";
            // 
            // txtEntity
            // 
            resources.ApplyResources(this.txtEntity, "txtEntity");
            this.txtEntity.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEntity.Border.Class = "TextBoxBorder";
            this.txtEntity.Border.CornerDiameter = 6;
            this.txtEntity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtEntity.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtEntity.ButtonCustom.DisplayPosition")));
            this.txtEntity.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtEntity.ButtonCustom.Image")));
            this.txtEntity.ButtonCustom.Text = resources.GetString("txtEntity.ButtonCustom.Text");
            this.txtEntity.ButtonCustom.Tooltip = resources.GetString("txtEntity.ButtonCustom.Tooltip");
            this.txtEntity.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtEntity.ButtonCustom2.DisplayPosition")));
            this.txtEntity.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtEntity.ButtonCustom2.Image")));
            this.txtEntity.ButtonCustom2.Text = resources.GetString("txtEntity.ButtonCustom2.Text");
            this.txtEntity.ButtonCustom2.Tooltip = resources.GetString("txtEntity.ButtonCustom2.Tooltip");
            this.txtEntity.DisabledBackColor = System.Drawing.Color.White;
            this.txtEntity.ForeColor = System.Drawing.Color.Black;
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.PreventEnterBeep = true;
            this.txtEntity.TextChanged += new System.EventHandler(this.txtEntity_TextChanged);
            this.txtEntity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntity_KeyDown);
            this.txtEntity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntity_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
            // 
            // cmbCurrency
            // 
            resources.ApplyResources(this.cmbCurrency, "cmbCurrency");
            this.cmbCurrency.DisplayMember = "Text";
            this.cmbCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.ForeColor = System.Drawing.Color.Black;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // btnPrintReport
            // 
            resources.ApplyResources(this.btnPrintReport, "btnPrintReport");
            this.btnPrintReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnPrintReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintReport.Symbol = "";
            this.btnPrintReport.SymbolSize = 24F;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnExpoerExcel
            // 
            resources.ApplyResources(this.btnExpoerExcel, "btnExpoerExcel");
            this.btnExpoerExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExpoerExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExpoerExcel.Image = global::Exchange.App.Properties.Resources.ExportExelNew;
            this.btnExpoerExcel.ImageFixedSize = new System.Drawing.Size(42, 42);
            this.btnExpoerExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnExpoerExcel.Name = "btnExpoerExcel";
            this.btnExpoerExcel.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnExpoerExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExpoerExcel.Click += new System.EventHandler(this.btnExpoerExcel_Click);
            // 
            // dgvEx
            // 
            resources.ApplyResources(this.dgvEx, "dgvEx");
            this.dgvEx.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEx.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(dgvEx_DesignTimeLayout, "dgvEx_DesignTimeLayout");
            this.dgvEx.DesignTimeLayout = dgvEx_DesignTimeLayout;
            this.dgvEx.Name = "dgvEx";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Name = "lblStatus";
            // 
            // AccountSideReportPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvEx);
            this.Controls.Add(this.btnExpoerExcel);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAccountCode);
            this.Controls.Add(this.txtEntity);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "AccountSideReportPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AccountSideReportPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountSideReportPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn cknDisc;
        private System.Windows.Forms.Label lblAccountCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEntity;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCurrency;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btnPrintReport;
        private DevComponents.DotNetBar.ButtonX btnExpoerExcel;
        private Janus.Windows.GridEX.GridEX dgvEx;
        private System.Windows.Forms.Label lblStatus;
    }
}