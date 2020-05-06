using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Operation
{
    public partial class DocumentListPage : MetroForm
    {
        public DocumentListPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void DocumentListPage_Load(object sender, EventArgs e)
        {
            var thread = new Thread(CashList);
            thread.Start();
            //using (var db = new UnitOfWork())
            //{
            //    dgvHeader.AutoGenerateColumns = false;
            //    var list= db.VoucherHeaderRepository.GetAll().ToList();
            //    dgvHeader.DataSource = list;
            //    var formatDate = Exchange.App.Properties.Settings.Default.FormatDate;
            //    foreach (DataGridViewRow row in dgvHeader.Rows)
            //    {

            //        var user = db.UserRepository.GetById(int.Parse(row.Cells["clnUser"].Value.ToString()));
            //        row.Cells["clnUserName"].Value = user.FullName;
            //    }

            //}
        }

        private void CashList()
        {
            var result =
                UtilityClass.GetData(
                    "select v.Id,v.Comment,v.ManualDate,FullName=(select FullName from Users where users.Id=v.UserId),UserId from VoucherHeaders v  order by ManualDate,Id desc");
            dgvHeader.AutoGenerateColumns = false;
            dgvHeader.Invoke(new Action(() => dgvHeader.DataSource = result));
        }

        private void dgvHeader_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvHeader.CurrentCell.ColumnIndex == 5)
            {
                using (var page = new DocumentOperationPage())
                {
                    page.VoucherId = (int) dgvHeader.CurrentRow.Cells["clnId"].Value;
                    page.ShowDialog();
                }

                DocumentListPage_Load(null, null);
            }
            else if (dgvHeader.CurrentCell.ColumnIndex == 6)
            {
                var dr = MessageBox.Show("آیا مایل به حذف این سند می باشید؟", "سوال", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var voucherLines = (from DataGridViewRow row in dgvLine.Rows
                        select new VoucherLine
                        {
                            EntityCode = int.Parse(row.Cells["clnCode"].Value.ToString()),
                            Comment = row.Cells["clnCommentLine"].Value == null
                                ? " "
                                : row.Cells["clnCommentLine"].Value.ToString(),
                            BedPrice = decimal.Parse(row.Cells["clnBed"].Value == null
                                ? "0"
                                : row.Cells["clnBed"].Value.ToString()),
                            BesPrice = decimal.Parse(row.Cells["clnBes"].Value == null
                                ? "0"
                                : row.Cells["clnBes"].Value.ToString()),
                            CurrencyId = int.Parse(row.Cells["clnCurrency"].Value.ToString()),
                            RatePrice = decimal.Parse(row.Cells["clnRate"].Value.ToString()),
                            BedTMIN = decimal.Parse(row.Cells["clnSBed"].Value == null
                                ? "0"
                                : row.Cells["clnSBed"].Value.ToString().ToString()),
                            BesTMIN = decimal.Parse(row.Cells["clnSBes"].Value == null
                                ? "0"
                                : row.Cells["clnSBed"].Value.ToString().ToString())
                        }).ToList();
                    var voucherHeader = new VoucherHeader
                    {
                        UserId = Convert.ToInt32(dgvHeader.CurrentRow.Cells["clnUser"].Value.ToString()),
                        Comment = dgvHeader.CurrentRow.Cells["clnComment"].Value.ToString(),
                        LogRecord = Convert.ToDateTime(dgvHeader.CurrentRow.Cells["clnDate"].Value.ToString()),
                        VoucherLines = voucherLines
                    };
                    using (var db = new UnitOfWork())
                    {
                        var value = dgvHeader.CurrentRow.Cells["clnId"].Value;
                        if (value != null)
                        {
                            db.VoucherHeaderRepository.Delete((int) value);
                            db.Save();
                        }
                    }
                }

                DocumentListPage_Load(null, null);
            }
            else
            {
                using (var db = new UnitOfWork())
                {
                    if (db.VoucherLineRepository != null)
                        if (dgvHeader.CurrentRow != null)
                        {
                            var headerId = (int) dgvHeader.CurrentRow.Cells["clnId"].Value;
                            dgvLine.AutoGenerateColumns = false;

                            var result = db.VoucherLineRepositoryFilter.Get(person =>
                                person.VoucherHeaderId == headerId);
                            dgvLine.DataSource = result;

                            foreach (DataGridViewRow row in dgvLine.Rows)
                            {
                                var code = (int) row.Cells["clnCode"].Value;

                                var entityCapital = db.AccountCapitalRepository.GetById(code);
                                if (entityCapital != null)
                                    row.Cells["clnEntity"].Value = entityCapital.Name;

                                var entityBank = db.BankAccountRepository.GetById(code);
                                if (entityBank != null)
                                    row.Cells["clnEntity"].Value = entityBank.Name;

                                var entityCash = db.CashDeskRepository.GetById(code);
                                if (entityCash != null)
                                    row.Cells["clnEntity"].Value = entityCash.Name;

                                var entityCoins = db.CoinsRepository.GetById(code);
                                if (entityCoins != null)
                                    row.Cells["clnEntity"].Value = entityCoins.Name;

                                var entityCost = db.CostRepository.GetById(code);
                                if (entityCost != null)
                                    row.Cells["clnEntity"].Value = entityCost.Name;

                                var entityIncome = db.IncomeRepository.GetById(code);
                                if (entityIncome != null)
                                    row.Cells["clnEntity"].Value = entityIncome.Name;

                                var entityPeople = db.PeopleRepository.GetById(code);
                                if (entityPeople != null)
                                    row.Cells["clnEntity"].Value = entityPeople.FirstName + " " + entityPeople.LastName;

                                var value = (int) row.Cells["clnCurrency"].Value;
                                var resultCurrency = db.CurrencyRepository.GetById(value);
                                if (resultCurrency != null)
                                    row.Cells["clnCur"].Value = resultCurrency.Name;
                            }
                        }
                }
            }
        }

        private void btnAddNewDoc_Click(object sender, EventArgs e)
        {
            using (var page = new DocumentOperationPage())
            {
                page.ShowDialog();
                DocumentListPage_Load(null, null);
            }
        }

        private void DocumentListPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFind.Text))
                return;
            //string query =
            //    "select v.Id,v.Comment,v.ManualDate,FullName=(select FullName from Users where users.Id=v.UserId) from VoucherHeaders v  where Comment like N'%"  + txtFind.Text + "%' order by ManualDate desc";
            //var result = UtilityClass.GetData(query);
            using (var db = new UnitOfWork())
            {
                var result = db.VoucherHeaderRepository.Get(header =>
                    header.Comment.Contains(txtFind.Text) || header.Id.ToString().Contains(txtFind.Text) ||
                    header.ManualDate.Contains(txtFind.Text));
                dgvHeader.DataSource = result;
                foreach (DataGridViewRow row in dgvHeader.Rows)
                {
                    var user = db.UserRepository.GetById(int.Parse(row.Cells["clnUser"].Value.ToString()));
                    row.Cells["clnUserName"].Value = user.FullName;
                }
            }
        }

        private void txtClearSearch_Click(object sender, EventArgs e)
        {
            txtFind.Clear();
        }
    }
}