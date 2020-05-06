using DevComponents.DotNetBar.Controls;

namespace Exchange.App.Pages.Operation
{
    partial class DocumentOperationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentOperationPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDate = new Atf.UI.DateTimeSelector();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBeds = new CurMoney.CurMoney();
            this.btnBess = new CurMoney.CurMoney();
            this.clnAdd = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAccountSide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBedTMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBesTMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clnDelete = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // txtDisc
            // 
            resources.ApplyResources(this.txtDisc, "txtDisc");
            this.txtDisc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDisc.Border.Class = "TextBoxBorder";
            this.txtDisc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtDisc.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDisc.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDisc.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtDisc.ButtonCustom.DisplayPosition")));
            this.txtDisc.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtDisc.ButtonCustom.Image")));
            this.txtDisc.ButtonCustom.Text = resources.GetString("txtDisc.ButtonCustom.Text");
            this.txtDisc.ButtonCustom.Tooltip = resources.GetString("txtDisc.ButtonCustom.Tooltip");
            this.txtDisc.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtDisc.ButtonCustom2.DisplayPosition")));
            this.txtDisc.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtDisc.ButtonCustom2.Image")));
            this.txtDisc.ButtonCustom2.Text = resources.GetString("txtDisc.ButtonCustom2.Text");
            this.txtDisc.ButtonCustom2.Tooltip = resources.GetString("txtDisc.ButtonCustom2.Tooltip");
            this.txtDisc.DisabledBackColor = System.Drawing.Color.White;
            this.txtDisc.ForeColor = System.Drawing.Color.Black;
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.PreventEnterBeep = true;
            this.txtDisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDisc_KeyDown);
            // 
            // txtDate
            // 
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.CustomFormat = "####-##-##";
            this.txtDate.ForeColor = System.Drawing.Color.Black;
            this.txtDate.Name = "txtDate";
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDate_KeyDown);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnOk.ImageTextSpacing = 25;
            this.btnOk.Name = "btnOk";
            this.btnOk.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.Symbol = "";
            this.btnOk.SymbolColor = System.Drawing.Color.Green;
            this.btnOk.SymbolSize = 30F;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.clnAdd,
            this.clnId,
            this.clnCode,
            this.clnAccountSide,
            this.clnDisc,
            this.clnBed,
            this.clnBes,
            this.clnIdCurrency,
            this.clnCurrency,
            this.clnRate,
            this.clnBedTMN,
            this.clnBesTMN,
            this.clnEdit,
            this.clnDelete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("IRANSans", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 30;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            this.dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyDown);
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.Symbol = "";
            this.btnAdd.SymbolColor = System.Drawing.Color.Green;
            this.btnAdd.SymbolSize = 30F;
            this.btnAdd.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // btnBeds
            // 
            resources.ApplyResources(this.btnBeds, "btnBeds");
            this.btnBeds.BackColor = System.Drawing.Color.White;
            this.btnBeds.ForeColor = System.Drawing.Color.Black;
            this.btnBeds.Name = "btnBeds";
            this.btnBeds.Precision = CurMoney.CurMoney.Precision_List.Two;
            this.btnBeds.Symbol = CurMoney.CurMoney.Symbol_List.Dot;
            // 
            // btnBess
            // 
            resources.ApplyResources(this.btnBess, "btnBess");
            this.btnBess.BackColor = System.Drawing.Color.White;
            this.btnBess.ForeColor = System.Drawing.Color.Black;
            this.btnBess.Name = "btnBess";
            this.btnBess.Precision = CurMoney.CurMoney.Precision_List.Two;
            this.btnBess.Symbol = CurMoney.CurMoney.Symbol_List.Dot;
            // 
            // clnAdd
            // 
            this.clnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.clnAdd, "clnAdd");
            this.clnAdd.Image = ((System.Drawing.Image)(resources.GetObject("clnAdd.Image")));
            this.clnAdd.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.clnAdd.Name = "clnAdd";
            this.clnAdd.Text = "*";
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            resources.ApplyResources(this.clnId, "clnId");
            this.clnId.Name = "clnId";
            // 
            // clnCode
            // 
            resources.ApplyResources(this.clnCode, "clnCode");
            this.clnCode.Name = "clnCode";
            this.clnCode.ReadOnly = true;
            // 
            // clnAccountSide
            // 
            this.clnAccountSide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.clnAccountSide, "clnAccountSide");
            this.clnAccountSide.Name = "clnAccountSide";
            this.clnAccountSide.ReadOnly = true;
            // 
            // clnDisc
            // 
            resources.ApplyResources(this.clnDisc, "clnDisc");
            this.clnDisc.Name = "clnDisc";
            // 
            // clnBed
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.clnBed.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.clnBed, "clnBed");
            this.clnBed.Name = "clnBed";
            this.clnBed.ReadOnly = true;
            // 
            // clnBes
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.clnBes.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.clnBes, "clnBes");
            this.clnBes.Name = "clnBes";
            this.clnBes.ReadOnly = true;
            // 
            // clnIdCurrency
            // 
            resources.ApplyResources(this.clnIdCurrency, "clnIdCurrency");
            this.clnIdCurrency.Name = "clnIdCurrency";
            this.clnIdCurrency.ReadOnly = true;
            // 
            // clnCurrency
            // 
            resources.ApplyResources(this.clnCurrency, "clnCurrency");
            this.clnCurrency.Name = "clnCurrency";
            this.clnCurrency.ReadOnly = true;
            // 
            // clnRate
            // 
            dataGridViewCellStyle3.Format = "N2";
            this.clnRate.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.clnRate, "clnRate");
            this.clnRate.Name = "clnRate";
            this.clnRate.ReadOnly = true;
            // 
            // clnBedTMN
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Format = "N2";
            this.clnBedTMN.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.clnBedTMN, "clnBedTMN");
            this.clnBedTMN.Name = "clnBedTMN";
            this.clnBedTMN.ReadOnly = true;
            // 
            // clnBesTMN
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Format = "N2";
            this.clnBesTMN.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.clnBesTMN, "clnBesTMN");
            this.clnBesTMN.Name = "clnBesTMN";
            this.clnBesTMN.ReadOnly = true;
            // 
            // clnEdit
            // 
            this.clnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.clnEdit, "clnEdit");
            this.clnEdit.Image = ((System.Drawing.Image)(resources.GetObject("clnEdit.Image")));
            this.clnEdit.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.clnEdit.Name = "clnEdit";
            this.clnEdit.Text = null;
            // 
            // clnDelete
            // 
            this.clnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.clnDelete, "clnDelete");
            this.clnDelete.Image = ((System.Drawing.Image)(resources.GetObject("clnDelete.Image")));
            this.clnDelete.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.clnDelete.Name = "clnDelete";
            this.clnDelete.Text = null;
            // 
            // DocumentOperationPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnBess);
            this.Controls.Add(this.btnBeds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentOperationPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.DocumentOperationPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocumentOperationPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDisc;
        private Atf.UI.DateTimeSelector txtDate;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DataGridViewX dgv;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private CurMoney.CurMoney btnBeds;
        private CurMoney.CurMoney btnBess;
        private DataGridViewButtonXColumn clnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAccountSide;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBedTMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBesTMN;
        private DataGridViewButtonXColumn clnEdit;
        private DataGridViewButtonXColumn clnDelete;
    }
}