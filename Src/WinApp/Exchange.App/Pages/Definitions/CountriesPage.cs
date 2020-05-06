using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Definitions
{
    public partial class CountriesPage : MetroForm
    {
        public CountriesPage()
        {
            InitializeComponent();
        }

        private void CountriesPage_Load(object sender, EventArgs e)
        {
            var ctl = Controls.Cast<Control>().ToList();
            UtilityClass.SetPermissoin(ctl);
            using (var db = new UnitOfWork())
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.CountryRepository.GetAll();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var result = db.CountryRepository.Get(country =>
                    country.Name.Contains(txtFind.Text) || country.Id.ToString().Contains(txtFind.Text) ||
                    country.Iso.Contains(txtFind.Text));
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
            using (var page = new AddCountryPage())
            {
                page.ShowDialog();
            }

            CountriesPage_Load(null, null);
        }

        private void dgvCountries_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 3:
                    EditRecord();
                    break;
                case 4:
                    RemoveRecord();
                    break;
            }
        }

        private void EditRecord()
        {
            using (var page = new AddCountryPage())
            {
                if (dgv.CurrentRow != null)
                {
                    page.CountryId = (int) dgv.CurrentRow.Cells["clnId"].Value;
                    page.ShowDialog();
                }
            }

            CountriesPage_Load(null, null);
        }

        private void RemoveRecord()
        {
            var dr = MessageBox.Show(@"Are You  Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                using (var dbContext = new UnitOfWork())
                {
                    if (dgv.CurrentRow != null)
                    {
                        dbContext.CountryRepository.Delete((int) dgv.CurrentRow.Cells["clnId"].Value);
                        dbContext.Save();
                    }
                }

            CountriesPage_Load(null, null);
        }

        private void CountriesPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}