using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddCashDeskPage : MetroForm
    {
        public int CashDeskId;

        public AddCashDeskPage()
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
            if (CashDeskId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var cashDesk = new CashDesk
            {
                Name = TxtName.Text,
                Comment = "",

                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.CashDeskRepository.Insert(cashDesk);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var cashDesk = new CashDesk
            {
                Name = TxtName.Text,
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                cashDesk.Id = CashDeskId;
                dbContext.CashDeskRepository.Update(cashDesk);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }


        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var cashDesk = dbContext.CashDeskRepository.GetById(CashDeskId);
                TxtName.Text = cashDesk.Name;
            }
        }

        private void AddCashDeskPage_Load(object sender, EventArgs e)
        {
            if (CashDeskId != 0)
                CashRecord();
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }
    }
}