using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddBaseInfoDetailsPage : MetroForm
    {
        public int BaseInfoDetailsId;

        public AddBaseInfoDetailsPage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (BaseInfoDetailsId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var baseInfoDetails = new BaseInfoDetails
            {
                BaseInfoGroupId = (int) cmbGroupInfo.SelectedValue,
                Name = TxtName.Text,
                Comment = "",
                Text = txtText.Text,
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.BaseInfoDetailsRepository.Insert(baseInfoDetails);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var baseInfoDetails = new BaseInfoDetails
            {
                BaseInfoGroupId = (int) cmbGroupInfo.SelectedValue,
                Name = TxtName.Text,
                Comment = "",
                Text = txtText.Text,
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                baseInfoDetails.Id = BaseInfoDetailsId;
                dbContext.BaseInfoDetailsRepository.Update(baseInfoDetails);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddBaseInfoDetailsPage_Load(object sender, EventArgs e)
        {
            FillGroup();
            if (BaseInfoDetailsId != 0)
                CashRecord();
        }

        private void FillGroup()
        {
            using (var dbContext = new UnitOfWork())
            {
                cmbGroupInfo.DataSource = dbContext.BaseInfoGroupRepository.GetAll();
                cmbGroupInfo.ValueMember = "Id";
                cmbGroupInfo.DisplayMember = "Text";
            }
        }


        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var baseInfoDetails = dbContext.BaseInfoDetailsRepository.GetById(BaseInfoDetailsId);
                TxtName.Text = baseInfoDetails.Name;
                txtText.Text = baseInfoDetails.Text;
            }
        }

        private void cmbGroupInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }
    }
}