using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.App.Properties;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddCountryPage : MetroForm
    {
        private readonly string _language = Settings.Default.Language;

        public int CountryId;

        public AddCountryPage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(_language);

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CountryId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var country = new Country
            {
                Code = txtCountryCode.Text,
                Comment = "",
                Continent = cmbRegion.Text,
                Iso = txtIso.Text,
                LogRecord = DateTime.Now,
                Name = TxtName.Text,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.CountryRepository.Insert(country);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var country = new Country
            {
                Code = txtCountryCode.Text,
                Comment = "",
                Continent = cmbRegion.Text,
                Iso = txtIso.Text,
                LogRecord = DateTime.Now,
                Name = TxtName.Text,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                country.Id = CountryId;
                dbContext.CountryRepository.Update(country);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddCountryPage_Load(object sender, EventArgs e)
        {
            RegionList();
            if (CountryId != 0)
                CashRecord();
        }

        private void RegionList()
        {
            using (var dbContext = new UnitOfWork())
            {
                var results = dbContext.CountryRepository.GetAll().Select(m => m.Continent).Distinct();
                cmbRegion.DataSource = results.ToList();
            }
        }

        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var country = dbContext.CountryRepository.GetById(CountryId);
                txtCountryCode.Text = country.Code;
                txtIso.Text = country.Iso;
                TxtName.Text = country.Name;
                cmbRegion.Text = country.Continent;
            }
        }

        private void txtCountryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtIso_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtCountryCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtIso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void cmbRegion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }
    }
}