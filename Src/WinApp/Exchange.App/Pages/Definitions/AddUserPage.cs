using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddUserPage : MetroForm
    {
        public int UserId;

        public AddUserPage()
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
            if (UserId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
                return;
            if (txtPassword.Text != txtRePassword.Text)
                return;
            var user = new Users
            {
                FullName = txtFullName.Text,
                UserName = SecurityClass.Encrypt(txtUserName.Text),
                Password = SecurityClass.Encrypt(txtPassword.Text),
                Tell = txtTell.Text,
                Mobile = txtMobile.Text,
                Address = txtAddress.Text,
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.UserRepository.Insert(user);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
                return;

            var user = new Users
            {
                FullName = txtFullName.Text,
                UserName = SecurityClass.Encrypt(txtUserName.Text),
                Password = SecurityClass.Encrypt(txtPassword.Text),
                Tell = txtTell.Text,
                Mobile = txtMobile.Text,
                Address = txtAddress.Text,
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                user.Id = UserId;
                dbContext.UserRepository.Update(user);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddUserPage_Load(object sender, EventArgs e)
        {
            if (UserId != 0)
                CashRecord();
        }


        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var user = dbContext.UserRepository.GetById(UserId);
                txtUserName.Text = SecurityClass.Decrypt(user.UserName);
                txtFullName.Text = user.FullName;
                txtTell.Text = user.Tell;
                txtMobile.Text = user.Mobile;
                txtAddress.Text = user.Address;
            }
        }

        private void txtTell_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtRePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtTell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }
    }
}