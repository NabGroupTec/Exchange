using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.AdvTree;
using Exchange.App.Infrastracture;

namespace Exchange.App.Pages
{
    public partial class LoginPage : DevComponents.DotNetBar.Metro.MetroForm
    {
        public LoginPage()
        {
            InitializeComponent();;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(string.IsNullOrEmpty(txtUsername.Text))
                    if (!UtilityClass.Setmessage(txtUsername, "واحد کالا را وارد نمائید"))
                    {
                        // Add Code From Mt
                        return;
                    }
            }
        }
    }
}
