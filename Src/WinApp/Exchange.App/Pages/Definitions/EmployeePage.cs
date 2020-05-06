using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Definitions
{
    public partial class EmployeePage : MetroForm
    {
        public EmployeePage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            var ctl = Controls.Cast<Control>().ToList();
            UtilityClass.SetPermissoin(ctl);
            using (var db = new UnitOfWork())
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.EmployeeRepository.GetAll();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var result = db.EmployeeRepository.Get(person =>
                    person.FirstName.Contains(txtFind.Text) || person.LastName.ToString().Contains(txtFind.Text)
                                                            || person.Tell.ToString().Contains(txtFind.Text)
                                                            || person.Mobile.ToString().Contains(txtFind.Text)
                                                            || person.Address.ToString().Contains(txtFind.Text));
                dgv.DataSource = result;
            }
        }

        private void txtClearSearch_Click(object sender, EventArgs e)
        {
            txtFind.Clear();
            txtFind.Focus();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            using (var page = new AddEmployeePage())
            {
                page.ShowDialog();
            }

            EmployeePage_Load(null, null);
        }

        private void dgvCountries_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6:
                    EditRecord();
                    break;
                case 7:
                    RemoveRecord();
                    break;
            }
        }

        private void EditRecord()
        {
            using (var page = new AddEmployeePage())
            {
                if (dgv.CurrentRow != null)
                {
                    page.EmployeeId = (int) dgv.CurrentRow.Cells["clnId"].Value;
                    page.ShowDialog();
                }
            }

            EmployeePage_Load(null, null);
        }

        private void RemoveRecord()
        {
            var dr = MessageBox.Show(@"Are You  Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                using (var dbContext = new UnitOfWork())
                {
                    var dtHasRecord =
                        UtilityClass.GetData("SELECT * FROM VoucherLines WHERE EntityCode=" +
                                             dgv.CurrentRow.Cells["clnId"].Value);
                    if (dtHasRecord.Rows.Count > 0)
                    {
                        MessageBox.Show("کاربر گرامی امکان حذف این رکورد وجود ندارد");
                        return;
                    }

                    if (dgv.CurrentRow != null)
                    {
                        dbContext.EmployeeRepository.Delete((int) dgv.CurrentRow.Cells["clnId"].Value);
                        dbContext.Save();
                    }
                }

            EmployeePage_Load(null, null);
        }

        private void PeoplePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}