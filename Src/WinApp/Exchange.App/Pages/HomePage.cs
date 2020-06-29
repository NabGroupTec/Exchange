using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevExpress.XtraEditors;
using Exchange.App.Infrastracture;
using Exchange.App.Pages.Configurations;
using Exchange.App.Pages.Definitions;
using Exchange.App.Pages.Operation;
using Exchange.App.Pages.ReportPage;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Exchange.App.Pages
{
    public partial class HomePage : MetroForm // DevComponents.DotNetBar.Metro.MetroForm
    {
        private readonly Timer _timer = new Timer();

        public HomePage()
        {
            ////var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TileLocations_Click(object sender, EventArgs e)
        {
            using (var page = new CountriesPage())
            {
                page.ShowDialog();
            }
        }

        private void TileSystemPart_Click(object sender, EventArgs e)
        {
            using (var page = new SystemPartsPage())
            {
                page.ShowDialog();
            }
        }

        private void TileBaseInfo_Click(object sender, EventArgs e)
        {
            using (var page = new BaseInfoDetailsPage())
            {
                page.ShowDialog();
            }
        }

        private void TileBaseInfoGroup_Click(object sender, EventArgs e)
        {
            using (var page = new BaseInfoGroupPage())
            {
                page.ShowDialog();
            }
        }


        private void HomePage_Load(object sender, EventArgs e)
        {

            SetStyleColor();
            var c = Controls.OfType<TileItem>().Cast<Control>().ToList();
            var ctl = Controls.OfType<ButtonX>().Cast<Control>().ToList();
            UtilityClass.SetPermissoin(c);
            UtilityClass.SetPermissoin(ctl);
            var assembly = Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            lblVersion.Text = fvi.FileVersion;

            _timer.Interval = 1000;

            _timer.Tick += TimerTick;

            _timer.Start();
            lblDate.Text = PersianDateTime.Now.Year + @"/" + PersianDateTime.Now.Month.ToString("0#") + @"/" +
                           PersianDateTime.Now.Day.ToString("0#");
            lblUser.Text = UtilityClass.FullName;
        }

        private void SetStyleColor()
        {
            Random random=new Random();
            foreach (ITileItem item in tileGroupBaseinfo.Items)
            {
                var color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), 0);

                item.Appearances.Normal.BackColor = color;
            }
            foreach (ITileItem item in tileGroupOperation.Items)
            {
                var color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), 0);

                item.Appearances.Normal.BackColor = color;
            }
            foreach (ITileItem item in tileGroupReports.Items)
            {
                var color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), 0);

                item.Appearances.Normal.BackColor = color;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            //get current time
            var hh = DateTime.Now.Hour;
            var mm = DateTime.Now.Minute;
            var ss = DateTime.Now.Second;

            //time
            var time = "";

            //padding leading zero
            if (hh < 10)
                time += "0" + hh;
            else
                time += hh;
            time += ":";

            if (mm < 10)
                time += "0" + mm;
            else
                time += mm;
            time += ":";

            if (ss < 10)
                time += "0" + ss;
            else
                time += ss;

            //update label
            lblTime.Text = time;
        }

        private void TileExit_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"آیا مطمئن به خروج از برنامه می باشید؟", @"Exchange",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                if (dialogResult == DialogResult.Yes)
                    Application.Exit();
        }


        private void xtileCustomer_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new PeoplePage())
            {
                page.ShowDialog();
            }
        }

        private void xtileCurrency_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new CurrenciesPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileBank_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new BankAccountsPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileCoins_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new CoinsPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileCashBox_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new CashDesksPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileCost_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new CostsPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileIncome_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new IncomePage())
            {
                page.ShowDialog();
            }
        }

        private void xtileAccount_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new AccountCapitalsPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileUsers_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new UsersPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileEstate_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new EstatePage())
            {
                page.ShowDialog();
            }
        }

        private void xtileEmployee_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new EmployeePage())
            {
                page.ShowDialog();
            }
        }

        private void xtilePayDoc_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new PerlerDocumentsPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileGetDoc_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new ReceivingDocumentsPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileOpDocument_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new DocumentListPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileReportMoein_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new AccountSideReportPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileReportDaily_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new DailyListReportPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileReportBalanceSheet_ItemClick(object sender, TileItemEventArgs e)
        {
            using (var page = new BalanceSheetPage())
            {
                page.ShowDialog();
            }
        }

        private void xtileSetting_ItemClick(object sender, TileItemEventArgs e)
        {
            var page=new SettingPage();
            page.ShowDialog();
        }

        private void tileAccountReview_ItemClick(object sender, TileItemEventArgs e)
        {
            var page = new AccountReviewPage();
            page.ShowDialog();
        }

        private void tilePackList_ItemClick(object sender, TileItemEventArgs e)
        {
            var page=new PackingListReport();
            page.ShowDialog();
        }
    }
}