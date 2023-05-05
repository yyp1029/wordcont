using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ScreenSaver_Test2
{
    public partial class frmScreenSaver : Form
    {
        int detY = 10;
        int detX = 10;
        public frmScreenSaver()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTitle.Top += detY;
            lblTitle.Left += detX;
            if (lblTitle.Top+lblTitle.Height>this.Height||lblTitle.Top<=0)//窗体的高度
            {
                detY = -detY;//改变Y轴偏移量
            }
            if (lblTitle.Left + lblTitle.Width > this.Width || lblTitle.Left <= 0)//窗体的宽度
            {
                detX = -detX;//改变X轴偏移量
            }
        }

        private void frmScreenSaver_KeyPress(object sender, KeyPressEventArgs e)
        {
            //退出程序
            Application.Exit();
        }

        private void frmScreenSaver_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }
    }
}
