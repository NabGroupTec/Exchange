namespace Exchange.App.Pages.Configurations
{
    partial class SettingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingPage));
            this.tabControl = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.cmbDateFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLanguage = new DevComponents.DotNetBar.SuperTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tabControl.ControlBox.Category = resources.GetString("tabControl.ControlBox.Category");
            // 
            // 
            // 
            this.tabControl.ControlBox.CloseBox.Category = resources.GetString("tabControl.ControlBox.CloseBox.Category");
            this.tabControl.ControlBox.CloseBox.CommandParameter = ((object)(resources.GetObject("tabControl.ControlBox.CloseBox.CommandParameter")));
            this.tabControl.ControlBox.CloseBox.Description = resources.GetString("tabControl.ControlBox.CloseBox.Description");
            this.tabControl.ControlBox.CloseBox.Name = "";
            this.tabControl.ControlBox.CloseBox.Tag = ((object)(resources.GetObject("tabControl.ControlBox.CloseBox.Tag")));
            this.tabControl.ControlBox.CloseBox.Text = resources.GetString("tabControl.ControlBox.CloseBox.Text");
            this.tabControl.ControlBox.CloseBox.Tooltip = resources.GetString("tabControl.ControlBox.CloseBox.Tooltip");
            this.tabControl.ControlBox.CommandParameter = ((object)(resources.GetObject("tabControl.ControlBox.CommandParameter")));
            this.tabControl.ControlBox.Description = resources.GetString("tabControl.ControlBox.Description");
            // 
            // 
            // 
            this.tabControl.ControlBox.MenuBox.Category = resources.GetString("tabControl.ControlBox.MenuBox.Category");
            this.tabControl.ControlBox.MenuBox.CommandParameter = ((object)(resources.GetObject("tabControl.ControlBox.MenuBox.CommandParameter")));
            this.tabControl.ControlBox.MenuBox.Description = resources.GetString("tabControl.ControlBox.MenuBox.Description");
            this.tabControl.ControlBox.MenuBox.Name = "";
            this.tabControl.ControlBox.MenuBox.Tag = ((object)(resources.GetObject("tabControl.ControlBox.MenuBox.Tag")));
            this.tabControl.ControlBox.MenuBox.Text = resources.GetString("tabControl.ControlBox.MenuBox.Text");
            this.tabControl.ControlBox.MenuBox.Tooltip = resources.GetString("tabControl.ControlBox.MenuBox.Tooltip");
            this.tabControl.ControlBox.Name = "";
            this.tabControl.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabControl.ControlBox.CloseBox,
            this.tabControl.ControlBox.MenuBox});
            this.tabControl.ControlBox.Tag = ((object)(resources.GetObject("tabControl.ControlBox.Tag")));
            this.tabControl.ControlBox.Text = resources.GetString("tabControl.ControlBox.Text");
            this.tabControl.ControlBox.Tooltip = resources.GetString("tabControl.ControlBox.Tooltip");
            this.tabControl.Controls.Add(this.superTabControlPanel1);
            this.tabControl.ForeColor = System.Drawing.Color.Black;
            this.tabControl.Name = "tabControl";
            this.tabControl.ReorderTabsEnabled = true;
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabLanguage});
            // 
            // superTabControlPanel1
            // 
            resources.ApplyResources(this.superTabControlPanel1, "superTabControlPanel1");
            this.superTabControlPanel1.Controls.Add(this.cmbLanguage);
            this.superTabControlPanel1.Controls.Add(this.label2);
            this.superTabControlPanel1.Controls.Add(this.btnCancel);
            this.superTabControlPanel1.Controls.Add(this.btnOk);
            this.superTabControlPanel1.Controls.Add(this.cmbDateFormat);
            this.superTabControlPanel1.Controls.Add(this.label1);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.TabItem = this.tabLanguage;
            // 
            // cmbLanguage
            // 
            resources.ApplyResources(this.cmbLanguage, "cmbLanguage");
            this.cmbLanguage.BackColor = System.Drawing.Color.White;
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.ForeColor = System.Drawing.Color.Black;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLanguage_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
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
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
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
            // cmbDateFormat
            // 
            resources.ApplyResources(this.cmbDateFormat, "cmbDateFormat");
            this.cmbDateFormat.BackColor = System.Drawing.Color.White;
            this.cmbDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateFormat.ForeColor = System.Drawing.Color.Black;
            this.cmbDateFormat.FormattingEnabled = true;
            this.cmbDateFormat.Name = "cmbDateFormat";
            this.cmbDateFormat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDateFormat_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // tabLanguage
            // 
            this.tabLanguage.AttachedControl = this.superTabControlPanel1;
            resources.ApplyResources(this.tabLanguage, "tabLanguage");
            this.tabLanguage.GlobalItem = false;
            this.tabLanguage.Name = "tabLanguage";
            // 
            // SettingPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TitleText = "تنظیمات سیستم";
            this.Load += new System.EventHandler(this.SettingPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl tabControl;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private System.Windows.Forms.ComboBox cmbDateFormat;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.SuperTabItem tabLanguage;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label2;
    }
}