namespace Exchange.App.Pages.Definitions
{
    partial class SystemPartsPage
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
            this.components = new System.ComponentModel.Container();
            this.TreeSystemPart = new System.Windows.Forms.TreeView();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // TreeSystemPart
            // 
            this.TreeSystemPart.BackColor = System.Drawing.Color.White;
            this.TreeSystemPart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeSystemPart.Dock = System.Windows.Forms.DockStyle.Right;
            this.TreeSystemPart.ForeColor = System.Drawing.Color.Black;
            this.TreeSystemPart.ImageIndex = 0;
            this.TreeSystemPart.ImageList = this.imgLst;
            this.TreeSystemPart.Location = new System.Drawing.Point(137, 0);
            this.TreeSystemPart.Name = "TreeSystemPart";
            this.TreeSystemPart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TreeSystemPart.RightToLeftLayout = true;
            this.TreeSystemPart.SelectedImageIndex = 0;
            this.TreeSystemPart.Size = new System.Drawing.Size(425, 495);
            this.TreeSystemPart.TabIndex = 0;
            this.TreeSystemPart.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeSystemPart_AfterSelect);
            // 
            // imgLst
            // 
            this.imgLst.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLst.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(13, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnAdd.Size = new System.Drawing.Size(35, 35);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.Symbol = "";
            this.btnAdd.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.SymbolSize = 30F;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Location = new System.Drawing.Point(13, 54);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnEdit.Size = new System.Drawing.Size(35, 35);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.Symbol = "";
            this.btnEdit.SymbolColor = System.Drawing.Color.Blue;
            this.btnEdit.SymbolSize = 20F;
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(13, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.Symbol = "";
            this.btnDelete.SymbolColor = System.Drawing.Color.Red;
            this.btnDelete.SymbolSize = 20F;
            this.btnDelete.TabIndex = 3;
            // 
            // SystemPartsPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(562, 495);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TreeSystemPart);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemPartsPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اجزای سیستم";
            this.Load += new System.EventHandler(this.SystemPartsPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SystemPartsPage_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeSystemPart;
        private System.Windows.Forms.ImageList imgLst;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnDelete;
    }
}