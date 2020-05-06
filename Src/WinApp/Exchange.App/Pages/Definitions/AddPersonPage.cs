using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.App.Properties;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;
using Exchange.Domain.Services;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddPersonPage : MetroForm
    {
        public int PersonId;

        public AddPersonPage()
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
            if (PersonId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(txtFamily.Text))
                return;

            if (cmbBank.SelectedValue == null)
                return;
            if (cmbNationality.SelectedValue == null)
                return;
            if (cmbCountry.SelectedValue == null)
                return;

            var person = new People
            {
                FirstName = txtFirstName.Text,
                LastName = txtFamily.Text,
                FatherName = txtFname.Text,
                BirthDate = Convert.ToDateTime(txtBDate.Value),
                AccountNumber = txtAccountNumber.Text,
                ShabaNumber = txtShabaNumber.Text,
                PassportCode = txtPassportNumber.Text,
                Email = txtEmail.Text,
                SocialNetwork = null,
                Tell = txtTell.Text,
                Mobile = txtMobile.Text,
                Address = txtAddress.Text,
                Nationality = (int) cmbNationality.SelectedValue,
                Photo = UtilityClass.ImageToByteArray(personPhoto.Image),
                CertificatNumber = txtCertificat.Text,
                BankId = (int) cmbBank.SelectedValue,
                NationalCode = txtNationalCode.Text,
                Comment = txtComment.Text,
                CartNumber = txtCartNumber.Text,
                City = txtCity.Text,
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId,
                CountryId = (int) cmbCountry.SelectedValue
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.PeopleRepository.Insert(person);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(txtFamily.Text))
                return;

            var person = new People
            {
                FirstName = txtFirstName.Text,
                LastName = txtFamily.Text,
                FatherName = txtFname.Text,
                BirthDate = Convert.ToDateTime(txtBDate.Value),
                AccountNumber = txtAccountNumber.Text,
                ShabaNumber = txtShabaNumber.Text,
                PassportCode = txtPassportNumber.Text,
                Email = txtEmail.Text,
                SocialNetwork = null,
                Tell = txtTell.Text,
                Mobile = txtMobile.Text,
                Address = txtAddress.Text,
                Nationality = (int) cmbNationality.SelectedValue,
                Photo = UtilityClass.ImageToByteArray(personPhoto.Image),
                CertificatNumber = txtCertificat.Text,
                BankId = (int) cmbBank.SelectedValue,
                NationalCode = txtNationalCode.Text,
                Comment = txtComment.Text,
                CartNumber = txtCartNumber.Text,
                City = txtCity.Text,
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId,
                CountryId = (int) cmbCountry.SelectedValue
            };
            using (var dbContext = new UnitOfWork())
            {
                person.Id = PersonId;
                dbContext.PeopleRepository.Update(person);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddPersonPage_Load(object sender, EventArgs e)
        {
            FillCountry();
            FillLists();
            InitialSetting();
            txtBDate.Value = DateTime.Now;
            if (PersonId != 0)
                CashRecord();
        }

        private void FillLists()
        {
            using (var context = new BaseInfoDetailsRepository())
            {
                //Nationality
                cmbNationality.DataSource = context.GetBaseInfoDetailsByGroupId(5);
                cmbNationality.ValueMember = "Id";
                ;
                cmbNationality.DisplayMember = "Text";
            }

            using (var dbContext = new UnitOfWork())
            {
                //Banks
                cmbBank.DataSource = dbContext.BankAccountRepository.GetAll();
                cmbBank.ValueMember = "Id";
                ;
                cmbBank.DisplayMember = "BankName";
            }
        }

        private void InitialSetting()
        {
            var formatDate = Settings.Default.FormatDate;
            txtBDate.UsePersianFormat = formatDate == "8";
        }

        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var person = dbContext.PeopleRepository.GetById(PersonId);
                txtFirstName.Text = person.FirstName;
                txtFamily.Text = person.LastName;
                txtFname.Text = person.FatherName;
                txtBDate.Text = person.BirthDate.ToString(CultureInfo.InvariantCulture);
                txtAccountNumber.Text = person.AccountNumber;
                txtShabaNumber.Text = person.ShabaNumber;
                txtPassportNumber.Text = person.PassportCode;
                txtEmail.Text = person.Email;
                txtTell.Text = person.Tell;
                txtMobile.Text = person.Mobile;
                txtAddress.Text = person.Address;
                txtNationalCode.Text = person.NationalCode;
                cmbBank.SelectedValue = person.BankId;
                cmbNationality.SelectedValue = person.Nationality;
                cmbCountry.SelectedValue = person.CountryId;
                txtCartNumber.Text = person.CartNumber;
                txtCertificat.Text = person.CertificatNumber;
                txtCity.Text = person.City;
                txtComment.Text = person.Comment;
                personPhoto.Image = UtilityClass.ByteArrayToImage(person.Photo);
            }
        }

        private void personPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog
                {
                    Filter = @"JPEG(*.jpeg)|*.jpeg|GIF(*.gif)|*.gif|PNG(*.Png)|*.png|AllFiles|*.*"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = File.Open(dialog.FileName, FileMode.OpenOrCreate);
                    var binaryBytes = new byte[fileStream.Length];
                    fileStream.Read(binaryBytes, 0, binaryBytes.Length);
                    fileStream.Close();
                    personPhoto.Image = Image.FromFile(dialog.FileName);
                }
                else
                {
                    personPhoto.Image = Resources.DefaultPerson;
                    //MessageBox.Show(@"Select Image", @"Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FillCountry()
        {
            using (var dbContext = new UnitOfWork())
            {
                cmbCountry.DataSource = dbContext.CountryRepository.GetAll();
                cmbCountry.ValueMember = "Id";
                cmbCountry.DisplayMember = "Name";
            }
        }

        private void txtAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtCartNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtPassportNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtCertificat_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtTell_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtFamily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtFname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void cmbNationality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtBDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
            if (e.KeyCode == Keys.Down)
                cmbBank.Focus();
        }

        private void cmbBank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtCartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtShabaNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassportNumber.Focus();
        }

        private void txtPassportNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtNationalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtCertificat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTell.Focus();
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

        private void cmbCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk.Focus();
        }
    }
}