using System;
using System.Windows.Forms;
using Exchange.App.Pages;
using Exchange.App.Pages.Login;
using Exchange.App.Pages.ReportPage;

namespace Exchange.App
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new ReportViewerPage());
            var splashPage = new SplashScreenPage();
            var dr = splashPage.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var login = new LoginPage();
                var result = login.ShowDialog();
                if (result == DialogResult.OK)
                    Application.Run(new HomePage());
            }
        }
    }
}