using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_AutoCompute_Test3
{
    public partial class frmCompute : Form
    {
        double num1;//随机数1
        double num2;//随机数2
        String operater;
        double answer;
        public frmCompute()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            //出题
            //随机生成两个操作数，一个操作符号
            Random rnd = new Random();
            num1 = rnd.Next(10);
            num2 = rnd.Next(10);

            int opr = rnd.Next(0,4);//随机生成0-3四个数，每个数代表一个运算符(不能取到Next（min，max）里面的上界值，可以取下界，左闭右开)
            //对应控件显示随机数和随机符号
            lblRandomNumber1.Text = num1.ToString();
            lblRandomNumber2.Text = num2.ToString();
            

            switch(opr)
            {
                case 0:
                    operater = "+";
                    answer=num1+ num2;
                    break;  
                case 1:
                    operater = "-";
                    answer=num1- num2;
                    break;
                case 2:
                    operater = "*";
                    answer=num1* num2;
                    break;
                case 3:
                    operater = "/";
                    answer=num1/ num2;
                    break;
                  
            }
            lblOperator.Text=operater;
            //txtAnswer.Text =  answer.ToString("0.00");





        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text == answer.ToString())
            {
                listBox1.Items.Add(lblRandomNumber1.Text + lblOperator.Text + lblRandomNumber2.Text + lblEqual.Text + txtAnswer.Text+ "★");
            }
            else {
                listBox1.Items.Add(lblRandomNumber1.Text + lblOperator.Text + lblRandomNumber2.Text + lblEqual.Text + txtAnswer.Text + "╳"+"      "+lblRandomNumber1.Text + lblOperator.Text + lblRandomNumber2.Text + lblEqual.Text + answer + "★");
            }
            txtAnswer.Text = "";
        }

        /*bug:随机数不随机，每次都是1+2开头，而且第一次加法运算总是错误，总是显示1+2=0。*/

        /*优化：当遇到5/9这种除不尽的算式的时候answer总是一个很长的循环小数，我不知道如何去让它显示为两位小数，
         试用过ToString（0.00）的方法，但会让所有结果变成两位小数，有何办法能让能算出具体结果的用整数，算不出来的保留两位小数呢*/
    }
}
