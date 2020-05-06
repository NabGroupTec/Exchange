using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Operation
{
    public partial class CurrencyListPage : MetroForm
    {
        public CurrencyListPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void DefinitionsListPage_Load(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = db.CurrencyRepository.GetAll();
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var result = db.CurrencyRepository.Get(currency =>
                    currency.Name.Contains(txtFind.Text) || currency.Id.ToString().Contains(txtFind.Text));
                dgv.DataSource = result;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                UtilityClass.CuId = Convert.ToInt32(dgv.CurrentRow.Cells["clnCode"].Value.ToString());
                UtilityClass.CuName = dgv.CurrentRow.Cells["clnName"].Value.ToString();
                Close();
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (dgv.CurrentRow != null)
                {
                    UtilityClass.CuId = Convert.ToInt32(dgv.CurrentRow.Cells["clnCode"].Value.ToString());
                    UtilityClass.CuName = dgv.CurrentRow.Cells["clnName"].Value.ToString();
                    Close();
                }
        }

        private void CurrencyListPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}