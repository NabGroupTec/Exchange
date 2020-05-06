using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;

namespace Exchange.App.Pages.Definitions
{
    public partial class SystemPartsPage : MetroForm
    {
        public SystemPartsPage()
        {
            InitializeComponent();
        }

        private void SystemPartsPage_Load(object sender, EventArgs e)
        {
            GetAllControls(this);
            CreateSytstemPartTree();
        }

        public void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                //UtilityClass.SetPermissoin(c);
            }
        }

        private void CreateSytstemPartTree()
        {
            TreeSystemPart
                .Nodes
                .Clear();

            var tn =
                new TreeNode("سطوح دسترسی سیستم");

            tn.ForeColor =
                Color.Blue;

            tn.Tag = "1";

            TreeSystemPart
                .Nodes
                .Add(tn);

            #region Load Tree View

            LoadTreeView(tn);

            #endregion
        }

        private void LoadTreeView(TreeNode TN)
        {
            int TagInt;
            TagInt = Convert.ToInt32(TN.Tag);
            DataTable systemPartChild = null;

            var sql =
                "SELECT  * ,(SELECT    COUNT(SP2.Id)   FROM SystemParts SP2   WHERE SP.Id = SP2.Level) ChildCount FROM SystemParts SP WHERE SP.Level=" +
                TagInt;

            systemPartChild = UtilityClass.GetData(sql);

            if (systemPartChild.Rows.Count > 0)
                foreach (DataRow item in systemPartChild.Rows)
                {
                    var M = new TreeNode();
                    M.Tag = item["Id"].ToString();
                    M.Text = M.Tag + " - " + item["Text"];
                    M.ToolTipText = "" + M.Tag;

                    if (TN.Level < imgLst.Images.Count - 1)
                    {
                        M.ImageIndex = TN.Level + 1;
                        M.SelectedImageIndex = TN.Level + 1;
                    }
                    else
                    {
                        M.ImageIndex = imgLst.Images.Count - 1;
                        M.SelectedImageIndex = imgLst.Images.Count - 1;
                    }

                    TN.Nodes.Add(M);
                    var CH = Convert.ToInt32(item["ChildCount"].ToString());
                    if (CH > 0) LoadTreeView(M);
                    M = null;
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TreeSystemPart.SelectedNode == null)
            {
                MessageBoxEx.Show("کابر گرامی ابتدا بایستی یکی از اجزای سیستم را انتخاب نمائید", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (var page = new AddSystemPartPage())
            {
                var getTag = int.Parse(TreeSystemPart.SelectedNode.Tag.ToString());

                page.PartId = getTag;

                page.ShowDialog();
                CreateSytstemPartTree();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var page = new AddSystemPartPage())
            {
                var getTag = int.Parse(TreeSystemPart.SelectedNode.Tag.ToString());
                page.PartId = getTag;
                page.ModeAction = "EDIT";
                page.ShowDialog();
                CreateSytstemPartTree();
            }
        }

        private void TreeSystemPart_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null &&
                e.Node.Parent.GetType() == typeof(TreeNode))
                UtilityClass.ParentSelectionId = int.Parse(e.Node.Parent.Tag.ToString());
        }

        private void SystemPartsPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}