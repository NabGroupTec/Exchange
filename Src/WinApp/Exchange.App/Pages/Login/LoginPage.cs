using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Exchange.App.Infrastracture;
using Exchange.App.Properties;
using Exchange.Domain.DataAccess;
using MetroFramework.Forms;

namespace Exchange.App.Pages.Login
{
    public partial class LoginPage : MetroForm
    {
        public LoginPage()
        {
            //var culture = Properties.Settings.Default.Language;
            ////Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (var dbContext = new UnitOfWork())
            {
                var userName = SecurityClass.Encrypt(txtUsername.Text);
                var password = SecurityClass.Encrypt(txtPassword.Text);

                var result = dbContext.UserRepository.Get(user =>
                    user.UserName == userName &&
                    user.Password == password);

                var users = result.ToList();
                if (!users.Any())
                {
                    UtilityClass.ShowMessage(this,
                        Settings.Default.Language == "fa-IR"
                            ? @"کاربری با این مشخصاب یافت نگردید"
                            : @"بەکارهێنەر به زانیاریانی ندوزراوه");
                    return;
                }

                foreach (var user in users)
                {
                    var permission = new List<string>();

                    if (chkRemember.Checked)
                        SaveProfile();
                    else
                        RemoveProfile();
                    var query =
                        @"SELECT * FROM UserAccesses UA JOIN SystemParts SP ON UA.SystemPartsId=SP.Id WHERE UA.UsersId=" +
                        user.Id;
                    var dtPermission = UtilityClass.GetData(query);
                    foreach (DataRow item in dtPermission.Rows) permission.Add(item["Name"].ToString());
                    UtilityClass.CurrentUserPermissions = permission;
                    UtilityClass.UserId = user.Id;
                    UtilityClass.FullName = user.FullName;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void RemoveProfile()
        {
            Settings.Default.IsRemember = "false";
            Settings.Default.UserName = "";
            Settings.Default.Password = "";

            Settings.Default.Save();
        }

        private void SaveProfile()
        {
            Settings.Default.IsRemember = "true";
            Settings.Default.UserName = SecurityClass.Encrypt(txtUsername.Text);
            Settings.Default.Password = SecurityClass.Encrypt(txtPassword.Text);

            Settings.Default.Save();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            var isRemember = Settings.Default.IsRemember;

            if (isRemember != "true")
            {
                chkRemember.Checked = false;
            }
            else
            {
                var userName = SecurityClass.Decrypt(Settings.Default.UserName);
                var password = Settings.Default.Password;

                txtUsername.Text = userName;
                txtPassword.Text = SecurityClass.Decrypt(password);
                chkRemember.Checked = true;
            }
        }


        private void LoginPage_KeyDown(object sender, KeyEventArgs e)
        {
            ShortcutKeys(e);
        }

        private void ShortcutKeys(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnOk_Click(null, null);
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            //if (e.KeyCode == Keys.Enter)
            //    SendKeys.Send("{TAB}"); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkLangPersian_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.Language = "fa-IR";
            Settings.Default.Save();
            Controls.Clear();
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void lnkLangKurdish_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.Language = "ku-Arab-IR";
            Settings.Default.Save();
            Controls.Clear();
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk_Click(null, null);
        }

        private void LoginPage_Resize(object sender, EventArgs e)
        {
            //Size = new Size(630, 205);
        }
    }
}