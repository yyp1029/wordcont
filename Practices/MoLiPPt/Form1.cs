using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoNiPPt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Graphics g;
        bool isDrawing=false;
        int drawIndex = 0;

        //用户绘制的所有图形
        List<SwpuGeomety> lstGeo = new List<SwpuGeomety> ();

       /*
        //存放矩形的链表
        List<SwpuRectangle> lstRect= new List<SwpuRectangle>();
        //当前正在绘制的矩形
        SwpuRectangle rect;

        //存放自由曲线的链表
        List<SwpuFreeLine> lstFreeLines = new List<SwpuFreeLine>();
        //当前正在绘制的曲线
        SwpuFreeLine freeLine;

        //存放椭圆的链表
        List<SwpuEllipse> lstEllipse = new List<SwpuEllipse>();
        //当前正在绘制的椭圆
        SwpuEllipse ellipse;*/


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            for(int i = 0; i < drawIndex; i++)
            {
                lstGeo[i].Draw(g);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtnRect.Checked)
            {
               SwpuRectangle rect = new SwpuRectangle();
                rect.fillColor= Color.Blue;//可更改填充的颜色
                rect.startPoint = e.Location;

                lstGeo.Add(rect);//添加到链表
            }
            else if (rbtnFreeLine.Checked)
            {
                SwpuFreeLine freeLine = new SwpuFreeLine();
                freeLine.lstPoints.Add(e.Location);

                lstGeo.Add(freeLine);

            }
            else if(rbtnEllipse.Checked)
            {
                SwpuEllipse ellipse = new SwpuEllipse();
                ellipse.fillColor= Color.Red;//可更改填充的颜色
                ellipse.startPoint = e.Location;

                lstGeo.Add(ellipse);//添加到链表
            }
            else if (rbtnTriangle.Checked)
            {
               SwpuTriangle triangle = new SwpuTriangle();
                triangle.fillColor= Color.Gold;
                triangle.frameColor = Color.Black;
                triangle.frameWidth = 2;
                triangle.point1 = e.Location;
                lstGeo.Add(triangle);
            }
            else if (rbtnDiamond.Checked)
            {
                Diamond diamond = new Diamond();
                diamond.fillColor = Color.Purple;
                //diamond.points[0] = e.Location;
                diamond.startPoint = e.Location;

                lstGeo.Add(diamond);
            }
            else if (rbtnPentagon.Checked)
            {
                Pentagram pentagram = new Pentagram();
                pentagram.fillColor = Color.Blue;
                //diamond.points[0] = e.Location;
                pentagram.startPoint = e.Location;

                lstGeo.Add(pentagram);
            }
            else if (rbtnArrow.Checked)
            {
                Arrow arrow = new Arrow();

                arrow.fillColor = Color.Pink;
                //diamond.points[0] = e.Location;
                arrow.startPoint = e.Location;

                lstGeo.Add(arrow);
            }

            drawIndex++;
            isDrawing=true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (rbtnRect.Checked)
                {
                    SwpuRectangle rect = (SwpuRectangle)lstGeo[lstGeo.Count - 1];//强制类型转换
                    rect.w = e.Location.X - rect.startPoint.X;
                    rect.h = e.Location.Y - rect.startPoint.Y;
                }
                else if (rbtnFreeLine.Checked)
                {
                    SwpuFreeLine freeLine = (SwpuFreeLine)lstGeo[lstGeo.Count - 1];//强制类型转换
                    freeLine.lstPoints.Add(e.Location);
                } 
                else if(rbtnEllipse.Checked)
                {
                    SwpuEllipse ellipse = (SwpuEllipse)lstGeo[lstGeo.Count - 1];//强制类型转换
                    ellipse.w = e.Location.X - ellipse.startPoint.X;
                    ellipse.h = e.Location.Y - ellipse.startPoint.Y;
                }
                else if (rbtnTriangle.Checked)
                {
                    SwpuTriangle triangle = (SwpuTriangle)lstGeo[lstGeo.Count - 1];
                    triangle.point2 = new Point((triangle.point1.X + e.Location.X) / 2, (int)(triangle.point1.Y + (e.Location.X - triangle.point1.X) / Math.Sqrt(3)));
                    triangle.point3 = new Point(e.Location.X, triangle.point1.Y);
                }
                else if (rbtnDiamond.Checked)
                {
                    Diamond diamond = (Diamond)lstGeo[lstGeo.Count - 1];
                    diamond.w = e.Location.X - diamond.startPoint.X;
                    diamond.h = e.Location.Y - diamond.startPoint.Y;

                    diamond.points[0] = new Point(diamond.startPoint.X + diamond.w / 2, diamond.startPoint.Y);
                    diamond.points[1] = new Point(diamond.startPoint.X + diamond.w, diamond.startPoint.Y + diamond.h / 2);
                    diamond.points[2] = new Point(diamond.startPoint.X + diamond.w / 2, diamond.startPoint.Y + diamond.h);
                    diamond.points[3] = new Point(diamond.startPoint.X, diamond.startPoint.Y + diamond.h / 2);


                }

                else if (rbtnPentagon.Checked)
                {
                    Pentagram pentagram = (Pentagram)lstGeo[lstGeo.Count - 1];
                    pentagram.w = e.Location.X - pentagram.startPoint.X;
                    pentagram.h = e.Location.Y - pentagram.startPoint.Y;

                    pentagram.points[0] = new Point(pentagram.startPoint.X + pentagram.w / 2, pentagram.startPoint.Y);
                    pentagram.points[1] = new Point(pentagram.startPoint.X + pentagram.w / 4, pentagram.startPoint.Y + pentagram.h);
                    pentagram.points[3] = new Point(pentagram.startPoint.X, pentagram.startPoint.Y + pentagram.h / 3);
                    pentagram.points[4] = new Point(pentagram.startPoint.X + pentagram.w / 4 * 3, pentagram.startPoint.Y + pentagram.h);
                    pentagram.points[2] = new Point(pentagram.startPoint.X + pentagram.w, pentagram.startPoint.Y + pentagram.h / 3);

                }
                else if (rbtnArrow.Checked)
                {
                    Arrow arrow = (Arrow)lstGeo[lstGeo.Count - 1];
                    arrow.w = e.Location.X - arrow.startPoint.X;
                    arrow.h = e.Location.Y - arrow.startPoint.Y;

                    arrow.points[0] = new Point(arrow.startPoint.X, arrow.startPoint.Y + arrow.h / 2);
                    arrow.points[1] = new Point(arrow.startPoint.X + arrow.w / 4, arrow.startPoint.Y);
                    arrow.points[2] = new Point(arrow.startPoint.X + arrow.w / 4, arrow.startPoint.Y + arrow.h / 3);
                    arrow.points[3] = new Point(arrow.startPoint.X + arrow.w, arrow.startPoint.Y + arrow.h / 3);
                    arrow.points[4] = new Point(arrow.startPoint.X + arrow.w, arrow.startPoint.Y + arrow.h / 3 * 2);
                    arrow.points[5] = new Point(arrow.startPoint.X + arrow.w / 4, arrow.startPoint.Y + arrow.h / 3 * 2);
                    arrow.points[6] = new Point(arrow.startPoint.X + arrow.w / 4, arrow.startPoint.Y + arrow.h);
                }
                this.Invalidate();
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing=false;
        }

        

        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (drawIndex > 0)
            {
                drawIndex--;
            }
            

            this.Invalidate();
        }

        /// <summary>
        /// 重做
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetry_Click(object sender, EventArgs e)
        {
            if (drawIndex < lstGeo.Count)
            {
                drawIndex++;
            }

            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbtnArrow_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
