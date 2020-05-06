using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Properties;
using Exchange.Domain.Services;

namespace Exchange.App.Pages.Configurations
{
    public partial class SettingPage : MetroForm
    {
        public SettingPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void SettingPage_Load(object sender, EventArgs e)
        {
            using (var baseInfo = new BaseInfoDetailsRepository())
            {
                cmbLanguage.DataSource = baseInfo.GetBaseInfoDetailsByGroupId(3);
                cmbLanguage.ValueMember = "Id";
                cmbLanguage.DisplayMember = "Name";

                cmbDateFormat.DataSource = baseInfo.GetBaseInfoDetailsByGroupId(4);
                cmbDateFormat.ValueMember = "Id";
                cmbDateFormat.DisplayMember = "Text";

                //Language Default Records = (Persian-5)_(Arabic=6)_(Kurdish=7)

                if (!string.IsNullOrEmpty(Settings.Default.Language))
                {
                    var a = Settings.Default.Language;
                    cmbLanguage.SelectedValue = int.Parse(Settings.Default.Language == "ku-Arab-IR" ? "6" : "5");
                }
                else
                {
                    Settings.Default.Language = "5";
                    Settings.Default.Save();
                }

                //Format Date Default Records = (Shamsi-8)_(Miladi=9)
                if (!string.IsNullOrEmpty(Settings.Default.FormatDate))
                {
                    cmbDateFormat.SelectedValue = int.Parse(Settings.Default.FormatDate);
                }
                else
                {
                    Settings.Default.FormatDate = "8";
                    Settings.Default.Save();
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.Default.FormatDate = cmbDateFormat.SelectedValue.ToString();
            Settings.Default.Language = cmbLanguage.Text;
            Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }

        private void SettingPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDateFormat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void cmbLanguage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }
    }
}