using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddReceivingDocumentPage : MetroForm
    {
        public int DocId;

        public AddReceivingDocumentPage()
        {
            InitializeComponent();
        }

        private void AddReceivingDocumentPage_Load(object sender, EventArgs e)
        {
            if (DocId != 0)
                CashRecord();
        }

        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var person = dbContext.ReceivingDocumentsRepository.GetById(DocId);
                txtTitle.Text = person.Title;
                txtComment.Text = person.Comment;
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (DocId != 0)
                UpdateRecord();
            else
                AddRecord();
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
                return;

            var income = new ReceivingDocuments
            {
                Title = txtTitle.Text,
                Comment = txtComment.Text,

                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.ReceivingDocumentsRepository.Insert(income);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
                return;

            var income = new ReceivingDocuments
            {
                Title = txtTitle.Text,
                Comment = "",
                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                income.Id = DocId;
                dbContext.ReceivingDocumentsRepository.Update(income);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}