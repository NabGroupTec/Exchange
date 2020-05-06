using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Definitions
{
    public partial class BaseInfoGroupPage : MetroForm
    {
        public BaseInfoGroupPage()
        {
            InitializeComponent();
        }

        private void BaseInfoGroupPage_Load(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.BaseInfoGroupRepository.GetAll();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var result = db.BaseInfoGroupRepository.Get(baseInfoGroup =>
                    baseInfoGroup.Name.Contains(txtFind.Text) || baseInfoGroup.Id.ToString().Contains(txtFind.Text));
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
            using (var page = new AddBaseInfoGroupPage())
            {
                page.ShowDialog();
            }

            BaseInfoGroupPage_Load(null, null);
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
            using (var page = new AddBaseInfoGroupPage())
            {
                if (dgv.CurrentRow != null)
                {
                    page.BaseInfoGroupId = (int) dgv.CurrentRow.Cells["clnId"].Value;
                    page.ShowDialog();
                }
            }

            BaseInfoGroupPage_Load(null, null);
        }

        private void RemoveRecord()
        {
            var dr = MessageBox.Show(@"Are You  Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                using (var dbContext = new UnitOfWork())
                {
                    if (dgv.CurrentRow != null)
                    {
                        dbContext.BaseInfoGroupRepository.Delete((int) dgv.CurrentRow.Cells["clnId"].Value);
                        dbContext.Save();
                    }
                }

            BaseInfoGroupPage_Load(null, null);
        }

        private void BaseInfoGroupPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}