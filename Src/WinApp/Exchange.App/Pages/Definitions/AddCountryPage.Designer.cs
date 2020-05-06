namespace Exchange.App.Pages.Definitions
{
    partial class AddCountryPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TxtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbRegion = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtCountryCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(383, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ایزو";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(361, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام کشور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(343, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "منطقه / قاره";
            // 
            // txtIso
            // 
            this.txtIso.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtIso.Border.Class = "TextBoxBorder";
            this.txtIso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtIso.DisabledBackColor = System.Drawing.Color.White;
            this.txtIso.ForeColor = System.Drawing.Color.Black;
            this.txtIso.Location = new System.Drawing.Point(152, 94);
            this.txtIso.Name = "txtIso";
            this.txtIso.PreventEnterBeep = true;
            this.txtIso.Size = new System.Drawing.Size(258, 36);
            this.txtIso.TabIndex = 2;
            this.txtIso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIso.WatermarkText = "iso";
            this.txtIso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIso_KeyDown);
            this.txtIso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIso_KeyPress);
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TxtName.Border.Class = "TextBoxBorder";
            this.TxtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TxtName.DisabledBackColor = System.Drawing.Color.White;
            this.TxtName.ForeColor = System.Drawing.Color.Black;
            this.TxtName.Location = new System.Drawing.Point(4, 156);
            this.TxtName.Name = "TxtName";
            this.TxtName.PreventEnterBeep = true;
            this.TxtName.Size = new System.Drawing.Size(406, 36);
            this.TxtName.TabIndex = 3;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtName.WatermarkText = "نام کشور";
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
            // 
            // cmbRegion
            // 
            this.cmbRegion.DisplayMember = "Text";
            this.cmbRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegion.Font = new System.Drawing.Font("IRANSans", 12F);
            this.cmbRegion.ForeColor = System.Drawing.Color.Black;
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.ItemHeight = 30;
            this.cmbRegion.Location = new System.Drawing.Point(4, 218);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbRegion.Size = new System.Drawing.Size(406, 36);
            this.cmbRegion.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cmbRegion.TabIndex = 4;
            this.cmbRegion.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.cmbRegion.WatermarkFont = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbRegion.WatermarkText = "قاره";
            this.cmbRegion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRegion_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Font = new System.Drawing.Font("IRANSans", 10F);
            this.btnOk.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnOk.ImageTextSpacing = 8;
            this.btnOk.Location = new System.Drawing.Point(96, 300);
            this.btnOk.Name = "btnOk";
            this.btnOk.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnOk.Size = new System.Drawing.Size(79, 31);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.SubItemsExpandWidth = 10;
            this.btnOk.Symbol = "";
            this.btnOk.SymbolSize = 12F;
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ثبت";
            this.btnOk.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("IRANSans", 10F);
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnCancel.ImageTextSpacing = 8;
            this.btnCancel.Location = new System.Drawing.Point(12, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnCancel.Size = new System.Drawing.Size(79, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.SubItemsExpandWidth = 10;
            this.btnCancel.Symbol = "";
            this.btnCancel.SymbolSize = 12F;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCountryCode.Border.Class = "TextBoxBorder";
            this.txtCountryCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtCountryCode.DisabledBackColor = System.Drawing.Color.White;
            this.txtCountryCode.ForeColor = System.Drawing.Color.Black;
            this.txtCountryCode.Location = new System.Drawing.Point(152, 32);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.PreventEnterBeep = true;
            this.txtCountryCode.Size = new System.Drawing.Size(258, 36);
            this.txtCountryCode.TabIndex = 1;
            this.txtCountryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCountryCode.WatermarkText = "کد کشور";
            this.txtCountryCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCountryCode_KeyDown);
            this.txtCountryCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountryCode_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(362, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "کد کشور";
            // 
            // AddCountryPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(422, 339);
            this.ControlBox = false;
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.txtIso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("IRANSans", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AddCountryPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کشور";
            this.Load += new System.EventHandler(this.AddCountryPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIso;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRegion;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCountryCode;
        private System.Windows.Forms.Label label4;
    }
}