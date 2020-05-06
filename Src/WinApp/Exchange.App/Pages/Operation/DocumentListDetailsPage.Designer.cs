namespace Exchange.App.Pages.Operation
{
    partial class DocumentListDetailsPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLine)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLine
            // 
            this.dgvLine.AllowUserToAddRows = false;
            this.dgvLine.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvLine.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLine.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvLine.Location = new System.Drawing.Point(0, 240);
            this.dgvLine.Name = "dgvLine";
            this.dgvLine.ReadOnly = true;
            this.dgvLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvLine.RowHeadersWidth = 4;
            this.dgvLine.Size = new System.Drawing.Size(951, 321);
            this.dgvLine.TabIndex = 4;
            // 
            // clnIdLine
            // 
            this.clnIdLine.DataPropertyName = "Id";
            this.clnIdLine.HeaderText = "کد";
            this.clnIdLine.Name = "clnIdLine";
            this.clnIdLine.ReadOnly = true;
            this.clnIdLine.Width = 50;
            // 
            // clnCode
            // 
            this.clnCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCode.DataPropertyName = "EntityCode";
            this.clnCode.HeaderText = "طرف حساب";
            this.clnCode.Name = "clnCode";
            this.clnCode.ReadOnly = true;
            this.clnCode.Visible = false;
            // 
            // clnEntity
            // 
            this.clnEntity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnEntity.HeaderText = "طرف حساب";
            this.clnEntity.Name = "clnEntity";
            this.clnEntity.ReadOnly = true;
            // 
            // clnCommentLine
            // 
            this.clnCommentLine.DataPropertyName = "Comment";
            this.clnCommentLine.HeaderText = "شرح";
            this.clnCommentLine.Name = "clnCommentLine";
            this.clnCommentLine.ReadOnly = true;
            // 
            // clnBed
            // 
            this.clnBed.DataPropertyName = "BedPrice";
            this.clnBed.HeaderText = "بد";
            this.clnBed.Name = "clnBed";
            this.clnBed.ReadOnly = true;
            // 
            // clnBes
            // 
            this.clnBes.DataPropertyName = "BesPrice";
            this.clnBes.HeaderText = "بس";
            this.clnBes.Name = "clnBes";
            this.clnBes.ReadOnly = true;
            // 
            // clnCurrency
            // 
            this.clnCurrency.DataPropertyName = "CurrencyId";
            this.clnCurrency.HeaderText = "ارز";
            this.clnCurrency.Name = "clnCurrency";
            this.clnCurrency.ReadOnly = true;
            this.clnCurrency.Visible = false;
            // 
            // clnCur
            // 
            this.clnCur.HeaderText = "ارز";
            this.clnCur.Name = "clnCur";
            this.clnCur.ReadOnly = true;
            // 
            // clnRate
            // 
            this.clnRate.DataPropertyName = "RatePrice";
            this.clnRate.HeaderText = "نرخ";
            this.clnRate.Name = "clnRate";
            this.clnRate.ReadOnly = true;
            // 
            // clnSBed
            // 
            this.clnSBed.DataPropertyName = "BedTMIN";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.clnSBed.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnSBed.HeaderText = "بدهکار";
            this.clnSBed.Name = "clnSBed";
            this.clnSBed.ReadOnly = true;
            this.clnSBed.Width = 120;
            // 
            // clnSBes
            // 
            this.clnSBes.DataPropertyName = "BesTMIN";
            dataGridViewCellStyle3.Format = "N2";
            this.clnSBes.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnSBes.HeaderText = "بستانکار";
            this.clnSBes.Name = "clnSBes";
            this.clnSBes.ReadOnly = true;
            this.clnSBes.Width = 120;
            // 
            // DocumentListDetailsPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.dgvLine);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocumentListDetailsPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جزئیات اسناد";
            this.Load += new System.EventHandler(this.DocumentListDetailsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}