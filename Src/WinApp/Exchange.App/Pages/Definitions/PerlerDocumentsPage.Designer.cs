namespace Exchange.App.Pages.Definitions
{
    partial class PerlerDocumentsPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerlerDocumentsPage));
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtClearSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtFind = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewButtonXColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.dataGridViewButtonXColumn2 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btnAddRecord = new DevComponents.DotNetBar.ButtonX();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clnDelete = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Cornsilk;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnName,
            this.clnEdit,
            this.clnDelete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv.Location = new System.Drawing.Point(12, 55);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.RowHeadersWidth = 4;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.Size = new System.Drawing.Size(760, 393);
            this.dgv.TabIndex = 7;
            this.dgv.Tag = "ListCapital";
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.txtSearch.Location = new System.Drawing.Point(707, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.txtSearch.Size = new System.Drawing.Size(31, 35);
            this.txtSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.txtSearch.Symbol = "";
            this.txtSearch.SymbolSize = 13F;
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // txtClearSearch
            // 
            this.txtClearSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.txtClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClearSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.txtClearSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.txtClearSearch.Location = new System.Drawing.Point(737, 12);
            this.txtClearSearch.Name = "txtClearSearch";
            this.txtClearSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 8, 0, 8);
            this.txtClearSearch.Size = new System.Drawing.Size(32, 35);
            this.txtClearSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.txtClearSearch.Symbol = "";
            this.txtClearSearch.SymbolSize = 13F;
            this.txtClearSearch.TabIndex = 9;
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFind.Border.Class = "TextBoxBorder";
            this.txtFind.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFind.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFind.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFind.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtFind.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFind.DisabledBackColor = System.Drawing.Color.White;
            this.txtFind.Font = new System.Drawing.Font("IRANSans", 8.7F);
            this.txtFind.ForeColor = System.Drawing.Color.Black;
            this.txtFind.Location = new System.Drawing.Point(376, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.PreventEnterBeep = true;
            this.txtFind.Size = new System.Drawing.Size(332, 35);
            this.txtFind.TabIndex = 8;
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFind.WatermarkText = "عبارت مورد جستجو را اینجا بنویسید";
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // dataGridViewButtonXColumn1
            // 
            this.dataGridViewButtonXColumn1.HeaderText = "ویرایش";
            this.dataGridViewButtonXColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonXColumn1.Image")));
            this.dataGridViewButtonXColumn1.Name = "dataGridViewButtonXColumn1";
            this.dataGridViewButtonXColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonXColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonXColumn1.Text = null;
            // 
            // dataGridViewButtonXColumn2
            // 
            this.dataGridViewButtonXColumn2.HeaderText = "حذف";
            this.dataGridViewButtonXColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonXColumn2.Image")));
            this.dataGridViewButtonXColumn2.Name = "dataGridViewButtonXColumn2";
            this.dataGridViewButtonXColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonXColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonXColumn2.Text = null;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRecord.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRecord.Location = new System.Drawing.Point(12, 12);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnAddRecord.Size = new System.Drawing.Size(35, 35);
            this.btnAddRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnAddRecord.Symbol = "";
            this.btnAddRecord.SymbolColor = System.Drawing.Color.Green;
            this.btnAddRecord.SymbolSize = 30F;
            this.btnAddRecord.TabIndex = 11;
            this.btnAddRecord.Tag = "AddCapital";
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            this.clnId.HeaderText = "کد";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 90;
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnName.DataPropertyName = "Title";
            this.clnName.HeaderText = "عنوان سند";
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            // 
            // clnEdit
            // 
            this.clnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.clnEdit.HeaderText = "ویرایش";
            this.clnEdit.Image = ((System.Drawing.Image)(resources.GetObject("clnEdit.Image")));
            this.clnEdit.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.clnEdit.Name = "clnEdit";
            this.clnEdit.ReadOnly = true;
            this.clnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnEdit.Text = null;
            this.clnEdit.ToolTipText = "EditCapital";
            this.clnEdit.Width = 60;
            // 
            // clnDelete
            // 
            this.clnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.clnDelete.HeaderText = "حذف";
            this.clnDelete.Image = ((System.Drawing.Image)(resources.GetObject("clnDelete.Image")));
            this.clnDelete.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.clnDelete.Name = "clnDelete";
            this.clnDelete.ReadOnly = true;
            this.clnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnDelete.Text = null;
            this.clnDelete.ToolTipText = "DeleteCapital";
            this.clnDelete.Width = 60;
            // 
            // PerlerDocumentsPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtClearSearch);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnAddRecord);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PerlerDocumentsPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت اسناد پرداختنی";
            this.Load += new System.EventHandler(this.PerlerDocumentsPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PerlerDocumentsPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clnEdit;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clnDelete;
        private DevComponents.DotNetBar.ButtonX txtSearch;
        private DevComponents.DotNetBar.ButtonX txtClearSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFind;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dataGridViewButtonXColumn1;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dataGridViewButtonXColumn2;
        private DevComponents.DotNetBar.ButtonX btnAddRecord;
    }
}