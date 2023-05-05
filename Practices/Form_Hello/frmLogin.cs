using From_QQ_Test1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Hello
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text == "123456" && txtPassword.Text == "654321")
            {
                //弹出另一个窗体（用想要弹出的窗体新建一个对象）
                frmMain fM = new frmMain();
                fM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("密码错误或用户不存在", "Error", MessageBoxButtons.OK);          
             }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmGetAccount fA = new frmGetAccount();
            fA.Show();

        }
    }
}
