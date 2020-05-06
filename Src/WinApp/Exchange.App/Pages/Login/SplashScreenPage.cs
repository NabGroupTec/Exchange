using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Login
{
    public partial class SplashScreenPage : MetroForm
    {
        private readonly BackgroundWorker _backgroundWorker;

        public SplashScreenPage()
        {
            _backgroundWorker = new BackgroundWorker();
            InitializeComponent();

            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
            _backgroundWorker.ProgressChanged += _backgroundWorker_ProgressChanged;
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            InitialDatabase();
        }

        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                using (var loginPage = new LoginPage())
                {
                    DialogResult = DialogResult.OK;
                    // loginPage.Enabled = true;
                    // loginPage.Owner = this;
                    // this.Hide();
                    //loginPage.Show();
                }
            }
            else if (e.Cancelled)
            {
                //lblStatus.Text = @"User Canceled";
            }
        }

        private void _backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //lblStatus.Text = $@"Counting number: {e.ProgressPercentage}...";
        }

        private void InitialDatabase()
        {
            //Domain.Infrastructure.UtilityClass.ConnectionString = "Data Source=127.0.0.1;Initial Catalog=ExchangeDB;User ID=sa;Password=6637310573";

            using (var dbContext = new UnitOfWork())
            {
                var list = dbContext.CountryRepository.GetAll();
                dbContext.Seed();
            }
        }

        private void SplashScreenPage_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            if (!_backgroundWorker.IsBusy)
                _backgroundWorker.RunWorkerAsync();
        }

        private void metroProgressSpinner1_Resize(object sender, EventArgs e)
        {
        }

        private void SplashScreenPage_Resize(object sender, EventArgs e)
        {
        }
    }
}