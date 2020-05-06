using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddCostPage : MetroForm
    {
        public int CostId;

        public AddCostPage()
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
            if (CostId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var cost = new Cost
            {
                Name = TxtName.Text,
                Comment = "",

                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.CostRepository.Insert(cost);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var cost = new Cost
            {
                Name = TxtName.Text,
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                cost.Id = CostId;
                dbContext.CostRepository.Update(cost);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var cost = dbContext.CostRepository.GetById(CostId);
                TxtName.Text = cost.Name;
            }
        }

        private void AddCashDeskPage_Load(object sender, EventArgs e)
        {
            if (CostId != 0)
                CashRecord();
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}