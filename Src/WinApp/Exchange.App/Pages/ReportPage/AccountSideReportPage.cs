using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.App.Pages.Operation;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;
using Janus.Windows.GridEX;

namespace Exchange.App.Pages.ReportPage
{
    public partial class AccountSideReportPage : MetroForm
    {
        private DataTable _dataTable = new DataTable();


        public AccountSideReportPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
        }

        private void txtEntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r')
                using (var page = new DefinitionsListPage())
                {
                    page.ShowDialog();
                    txtEntity.Clear();
                    lblAccountCode.Text = UtilityClass.AccountCode.ToString();
                    txtEntity.Text = UtilityClass.AccountName;
                    GetMoein();
                }
        }

        private void txtEntity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (!string.IsNullOrEmpty(lblAccountCode.Text))
                {
                    txtEntity.Text = UtilityClass.AccountName;
                    SendKeys.Send("{Tab}");
                    GetMoein();
                }
        }

        private void GetMoein()
        {
            using (new UnitOfWork())
            {
                var currencyValue = cmbCurrency.SelectedValue;
                string sql;

                if (currencyValue != null && (int) cmbCurrency.SelectedValue != 0)
                    sql ="SELECT h.Id DocId,*,Mandeh=0.0,T=N' ',Master=0.0,c.Name Currency  FROM VoucherHeaders H JOIN VoucherLines L ON H.Id=L.VoucherHeaderId JOIN Currencies c ON L.CurrencyId=C.Id WHERE L.EntityCode=" +
                          lblAccountCode.Text + " AND L.CurrencyId=" + currencyValue;
                else
                    sql = @"SELECT h.Id DocId,h.ManualDate,h.Comment,c.Name Currency,l.BedPrice,l.BesPrice,Mandeh=0.0,T=N' ',Master=0.0 ,l.BedTMIN,l.BesTMIN 
                FROM VoucherHeaders H JOIN VoucherLines L ON H.Id = L.VoucherHeaderId
                JOIN Currencies c ON L.CurrencyId = C.Id";

                var dt = UtilityClass.GetData(sql);
                SetBedBesTableMoein(dt);
                _dataTable = dt;
                dgvEx.DataSource = dt;
                dgvEx.TotalRow = InheritableBoolean.True;
                dgvEx.RootTable.Columns[4].AggregateFunction = AggregateFunction.Sum;
                dgvEx.RootTable.Columns[5].AggregateFunction = AggregateFunction.Sum;
                dgvEx.RootTable.Columns[7].AggregateFunction = AggregateFunction.Sum;
                dgvEx.RootTable.Columns[8].AggregateFunction = AggregateFunction.Sum;
            }
        }

        private void AccountSideReportPage_Load(object sender, EventArgs e)
        {
            cmbCurrency.Items.Add("ارز را انتخاب نمائید");
            using (var dbContext = new UnitOfWork())
            {
                var result = dbContext.CurrencyRepository.GetAll().ToList();
                var currency = new List<Currency>
                {
                    new Currency
                    {
                        Country = "",
                        UserId = 1,
                        Comment = "",
                        Name = "ارز را انتخاب نمائبد",
                        LogRecord = DateTime.Now,
                        Status = 1,
                        FloatName = ""
                    }
                };
                currency.AddRange(result);
                cmbCurrency.DataSource = currency;
                cmbCurrency.ValueMember = "Id";
                cmbCurrency.DisplayMember = "Name";
            }
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblAccountCode.Text))
            {
                if ((int) cmbCurrency.SelectedValue == 0)
                    GetMoein();

                if (cmbCurrency.SelectedValue != null) GetMoein();
            }
        }

        private void txtEntity_TextChanged(object sender, EventArgs e)
        {
        }

        private void AccountSideReportPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void SetBedBesTableMoein(DataTable dt)
        {
            dt.Columns["Mandeh"].ReadOnly = false;
            dt.Columns["T"].ReadOnly = false;
            dt.Columns["Master"].ReadOnly = false;
            dt.Columns["T"].MaxLength = 50;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                double oldmon;
                if (i == 0)
                    oldmon = 0;
                else
                    oldmon = double.Parse(dt.Rows[i - 1]["Mandeh"].ToString());

                var newmon = double.Parse(dt.Rows[i]["BedPrice"].ToString()) > 0
                    ? double.Parse(dt.Rows[i]["BedPrice"].ToString())
                    : double.Parse(dt.Rows[i]["BesPrice"].ToString()) * -1;

                if (double.Parse(dt.Rows[i]["BedPrice"].ToString()) > 0 &&
                    double.Parse(dt.Rows[i]["BesPrice"].ToString()) == 0)
                    newmon = double.Parse(dt.Rows[i]["BedPrice"].ToString());
                else if (double.Parse(dt.Rows[i]["BedPrice"].ToString()) == 0 &&
                         double.Parse(dt.Rows[i]["BesPrice"].ToString()) > 0)
                    newmon = double.Parse(dt.Rows[i]["BesPrice"].ToString()) * -1;

                else if (double.Parse(dt.Rows[i]["BedPrice"].ToString()) > 0 &&
                         double.Parse(dt.Rows[i]["BesPrice"].ToString()) > 0)
                    newmon = double.Parse(dt.Rows[i]["BedPrice"].ToString()) +
                             double.Parse(dt.Rows[i]["BesPrice"].ToString()) * -1;

                var demands = newmon + oldmon;
                dt.Rows[i]["Mandeh"] = demands;
                dt.Rows[i]["T"] = double.Parse(dt.Rows[i]["Mandeh"].ToString()) >= 0 ? "بد" : "بس";
            }

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                if (double.Parse(dt.Rows[i]["Mandeh"].ToString()) < 0)
                    dt.Rows[i]["Mandeh"] = double.Parse(dt.Rows[i]["Mandeh"].ToString()) * -1;

                var bedTin = double.Parse(dt.Rows[i]["BedTMIN"].ToString());
                if (bedTin <= 0) dt.Rows[i]["Master"] = double.Parse(dt.Rows[i]["BesTMIN"].ToString());
                if (double.Parse(dt.Rows[i]["BesTMIN"].ToString()) <= 0)
                    dt.Rows[i]["Master"] = double.Parse(dt.Rows[i]["BedTMIN"].ToString());
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewerPage();
            reportViewer.PrintName = "ACCOUNTSIDE";
            reportViewer.DataTable = _dataTable;
            reportViewer.EntityName = txtEntity.Text;

            reportViewer.ShowDialog();
        }

        private void btnExpoerExcel_Click(object sender, EventArgs e)
        {
            UtilityClass.ExportGridEx(dgvEx, txtEntity.Text);
        }
    }
}