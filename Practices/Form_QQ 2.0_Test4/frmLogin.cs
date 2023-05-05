using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_QQ_2._0_Test4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fM= new frmMain();
            fM.ShowDialog();
            
        }

        private void linkLabel_Enroll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_Enroll.LinkVisited = true;
            Process.Start("msedge.exe", "https://ssl.zc.qq.com/v3/index-chs.html");

        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            //关闭控件背景色变红
            picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;//移出鼠标变回透明
        }

        /// <summary>
        /// 移入头像加号弹出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        int moveStep;
        bool moveRight = true;
        private void picHeadshot_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            moveStep = 8;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picAdd.Location = new Point(picAdd.Location.X + moveStep, picAdd.Location.Y);
            if (moveRight&&picAdd.Location.X >= 500)
            {
                moveStep = 0;
            }
            if (moveRight&&picAdd.Location.X<359)
            {
                moveStep= 0;
            }
        }

        private void picHeadshot_MouseLeave(object sender, EventArgs e)
        {
            moveStep = -8;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_Recover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_Recover.LinkVisited = true;
            Process.Start("msedge.exe", "https://aq.qq.com/cn2/findpsw/pc/pc_find_pwd_input_account?pw_type=6");
        }
    }
}
