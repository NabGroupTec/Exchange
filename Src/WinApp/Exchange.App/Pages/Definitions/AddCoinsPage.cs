using System;
using System.Globalization;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddCoinsPage : MetroForm
    {
        public int CoinId;

        public AddCoinsPage()
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
            if (CoinId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(txtName.Text))
                return;

            if (string.IsNullOrEmpty(txtSell.Text))
                return;

            if (string.IsNullOrEmpty(txtBuy.Text))
                return;
            var coin = new Coins
            {
                Name = txtName.Text,
                Comment = txtComment.Text,
                BuyRate = Convert.ToDecimal(txtBuy.Text),
                SellRate = Convert.ToDecimal(txtSell.Text),
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.CoinsRepository.Insert(coin);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(txtComment.Text))
                return;

            var coin = new Coins
            {
                Name = txtName.Text,
                Comment = txtComment.Text,
                BuyRate = Convert.ToDecimal(txtBuy.Text),
                SellRate = Convert.ToDecimal(txtSell.Text),
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                coin.Id = CoinId;
                dbContext.CoinsRepository.Update(coin);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddCoinsPage_Load(object sender, EventArgs e)
        {
            if (CoinId != 0)
                CashRecord();
        }


        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var coin = dbContext.CoinsRepository.GetById(CoinId);
                txtComment.Text = coin.Comment;
                txtName.Text = coin.Name;
                txtSell.Text = coin.SellRate.ToString(CultureInfo.InvariantCulture);
                txtBuy.Text = coin.BuyRate.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
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

        private void txtBuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.CurrencyFormat(txtBuy);
        }

        private void txtSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.CurrencyFormat(txtSell);
        }
    }
}