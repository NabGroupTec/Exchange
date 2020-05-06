using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Definitions
{
    public partial class BaseInfoDetailsPage : MetroForm
    {
        public BaseInfoDetailsPage()
        {
            InitializeComponent();
        }

        private void BaseInfoDetailsPage_Load(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.BaseInfoDetailsRepository.GetAll();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var result = db.BaseInfoDetailsRepository.Get(baseInfoDetails =>
                    baseInfoDetails.Name.Contains(txtFind.Text) ||
                    baseInfoDetails.Id.ToString().Contains(txtFind.Text));
                dgv.DataSource = result;
            }
        }

        private void txtClearSearch_Click(object sender, EventArgs e)
        {
            txtFind.Clear();
            txtFind.Focus();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            using (var page = new AddBaseInfoDetailsPage())
            {
                page.ShowDialog();
            }

            BaseInfoDetailsPage_Load(null, null);
        }

        private void dgvCountries_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    EditRecord();
                    break;
                case 3:
                    RemoveRecord();
                    break;
            }
        }

        private void EditRecord()
        {
            using (var page = new AddBaseInfoDetailsPage())
            {
                if (dgv.CurrentRow != null)
                {
                    page.BaseInfoDetailsId = (int) dgv.CurrentRow.Cells["clnId"].Value;
                    page.ShowDialog();
                }
            }

            BaseInfoDetailsPage_Load(null, null);
        }

        private void RemoveRecord()
        {
            var dr = MessageBox.Show(@"Are You  Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                using (var dbContext = new UnitOfWork())
                {
                    if (dgv.CurrentRow != null)
                    {
                        dbContext.BaseInfoDetailsRepository.Delete((int) dgv.CurrentRow.Cells["clnId"].Value);
                        dbContext.Save();
                    }
                }

            BaseInfoDetailsPage_Load(null, null);
        }

        private void BaseInfoDetailsPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}