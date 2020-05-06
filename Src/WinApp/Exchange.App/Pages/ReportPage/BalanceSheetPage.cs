using System;
using Exchange.App.Infrastracture;
using Janus.Windows.GridEX;
using Telerik.Examples.WinControls.Editors.DateTimePicker.FirstLook;
using Telerik.WinControls.UI;

namespace Exchange.App.Pages.ReportPage
{
    public partial class BalanceSheetPage : RadForm
    {
        public BalanceSheetPage()
        {
            //var culture = Exchange.App.Properties.Settings.Default.Language;
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            InitializeComponent();
            fromDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
            ToDate.Culture = PersianCultureHelper.GetFixedPersianCulture();
        }

        private void BalanceSheetPage_Load(object sender, EventArgs e)
        {
            fromDate.Text = UtilityClass.GetDate(); // DateTime.Now.ToShortDateString();
            ToDate.Text = UtilityClass.GetDate(); // DateTime.Now.ToShortDateString();
        }

        private void btnTackReport_Click(object sender, EventArgs e)
        {
            var fromDate = this.fromDate.Text.Replace("/", "-");
            var toDate = ToDate.Text.Replace("/", "-");

            #region Get Balance Report

            var data = UtilityClass.GetData(@"SELECT N'بانک' AccountName,
       BA.Name,
       SUM(vl.BedPrice) Bed,
       SUM(vl.BesPrice) Bes,
       C.Name Currency,
       SUM(vl.BedTMIN) BedMaster,
       SUM(vl.BesTMIN) BesMaster
FROM dbo.BankAccounts AS BA
    JOIN dbo.VoucherLines AS vl
        ON BA.Id = vl.EntityCode
		JOIN dbo.VoucherHeaders AS VH ON VH.Id = vl.VoucherHeaderId
    JOIN dbo.Currencies AS C
        ON vl.CurrencyId = C.Id
		WHERE vh.ManualDate BETWEEN '" + fromDate + @"' AND '" + toDate + @"'
GROUP BY C.Name,
         BA.Name
UNION
SELECT N'حساب های سرمایه ای' AccountName,
       ac.Name,
       SUM(vl.BedPrice) Bed,
       SUM(vl.BesPrice) Bes,
       C.Name Currency,
       SUM(vl.BedTMIN) BedMaster,
       SUM(vl.BesTMIN) BesMaster
FROM dbo.AccountCapitals AS ac
    JOIN dbo.VoucherLines AS vl
        ON ac.Id = vl.EntityCode
		JOIN dbo.VoucherHeaders AS VH ON VH.Id = vl.VoucherHeaderId
    JOIN dbo.Currencies AS C
        ON vl.CurrencyId = C.Id
		WHERE vh.ManualDate BETWEEN '" + fromDate + @"' AND '" + toDate + @"'
GROUP BY C.Name,
         ac.Name
UNION
SELECT N'صندوق' AccountName,
       CD.Name,
       ISNULL(SUM(vl.BedPrice), 0) Bed,
       ISNULL(SUM(vl.BesPrice), 0) Bes,
       C.Name Currency,
       SUM(vl.BedTMIN) BedMaster,
       SUM(vl.BesTMIN) BesMaster
FROM dbo.CashDesks AS CD
    JOIN dbo.VoucherLines AS vl
        ON CD.Id = vl.EntityCode
		JOIN dbo.VoucherHeaders AS VH ON VH.Id = vl.VoucherHeaderId
    JOIN dbo.Currencies AS C
        ON vl.CurrencyId = C.Id
		WHERE vh.ManualDate BETWEEN '" + fromDate + @"' AND '" + toDate + @"'
GROUP BY C.Name,
         CD.Name
UNION
SELECT N'مسکوکات' AccountName,
       C2.Name,
       ISNULL(SUM(vl.BedPrice), 0) Bed,
       ISNULL(SUM(vl.BesPrice), 0) Bes,
       C.Name Currency,
       SUM(vl.BedTMIN) BedMaster,
       SUM(vl.BesTMIN) BesMaster
FROM dbo.Coins AS C2
    LEFT JOIN dbo.VoucherLines AS vl
        ON C2.Id = vl.EntityCode
		JOIN dbo.VoucherHeaders AS VH ON VH.Id = vl.VoucherHeaderId
    LEFT JOIN dbo.Currencies AS C
        ON vl.CurrencyId = C.Id
		WHERE vh.ManualDate BETWEEN '" + fromDate + @"' AND '" + toDate + @"'
GROUP BY C.Name,
         C2.Name
UNION
SELECT N'هزینه ها' AccountName,
       C3.Name,
       ISNULL(SUM(vl.BedPrice), 0) Bed,
       ISNULL(SUM(vl.BesPrice), 0) Bes,
       C.Name Currency,
       SUM(vl.BedTMIN) BedMaster,
       SUM(vl.BesTMIN) BesMaster
FROM dbo.Costs AS C3
    LEFT JOIN dbo.VoucherLines AS vl
        ON C3.Id = vl.EntityCode
		JOIN dbo.VoucherHeaders AS VH ON VH.Id = vl.VoucherHeaderId
    LEFT JOIN dbo.Currencies AS C
        ON vl.CurrencyId = C.Id
WHERE C.Name IS NOT NULL AND  vh.ManualDate BETWEEN '" + fromDate + @"' AND '" + toDate + @"'
GROUP BY C.Name,
         C3.Name
UNION
SELECT N'کارمندان' AccountName,
       E.FirstName + ' ' + E.LastName Name,
       ISNULL(SUM(vl.BedPrice), 0) Bed,
       ISNULL(SUM(vl.BesPrice), 0) Bes,
       C.Name Currency,
       SUM(vl.BedTMIN) BedMaster,
       SUM(vl.BesTMIN) BesMaster
FROM dbo.Employees AS E
    LEFT JOIN dbo.VoucherLines AS vl
        ON E.Id = vl.EntityCode
		JOIN dbo.VoucherHeaders AS VH ON VH.Id = vl.VoucherHeaderId
    LEFT JOIN dbo.Currencies AS C
        ON vl.CurrencyId = C.Id
WHERE C.Name IS NOT NULL AND  vh.ManualDate BETWEEN '" + fromDate + @"' AND '" + toDate + @"'
GROUP BY C.Name,
         E.FirstName,
         E.LastName
UNION
SELECT N' اموال و دارایی' AccountName,
       E.Name,
       ISNULL(SUM(vl.BedPrice), 0) Bed,
       ISNULL(SUM(vl.BesPrice), 0) Bes,
       C.Name Currency,
       SUM(vl.BedTMIN) BedMaster,
       SUM(vl.BesTMIN) BesMaster
FROM dbo.Estates AS E
    LEFT JOIN dbo.VoucherLines AS vl
        ON E.Id = vl.EntityCode
		JOIN dbo.VoucherHeaders AS VH ON VH.Id = vl.VoucherHeaderId
    LEFT JOIN dbo.Currencies AS C
        ON vl.CurrencyId = C.Id
WHERE C.Name IS NOT NULL AND  vh.ManualDate BETWEEN '" + fromDate + @"' AND '" + toDate + @"'
GROUP BY C.Name,
         E.Name
UNION
SELECT N'درآمد' AccountName,
       E.Name,
       ISNULL(SUM(vl.BedPrice), 0) Bed,
       ISNULL(SUM(vl.BesPrice), 0) Bes,
       C.Name Currency,
       SUM(vl.BedTMIN) BedMaster,
       SUM(vl.BesTMIN) BesMaster
FROM dbo.Incomes AS E
    LEFT JOIN dbo.VoucherLines AS vl
        ON E.Id = vl.EntityCode
		JOIN dbo.VoucherHeaders AS VH ON VH.Id = vl.VoucherHeaderId
    LEFT JOIN dbo.Currencies AS C
        ON vl.CurrencyId = C.Id
WHERE C.Name IS NOT NULL AND  vh.ManualDate BETWEEN '" + fromDate + @"' AND '" + toDate + @"'
GROUP BY C.Name,
         E.Name
UNION
SELECT N'مشتریان' AccountName,
       P.FirstName + ' ' + P.LastName Name,
       ISNULL(SUM(vl.BedPrice), 0) Bed,
       ISNULL(SUM(vl.BesPrice), 0) Bes,
       C.Name Currency,
       SUM(vl.BedTMIN) BedMaster,
       SUM(vl.BesTMIN) BesMaster
FROM dbo.People AS P
    LEFT JOIN dbo.VoucherLines AS vl
        ON P.Id = vl.EntityCode
		JOIN dbo.VoucherHeaders AS VH ON VH.Id = vl.VoucherHeaderId
    LEFT JOIN dbo.Currencies AS C
        ON vl.CurrencyId = C.Id
WHERE C.Name IS NOT NULL AND  vh.ManualDate BETWEEN '" + fromDate + @"' AND '" + toDate + @"'
GROUP BY C.Name,
         P.FirstName,
         P.LastName;");

            #endregion

            dgv.DataSource = data;
            dgv.TotalRow = InheritableBoolean.True;
            dgv.RootTable.Columns[2].AggregateFunction = AggregateFunction.Sum;
            dgv.RootTable.Columns[3].AggregateFunction = AggregateFunction.Sum;

            dgv.RootTable.Columns[5].AggregateFunction = AggregateFunction.Sum;
            dgv.RootTable.Columns[6].AggregateFunction = AggregateFunction.Sum;
        }
    }
}