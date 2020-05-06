using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.App.Pages.Operation;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Definitions
{
    public partial class UsersPage : MetroForm
    {
        public UsersPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            ////Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void UsersPage_Load(object sender, EventArgs e)
        {
            var ctl = Controls.Cast<Control>().ToList();


            UtilityClass.SetPermissoin(ctl);


            using (var db = new UnitOfWork())
            {
                //var page=new SystemPartsPage();
                //page.ShowDialog();
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.UserRepository.GetAll();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var result = db.UserRepository.Get(user =>
                    user.FullName.Contains(txtFind.Text) || user.Id.ToString().Contains(txtFind.Text));
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
            using (var page = new AddUserPage())
            {
                page.ShowDialog();
            }

            using (var db = new UnitOfWork())
            {
                //var page=new SystemPartsPage();
                //page.ShowDialog();
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.UserRepository.GetAll();
            }
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
                case 8:
                    SetPermissions();
                    break;
            }
        }

        private void SetPermissions()
        {
            using (var page = new UserAccessLevelPage())
            {
                if (dgv.CurrentRow != null)
                {
                    page.SelectionUserId = Convert.ToInt32(dgv.CurrentRow.Cells["clnId"].Value.ToString());
                    page.ShowDialog();
                }
            }
        }

        private void EditRecord()
        {
            using (var page = new AddUserPage())
            {
                if (dgv.CurrentRow != null)
                {
                    page.UserId = (int) dgv.CurrentRow.Cells["clnId"].Value;
                    page.ShowDialog();
                }
            }

            using (var db = new UnitOfWork())
            {
                //var page=new SystemPartsPage();
                //page.ShowDialog();
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.UserRepository.GetAll();
            }
        }

        private void RemoveRecord()
        {
            var dr = MessageBox.Show(@"Are You  Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                using (var dbContext = new UnitOfWork())
                {
                    var dtHasRecord =
                        UtilityClass.GetData("SELECT * FROM VoucherHeaders WHERE UserId=" +
                                             dgv.CurrentRow.Cells["clnId"].Value);
                    if (dtHasRecord.Rows.Count > 0)
                    {
                        MessageBox.Show("کاربر گرامی امکان حذف این رکورد وجود ندارد");
                        return;
                    }

                    if (dgv.CurrentRow != null)
                    {
                        dbContext.UserRepository.Delete((int) dgv.CurrentRow.Cells["clnId"].Value);
                        dbContext.Save();
                    }
                }

            using (var db = new UnitOfWork())
            {
                //var page=new SystemPartsPage();
                //page.ShowDialog();
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.UserRepository.GetAll();
            }
        }

        private void UsersPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}