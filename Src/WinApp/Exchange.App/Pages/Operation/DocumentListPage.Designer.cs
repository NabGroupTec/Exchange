namespace Exchange.App.Pages.Operation
{
    partial class DocumentListPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentListPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHeader = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnAddNewDoc = new DevComponents.DotNetBar.ButtonX();
            this.txtSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtClearSearch = new DevComponents.DotNetBar.ButtonX();
            this.txtFind = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvLine = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clnIdLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCommentLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSBes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEdit = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.clnDelete = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLine)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHeader
            // 
            this.dgvHeader.AllowUserToAddRows = false;
            this.dgvHeader.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvHeader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvHeader, "dgvHeader");
            this.dgvHeader.BackgroundColor = System.Drawing.Color.White;
            this.dgvHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnDate,
            this.clnComment,
            this.clnUser,
            this.clnUserName,
            this.clnEdit,
            this.clnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHeader.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHeader.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvHeader.Name = "dgvHeader";
            this.dgvHeader.ReadOnly = true;
            this.dgvHeader.RowTemplate.Height = 40;
            this.dgvHeader.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHeader_CellMouseClick);
            // 
            // btnAddNewDoc
            // 
            this.btnAddNewDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btnAddNewDoc, "btnAddNewDoc");
            this.btnAddNewDoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewDoc.ImageTextSpacing = 20;
            this.btnAddNewDoc.Name = "btnAddNewDoc";
            this.btnAddNewDoc.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnAddNewDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewDoc.Symbol = "";
            this.btnAddNewDoc.SymbolColor = System.Drawing.Color.Blue;
            this.btnAddNewDoc.SymbolSize = 30F;
            this.btnAddNewDoc.Tag = "AddDocument";
            this.btnAddNewDoc.Click += new System.EventHandler(this.btnAddNewDoc_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.txtSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.txtSearch.Symbol = "";
            this.txtSearch.SymbolSize = 13F;
            // 
            // txtClearSearch
            // 
            this.txtClearSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.txtClearSearch, "txtClearSearch");
            this.txtClearSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.txtClearSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.txtClearSearch.Name = "txtClearSearch";
            this.txtClearSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(0, 8, 0, 8);
            this.txtClearSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.txtClearSearch.Symbol = "";
            this.txtClearSearch.SymbolSize = 13F;
            this.txtClearSearch.Click += new System.EventHandler(this.txtClearSearch_Click);
            // 
            // txtFind
            // 
            resources.ApplyResources(this.txtFind, "txtFind");
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
            this.txtFind.ForeColor = System.Drawing.Color.Black;
            this.txtFind.Name = "txtFind";
            this.txtFind.PreventEnterBeep = true;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // dgvLine
            // 
            this.dgvLine.AllowUserToAddRows = false;
            this.dgvLine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvLine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLine.BackgroundColor = System.Drawing.Color.White;
            this.dgvLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdLine,
            this.clnCode,
            this.clnEntity,
            this.clnCommentLine,
            this.clnBed,
            this.clnBes,
            this.clnCurrency,
            this.clnCur,
            this.clnRate,
            this.clnSBed,
            this.clnSBes});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("IRANSans", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLine.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.dgvLine, "dgvLine");
            this.dgvLine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvLine.Name = "dgvLine";
            this.dgvLine.ReadOnly = true;
            // 
            // clnIdLine
            // 
            this.clnIdLine.DataPropertyName = "Id";
            resources.ApplyResources(this.clnIdLine, "clnIdLine");
            this.clnIdLine.Name = "clnIdLine";
            this.clnIdLine.ReadOnly = true;
            // 
            // clnCode
            // 
            this.clnCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCode.DataPropertyName = "EntityCode";
            resources.ApplyResources(this.clnCode, "clnCode");
            this.clnCode.Name = "clnCode";
            this.clnCode.ReadOnly = true;
            // 
            // clnEntity
            // 
            this.clnEntity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.clnEntity, "clnEntity");
            this.clnEntity.Name = "clnEntity";
            this.clnEntity.ReadOnly = true;
            // 
            // clnCommentLine
            // 
            this.clnCommentLine.DataPropertyName = "Comment";
            resources.ApplyResources(this.clnCommentLine, "clnCommentLine");
            this.clnCommentLine.Name = "clnCommentLine";
            this.clnCommentLine.ReadOnly = true;
            // 
            // clnBed
            // 
            this.clnBed.DataPropertyName = "BedPrice";
            resources.ApplyResources(this.clnBed, "clnBed");
            this.clnBed.Name = "clnBed";
            this.clnBed.ReadOnly = true;
            // 
            // clnBes
            // 
            this.clnBes.DataPropertyName = "BesPrice";
            resources.ApplyResources(this.clnBes, "clnBes");
            this.clnBes.Name = "clnBes";
            this.clnBes.ReadOnly = true;
            // 
            // clnCurrency
            // 
            this.clnCurrency.DataPropertyName = "CurrencyId";
            resources.ApplyResources(this.clnCurrency, "clnCurrency");
            this.clnCurrency.Name = "clnCurrency";
            this.clnCurrency.ReadOnly = true;
            // 
            // clnCur
            // 
            resources.ApplyResources(this.clnCur, "clnCur");
            this.clnCur.Name = "clnCur";
            this.clnCur.ReadOnly = true;
            // 
            // clnRate
            // 
            this.clnRate.DataPropertyName = "RatePrice";
            resources.ApplyResources(this.clnRate, "clnRate");
            this.clnRate.Name = "clnRate";
            this.clnRate.ReadOnly = true;
            // 
            // clnSBed
            // 
            this.clnSBed.DataPropertyName = "BedTMIN";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.clnSBed.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.clnSBed, "clnSBed");
            this.clnSBed.Name = "clnSBed";
            this.clnSBed.ReadOnly = true;
            // 
            // clnSBes
            // 
            this.clnSBes.DataPropertyName = "BesTMIN";
            dataGridViewCellStyle5.Format = "N2";
            this.clnSBes.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.clnSBes, "clnSBes");
            this.clnSBes.Name = "clnSBes";
            this.clnSBes.ReadOnly = true;
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            resources.ApplyResources(this.clnId, "clnId");
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            // 
            // clnDate
            // 
            this.clnDate.DataPropertyName = "ManualDate";
            resources.ApplyResources(this.clnDate, "clnDate");
            this.clnDate.Name = "clnDate";
            this.clnDate.ReadOnly = true;
            // 
            // clnComment
            // 
            this.clnComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnComment.DataPropertyName = "Comment";
            resources.ApplyResources(this.clnComment, "clnComment");
            this.clnComment.Name = "clnComment";
            this.clnComment.ReadOnly = true;
            // 
            // clnUser
            // 
            this.clnUser.DataPropertyName = "UserId";
            resources.ApplyResources(this.clnUser, "clnUser");
            this.clnUser.Name = "clnUser";
            this.clnUser.ReadOnly = true;
            // 
            // clnUserName
            // 
            this.clnUserName.DataPropertyName = "FullName";
            resources.ApplyResources(this.clnUserName, "clnUserName");
            this.clnUserName.Name = "clnUserName";
            this.clnUserName.ReadOnly = true;
            // 
            // clnEdit
            // 
            this.clnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.clnEdit, "clnEdit");
            this.clnEdit.Image = ((System.Drawing.Image)(resources.GetObject("clnEdit.Image")));
            this.clnEdit.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.clnEdit.Name = "clnEdit";
            this.clnEdit.ReadOnly = true;
            this.clnEdit.Text = null;
            // 
            // clnDelete
            // 
            this.clnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.clnDelete, "clnDelete");
            this.clnDelete.Image = ((System.Drawing.Image)(resources.GetObject("clnDelete.Image")));
            this.clnDelete.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.clnDelete.Name = "clnDelete";
            this.clnDelete.ReadOnly = true;
            this.clnDelete.Text = null;
            // 
            // DocumentListPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dgvLine);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtClearSearch);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnAddNewDoc);
            this.Controls.Add(this.dgvHeader);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "DocumentListPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.DocumentListPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocumentListPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHeader;
        private DevComponents.DotNetBar.ButtonX btnAddNewDoc;
        private DevComponents.DotNetBar.ButtonX txtSearch;
        private DevComponents.DotNetBar.ButtonX txtClearSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFind;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCommentLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCur;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSBes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUserName;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clnEdit;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn clnDelete;
    }
}