using System;
using System.Data;
using System.Resources;
using System.Windows.Forms;
using Exchange.App.DataSets;
using Telerik.WinControls.UI;

namespace Exchange.App.Pages.Language
{
    public partial class LanguagePage : RadForm
    {
        public LanguagePage()
        {
            InitializeComponent();
        }

        public LanguagePage(DataTable dataTabl)
        {
            InitializeComponent();
            dgv.DataSource = dataTabl;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var lang = new DataSet_Language();
            lang.Languages.WriteXml(string.Format("{0}/data.xml", Application.StartupPath));
            var rKu = new ResourceWriter(Application.StartupPath + "/resource.ku.resources");
            var rAr = new ResourceWriter(Application.StartupPath + "/resource.ar.resources");
            foreach (DataSet_Language.LanguagesRow row in lang.Languages.Rows)
            {
                rKu.AddResource(row.ID, row.Kurdish);
                rAr.AddResource(row.ID, row.Arabic);
            }

            rKu.Generate();
            rKu.Close();
            rAr.Generate();
            rAr.Close();
        }
    }
}