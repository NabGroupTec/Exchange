using System;
using System.Globalization;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Operation
{
    public partial class GetDataDocumentPage : MetroForm
    {
        public GetDataDocumentPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        //private decimal _beds = 0;
        //private decimal _bess = 0;
        private void GetDataDocumentPage_Load(object sender, EventArgs e)
        {
            using (var dbContext = new UnitOfWork())
            {
                cmbCurrency.DataSource = dbContext.CurrencyRepository.GetAll();
                cmbCurrency.ValueMember = "Id";
                cmbCurrency.DisplayMember = "Name";
            }

            lblAccountCode.Text = UtilityClass.AccCode;
            txtEntity.Text = UtilityClass.AccName;
            txtBed.Text = UtilityClass.Bed.ToString(CultureInfo.InvariantCulture);
            txtBes.Text = UtilityClass.Bes.ToString(CultureInfo.InvariantCulture);
            cmbCurrency.SelectedValue = UtilityClass.CurrencyCode;
            txtRatePrice.Text = UtilityClass.RatePrice.ToString(CultureInfo.InvariantCulture);
            txtBedehkar.Text = UtilityClass.BedTMN.ToString(CultureInfo.InvariantCulture);
            txtBestankar.Text = UtilityClass.BesTMN.ToString(CultureInfo.InvariantCulture);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBed.Text))
                return;
            if (string.IsNullOrEmpty(txtBes.Text))
                return;
            if (cmbCurrency.SelectedValue == null)
                return;
            if (string.IsNullOrEmpty(txtRatePrice.Text))
                return;
            if (txtRatePrice.Text == txtBes.Text)
                return;

            if (txtBed.Text == "0" && txtBes.Text == "0")
                return;

            UtilityClass.Bed = decimal.Parse(txtBed.Text);
            UtilityClass.Bes = decimal.Parse(txtBes.Text);
            UtilityClass.CurrencyCode = int.Parse(cmbCurrency.SelectedValue.ToString());
            UtilityClass.Currency = cmbCurrency.Text;
            UtilityClass.RatePrice = decimal.Parse(txtRatePrice.Text);
            UtilityClass.BedTMN = decimal.Parse(txtBedehkar.Text);
            UtilityClass.BesTMN = decimal.Parse(txtBestankar.Text);
            UtilityClass.AccCode = lblAccountCode.Text;
            UtilityClass.AccName = txtEntity.Text;
            DialogResult = DialogResult.OK;
        }


        private void txtEntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r' && e.KeyChar != '\u001b')
                using (var page = new DefinitionsListPage())
                {
                    page.ShowDialog();
                    txtEntity.Clear();
                    lblAccountCode.Text = UtilityClass.AccountCode.ToString();
                    txtEntity.Text = UtilityClass.AccountName;
                }
        }

        private void txtEntity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (!string.IsNullOrEmpty(lblAccountCode.Text))
                {
                    txtEntity.Text = UtilityClass.AccountName;
                    SendKeys.Send("{Tab}");
                    txtBed.SelectAll();
                }
        }

        private void txtBed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtBes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtBedehkar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                //txtRatePrice.Text = _beds.ToString(CultureInfo.InvariantCulture);
                SendKeys.Send("{Tab}");
        }


        private void txtBestankar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                //if (_bess != 0)
                //    txtRatePrice.Text = _bess.ToString(CultureInfo.InvariantCulture);
                SendKeys.Send("{Tab}");
        }


        private void txtBed_TextChanged(object sender, EventArgs e)
        {
            if (chkCalc.Checked)
                txtRatePrice.Text = Convert.ToString(decimal.Parse(txtBedehkar.Text) / decimal.Parse(txtBed.Text),
                    CultureInfo.InvariantCulture);
            else
                txtBedehkar.Text = Convert.ToString(decimal.Parse(txtBed.Text) * decimal.Parse(txtRatePrice.Text),
                    CultureInfo.InvariantCulture);
        }


        private void txtBes_TextChanged(object sender, EventArgs e)
        {
            if (chkCalc.Checked)
                txtRatePrice.Text = Convert.ToString(decimal.Parse(txtBestankar.Text) / decimal.Parse(txtBes.Text),
                    CultureInfo.InvariantCulture);
            else
                txtBestankar.Text = Convert.ToString(decimal.Parse(txtBes.Text) * decimal.Parse(txtRatePrice.Text),
                    CultureInfo.InvariantCulture);
        }

        private void txtBedehkar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBedehkar.Text))
                return;
            if (txtBedehkar.Text == "0")
                return;
            if (txtBed.Text == "0")
                return;
            if (chkCalc.Checked)
                txtRatePrice.Text =
                    (decimal.Parse(txtBedehkar.Text) / decimal.Parse(txtBed.Text)).ToString(
                        CultureInfo.InvariantCulture);
        }

        private void txtBestankar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBestankar.Text))
                return;
            if (txtBestankar.Text == "0")
                return;
            if (txtBes.Text == "0")
                return;
            if (chkCalc.Checked)
                txtRatePrice.Text =
                    (decimal.Parse(txtBestankar.Text) / decimal.Parse(txtBes.Text)).ToString(CultureInfo
                        .InvariantCulture);
        }

        private void txtRatePrice_TextChanged(object sender, EventArgs e)
        {
            if (!chkCalc.Checked)
            {
                if (decimal.Parse(txtBed.Text) > 0)
                {
                    var bed = double.Parse(txtBed.Text);
                    var rate = double.Parse(txtRatePrice.Text);
                    var result = bed * rate;
                    txtBedehkar.Text = result.ToString(CultureInfo.InvariantCulture);
                }

                if (decimal.Parse(txtBes.Text) > 0)
                {
                    var bes = double.Parse(txtBes.Text);
                    var rate = double.Parse(txtRatePrice.Text);
                    var result = bes * rate;
                    txtBestankar.Text = result.ToString(CultureInfo.InvariantCulture);
                    //txtBestankar.Text = Convert.ToString(decimal.Parse(txtBes.Text) * decimal.Parse(txtRatePrice.Text));
                }
            }
        }

        private void txtRatePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void GetDataDocumentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void chkCalc_CheckedChanged(object sender, EventArgs e)
        {
            txtRatePrice.ReadOnly = true;
        }
    }
}