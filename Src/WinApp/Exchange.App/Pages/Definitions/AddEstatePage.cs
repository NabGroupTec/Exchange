using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddEstatePage : MetroForm
    {
        public int EstateId;

        public AddEstatePage()
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
            if (EstateId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var cost = new Estate
            {
                Name = TxtName.Text,
                Comment = "",
                Value = Convert.ToDecimal(txtValue.Text),

                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.EstateRepository.Insert(cost);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var cost = new Estate
            {
                Name = TxtName.Text,
                Value = Convert.ToDecimal(txtValue.Text),
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                cost.Id = EstateId;
                dbContext.EstateRepository.Update(cost);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }


        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var cost = dbContext.EstateRepository.GetById(EstateId);
                TxtName.Text = cost.Name;
                txtValue.Text = cost.Value.ToString();
            }
        }

        private void AddCashDeskPage_Load(object sender, EventArgs e)
        {
            if (EstateId != 0)
                CashRecord();
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }
    }
}