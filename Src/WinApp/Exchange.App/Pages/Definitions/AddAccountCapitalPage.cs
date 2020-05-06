using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddAccountCapitalPage : MetroForm
    {
        public int CapitalId;

        public AddAccountCapitalPage()
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
            if (CapitalId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var capital = new AccountCapital
            {
                Name = TxtName.Text,
                Comment = "",

                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.AccountCapitalRepository.Insert(capital);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var capital = new AccountCapital
            {
                Name = TxtName.Text,
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                capital.Id = CapitalId;
                dbContext.AccountCapitalRepository.Update(capital);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }


        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var cost = dbContext.AccountCapitalRepository.GetById(CapitalId);
                TxtName.Text = cost.Name;
            }
        }

        private void AddAccountCapitalPage_Load(object sender, EventArgs e)
        {
            if (CapitalId != 0)
                CashRecord();
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void AddAccountCapitalPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}