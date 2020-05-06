using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Exchange.App.Infrastracture;
using Exchange.App.ViewModels;
using Exchange.Domain.DataAccess;

namespace Exchange.App.Pages.Operation
{
    public partial class DefinitionsListPage : OfficeForm
    {
        private readonly BindingSource _bs = new BindingSource();
        private IEnumerable<DefinitionsListViewModel> list;

        public DefinitionsListPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void DefinitionsListPage_Load(object sender, EventArgs e)
        {
            using (var db = new UnitOfWork())
            {
                var peopleList = db.PeopleRepository.GetAll().Select(people => new DefinitionsListViewModel
                    {AccountCode = people.Id, AccountName = people.FirstName + " " + people.LastName});
                var incomeList = db.IncomeRepository.GetAll().Select(income => new DefinitionsListViewModel
                    {AccountCode = income.Id, AccountName = income.Name});
                var costList = db.CostRepository.GetAll().Select(cost => new DefinitionsListViewModel
                    {AccountCode = cost.Id, AccountName = cost.Name});
                var coinsList = db.CoinsRepository.GetAll().Select(coins => new DefinitionsListViewModel
                    {AccountCode = coins.Id, AccountName = coins.Name});
                var cashDeskList = db.CashDeskRepository.GetAll().Select(cashDesk => new DefinitionsListViewModel
                    {AccountCode = cashDesk.Id, AccountName = cashDesk.Name});
                var bankList = db.BankAccountRepository.GetAll().Select(bank => new DefinitionsListViewModel
                {
                    AccountCode = bank.Id, AccountName = bank.BankName + " " + bank.Name, CurrencyId = bank.CurrencyId
                });
                var capitalList = db.AccountCapitalRepository.GetAll().Select(capital => new DefinitionsListViewModel
                    {AccountCode = capital.Id, AccountName = capital.Name});
                var estate = db.EstateRepository.GetAll().Select(estat => new DefinitionsListViewModel
                    {AccountCode = estat.Id, AccountName = estat.Name});
                var employee = db.EmployeeRepository.Get().Select(emp => new DefinitionsListViewModel
                    {AccountCode = emp.Id, AccountName = emp.FirstName + " " + emp.LastName});
                var peler = db.PerlerDocumentsRepository.Get().Select(emp => new DefinitionsListViewModel
                    {AccountCode = emp.Id, AccountName = emp.Title});
                var receive = db.ReceivingDocumentsRepository.Get().Select(emp => new DefinitionsListViewModel
                    {AccountCode = emp.Id, AccountName = emp.Title});
                list = peopleList.ToList().Concat(incomeList).ToList().Concat(costList).ToList().Concat(coinsList)
                    .ToList().Concat(cashDeskList).ToList().Concat(bankList).ToList().Concat(capitalList).ToList()
                    .Concat(estate).ToList().Concat(employee).ToList().Concat(peler).ToList().Concat(receive).ToList();
                _bs.DataSource = list.ToList();
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = _bs;
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            var l = list.Where(p => p.AccountName.Contains(txtFind.Text));
            dgv.DataSource = l.ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                var value = dgv.CurrentRow.Cells["clnCode"].Value;
                if (value != null)
                {
                    UtilityClass.AccountCode = Convert.ToInt32(value.ToString());
                    UtilityClass.AccountName = dgv.CurrentRow.Cells["clnName"].Value.ToString();
                    UtilityClass.CurrencyId = Convert.ToInt32(dgv.CurrentRow.Cells["clnCurrency"].Value.ToString());
                }

                Close();
            }
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (dgv.CurrentRow != null)
                {
                    var value = dgv.CurrentRow.Cells["clnCode"].Value;
                    if (value != null)
                    {
                        UtilityClass.AccountCode = Convert.ToInt32(value.ToString());
                        UtilityClass.AccountName = dgv.CurrentRow.Cells["clnName"].Value.ToString();
                        UtilityClass.CurrencyId = Convert.ToInt32(dgv.CurrentRow.Cells["clnCurrency"].Value.ToString());
                    }

                    Close();
                }
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                dgv.Focus();
            if (e.KeyCode == Keys.Enter)
                if (dgv.CurrentRow != null)
                {
                    var value = dgv.CurrentRow.Cells["clnCode"].Value;
                    if (value != null)
                    {
                        UtilityClass.AccountCode = Convert.ToInt32(value.ToString());
                        UtilityClass.AccountName = dgv.CurrentRow.Cells["clnName"].Value.ToString();
                        UtilityClass.CurrencyId = Convert.ToInt32(dgv.CurrentRow.Cells["clnCurrency"].Value.ToString());
                    }

                    Close();
                }
        }

        private void DefinitionsListPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}