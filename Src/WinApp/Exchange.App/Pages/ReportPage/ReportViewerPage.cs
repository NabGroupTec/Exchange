using System;
using System.Data;
using DevComponents.DotNetBar.Metro;
using Exchange.App.DataSets;
using Exchange.App.Infrastracture;
using Microsoft.Reporting.WinForms;

namespace Exchange.App.Pages.ReportPage
{
    public partial class ReportViewerPage : MetroForm
    {
        public DataTable DataTable;
        public string EntityName;
        public string PrintName;

        public ReportViewerPage()
        {
            InitializeComponent();
        }

        private void Print()
        {
            switch (PrintName)
            {
                case @"ACCOUNTSIDE":
                    reportViewer.Visible = true;
                    var row = new DataSet_AccountSide();
                    foreach (DataRow itemRow in DataTable.Rows)
                    {
                        row.AccountSide.ImportRow(itemRow);
                    }

                    var dsCustomers = row;
                    var reportParameterUser = new ReportParameter("UserName", UtilityClass.FullName);
                    var reportParameterTime = new ReportParameter("Time", DateTime.Now.ToShortTimeString());
                    var reportParameterDate = new ReportParameter("Date",  UtilityClass.JustGetDate().Substring(0, 10));
                    var reportParameterCustomer = new ReportParameter("Customer", EntityName);
                    var dataSource = new ReportDataSource("DataSet_AccountSide", dsCustomers.Tables[0]);
                    reportViewer.LocalReport.DataSources.Clear();
                    reportViewer.LocalReport.SetParameters(new[] { reportParameterUser, reportParameterTime, reportParameterDate, reportParameterCustomer });
                    reportViewer.LocalReport.DataSources.Add(dataSource);
                    reportViewer.RefreshReport();
                    break;
                case "DAILY":
                    var rowDaily = new DataSet_DailyReport();
                    foreach (DataRow itemRow in DataTable.Rows)
                    {
                        rowDaily.Daily.ImportRow(itemRow);
                    }

                    reportViewerDaily.Visible = true;
                    var dsDaily = rowDaily;
                    var rptParameterUser = new ReportParameter("UserName", UtilityClass.FullName);
                    var rptParameterTime = new ReportParameter("Time", DateTime.Now.ToShortTimeString());
                    var rptParameterDate = new ReportParameter("Date", UtilityClass.JustGetDate().Substring(0, 10));
                    var dataSourceDaily = new ReportDataSource("DataSet_DailyReport", dsDaily.Tables[0]);
                    reportViewerDaily.LocalReport.DataSources.Clear();
                    reportViewerDaily.LocalReport.SetParameters(new[] { rptParameterUser, rptParameterTime, rptParameterDate });
                    reportViewerDaily.LocalReport.DataSources.Add(dataSourceDaily);
                    reportViewerDaily.RefreshReport();
                    break;
                case "PACK":
                    reportViewerPack.Visible = true;
                    var rowPack = new DataSet_PackingList();
                    foreach (DataRow itemRow in DataTable.Rows)
                    {
                        rowPack.PackList.ImportRow(itemRow);
                    }

                    var dsPack = rowPack;
                    var rptParameterUserP = new ReportParameter("UserName", UtilityClass.FullName);
                    var rptParameterTimeP = new ReportParameter("Time", DateTime.Now.ToShortTimeString());
                    var rptParameterDateP = new ReportParameter("Date", UtilityClass.JustGetDate().Substring(0, 10));
                    var dataSourcePack = new ReportDataSource("DataSet_PackingList", dsPack.Tables[0]);
                    reportViewerPack.LocalReport.DataSources.Clear();
                    reportViewerPack.LocalReport.SetParameters(new[] { rptParameterUserP, rptParameterTimeP, rptParameterDateP });
                    reportViewerPack.LocalReport.DataSources.Add(dataSourcePack);
                    reportViewerPack.RefreshReport();
                    break;

            }
        }

        private void ReportViewerPage_Load(object sender, EventArgs e)
        {
            Print();
            this.reportViewerPack.RefreshReport();
        }
    }
}