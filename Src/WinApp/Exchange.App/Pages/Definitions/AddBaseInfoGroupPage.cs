using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddBaseInfoGroupPage : MetroForm
    {
        public int BaseInfoGroupId;

        public AddBaseInfoGroupPage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (BaseInfoGroupId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var baseInfoGroup = new BaseInfoGroup
            {
                Name = TxtName.Text,
                Comment = "",
                Text = txtText.Text,
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.BaseInfoGroupRepository.Insert(baseInfoGroup);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
                return;

            var baseInfoGroup = new BaseInfoGroup
            {
                Name = TxtName.Text,
                Comment = "",
                Text = txtText.Text,
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                baseInfoGroup.Id = BaseInfoGroupId;
                dbContext.BaseInfoGroupRepository.Update(baseInfoGroup);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void AddBaseInfoGroupPage_Load(object sender, EventArgs e)
        {
            if (BaseInfoGroupId != 0)
                CashRecord();
        }


        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var baseInfoGroup = dbContext.BaseInfoGroupRepository.GetById(BaseInfoGroupId);
                TxtName.Text = baseInfoGroup.Name;
                txtText.Text = baseInfoGroup.Text;
            }
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