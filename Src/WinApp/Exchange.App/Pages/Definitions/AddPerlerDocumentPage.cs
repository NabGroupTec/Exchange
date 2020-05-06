using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Definitions
{
    public partial class AddPerlerDocumentPage : MetroForm
    {
        public int DocId;

        public AddPerlerDocumentPage()
        {
            InitializeComponent();
        }

        private void AddPerlerDocumentPage_Load(object sender, EventArgs e)
        {
            CashBank();
            if (DocId != 0)
                CashRecord();
        }

        private void CashBank()
        {
            using (var dbContext = new UnitOfWork())
            {
                //Banks
                cmbBank.DataSource = dbContext.BankAccountRepository.GetAll();
                cmbBank.ValueMember = "Id";
                ;
                cmbBank.DisplayMember = "BankName";
            }
        }

        private void AddRecord()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
                return;

            var income = new PerlerDocuments
            {
                Title = txtTitle.Text,
                Comment = txtComment.Text,

                LogRecord = DateTime.Now,
                Status = 1,
                UserId = UtilityClass.UserId
            };
            using (var dbContext = new UnitOfWork())
            {
                dbContext.PerlerDocumentsRepository.Insert(income);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void CashRecord()
        {
            using (var dbContext = new UnitOfWork())
            {
                var person = dbContext.PerlerDocumentsRepository.GetById(DocId);
                txtTitle.Text = person.Title;
                txtComment.Text = person.Comment;
            }
        }

        private void UpdateRecord()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
                return;

            var income = new PerlerDocuments
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
                dbContext.PerlerDocumentsRepository.Update(income);
                dbContext.Save();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (DocId != 0)
                UpdateRecord();
            else
                AddRecord();
        }
    }
}