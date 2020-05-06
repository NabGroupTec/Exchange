using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddIncomePage : MetroForm
    {
        public int IncomeId;

        public AddIncomePage()
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
            if (IncomeId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var income = new Income
            {
                Name = TxtName.Text,
                Comment = "",

                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.IncomeRepository.Insert(income);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var income = new Income
            {
                Name = TxtName.Text,
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                income.Id = IncomeId;
                dbContext.IncomeRepository.Update(income);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }


        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var cost = dbContext.IncomeRepository.GetById(IncomeId);
                TxtName.Text = cost.Name;
            }
        }

        private void AddIncomePage_Load(object sender, EventArgs e)
        {
            if (IncomeId != 0)
                CashRecord();
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }
    }
}