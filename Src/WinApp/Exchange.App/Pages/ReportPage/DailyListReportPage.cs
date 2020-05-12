using System;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevExpress.XtraEditors;
using Exchange.App.Infrastracture;
using Exchange.App.Properties;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.ReportPage
{
    public partial class DailyListReportPage : XtraForm
    {
        private DataView _dv = new DataView();


        public DailyListReportPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void GetReport()
        {
            using (new UnitOfWork())
            {
                //var currencyValue = DateTime.Parse(txtDate.Text);
                var sql =
                    "SELECT * FROM VoucherHeaders H JOIN VoucherLines L ON H.Id=L.VoucherHeaderId JOIN Currencies c ON L.CurrencyId=C.Id WHERE ManualDate='" +
                    txtDate.Text.Replace("-", "/") + "'";

                var dt = UtilityClass.GetData(sql);
                _dv = dt.DefaultView;

                gridControl.DataSource = _dv;
            }
        }

        private void AccountSideReportPage_Load(object sender, EventArgs e)
        {
            var formatDate = Settings.Default.FormatDate;
            txtDate.UsePersianFormat = formatDate == "8";
            txtDate.Value = DateTime.Now;
            GetReport();
        }
        private void AccountSideReportPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            GetReport();
        }
        private void btnPrintReport_Click(object sender, EventArgs e)
        {

        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
var query = " Comment LIKE '%" + txtFind.Text + "%'";
            _dv.RowFilter = query;
        }
    }
}