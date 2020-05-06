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

namespace Exchange.App.Pages.Definitions
{
    public partial class AddEmployeePage : MetroForm
    {
        public int EmployeeId;

        public AddEmployeePage()
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
            if (EmployeeId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(txtFamily.Text))
                return;

            if (string.IsNullOrEmpty(txtFirstName.Text))
                return;

            var employee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtFamily.Text,
                FatherName = txtFname.Text,
                BirthDate = Convert.ToDateTime(txtBDate.Value),
                Email = txtEmail.Text,
                Tell = txtTell.Text,
                Mobile = txtMobile.Text,
                Address = txtAddress.Text,
                Photo = UtilityClass.ImageToByteArray(personPhoto.Image),
                NationalCode = txtNationalCode.Text,
                Comment = txtComment.Text,
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.EmployeeRepository.Insert(employee);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(txtFamily.Text))
                return;

            var employee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtFamily.Text,
                FatherName = txtFname.Text,
                BirthDate = Convert.ToDateTime(txtBDate.Value),
                Email = txtEmail.Text,
                Tell = txtTell.Text,
                Mobile = txtMobile.Text,
                Address = txtAddress.Text,
                Photo = UtilityClass.ImageToByteArray(personPhoto.Image),
                NationalCode = txtNationalCode.Text,
                Comment = txtComment.Text,
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                employee.Id = EmployeeId;
                dbContext.EmployeeRepository.Update(employee);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddEmployeePage_Load(object sender, EventArgs e)
        {
            Width = 789;
            Height = 406;

            InitialSetting();
            txtBDate.Value = DateTime.Now;
            if (EmployeeId != 0)
                CashRecord();
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
                var person = dbContext.EmployeeRepository.GetById(EmployeeId);
                txtFirstName.Text = person.FirstName;
                txtFamily.Text = person.LastName;
                txtFname.Text = person.FatherName;
                txtBDate.Text = person.BirthDate.ToString(CultureInfo.InvariantCulture);
                txtEmail.Text = person.Email;
                txtTell.Text = person.Tell;
                txtMobile.Text = person.Mobile;
                txtAddress.Text = person.Address;
                txtNationalCode.Text = person.NationalCode;
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

        private void txtNationalCode_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            UtilityClass.NumberFilter(sender, e);
        }
    }
}