using System.Drawing;

namespace Exchange.App.Pages.Login
{
    partial class LoginPage
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
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.chkRemember = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkLangKurdish = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkLangPersian = new System.Windows.Forms.LinkLabel();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.btnLogoPass = new DevComponents.DotNetBar.ButtonX();
            this.btnLogoUser = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtUsername.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsername.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsername.DisabledBackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("IRANSans", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(202, 89);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PreventEnterBeep = true;
            this.txtUsername.Size = new System.Drawing.Size(413, 38);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUsername.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtUsername.WatermarkText = "نــــام کــــاربری ";
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPassword.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.DisabledBackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("IRANSans", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(202, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(413, 38);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPassword.WatermarkText = "کلمه عبـــور";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Font = new System.Drawing.Font("IRANSans", 10F);
            this.btnOk.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnOk.ImageTextSpacing = 8;
            this.btnOk.Location = new System.Drawing.Point(521, 203);
            this.btnOk.Name = "btnOk";
            this.btnOk.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnOk.Size = new System.Drawing.Size(94, 42);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.SubItemsExpandWidth = 10;
            this.btnOk.Symbol = "";
            this.btnOk.SymbolSize = 15F;
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "تائید";
            this.btnOk.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkRemember
            // 
            this.chkRemember.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkRemember.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkRemember.Font = new System.Drawing.Font("IRANSans", 8F);
            this.chkRemember.ForeColor = System.Drawing.Color.Black;
            this.chkRemember.Location = new System.Drawing.Point(202, 179);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(143, 17);
            this.chkRemember.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkRemember.TabIndex = 2;
            this.chkRemember.Text = "Remember Me";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("IRANSans", 10F);
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnCancel.ImageTextSpacing = 8;
            this.btnCancel.Location = new System.Drawing.Point(425, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnCancel.Size = new System.Drawing.Size(94, 42);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.SubItemsExpandWidth = 10;
            this.btnCancel.Symbol = "";
            this.btnCancel.SymbolSize = 15F;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("IRANSans", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 90000;
            this.label1.Text = "Exchange System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("IRANSans", 7F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 90000000;
            this.label2.Text = "Nab Group Tec";
            // 
            // lnkLangKurdish
            // 
            this.lnkLangKurdish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkLangKurdish.AutoSize = true;
            this.lnkLangKurdish.BackColor = System.Drawing.Color.White;
            this.lnkLangKurdish.Font = new System.Drawing.Font("IRANSans", 8.249999F);
            this.lnkLangKurdish.ForeColor = System.Drawing.Color.Black;
            this.lnkLangKurdish.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLangKurdish.Location = new System.Drawing.Point(37, 196);
            this.lnkLangKurdish.Name = "lnkLangKurdish";
            this.lnkLangKurdish.Size = new System.Drawing.Size(36, 19);
            this.lnkLangKurdish.TabIndex = 15;
            this.lnkLangKurdish.TabStop = true;
            this.lnkLangKurdish.Text = "کوردی";
            this.lnkLangKurdish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLangKurdish_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("IRANSans", 8.249999F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 196);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(12, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "|";
            // 
            // lnkLangPersian
            // 
            this.lnkLangPersian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkLangPersian.AutoSize = true;
            this.lnkLangPersian.BackColor = System.Drawing.Color.White;
            this.lnkLangPersian.Font = new System.Drawing.Font("IRANSans", 8.249999F);
            this.lnkLangPersian.ForeColor = System.Drawing.Color.Black;
            this.lnkLangPersian.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLangPersian.Location = new System.Drawing.Point(85, 196);
            this.lnkLangPersian.Name = "lnkLangPersian";
            this.lnkLangPersian.Size = new System.Drawing.Size(37, 19);
            this.lnkLangPersian.TabIndex = 13;
            this.lnkLangPersian.TabStop = true;
            this.lnkLangPersian.Text = "فارسی";
            this.lnkLangPersian.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLangPersian_LinkClicked);
            // 
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.Color.White;
            this.picLogin.ForeColor = System.Drawing.Color.Black;
            this.picLogin.Image = global::Exchange.App.Properties.Resources.login;
            this.picLogin.Location = new System.Drawing.Point(9, 48);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(146, 130);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 0;
            this.picLogin.TabStop = false;
            // 
            // btnLogoPass
            // 
            this.btnLogoPass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogoPass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogoPass.Font = new System.Drawing.Font("IRANSans", 10F);
            this.btnLogoPass.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnLogoPass.ImageTextSpacing = 8;
            this.btnLogoPass.Location = new System.Drawing.Point(161, 130);
            this.btnLogoPass.Name = "btnLogoPass";
            this.btnLogoPass.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8, 0, 8, 0);
            this.btnLogoPass.Size = new System.Drawing.Size(41, 38);
            this.btnLogoPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogoPass.SubItemsExpandWidth = 10;
            this.btnLogoPass.Symbol = "";
            this.btnLogoPass.SymbolSize = 15F;
            this.btnLogoPass.TabIndex = 10;
            this.btnLogoPass.TabStop = false;
            this.btnLogoPass.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnLogoUser
            // 
            this.btnLogoUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogoUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogoUser.Font = new System.Drawing.Font("IRANSans", 10F);
            this.btnLogoUser.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnLogoUser.ImageTextSpacing = 8;
            this.btnLogoUser.Location = new System.Drawing.Point(161, 89);
            this.btnLogoUser.Name = "btnLogoUser";
            this.btnLogoUser.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8, 0, 8, 0);
            this.btnLogoUser.Size = new System.Drawing.Size(41, 38);
            this.btnLogoUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogoUser.SubItemsExpandWidth = 10;
            this.btnLogoUser.Symbol = "";
            this.btnLogoUser.SymbolColor = System.Drawing.Color.Black;
            this.btnLogoUser.SymbolSize = 15F;
            this.btnLogoUser.TabIndex = 9;
            this.btnLogoUser.TabStop = false;
            this.btnLogoUser.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // LoginPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(644, 254);
            this.ControlBox = false;
            this.Controls.Add(this.lnkLangKurdish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkLangPersian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogoPass);
            this.Controls.Add(this.btnLogoUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picLogin);
            this.Font = new System.Drawing.Font("IRANSans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.Resizable = false;
            this.ShowIcon = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginPage_KeyDown);
            this.Resize += new System.EventHandler(this.LoginPage_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkRemember;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkLangKurdish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkLangPersian;
        private DevComponents.DotNetBar.ButtonX btnLogoPass;
        private DevComponents.DotNetBar.ButtonX btnLogoUser;
    }
}