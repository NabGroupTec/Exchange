using System;
using System.Data;
using System.Windows.Forms;
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
            var sql =
                "SELECT * FROM VoucherHeaders H JOIN VoucherLines L ON H.Id=L.VoucherHeaderId JOIN Currencies c ON L.CurrencyId=C.Id WHERE ManualDate='" +
                txtDate.Text.Replace("/", "-") + "'";
            using (new UnitOfWork())
            {
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
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewerPage();
            reportViewer.PrintName = "DAILY";
            reportViewer.DataTable = _dv.Table;

            reportViewer.ShowDialog();
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            var query = " Comment LIKE '%" + txtFind.Text + "%'";
            _dv.RowFilter = query;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            GetReport();
        }
    }
}