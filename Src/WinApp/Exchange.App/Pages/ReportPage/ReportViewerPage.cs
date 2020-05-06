﻿using System;
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

                    var row = new DataSet_AccountSide();
                    foreach (DataRow itemRow in DataTable.Rows)
                    {
                        row.AccountSide.ImportRow(itemRow);
                    }

                    var dsCustomers = row;
                    var reportParameterUser = new ReportParameter("UserName", UtilityClass.FullName);
                    var reportParameterTime = new ReportParameter("Time", DateTime.Now.ToShortTimeString());
                    var reportParameterDate = new ReportParameter("Date", UtilityClass.JustGetDate().Substring(0,10));
                    var reportParameterCustomer = new ReportParameter("Customer", EntityName);
                    var dataSource = new ReportDataSource("DataSet_AccountSide", dsCustomers.Tables[0]);
                    reportViewer.LocalReport.DataSources.Clear();
                    reportViewer.LocalReport.SetParameters(new[] { reportParameterUser,reportParameterTime,reportParameterDate,reportParameterCustomer });
                    reportViewer.LocalReport.DataSources.Add(dataSource);
                    reportViewer.RefreshReport();
                    break;
            }
        }

        private void ReportViewerPage_Load(object sender, EventArgs e)
        {
            Print();
        }
    }
}