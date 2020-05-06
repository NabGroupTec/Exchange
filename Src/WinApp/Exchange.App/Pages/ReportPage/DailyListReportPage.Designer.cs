namespace Exchange.App.Pages.ReportPage
{
    partial class DailyListReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyListReportPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnPrintReport = new DevComponents.DotNetBar.ButtonX();
            this.txtDate = new Atf.UI.DateTimeSelector();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtClearSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtFind = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.clnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCurrencyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBedehkar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBestankar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMandeh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnDate,
            this.clnId,
            this.clnDisc,
            this.clnCurrencyId,
            this.clnBedehkar,
            this.clnBestankar,
            this.clnMandeh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 30;
            // 
            // btnPrintReport
            // 
            resources.ApplyResources(this.btnPrintReport, "btnPrintReport");
            this.btnPrintReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrintReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrintReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnPrintReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrintReport.Symbol = "";
            // 
            // txtDate
            // 
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.CustomFormat = "####/##/##";
            this.txtDate.ForeColor = System.Drawing.Color.Black;
            this.txtDate.Name = "txtDate";
            this.txtDate.ValueChanged += new System.EventHandler(this.txtDate_ValueChanged);
            this.txtDate.Click += new System.EventHandler(this.txtDate_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.txtSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.txtSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.txtSearch.Symbol = "";
            this.txtSearch.SymbolSize = 13F;
            // 
            // txtClearSearch
            // 
            resources.ApplyResources(this.txtClearSearch, "txtClearSearch");
            this.txtClearSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.txtClearSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.txtClearSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.txtClearSearch.Name = "txtClearSearch";
            this.txtClearSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 8, 0, 8);
            this.txtClearSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.txtClearSearch.Symbol = "";
            this.txtClearSearch.SymbolSize = 13F;
            // 
            // txtFind
            // 
            resources.ApplyResources(this.txtFind, "txtFind");
            this.txtFind.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFind.Border.Class = "TextBoxBorder";
            this.txtFind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFind.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFind.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFind.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFind.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFind.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtFind.ButtonCustom.DisplayPosition")));
            this.txtFind.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtFind.ButtonCustom.Image")));
            this.txtFind.ButtonCustom.Text = resources.GetString("txtFind.ButtonCustom.Text");
            this.txtFind.ButtonCustom.Tooltip = resources.GetString("txtFind.ButtonCustom.Tooltip");
            this.txtFind.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtFind.ButtonCustom2.DisplayPosition")));
            this.txtFind.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtFind.ButtonCustom2.Image")));
            this.txtFind.ButtonCustom2.Text = resources.GetString("txtFind.ButtonCustom2.Text");
            this.txtFind.ButtonCustom2.Tooltip = resources.GetString("txtFind.ButtonCustom2.Tooltip");
            this.txtFind.DisabledBackColor = System.Drawing.Color.White;
            this.txtFind.ForeColor = System.Drawing.Color.Black;
            this.txtFind.Name = "txtFind";
            this.txtFind.PreventEnterBeep = true;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // clnDate
            // 
            this.clnDate.DataPropertyName = "ManualDate";
            resources.ApplyResources(this.clnDate, "clnDate");
            this.clnDate.Name = "clnDate";
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            resources.ApplyResources(this.clnId, "clnId");
            this.clnId.Name = "clnId";
            // 
            // clnDisc
            // 
            this.clnDisc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnDisc.DataPropertyName = "Comment";
            resources.ApplyResources(this.clnDisc, "clnDisc");
            this.clnDisc.Name = "clnDisc";
            // 
            // clnCurrencyId
            // 
            this.clnCurrencyId.DataPropertyName = "Name";
            resources.ApplyResources(this.clnCurrencyId, "clnCurrencyId");
            this.clnCurrencyId.Name = "clnCurrencyId";
            // 
            // clnBedehkar
            // 
            this.clnBedehkar.DataPropertyName = "BedPrice";
            resources.ApplyResources(this.clnBedehkar, "clnBedehkar");
            this.clnBedehkar.Name = "clnBedehkar";
            // 
            // clnBestankar
            // 
            this.clnBestankar.DataPropertyName = "BesPrice";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.clnBestankar.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.clnBestankar, "clnBestankar");
            this.clnBestankar.Name = "clnBestankar";
            // 
            // clnMandeh
            // 
            resources.ApplyResources(this.clnMandeh, "clnMandeh");
            this.clnMandeh.Name = "clnMandeh";
            // 
            // DailyListReportPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtClearSearch);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "DailyListReportPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AccountSideReportPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountSideReportPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cknDisc;
        private DevComponents.DotNetBar.ButtonX btnPrintReport;
        private Atf.UI.DateTimeSelector txtDate;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX txtSearch;
        private DevComponents.DotNetBar.ButtonX txtClearSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCurrencyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBedehkar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBestankar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMandeh;
    }
}