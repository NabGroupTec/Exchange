namespace Exchange.App.Pages.Definitions
{
    partial class AddEstatePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEstatePage));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtValue = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
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
            // txtValue
            // 
            resources.ApplyResources(this.txtValue, "txtValue");
            this.txtValue.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtValue.Border.Class = "TextBoxBorder";
            this.txtValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtValue.ButtonCustom.DisplayPosition = ((int)(resources.GetObject("txtValue.ButtonCustom.DisplayPosition")));
            this.txtValue.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("txtValue.ButtonCustom.Image")));
            this.txtValue.ButtonCustom.Text = resources.GetString("txtValue.ButtonCustom.Text");
            this.txtValue.ButtonCustom.Tooltip = resources.GetString("txtValue.ButtonCustom.Tooltip");
            this.txtValue.ButtonCustom2.DisplayPosition = ((int)(resources.GetObject("txtValue.ButtonCustom2.DisplayPosition")));
            this.txtValue.ButtonCustom2.Image = ((System.Drawing.Image)(resources.GetObject("txtValue.ButtonCustom2.Image")));
            this.txtValue.ButtonCustom2.Text = resources.GetString("txtValue.ButtonCustom2.Text");
            this.txtValue.ButtonCustom2.Tooltip = resources.GetString("txtValue.ButtonCustom2.Tooltip");
            this.txtValue.DisabledBackColor = System.Drawing.Color.White;
            this.txtValue.ForeColor = System.Drawing.Color.Black;
            this.txtValue.Name = "txtValue";
            this.txtValue.PreventEnterBeep = true;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // AddEstatePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AddEstatePage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AddCashDeskPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtName;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtValue;
        private System.Windows.Forms.Label label1;
    }
}