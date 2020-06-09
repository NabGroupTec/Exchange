using DevExpress.XtraEditors;

namespace Exchange.App.Pages.Operation
{
    partial class GetDataDocumentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetDataDocumentPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtEntity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAccountCode = new System.Windows.Forms.Label();
            this.txtBed = new CurMoney.CurMoney();
            this.txtBes = new CurMoney.CurMoney();
            this.txtBedehkar = new CurMoney.CurMoney();
            this.txtBestankar = new CurMoney.CurMoney();
            this.txtRatePrice = new CurMoney.CurMoney();
            this.chkCalc = new MetroFramework.Controls.MetroCheckBox();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.txtBuyPrice = new CurMoney.CurMoney();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.DisplayMember = "Text";
            this.cmbCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            resources.ApplyResources(this.cmbCurrency, "cmbCurrency");
            this.cmbCurrency.ForeColor = System.Drawing.Color.Black;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
            // 
            // txtEntity
            // 
            this.txtEntity.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEntity.Border.Class = "TextBoxBorder";
            this.txtEntity.Border.CornerDiameter = 6;
            this.txtEntity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtEntity.DisabledBackColor = System.Drawing.Color.White;
            this.txtEntity.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txtEntity, "txtEntity");
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.PreventEnterBeep = true;
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
            // lblAccountCode
            // 
            resources.ApplyResources(this.lblAccountCode, "lblAccountCode");
            this.lblAccountCode.BackColor = System.Drawing.Color.White;
            this.lblAccountCode.ForeColor = System.Drawing.Color.Black;
            this.lblAccountCode.Name = "lblAccountCode";
            // 
            // txtBed
            // 
            this.txtBed.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtBed, "txtBed");
            this.txtBed.ForeColor = System.Drawing.Color.Black;
            this.txtBed.Name = "txtBed";
            this.txtBed.Precision = CurMoney.CurMoney.Precision_List.Four;
            this.txtBed.Symbol = CurMoney.CurMoney.Symbol_List.Dot;
            this.txtBed.TextChanged += new System.EventHandler(this.txtBed_TextChanged);
            this.txtBed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBed_KeyDown);
            // 
            // txtBes
            // 
            this.txtBes.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtBes, "txtBes");
            this.txtBes.ForeColor = System.Drawing.Color.Black;
            this.txtBes.Name = "txtBes";
            this.txtBes.Precision = CurMoney.CurMoney.Precision_List.Four;
            this.txtBes.Symbol = CurMoney.CurMoney.Symbol_List.Dot;
            this.txtBes.TextChanged += new System.EventHandler(this.txtBes_TextChanged);
            this.txtBes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBes_KeyDown);
            // 
            // txtBedehkar
            // 
            this.txtBedehkar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtBedehkar, "txtBedehkar");
            this.txtBedehkar.ForeColor = System.Drawing.Color.Black;
            this.txtBedehkar.Name = "txtBedehkar";
            this.txtBedehkar.Precision = CurMoney.CurMoney.Precision_List.Four;
            this.txtBedehkar.Symbol = CurMoney.CurMoney.Symbol_List.Dot;
            this.txtBedehkar.TextChanged += new System.EventHandler(this.txtBedehkar_TextChanged);
            this.txtBedehkar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBedehkar_KeyDown);
            // 
            // txtBestankar
            // 
            this.txtBestankar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtBestankar, "txtBestankar");
            this.txtBestankar.ForeColor = System.Drawing.Color.Black;
            this.txtBestankar.Name = "txtBestankar";
            this.txtBestankar.Precision = CurMoney.CurMoney.Precision_List.Four;
            this.txtBestankar.Symbol = CurMoney.CurMoney.Symbol_List.Dot;
            this.txtBestankar.TextChanged += new System.EventHandler(this.txtBestankar_TextChanged);
            this.txtBestankar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBestankar_KeyDown);
            // 
            // txtRatePrice
            // 
            this.txtRatePrice.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtRatePrice, "txtRatePrice");
            this.txtRatePrice.ForeColor = System.Drawing.Color.Black;
            this.txtRatePrice.Name = "txtRatePrice";
            this.txtRatePrice.Precision = CurMoney.CurMoney.Precision_List.Four;
            this.txtRatePrice.Symbol = CurMoney.CurMoney.Symbol_List.Dot;
            this.txtRatePrice.TextChanged += new System.EventHandler(this.txtRatePrice_TextChanged);
            this.txtRatePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRatePrice_KeyDown);
            // 
            // chkCalc
            // 
            resources.ApplyResources(this.chkCalc, "chkCalc");
            this.chkCalc.BackColor = System.Drawing.Color.White;
            this.chkCalc.ForeColor = System.Drawing.Color.Black;
            this.chkCalc.Name = "chkCalc";
            this.chkCalc.UseSelectable = true;
            this.chkCalc.CheckedChanged += new System.EventHandler(this.chkCalc_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnOk.Appearance.Font")));
            this.btnOk.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Appearance.Options.UseForeColor = true;
            this.btnOk.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOk.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.BackColor = System.Drawing.Color.White;
            this.txtBuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuyPrice.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txtBuyPrice, "txtBuyPrice");
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Precision = CurMoney.CurMoney.Precision_List.Four;
            this.txtBuyPrice.ReadOnly = true;
            this.txtBuyPrice.Symbol = CurMoney.CurMoney.Symbol_List.Dot;
            this.txtBuyPrice.TabStop = false;
            this.txtBuyPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuyPrice_KeyDown);
            // 
            // GetDataDocumentPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkCalc);
            this.Controls.Add(this.txtRatePrice);
            this.Controls.Add(this.txtBestankar);
            this.Controls.Add(this.txtBedehkar);
            this.Controls.Add(this.txtBes);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.lblAccountCode);
            this.Controls.Add(this.txtEntity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetDataDocumentPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.GetDataDocumentPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GetDataDocumentPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCurrency;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEntity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAccountCode;
        private CurMoney.CurMoney txtBed;
        private CurMoney.CurMoney txtBes;
        private CurMoney.CurMoney txtBedehkar;
        private CurMoney.CurMoney txtBestankar;
        private CurMoney.CurMoney txtRatePrice;
        private MetroFramework.Controls.MetroCheckBox chkCalc;
        private SimpleButton btnOk;
        private CurMoney.CurMoney txtBuyPrice;
    }
}