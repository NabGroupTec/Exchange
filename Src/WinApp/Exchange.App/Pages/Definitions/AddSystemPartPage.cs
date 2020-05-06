using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddSystemPartPage : MetroForm
    {
        public AddSystemPartPage()
        {
            InitializeComponent();
        }

        public int PartId { get; set; }
        public string ModeAction { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text)) return;
            if (string.IsNullOrEmpty(txtPermission.Text)) return;

            if (ModeAction == "EDIT")
            {
                var part = new SystemParts
                {
                    Name = TxtName.Text,
                    Text = txtPermission.Text,
                    Level = UtilityClass.ParentSelectionId,
                    Priority = 1,
                    LogRecord = DateTime.Now,
                    Status = 1,
                    Comment = "",
                    UserId = UtilityClass.UserId
                };
                using (var db = new UnitOfWork())
                {
                    part.Id = PartId;

                    db.SystemPartsRepository.Update(part);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var part = new SystemParts
                {
                    Name = TxtName.Text,
                    Text = txtPermission.Text,
                    Level = PartId,
                    Priority = 1,
                    LogRecord = DateTime.Now,
                    Status = 1,
                    Comment = "",
                    UserId = UtilityClass.UserId
                };
                using (var db = new UnitOfWork())
                {
                    db.SystemPartsRepository.Insert(part);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }

            Close();
        }

        private void AddSystemPartPage_Load(object sender, EventArgs e)
        {
            if (ModeAction == "EDIT")
                LoadData();
        }

        private void LoadData()
        {
            using (var db = new UnitOfWork())
            {
                var result = db.SystemPartsRepository.GetById(PartId);
                TxtName.Text = result.Name;
                txtPermission.Text = result.Text;
            }
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }
    }
}