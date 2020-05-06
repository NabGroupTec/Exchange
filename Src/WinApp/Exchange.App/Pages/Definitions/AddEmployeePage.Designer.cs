namespace Exchange.App.Pages.Definitions
{
    partial class AddEmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeePage));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtFname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTell = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBDate = new Atf.UI.DateTimeSelector();
            this.personPhoto = new System.Windows.Forms.PictureBox();
            this.txtComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label17 = new System.Windows.Forms.Label();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNationalCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.personPhoto)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.groupPanel4.SuspendLayout();
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
            // txtFamily
            // 
            resources.ApplyResources(this.txtFamily, "txtFamily");
            this.txtFamily.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFamily.Border.Class = "TextBoxBorder";
            this.txtFamily.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFamily.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtFamily.ButtonCustom.DisplayPosition")));
            this.txtFamily.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtFamily.ButtonCustom.Image")));
            this.txtFamily.ButtonCustom.Text = resources.GetString("txtFamily.ButtonCustom.Text");
            this.txtFamily.ButtonCustom.Tooltip = resources.GetString("txtFamily.ButtonCustom.Tooltip");
            this.txtFamily.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtFamily.ButtonCustom2.DisplayPosition")));
            this.txtFamily.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtFamily.ButtonCustom2.Image")));
            this.txtFamily.ButtonCustom2.Text = resources.GetString("txtFamily.ButtonCustom2.Text");
            this.txtFamily.ButtonCustom2.Tooltip = resources.GetString("txtFamily.ButtonCustom2.Tooltip");
            this.txtFamily.DisabledBackColor = System.Drawing.Color.White;
            this.txtFamily.ForeColor = System.Drawing.Color.Black;
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.PreventEnterBeep = true;
            this.txtFamily.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFamily_KeyDown);
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
            // txtFname
            // 
            resources.ApplyResources(this.txtFname, "txtFname");
            this.txtFname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFname.Border.Class = "TextBoxBorder";
            this.txtFname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFname.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtFname.ButtonCustom.DisplayPosition")));
            this.txtFname.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtFname.ButtonCustom.Image")));
            this.txtFname.ButtonCustom.Text = resources.GetString("txtFname.ButtonCustom.Text");
            this.txtFname.ButtonCustom.Tooltip = resources.GetString("txtFname.ButtonCustom.Tooltip");
            this.txtFname.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtFname.ButtonCustom2.DisplayPosition")));
            this.txtFname.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtFname.ButtonCustom2.Image")));
            this.txtFname.ButtonCustom2.Text = resources.GetString("txtFname.ButtonCustom2.Text");
            this.txtFname.ButtonCustom2.Tooltip = resources.GetString("txtFname.ButtonCustom2.Tooltip");
            this.txtFname.DisabledBackColor = System.Drawing.Color.White;
            this.txtFname.ForeColor = System.Drawing.Color.Black;
            this.txtFname.Name = "txtFname";
            this.txtFname.PreventEnterBeep = true;
            this.txtFname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFname_KeyDown);
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
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFirstName.Border.Class = "TextBoxBorder";
            this.txtFirstName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFirstName.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtFirstName.ButtonCustom.DisplayPosition")));
            this.txtFirstName.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtFirstName.ButtonCustom.Image")));
            this.txtFirstName.ButtonCustom.Text = resources.GetString("txtFirstName.ButtonCustom.Text");
            this.txtFirstName.ButtonCustom.Tooltip = resources.GetString("txtFirstName.ButtonCustom.Tooltip");
            this.txtFirstName.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtFirstName.ButtonCustom2.DisplayPosition")));
            this.txtFirstName.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtFirstName.ButtonCustom2.Image")));
            this.txtFirstName.ButtonCustom2.Text = resources.GetString("txtFirstName.ButtonCustom2.Text");
            this.txtFirstName.ButtonCustom2.Tooltip = resources.GetString("txtFirstName.ButtonCustom2.Tooltip");
            this.txtFirstName.DisabledBackColor = System.Drawing.Color.White;
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PreventEnterBeep = true;
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
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
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Name = "label10";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtEmail.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtEmail.ButtonCustom.DisplayPosition")));
            this.txtEmail.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtEmail.ButtonCustom.Image")));
            this.txtEmail.ButtonCustom.Text = resources.GetString("txtEmail.ButtonCustom.Text");
            this.txtEmail.ButtonCustom.Tooltip = resources.GetString("txtEmail.ButtonCustom.Tooltip");
            this.txtEmail.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtEmail.ButtonCustom2.DisplayPosition")));
            this.txtEmail.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtEmail.ButtonCustom2.Image")));
            this.txtEmail.ButtonCustom2.Text = resources.GetString("txtEmail.ButtonCustom2.Text");
            this.txtEmail.ButtonCustom2.Tooltip = resources.GetString("txtEmail.ButtonCustom2.Tooltip");
            this.txtEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            // 
            // txtBDate
            // 
            resources.ApplyResources(this.txtBDate, "txtBDate");
            this.txtBDate.BackColor = System.Drawing.Color.White;
            this.txtBDate.ForeColor = System.Drawing.Color.Black;
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBDate_KeyDown);
            // 
            // personPhoto
            // 
            resources.ApplyResources(this.personPhoto, "personPhoto");
            this.personPhoto.BackColor = System.Drawing.Color.White;
            this.personPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personPhoto.ForeColor = System.Drawing.Color.Black;
            this.personPhoto.Image = global::Exchange.App.Properties.Resources.DefaultPerson;
            this.personPhoto.Name = "personPhoto";
            this.personPhoto.TabStop = false;
            this.personPhoto.Click += new System.EventHandler(this.personPhoto_Click);
            // 
            // txtComment
            // 
            resources.ApplyResources(this.txtComment, "txtComment");
            this.txtComment.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtComment.Border.Class = "TextBoxBorder";
            this.txtComment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtComment.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtComment.ButtonCustom.DisplayPosition")));
            this.txtComment.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtComment.ButtonCustom.Image")));
            this.txtComment.ButtonCustom.Text = resources.GetString("txtComment.ButtonCustom.Text");
            this.txtComment.ButtonCustom.Tooltip = resources.GetString("txtComment.ButtonCustom.Tooltip");
            this.txtComment.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtComment.ButtonCustom2.DisplayPosition")));
            this.txtComment.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtComment.ButtonCustom2.Image")));
            this.txtComment.ButtonCustom2.Text = resources.GetString("txtComment.ButtonCustom2.Text");
            this.txtComment.ButtonCustom2.Tooltip = resources.GetString("txtComment.ButtonCustom2.Tooltip");
            this.txtComment.DisabledBackColor = System.Drawing.Color.White;
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.Name = "txtComment";
            this.txtComment.PreventEnterBeep = true;
            this.txtComment.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtComment_KeyDown);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Name = "label17";
            // 
            // groupPanel3
            // 
            resources.ApplyResources(this.groupPanel3, "groupPanel3");
            this.groupPanel3.BackColor = System.Drawing.Color.White;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.label4);
            this.groupPanel3.Controls.Add(this.label5);
            this.groupPanel3.Controls.Add(this.label6);
            this.groupPanel3.Controls.Add(this.txtComment);
            this.groupPanel3.Controls.Add(this.txtTell);
            this.groupPanel3.Controls.Add(this.label17);
            this.groupPanel3.Controls.Add(this.txtMobile);
            this.groupPanel3.Controls.Add(this.txtAddress);
            this.groupPanel3.Controls.Add(this.label10);
            this.groupPanel3.Controls.Add(this.txtEmail);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Name = "groupPanel3";
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // groupPanel4
            // 
            resources.ApplyResources(this.groupPanel4, "groupPanel4");
            this.groupPanel4.BackColor = System.Drawing.Color.White;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.label8);
            this.groupPanel4.Controls.Add(this.txtNationalCode);
            this.groupPanel4.Controls.Add(this.label1);
            this.groupPanel4.Controls.Add(this.label2);
            this.groupPanel4.Controls.Add(this.label3);
            this.groupPanel4.Controls.Add(this.txtFamily);
            this.groupPanel4.Controls.Add(this.txtFname);
            this.groupPanel4.Controls.Add(this.txtFirstName);
            this.groupPanel4.Controls.Add(this.label7);
            this.groupPanel4.Controls.Add(this.txtBDate);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Name = "groupPanel4";
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.CustomizeBackground2;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // txtNationalCode
            // 
            resources.ApplyResources(this.txtNationalCode, "txtNationalCode");
            this.txtNationalCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNationalCode.Border.Class = "TextBoxBorder";
            this.txtNationalCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtNationalCode.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtNationalCode.ButtonCustom.DisplayPosition")));
            this.txtNationalCode.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtNationalCode.ButtonCustom.Image")));
            this.txtNationalCode.ButtonCustom.Text = resources.GetString("txtNationalCode.ButtonCustom.Text");
            this.txtNationalCode.ButtonCustom.Tooltip = resources.GetString("txtNationalCode.ButtonCustom.Tooltip");
            this.txtNationalCode.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtNationalCode.ButtonCustom2.DisplayPosition")));
            this.txtNationalCode.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtNationalCode.ButtonCustom2.Image")));
            this.txtNationalCode.ButtonCustom2.Text = resources.GetString("txtNationalCode.ButtonCustom2.Text");
            this.txtNationalCode.ButtonCustom2.Tooltip = resources.GetString("txtNationalCode.ButtonCustom2.Tooltip");
            this.txtNationalCode.DisabledBackColor = System.Drawing.Color.White;
            this.txtNationalCode.ForeColor = System.Drawing.Color.Black;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.PreventEnterBeep = true;
            this.txtNationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalCode_KeyPress_1);
            // 
            // AddEmployeePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.groupPanel4);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.personPhoto);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AddEmployeePage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AddEmployeePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personPhoto)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFamily;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFirstName;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTell;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private Atf.UI.DateTimeSelector txtBDate;
        private System.Windows.Forms.PictureBox personPhoto;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComment;
        private System.Windows.Forms.Label label17;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNationalCode;
    }
}