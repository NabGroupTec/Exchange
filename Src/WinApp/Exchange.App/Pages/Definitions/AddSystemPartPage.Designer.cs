namespace Exchange.App.Pages.Definitions
{
    partial class AddSystemPartPage
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
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.TxtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPermission = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnCancel.ImageTextSpacing = 8;
            this.btnCancel.Location = new System.Drawing.Point(12, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnCancel.Size = new System.Drawing.Size(79, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.SubItemsExpandWidth = 10;
            this.btnCancel.Symbol = "";
            this.btnCancel.SymbolSize = 12F;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.ImageFixedSize = new System.Drawing.Size(13, 15);
            this.btnOk.ImageTextSpacing = 8;
            this.btnOk.Location = new System.Drawing.Point(96, 168);
            this.btnOk.Name = "btnOk";
            this.btnOk.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnOk.Size = new System.Drawing.Size(79, 31);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.SubItemsExpandWidth = 10;
            this.btnOk.Symbol = "";
            this.btnOk.SymbolSize = 12F;
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "ثبت";
            this.btnOk.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            this.TxtName.Location = new System.Drawing.Point(12, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.PreventEnterBeep = true;
            this.TxtName.Size = new System.Drawing.Size(360, 36);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtName.WatermarkText = "قسمت";
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(314, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "نام قسمت";
            // 
            // txtPermission
            // 
            this.txtPermission.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPermission.Border.Class = "TextBoxBorder";
            this.txtPermission.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPermission.DisabledBackColor = System.Drawing.Color.White;
            this.txtPermission.ForeColor = System.Drawing.Color.Black;
            this.txtPermission.Location = new System.Drawing.Point(12, 94);
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.PreventEnterBeep = true;
            this.txtPermission.Size = new System.Drawing.Size(360, 36);
            this.txtPermission.TabIndex = 2;
            this.txtPermission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPermission.WatermarkText = "دسترسی";
            this.txtPermission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPermission_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "اسم دسترسی";
            // 
            // AddSystemPartPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.txtPermission);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSystemPartPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه / ویرایش اجزای سیستم";
            this.Load += new System.EventHandler(this.AddSystemPartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtName;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPermission;
        private System.Windows.Forms.Label label1;
    }
}