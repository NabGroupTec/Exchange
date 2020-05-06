namespace Exchange.App.Pages.Definitions
{
    partial class AddBankAccountPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBankAccountPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtShabaNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtBankName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCurrency = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtCartNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBank = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            // txtAccountNumber
            // 
            resources.ApplyResources(this.txtAccountNumber, "txtAccountNumber");
            this.txtAccountNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAccountNumber.Border.Class = "TextBoxBorder";
            this.txtAccountNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtAccountNumber.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtAccountNumber.ButtonCustom.DisplayPosition")));
            this.txtAccountNumber.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtAccountNumber.ButtonCustom.Image")));
            this.txtAccountNumber.ButtonCustom.Text = resources.GetString("txtAccountNumber.ButtonCustom.Text");
            this.txtAccountNumber.ButtonCustom.Tooltip = resources.GetString("txtAccountNumber.ButtonCustom.Tooltip");
            this.txtAccountNumber.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtAccountNumber.ButtonCustom2.DisplayPosition")));
            this.txtAccountNumber.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtAccountNumber.ButtonCustom2.Image")));
            this.txtAccountNumber.ButtonCustom2.Text = resources.GetString("txtAccountNumber.ButtonCustom2.Text");
            this.txtAccountNumber.ButtonCustom2.Tooltip = resources.GetString("txtAccountNumber.ButtonCustom2.Tooltip");
            this.txtAccountNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PreventEnterBeep = true;
            this.txtAccountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountNumber_KeyDown);
            this.txtAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNumber_KeyPress);
            // 
            // txtShabaNumber
            // 
            resources.ApplyResources(this.txtShabaNumber, "txtShabaNumber");
            this.txtShabaNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtShabaNumber.Border.Class = "TextBoxBorder";
            this.txtShabaNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtShabaNumber.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtShabaNumber.ButtonCustom.DisplayPosition")));
            this.txtShabaNumber.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtShabaNumber.ButtonCustom.Image")));
            this.txtShabaNumber.ButtonCustom.Text = resources.GetString("txtShabaNumber.ButtonCustom.Text");
            this.txtShabaNumber.ButtonCustom.Tooltip = resources.GetString("txtShabaNumber.ButtonCustom.Tooltip");
            this.txtShabaNumber.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtShabaNumber.ButtonCustom2.DisplayPosition")));
            this.txtShabaNumber.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtShabaNumber.ButtonCustom2.Image")));
            this.txtShabaNumber.ButtonCustom2.Text = resources.GetString("txtShabaNumber.ButtonCustom2.Text");
            this.txtShabaNumber.ButtonCustom2.Tooltip = resources.GetString("txtShabaNumber.ButtonCustom2.Tooltip");
            this.txtShabaNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtShabaNumber.ForeColor = System.Drawing.Color.Black;
            this.txtShabaNumber.Name = "txtShabaNumber";
            this.txtShabaNumber.PreventEnterBeep = true;
            this.txtShabaNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShabaNumber_KeyDown);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnOk.ImageTextSpacing = 8;
            this.btnOk.Name = "btnOk";
            this.btnOk.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.SubItemsExpandWidth = 10;
            this.btnOk.Symbol = "";
            this.btnOk.SymbolSize = 12F;
            this.btnOk.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnCancel.ImageTextSpacing = 8;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.SubItemsExpandWidth = 10;
            this.btnCancel.Symbol = "";
            this.btnCancel.SymbolSize = 12F;
            this.btnCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBankName
            // 
            resources.ApplyResources(this.txtBankName, "txtBankName");
            this.txtBankName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBankName.Border.Class = "TextBoxBorder";
            this.txtBankName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtBankName.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtBankName.ButtonCustom.DisplayPosition")));
            this.txtBankName.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtBankName.ButtonCustom.Image")));
            this.txtBankName.ButtonCustom.Text = resources.GetString("txtBankName.ButtonCustom.Text");
            this.txtBankName.ButtonCustom.Tooltip = resources.GetString("txtBankName.ButtonCustom.Tooltip");
            this.txtBankName.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtBankName.ButtonCustom2.DisplayPosition")));
            this.txtBankName.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtBankName.ButtonCustom2.Image")));
            this.txtBankName.ButtonCustom2.Text = resources.GetString("txtBankName.ButtonCustom2.Text");
            this.txtBankName.ButtonCustom2.Tooltip = resources.GetString("txtBankName.ButtonCustom2.Tooltip");
            this.txtBankName.DisabledBackColor = System.Drawing.Color.White;
            this.txtBankName.ForeColor = System.Drawing.Color.Black;
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.PreventEnterBeep = true;
            this.txtBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBankName_KeyDown);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
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
            this.cmbCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cmbCurrency.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.cmbCurrency.WatermarkFont = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbCurrency.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCurrency_KeyDown);
            // 
            // txtCartNumber
            // 
            resources.ApplyResources(this.txtCartNumber, "txtCartNumber");
            this.txtCartNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCartNumber.Border.Class = "TextBoxBorder";
            this.txtCartNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtCartNumber.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtCartNumber.ButtonCustom.DisplayPosition")));
            this.txtCartNumber.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtCartNumber.ButtonCustom.Image")));
            this.txtCartNumber.ButtonCustom.Text = resources.GetString("txtCartNumber.ButtonCustom.Text");
            this.txtCartNumber.ButtonCustom.Tooltip = resources.GetString("txtCartNumber.ButtonCustom.Tooltip");
            this.txtCartNumber.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtCartNumber.ButtonCustom2.DisplayPosition")));
            this.txtCartNumber.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtCartNumber.ButtonCustom2.Image")));
            this.txtCartNumber.ButtonCustom2.Text = resources.GetString("txtCartNumber.ButtonCustom2.Text");
            this.txtCartNumber.ButtonCustom2.Tooltip = resources.GetString("txtCartNumber.ButtonCustom2.Tooltip");
            this.txtCartNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtCartNumber.ForeColor = System.Drawing.Color.Black;
            this.txtCartNumber.Name = "txtCartNumber";
            this.txtCartNumber.PreventEnterBeep = true;
            this.txtCartNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCartNumber_KeyDown);
            this.txtCartNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartNumber_KeyPress);
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
            // txtBank
            // 
            resources.ApplyResources(this.txtBank, "txtBank");
            this.txtBank.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBank.Border.Class = "TextBoxBorder";
            this.txtBank.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtBank.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtBank.ButtonCustom.DisplayPosition")));
            this.txtBank.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtBank.ButtonCustom.Image")));
            this.txtBank.ButtonCustom.Text = resources.GetString("txtBank.ButtonCustom.Text");
            this.txtBank.ButtonCustom.Tooltip = resources.GetString("txtBank.ButtonCustom.Tooltip");
            this.txtBank.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtBank.ButtonCustom2.DisplayPosition")));
            this.txtBank.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtBank.ButtonCustom2.Image")));
            this.txtBank.ButtonCustom2.Text = resources.GetString("txtBank.ButtonCustom2.Text");
            this.txtBank.ButtonCustom2.Tooltip = resources.GetString("txtBank.ButtonCustom2.Tooltip");
            this.txtBank.DisabledBackColor = System.Drawing.Color.White;
            this.txtBank.ForeColor = System.Drawing.Color.Black;
            this.txtBank.Name = "txtBank";
            this.txtBank.PreventEnterBeep = true;
            this.txtBank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBank_KeyDown);
            // 
            // AddBankAccountPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCartNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBankName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.txtShabaNumber);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AddBankAccountPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AddBankAccountPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddBankAccountPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccountNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtShabaNumber;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBankName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbCurrency;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCartNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBank;
    }
}