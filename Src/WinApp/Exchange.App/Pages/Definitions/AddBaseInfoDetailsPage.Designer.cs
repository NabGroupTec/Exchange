namespace Exchange.App.Pages.Definitions
{
    partial class AddBaseInfoDetailsPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtText = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbGroupInfo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(285, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام سیستمی اطلاعات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(331, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام اطلاعات";
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
            this.TxtName.Location = new System.Drawing.Point(12, 94);
            this.TxtName.Name = "TxtName";
            this.TxtName.PreventEnterBeep = true;
            this.TxtName.Size = new System.Drawing.Size(373, 36);
            this.TxtName.TabIndex = 2;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtName.WatermarkText = "نام سیستمی اطلاعات";
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnOk.ImageTextSpacing = 8;
            this.btnOk.Location = new System.Drawing.Point(96, 223);
            this.btnOk.Name = "btnOk";
            this.btnOk.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnOk.Size = new System.Drawing.Size(79, 31);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.SubItemsExpandWidth = 10;
            this.btnOk.Symbol = "";
            this.btnOk.SymbolSize = 12F;
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "ثبت";
            this.btnOk.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnCancel.ImageTextSpacing = 8;
            this.btnCancel.Location = new System.Drawing.Point(12, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnCancel.Size = new System.Drawing.Size(79, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.SubItemsExpandWidth = 10;
            this.btnCancel.Symbol = "";
            this.btnCancel.SymbolSize = 12F;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtText.Border.Class = "TextBoxBorder";
            this.txtText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtText.DisabledBackColor = System.Drawing.Color.White;
            this.txtText.ForeColor = System.Drawing.Color.Black;
            this.txtText.Location = new System.Drawing.Point(12, 156);
            this.txtText.Name = "txtText";
            this.txtText.PreventEnterBeep = true;
            this.txtText.Size = new System.Drawing.Size(373, 36);
            this.txtText.TabIndex = 3;
            this.txtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtText.WatermarkText = "نام اطلاعات";
            this.txtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyDown);
            // 
            // cmbGroupInfo
            // 
            this.cmbGroupInfo.DisplayMember = "Text";
            this.cmbGroupInfo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGroupInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupInfo.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupInfo.ForeColor = System.Drawing.Color.Black;
            this.cmbGroupInfo.FormattingEnabled = true;
            this.cmbGroupInfo.ItemHeight = 30;
            this.cmbGroupInfo.Location = new System.Drawing.Point(12, 32);
            this.cmbGroupInfo.Name = "cmbGroupInfo";
            this.cmbGroupInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbGroupInfo.Size = new System.Drawing.Size(373, 36);
            this.cmbGroupInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.cmbGroupInfo.TabIndex = 1;
            this.cmbGroupInfo.WatermarkColor = System.Drawing.SystemColors.ControlDark;
            this.cmbGroupInfo.WatermarkFont = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbGroupInfo.WatermarkText = "گروه را انتخاب نمائید";
            this.cmbGroupInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGroupInfo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "گروه اطلاعات پایه";
            // 
            // AddBaseInfoDetailsPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(397, 266);
            this.ControlBox = false;
            this.Controls.Add(this.cmbGroupInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AddBaseInfoDetailsPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات پایه";
            this.Load += new System.EventHandler(this.AddBaseInfoDetailsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtName;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtText;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbGroupInfo;
        private System.Windows.Forms.Label label1;
    }
}