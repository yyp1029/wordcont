using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //绘图类
        Graphics g= null;

        Random r = new Random();

        /// <summary>
        /// 绘图事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //实例化
            g = e.Graphics;

            //自定义钢笔对象
            Pen pen = new Pen(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)));
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;//线的风格（虚实）

            if (lstAllPoints.Count >= 2)
            {    
                //画直线
                g.DrawLines(pen, lstAllPoints.ToArray());//引用pen对象画线
            }
            for (int i = 0; i < lstAllPoints.Count; i++)
            {
                Color randColor = Color.FromArgb(r.Next(255),r.Next(255), r.Next(255));
                SolidBrush sb = new SolidBrush(randColor);
                g.FillEllipse(sb, lstAllPoints[i].X-15, lstAllPoints[i].Y-15, 30, 30);
            }
       
        }

        //存放鼠标移动过程中的所有轨迹
        List<Point> lstAllPoints= new List<Point>();

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
         
        }


        /// <summary>
        /// 随机的添加点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            lstAllPoints.Add(new Point(r.Next(this.Width), r.Next(this.Height)));
            this.Invalidate();
        }
    }
}
