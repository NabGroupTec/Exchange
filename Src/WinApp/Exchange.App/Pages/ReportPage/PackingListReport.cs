using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Exchange.App.Infrastracture;

namespace Exchange.App.Pages.ReportPage
{
    public partial class PackingListReport : DevExpress.XtraEditors.XtraForm
    {
        DataView dv=new DataView();
        DataTable resultTable=new DataTable();
        public PackingListReport()
        {
            InitializeComponent();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PackingListReport_Load(object sender, EventArgs e)
        {
            var result = UtilityClass.GetDataLavan(@"SELECT cc.FaxNo, 
            InvoiceNo,
            cc.MarkName,
            ITEMNo,
            CartonNo,
            Carton,
            CBM,
            Quantity,
            SumValue = Carton * Quantity,
            Price,
            SumPrice = format((Carton * Quantity * Price), 'N0') ,
            Komision = ((Carton * Quantity * Price) * 2) / 100
            FROM dbo.QV_CountCarton AS cc
                JOIN dbo.QV_PackingList qv ON cc.IdKey = qv.IdKey; ");
            dv = result.DefaultView;
            gridControl1.DataSource = dv;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            var reportViewer = new ReportViewerPage();
            reportViewer.PrintName = "PACK";
            var table = dv.ToTable("tbl");
            reportViewer.DataTable = table;

            
            reportViewer.ShowDialog();
        }

        private void txtFind_EditValueChanged(object sender, EventArgs e)
        {
            var query = " FaxNo LIKE '%" + txtFind.Text + "%' OR InvoiceNo LIKE '%" + txtFind.Text + "%' OR MarkName LIKE '%" + txtFind.Text + "%' ";
            dv.RowFilter = query;

        }
    }
}