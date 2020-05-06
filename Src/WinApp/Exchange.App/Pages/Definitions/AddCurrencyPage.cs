using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddCurrencyPage : MetroForm
    {
        public int CurrencyId;

        public AddCurrencyPage()
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
            if (CurrencyId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(txtBuy.Text))
                txtBuy.Text = "0";

            if (string.IsNullOrEmpty(txtSell.Text))
                txtSell.Text = "0";


            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var currency = new Currency
            {
                Country = txtCountry.Text,
                Name = TxtName.Text,
                Symbol = txtSymbol.Text,
                NumberDigit = Convert.ToSingle(txtNumberDigit.Text),
                PurchaseRate = Convert.ToDecimal(txtBuy.Text),
                SellingRate = Convert.ToDecimal(txtSell.Text),
                FloatName = txtFloatName.Text,
                SymbolFloat = txtFloatSymbol.Text,
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId,
                IsPrimary = chkDefault.Checked
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.CurrencyRepository.Insert(currency);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var currency = new Currency
            {
                Country = txtCountry.Text,
                Name = TxtName.Text,
                Symbol = txtSymbol.Text,
                NumberDigit = Convert.ToSingle(txtNumberDigit.Text),
                PurchaseRate = Convert.ToDecimal(txtBuy.Text),
                SellingRate = Convert.ToDecimal(txtSell.Text),
                FloatName = txtFloatName.Text,
                SymbolFloat = txtFloatSymbol.Text,
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId,
                IsPrimary = chkDefault.Checked
            };
            using (var dbContext = new UnitOfWork())
            {
                currency.Id = CurrencyId;
                dbContext.CurrencyRepository.Update(currency);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddCurrencyPage_Load(object sender, EventArgs e)
        {
            GetDefaultCurrency();
            if (CurrencyId != 0)
                CashRecord();
        }

        private void GetDefaultCurrency()
        {
            using (var dbContext = new ExchangeDbContext())
            {
                var primaryCurrency = (from s in dbContext.Currencies
                    where s.IsPrimary
                    select s).ToList();
                if (CurrencyId == 0)
                {
                    var result = (from p in dbContext.VoucherLines select p).ToList();
                    if (primaryCurrency.Count == 0 && result.Count <= 0)
                        chkDefault.Enabled = true;
                }
                else
                {
                    var result = dbContext.VoucherLines
                        .FirstOrDefault(p => p.CurrencyId == CurrencyId);
                    if (result != null)
                        chkDefault.Enabled = false;
                }
            }
        }

        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var currency = dbContext.CurrencyRepository.GetById(CurrencyId);
                TxtName.Text = currency.Name;
                txtSymbol.Text = currency.Symbol;
                txtCountry.Text = currency.Country;
                txtNumberDigit.Text = currency.NumberDigit.ToString(CultureInfo.InvariantCulture);
                txtBuy.Text = currency.PurchaseRate.ToString(CultureInfo.InvariantCulture);
                txtSell.Text = currency.SellingRate.ToString(CultureInfo.InvariantCulture);
                txtFloatName.Text = currency.FloatName;
                txtFloatSymbol.Text = currency.SymbolFloat;
                chkDefault.CheckValue = currency.IsPrimary;
            }
        }

        private void txtSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtNumberDigit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtFloatName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtFloatSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtBuy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtSell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }
    }
}