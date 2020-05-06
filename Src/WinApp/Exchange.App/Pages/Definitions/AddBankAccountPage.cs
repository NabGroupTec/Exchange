using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddBankAccountPage : MetroForm
    {
        public int BankId;

        public AddBankAccountPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (BankId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(txtBankName.Text))
                return;

            var bank = new BankAccount
            {
                Name = txtBankName.Text,
                Comment = "",
                AccountNumber = txtAccountNumber.Text,
                ShabaNumber = txtShabaNumber.Text,
                LogRecord = DateTime.Now,
                CartNumber = txtCartNumber.Text,
                Status = 1,
                UserId = UtilityClass.UserId,
                CurrencyId = (int) cmbCurrency.SelectedValue,
                BankName = txtBank.Text
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.BankAccountRepository.Insert(bank);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(txtBankName.Text))
                return;

            var bank = new BankAccount
            {
                Name = txtBankName.Text,
                Comment = "",
                AccountNumber = txtAccountNumber.Text,
                ShabaNumber = txtShabaNumber.Text,
                LogRecord = DateTime.Now,
                CartNumber = txtCartNumber.Text,
                Status = 1,
                UserId = UtilityClass.UserId,
                CurrencyId = (int) cmbCurrency.SelectedValue,
                BankName = txtBank.Text
            };
            using (var dbContext = new UnitOfWork())
            {
                bank.Id = BankId;
                dbContext.BankAccountRepository.Update(bank);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddBankAccountPage_Load(object sender, EventArgs e)
        {
            CurrencyList();

            if (BankId != 0)
                CashRecord();
        }


        private void CurrencyList()
        {
            using (var dbContext = new UnitOfWork())
            {
                cmbCurrency.DataSource = dbContext.CurrencyRepository.GetAll();
                cmbCurrency.ValueMember = "Id";
                cmbCurrency.DisplayMember = "Name";
            }
        }

        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var bank = dbContext.BankAccountRepository.GetById(BankId);
                txtBankName.Text = bank.Name;
                txtAccountNumber.Text = bank.AccountNumber;
                txtShabaNumber.Text = bank.ShabaNumber;
                txtCartNumber.Text = bank.CartNumber;
                cmbCurrency.SelectedValue = bank.CurrencyId;
                txtBank.Text = bank.BankName;
            }
        }

        private void txtAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtCartNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtBank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtShabaNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtCartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void AddBankAccountPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}