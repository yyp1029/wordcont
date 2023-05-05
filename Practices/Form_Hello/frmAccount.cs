using Form_Hello;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From_QQ_Test1
{
    public partial class frmGetAccount : Form
    {
        public frmGetAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // frmLogin fL = new frmLogin();
            //fL.ShowDialog();
            this.Hide();
        }
    }
}
