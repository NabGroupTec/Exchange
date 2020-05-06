namespace Exchange.App.Pages.Definitions
{
    partial class CountriesPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountriesPage));
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clnDelete = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.txtFind = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtClearSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnAddRecord = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewButtonXColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.dataGridViewButtonXColumn2 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cornsilk;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnIso,
            this.clnName,
            this.clnEdit,
            this.clnDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv.Location = new System.Drawing.Point(12, 56);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSans", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersWidth = 4;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.Size = new System.Drawing.Size(760, 393);
            this.dgv.TabIndex = 0;
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCountries_CellMouseClick);
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            this.clnId.HeaderText = "کدکشور";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 90;
            // 
            // clnIso
            // 
            this.clnIso.DataPropertyName = "Iso";
            this.clnIso.HeaderText = "ایزو";
            this.clnIso.Name = "clnIso";
            this.clnIso.ReadOnly = true;
            this.clnIso.Width = 70;
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnName.DataPropertyName = "Name";
            this.clnName.HeaderText = "نام کشور";
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
            this.clnDelete.Width = 60;
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
            this.txtFind.Location = new System.Drawing.Point(376, 13);
            this.txtFind.Name = "txtFind";
            this.txtFind.PreventEnterBeep = true;
            this.txtFind.Size = new System.Drawing.Size(332, 35);
            this.txtFind.TabIndex = 1;
            this.txtFind.WatermarkText = "Quick Search";
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // txtClearSearch
            // 
            this.txtClearSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.txtClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClearSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.txtClearSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.txtClearSearch.Location = new System.Drawing.Point(737, 13);
            this.txtClearSearch.Name = "txtClearSearch";
            this.txtClearSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 8, 0, 8);
            this.txtClearSearch.Size = new System.Drawing.Size(32, 35);
            this.txtClearSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.txtClearSearch.Symbol = "";
            this.txtClearSearch.SymbolSize = 13F;
            this.txtClearSearch.TabIndex = 2;
            this.txtClearSearch.Click += new System.EventHandler(this.txtClearSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.txtSearch.Location = new System.Drawing.Point(707, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.txtSearch.Size = new System.Drawing.Size(31, 35);
            this.txtSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.txtSearch.Symbol = "";
            this.txtSearch.SymbolSize = 13F;
            this.txtSearch.TabIndex = 5;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRecord.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRecord.Location = new System.Drawing.Point(12, 13);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnAddRecord.Size = new System.Drawing.Size(35, 35);
            this.btnAddRecord.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnAddRecord.Symbol = "";
            this.btnAddRecord.SymbolColor = System.Drawing.Color.Green;
            this.btnAddRecord.SymbolSize = 30F;
            this.btnAddRecord.TabIndex = 6;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // dataGridViewButtonXColumn1
            // 
            this.dataGridViewButtonXColumn1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.dataGridViewButtonXColumn1.HeaderText = "ویرایش";
            this.dataGridViewButtonXColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonXColumn1.Image")));
            this.dataGridViewButtonXColumn1.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.dataGridViewButtonXColumn1.Name = "dataGridViewButtonXColumn1";
            this.dataGridViewButtonXColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonXColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonXColumn1.Text = null;
            this.dataGridViewButtonXColumn1.Width = 60;
            // 
            // dataGridViewButtonXColumn2
            // 
            this.dataGridViewButtonXColumn2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.dataGridViewButtonXColumn2.HeaderText = "حذف";
            this.dataGridViewButtonXColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonXColumn2.Image")));
            this.dataGridViewButtonXColumn2.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.dataGridViewButtonXColumn2.Name = "dataGridViewButtonXColumn2";
            this.dataGridViewButtonXColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonXColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonXColumn2.Text = null;
            this.dataGridViewButtonXColumn2.Width = 60;
            // 
            // CountriesPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtClearSearch);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("IRANSans", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountriesPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countries";
            this.Load += new System.EventHandler(this.CountriesPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountriesPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFind;
        private DevComponents.DotNetBar.ButtonX txtClearSearch;
        private DevComponents.DotNetBar.ButtonX txtSearch;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dataGridViewButtonXColumn1;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dataGridViewButtonXColumn2;
        private DevComponents.DotNetBar.ButtonX btnAddRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clnEdit;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clnDelete;
    }
}