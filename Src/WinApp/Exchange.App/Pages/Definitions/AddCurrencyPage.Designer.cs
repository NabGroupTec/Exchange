namespace Exchange.App.Pages.Definitions
{
    partial class AddCurrencyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCurrencyPage));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtSymbol = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberDigit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSell = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFloatSymbol = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFloatName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label8 = new System.Windows.Forms.Label();
            this.chkDefault = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtCountry = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberDigit)).BeginInit();
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
            // TxtName
            // 
            resources.ApplyResources(this.TxtName, "TxtName");
            this.TxtName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtName.Border.Class = "TextBoxBorder";
            this.TxtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TxtName.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("TxtName.ButtonCustom.DisplayPosition")));
            this.TxtName.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("TxtName.ButtonCustom.Image")));
            this.TxtName.ButtonCustom.Text = resources.GetString("TxtName.ButtonCustom.Text");
            this.TxtName.ButtonCustom.Tooltip = resources.GetString("TxtName.ButtonCustom.Tooltip");
            this.TxtName.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("TxtName.ButtonCustom2.DisplayPosition")));
            this.TxtName.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("TxtName.ButtonCustom2.Image")));
            this.TxtName.ButtonCustom2.Text = resources.GetString("TxtName.ButtonCustom2.Text");
            this.TxtName.ButtonCustom2.Tooltip = resources.GetString("TxtName.ButtonCustom2.Tooltip");
            this.TxtName.DisabledBackColor = System.Drawing.Color.White;
            this.TxtName.ForeColor = System.Drawing.Color.Black;
            this.TxtName.Name = "TxtName";
            this.TxtName.PreventEnterBeep = true;
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
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
            // txtSymbol
            // 
            resources.ApplyResources(this.txtSymbol, "txtSymbol");
            this.txtSymbol.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSymbol.Border.Class = "TextBoxBorder";
            this.txtSymbol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtSymbol.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtSymbol.ButtonCustom.DisplayPosition")));
            this.txtSymbol.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtSymbol.ButtonCustom.Image")));
            this.txtSymbol.ButtonCustom.Text = resources.GetString("txtSymbol.ButtonCustom.Text");
            this.txtSymbol.ButtonCustom.Tooltip = resources.GetString("txtSymbol.ButtonCustom.Tooltip");
            this.txtSymbol.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtSymbol.ButtonCustom2.DisplayPosition")));
            this.txtSymbol.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtSymbol.ButtonCustom2.Image")));
            this.txtSymbol.ButtonCustom2.Text = resources.GetString("txtSymbol.ButtonCustom2.Text");
            this.txtSymbol.ButtonCustom2.Tooltip = resources.GetString("txtSymbol.ButtonCustom2.Tooltip");
            this.txtSymbol.DisabledBackColor = System.Drawing.Color.White;
            this.txtSymbol.ForeColor = System.Drawing.Color.Black;
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.PreventEnterBeep = true;
            this.txtSymbol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSymbol_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // txtNumberDigit
            // 
            resources.ApplyResources(this.txtNumberDigit, "txtNumberDigit");
            this.txtNumberDigit.BackColor = System.Drawing.Color.White;
            this.txtNumberDigit.ForeColor = System.Drawing.Color.Black;
            this.txtNumberDigit.Name = "txtNumberDigit";
            this.txtNumberDigit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumberDigit_KeyDown);
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
            // txtBuy
            // 
            resources.ApplyResources(this.txtBuy, "txtBuy");
            this.txtBuy.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBuy.Border.Class = "TextBoxBorder";
            this.txtBuy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtBuy.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtBuy.ButtonCustom.DisplayPosition")));
            this.txtBuy.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtBuy.ButtonCustom.Image")));
            this.txtBuy.ButtonCustom.Text = resources.GetString("txtBuy.ButtonCustom.Text");
            this.txtBuy.ButtonCustom.Tooltip = resources.GetString("txtBuy.ButtonCustom.Tooltip");
            this.txtBuy.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtBuy.ButtonCustom2.DisplayPosition")));
            this.txtBuy.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtBuy.ButtonCustom2.Image")));
            this.txtBuy.ButtonCustom2.Text = resources.GetString("txtBuy.ButtonCustom2.Text");
            this.txtBuy.ButtonCustom2.Tooltip = resources.GetString("txtBuy.ButtonCustom2.Tooltip");
            this.txtBuy.DisabledBackColor = System.Drawing.Color.White;
            this.txtBuy.ForeColor = System.Drawing.Color.Black;
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.PreventEnterBeep = true;
            this.txtBuy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuy_KeyDown);
            this.txtBuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuy_KeyPress);
            // 
            // txtSell
            // 
            resources.ApplyResources(this.txtSell, "txtSell");
            this.txtSell.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSell.Border.Class = "TextBoxBorder";
            this.txtSell.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtSell.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtSell.ButtonCustom.DisplayPosition")));
            this.txtSell.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtSell.ButtonCustom.Image")));
            this.txtSell.ButtonCustom.Text = resources.GetString("txtSell.ButtonCustom.Text");
            this.txtSell.ButtonCustom.Tooltip = resources.GetString("txtSell.ButtonCustom.Tooltip");
            this.txtSell.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtSell.ButtonCustom2.DisplayPosition")));
            this.txtSell.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtSell.ButtonCustom2.Image")));
            this.txtSell.ButtonCustom2.Text = resources.GetString("txtSell.ButtonCustom2.Text");
            this.txtSell.ButtonCustom2.Tooltip = resources.GetString("txtSell.ButtonCustom2.Tooltip");
            this.txtSell.DisabledBackColor = System.Drawing.Color.White;
            this.txtSell.ForeColor = System.Drawing.Color.Black;
            this.txtSell.Name = "txtSell";
            this.txtSell.PreventEnterBeep = true;
            this.txtSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSell_KeyDown);
            this.txtSell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSell_KeyPress);
            // 
            // txtFloatSymbol
            // 
            resources.ApplyResources(this.txtFloatSymbol, "txtFloatSymbol");
            this.txtFloatSymbol.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFloatSymbol.Border.Class = "TextBoxBorder";
            this.txtFloatSymbol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFloatSymbol.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtFloatSymbol.ButtonCustom.DisplayPosition")));
            this.txtFloatSymbol.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtFloatSymbol.ButtonCustom.Image")));
            this.txtFloatSymbol.ButtonCustom.Text = resources.GetString("txtFloatSymbol.ButtonCustom.Text");
            this.txtFloatSymbol.ButtonCustom.Tooltip = resources.GetString("txtFloatSymbol.ButtonCustom.Tooltip");
            this.txtFloatSymbol.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtFloatSymbol.ButtonCustom2.DisplayPosition")));
            this.txtFloatSymbol.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtFloatSymbol.ButtonCustom2.Image")));
            this.txtFloatSymbol.ButtonCustom2.Text = resources.GetString("txtFloatSymbol.ButtonCustom2.Text");
            this.txtFloatSymbol.ButtonCustom2.Tooltip = resources.GetString("txtFloatSymbol.ButtonCustom2.Tooltip");
            this.txtFloatSymbol.DisabledBackColor = System.Drawing.Color.White;
            this.txtFloatSymbol.ForeColor = System.Drawing.Color.Black;
            this.txtFloatSymbol.Name = "txtFloatSymbol";
            this.txtFloatSymbol.PreventEnterBeep = true;
            this.txtFloatSymbol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFloatSymbol_KeyDown);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
            // 
            // txtFloatName
            // 
            resources.ApplyResources(this.txtFloatName, "txtFloatName");
            this.txtFloatName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFloatName.Border.Class = "TextBoxBorder";
            this.txtFloatName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFloatName.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtFloatName.ButtonCustom.DisplayPosition")));
            this.txtFloatName.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtFloatName.ButtonCustom.Image")));
            this.txtFloatName.ButtonCustom.Text = resources.GetString("txtFloatName.ButtonCustom.Text");
            this.txtFloatName.ButtonCustom.Tooltip = resources.GetString("txtFloatName.ButtonCustom.Tooltip");
            this.txtFloatName.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtFloatName.ButtonCustom2.DisplayPosition")));
            this.txtFloatName.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtFloatName.ButtonCustom2.Image")));
            this.txtFloatName.ButtonCustom2.Text = resources.GetString("txtFloatName.ButtonCustom2.Text");
            this.txtFloatName.ButtonCustom2.Tooltip = resources.GetString("txtFloatName.ButtonCustom2.Tooltip");
            this.txtFloatName.DisabledBackColor = System.Drawing.Color.White;
            this.txtFloatName.ForeColor = System.Drawing.Color.Black;
            this.txtFloatName.Name = "txtFloatName";
            this.txtFloatName.PreventEnterBeep = true;
            this.txtFloatName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFloatName_KeyDown);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // chkDefault
            // 
            resources.ApplyResources(this.chkDefault, "chkDefault");
            this.chkDefault.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkDefault.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkDefault.ForeColor = System.Drawing.Color.Black;
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // txtCountry
            // 
            resources.ApplyResources(this.txtCountry, "txtCountry");
            this.txtCountry.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCountry.Border.Class = "TextBoxBorder";
            this.txtCountry.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtCountry.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtCountry.ButtonCustom.DisplayPosition")));
            this.txtCountry.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtCountry.ButtonCustom.Image")));
            this.txtCountry.ButtonCustom.Text = resources.GetString("txtCountry.ButtonCustom.Text");
            this.txtCountry.ButtonCustom.Tooltip = resources.GetString("txtCountry.ButtonCustom.Tooltip");
            this.txtCountry.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtCountry.ButtonCustom2.DisplayPosition")));
            this.txtCountry.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtCountry.ButtonCustom2.Image")));
            this.txtCountry.ButtonCustom2.Text = resources.GetString("txtCountry.ButtonCustom2.Text");
            this.txtCountry.ButtonCustom2.Tooltip = resources.GetString("txtCountry.ButtonCustom2.Tooltip");
            this.txtCountry.DisabledBackColor = System.Drawing.Color.White;
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PreventEnterBeep = true;
            this.txtCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrency_KeyDown);
            // 
            // AddCurrencyPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.txtFloatName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFloatSymbol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSell);
            this.Controls.Add(this.txtBuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumberDigit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AddCurrencyPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AddCurrencyPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberDigit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtName;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtNumberDigit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBuy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSell;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFloatSymbol;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFloatName;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkDefault;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCountry;
    }
}