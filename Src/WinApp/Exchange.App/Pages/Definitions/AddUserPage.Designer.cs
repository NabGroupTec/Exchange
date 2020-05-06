namespace Exchange.App.Pages.Definitions
{
    partial class AddUserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserPage));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRePassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTell = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtUserName.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtUserName.ButtonCustom.DisplayPosition")));
            this.txtUserName.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtUserName.ButtonCustom.Image")));
            this.txtUserName.ButtonCustom.Text = resources.GetString("txtUserName.ButtonCustom.Text");
            this.txtUserName.ButtonCustom.Tooltip = resources.GetString("txtUserName.ButtonCustom.Tooltip");
            this.txtUserName.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtUserName.ButtonCustom2.DisplayPosition")));
            this.txtUserName.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtUserName.ButtonCustom2.Image")));
            this.txtUserName.ButtonCustom2.Text = resources.GetString("txtUserName.ButtonCustom2.Text");
            this.txtUserName.ButtonCustom2.Tooltip = resources.GetString("txtUserName.ButtonCustom2.Tooltip");
            this.txtUserName.DisabledBackColor = System.Drawing.Color.White;
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PreventEnterBeep = true;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
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
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPassword.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtPassword.ButtonCustom.DisplayPosition")));
            this.txtPassword.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtPassword.ButtonCustom.Image")));
            this.txtPassword.ButtonCustom.Text = resources.GetString("txtPassword.ButtonCustom.Text");
            this.txtPassword.ButtonCustom.Tooltip = resources.GetString("txtPassword.ButtonCustom.Tooltip");
            this.txtPassword.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtPassword.ButtonCustom2.DisplayPosition")));
            this.txtPassword.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtPassword.ButtonCustom2.Image")));
            this.txtPassword.ButtonCustom2.Text = resources.GetString("txtPassword.ButtonCustom2.Text");
            this.txtPassword.ButtonCustom2.Tooltip = resources.GetString("txtPassword.ButtonCustom2.Tooltip");
            this.txtPassword.DisabledBackColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
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
            // txtFullName
            // 
            resources.ApplyResources(this.txtFullName, "txtFullName");
            this.txtFullName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFullName.Border.Class = "TextBoxBorder";
            this.txtFullName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFullName.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtFullName.ButtonCustom.DisplayPosition")));
            this.txtFullName.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtFullName.ButtonCustom.Image")));
            this.txtFullName.ButtonCustom.Text = resources.GetString("txtFullName.ButtonCustom.Text");
            this.txtFullName.ButtonCustom.Tooltip = resources.GetString("txtFullName.ButtonCustom.Tooltip");
            this.txtFullName.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtFullName.ButtonCustom2.DisplayPosition")));
            this.txtFullName.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtFullName.ButtonCustom2.Image")));
            this.txtFullName.ButtonCustom2.Text = resources.GetString("txtFullName.ButtonCustom2.Text");
            this.txtFullName.ButtonCustom2.Tooltip = resources.GetString("txtFullName.ButtonCustom2.Tooltip");
            this.txtFullName.DisabledBackColor = System.Drawing.Color.White;
            this.txtFullName.ForeColor = System.Drawing.Color.Black;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PreventEnterBeep = true;
            this.txtFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFullName_KeyDown);
            // 
            // txtRePassword
            // 
            resources.ApplyResources(this.txtRePassword, "txtRePassword");
            this.txtRePassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRePassword.Border.Class = "TextBoxBorder";
            this.txtRePassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtRePassword.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtRePassword.ButtonCustom.DisplayPosition")));
            this.txtRePassword.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtRePassword.ButtonCustom.Image")));
            this.txtRePassword.ButtonCustom.Text = resources.GetString("txtRePassword.ButtonCustom.Text");
            this.txtRePassword.ButtonCustom.Tooltip = resources.GetString("txtRePassword.ButtonCustom.Tooltip");
            this.txtRePassword.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtRePassword.ButtonCustom2.DisplayPosition")));
            this.txtRePassword.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtRePassword.ButtonCustom2.Image")));
            this.txtRePassword.ButtonCustom2.Text = resources.GetString("txtRePassword.ButtonCustom2.Text");
            this.txtRePassword.ButtonCustom2.Tooltip = resources.GetString("txtRePassword.ButtonCustom2.Tooltip");
            this.txtRePassword.DisabledBackColor = System.Drawing.Color.White;
            this.txtRePassword.ForeColor = System.Drawing.Color.Black;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PreventEnterBeep = true;
            this.txtRePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRePassword_KeyDown);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
            // 
            // txtTell
            // 
            resources.ApplyResources(this.txtTell, "txtTell");
            this.txtTell.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTell.Border.Class = "TextBoxBorder";
            this.txtTell.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtTell.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtTell.ButtonCustom.DisplayPosition")));
            this.txtTell.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtTell.ButtonCustom.Image")));
            this.txtTell.ButtonCustom.Text = resources.GetString("txtTell.ButtonCustom.Text");
            this.txtTell.ButtonCustom.Tooltip = resources.GetString("txtTell.ButtonCustom.Tooltip");
            this.txtTell.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtTell.ButtonCustom2.DisplayPosition")));
            this.txtTell.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtTell.ButtonCustom2.Image")));
            this.txtTell.ButtonCustom2.Text = resources.GetString("txtTell.ButtonCustom2.Text");
            this.txtTell.ButtonCustom2.Tooltip = resources.GetString("txtTell.ButtonCustom2.Tooltip");
            this.txtTell.DisabledBackColor = System.Drawing.Color.White;
            this.txtTell.ForeColor = System.Drawing.Color.Black;
            this.txtTell.Name = "txtTell";
            this.txtTell.PreventEnterBeep = true;
            this.txtTell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTell_KeyDown);
            this.txtTell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTell_KeyPress);
            // 
            // txtMobile
            // 
            resources.ApplyResources(this.txtMobile, "txtMobile");
            this.txtMobile.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtMobile.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtMobile.ButtonCustom.DisplayPosition")));
            this.txtMobile.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtMobile.ButtonCustom.Image")));
            this.txtMobile.ButtonCustom.Text = resources.GetString("txtMobile.ButtonCustom.Text");
            this.txtMobile.ButtonCustom.Tooltip = resources.GetString("txtMobile.ButtonCustom.Tooltip");
            this.txtMobile.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtMobile.ButtonCustom2.DisplayPosition")));
            this.txtMobile.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtMobile.ButtonCustom2.Image")));
            this.txtMobile.ButtonCustom2.Text = resources.GetString("txtMobile.ButtonCustom2.Text");
            this.txtMobile.ButtonCustom2.Tooltip = resources.GetString("txtMobile.ButtonCustom2.Tooltip");
            this.txtMobile.DisabledBackColor = System.Drawing.Color.White;
            this.txtMobile.ForeColor = System.Drawing.Color.Black;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PreventEnterBeep = true;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtAddress.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtAddress.ButtonCustom.DisplayPosition")));
            this.txtAddress.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtAddress.ButtonCustom.Image")));
            this.txtAddress.ButtonCustom.Text = resources.GetString("txtAddress.ButtonCustom.Text");
            this.txtAddress.ButtonCustom.Tooltip = resources.GetString("txtAddress.ButtonCustom.Tooltip");
            this.txtAddress.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtAddress.ButtonCustom2.DisplayPosition")));
            this.txtAddress.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtAddress.ButtonCustom2.Image")));
            this.txtAddress.ButtonCustom2.Text = resources.GetString("txtAddress.ButtonCustom2.Text");
            this.txtAddress.ButtonCustom2.Tooltip = resources.GetString("txtAddress.ButtonCustom2.Tooltip");
            this.txtAddress.DisabledBackColor = System.Drawing.Color.White;
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PreventEnterBeep = true;
            this.txtAddress.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // AddUserPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AddUserPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AddUserPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFullName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRePassword;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTell;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
    }
}