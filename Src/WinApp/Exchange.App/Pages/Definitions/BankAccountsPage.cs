using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Definitions
{
    public partial class BankAccountsPage : MetroForm
    {
        public BankAccountsPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void BankAccountsPage_Load(object sender, EventArgs e)
        {
            var ctl = Controls.Cast<Control>().ToList();
            UtilityClass.SetPermissoin(ctl);
            using (var db = new UnitOfWork())
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.BankAccountRepository.GetAll();
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    var value = db.CurrencyRepository.GetById((int) row.Cells["clnCurrency"].Value);
                    row.Cells["clnCu"].Value = value.Name;
                }
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var result = db.BankAccountRepository.Get(bank =>
                    bank.Name.Contains(txtFind.Text) ||
                    bank.Id.ToString().Contains(txtFind.Text) ||
                    bank.AccountNumber.Contains(txtFind.Text) ||
                    bank.ShabaNumber.Contains(txtFind.Text) ||
                    bank.CartNumber.Contains(txtFind.Text));
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
            using (var page = new AddBankAccountPage())
            {
                page.ShowDialog();
            }

            BankAccountsPage_Load(null, null);
        }

        private void dgvCountries_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 8:
                    EditRecord();
                    break;
                case 9:
                    RemoveRecord();
                    break;
            }
        }

        private void EditRecord()
        {
            using (var page = new AddBankAccountPage())
            {
                if (dgv.CurrentRow != null)
                {
                    page.BankId = (int) dgv.CurrentRow.Cells["clnId"].Value;
                    page.ShowDialog();
                }
            }

            BankAccountsPage_Load(null, null);
        }

        private void RemoveRecord()
        {
            var dr = MessageBox.Show(@"Are You  Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                using (var dbContext = new UnitOfWork())
                {
                    var dtHasRecord =
                        UtilityClass.GetData("SELECT * FROM VoucherLines WHERE EntityCode=" +
                                             dgv.CurrentRow.Cells["clnId"].Value);
                    if (dtHasRecord.Rows.Count > 0)
                    {
                        MessageBox.Show("کاربر گرامی امکان حذف این رکورد وجود ندارد");
                        return;
                    }

                    if (dgv.CurrentRow != null)
                    {
                        dbContext.BankAccountRepository.Delete((int) dgv.CurrentRow.Cells["clnId"].Value);
                        dbContext.Save();
                    }
                }

            BankAccountsPage_Load(null, null);
        }

        private void BankAccountsPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}