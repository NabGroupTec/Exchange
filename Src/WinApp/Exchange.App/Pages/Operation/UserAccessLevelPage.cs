using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Exchange.App.Infrastracture;
using Exchange.App.Pages.Definitions;
using Exchange.Domain.DataAccess;
using Exchange.Domain.Entities;

namespace Exchange.App.Pages.Operation
{
    public partial class UserAccessLevelPage : MetroForm
    {
        public UserAccessLevelPage()
        {
            InitializeComponent();
        }

        public int SelectionUserId { get; set; }

        private void SystemPartsPage_Load(object sender, EventArgs e)
        {
            CreateSytstemPartTree();
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
                    var m = new TreeNode();
                    m.Tag = item["Id"].ToString();
                    m.Text = m.Tag + " - " + item["Text"];
                    m.ToolTipText = "" + m.Tag;

                    var getSysPartFormId = Convert.ToInt32(m.Tag);
                    IEnumerable<UserAccess> havePermission;
                    using (var db = new UnitOfWork())
                    {
                        var id = getSysPartFormId;
                        var result = db.UserAccessRepository
                            .Get(p => p.UsersId == SelectionUserId && p.SystemPartsId == id);
                        havePermission = result;
                    }

                    if (havePermission.ToList().Count > 0)
                        m.Checked = true;

                    if (TN.Level < imgLst.Images.Count - 1)
                    {
                        m.ImageIndex = TN.Level + 1;
                        m.SelectedImageIndex = TN.Level + 1;
                    }
                    else
                    {
                        m.ImageIndex = imgLst.Images.Count - 1;
                        m.SelectedImageIndex = imgLst.Images.Count - 1;
                    }

                    TN.Nodes.Add(m);
                    var CH = Convert.ToInt32(item["ChildCount"].ToString());
                    if (CH > 0) LoadTreeView(m);
                    m = null;
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetArrayofCheckedNodes();
            DialogResult = DialogResult.OK;
        }

        private string GetArrayofCheckedNodes()
        {
            return string.Join(" , ", GetCheckedNodes(TreeSystemPart.Nodes));
        }

        public List<string> GetCheckedNodes(TreeNodeCollection nodes)
        {
            var nodeList = new List<string>();
            if (nodes == null) return nodeList;

            foreach (TreeNode childNode in nodes)
            {
                if (childNode.Checked)
                {
                    var havePermission =
                        CheckHavePermission(SelectionUserId, int.Parse(childNode.Tag.ToString()));

                    if (havePermission.Count == 0)
                        using (var db = new UnitOfWork())
                        {
                            var userAccess = new UserAccess
                            {
                                UserId = UtilityClass.UserId,
                                SystemPartsId = int.Parse(childNode.Tag.ToString()),
                                Comment = "",
                                LogRecord = DateTime.Now,
                                Status = 1,
                                UsersId = SelectionUserId
                            };
                            db.UserAccessRepository.Insert(userAccess);
                            db.Save();
                        }
                }
                else if (childNode.Checked == false && childNode.Tag.ToString() != "1")
                {
                    using (var db = new UnitOfWork())
                    {
                        var value = int.Parse(childNode.Tag.ToString());
                        var result = db.UserAccessRepository
                            .Get(p => p.UsersId == SelectionUserId && p.SystemPartsId == value).ToList();
                        foreach (var userAccess in result)
                        {
                            db.UserAccessRepository.Delete(userAccess.Id);
                            db.Save();
                        }
                    }
                }

                nodeList.AddRange(GetCheckedNodes(childNode.Nodes));
            }

            return nodeList;
        }

        private List<UserAccess> CheckHavePermission(int userId, int tag)
        {
            using (var db = new UnitOfWork())
            {
                var result = db.UserAccessRepository.Get(p => p.UsersId == userId && p.SystemPartsId == tag).ToList();
                return result;
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

        private void TreeSystemPart_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckedChildNode(e.Node, e.Node.Checked);
        }

        private void CheckedChildNode(TreeNode node, bool isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;
                if (item.Nodes.Count > 0) CheckedChildNode(item, isChecked);
            }
        }

        private void UserAccessLevelPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}