using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace MoNiPPt
{
    class SwpuGeomety
    {
        public Color fillColor;
        public Color frameColor = Color.Red;//边框颜色
        public int frameWidth = 5;//边框的宽度
        public DashStyle dashStyle = DashStyle.Dash;//画虚线

        public virtual void Draw(Graphics g)//多态，调用不同的Draw方法,父类的虚方法，子类必须实现
        {

        }
    }

    /// <summary>
    /// 矩形类
    /// </summary>
    internal class SwpuRectangle : SwpuGeomety
    {
        public Point startPoint;
        public int w;
        public int h;
        TextureBrush tb;//纹理画刷

        
        public SwpuRectangle()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("3.png") ;
            tb =new TextureBrush(bmp);
        }

        public override void Draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(fillColor);//创建刷子对象
            g.FillRectangle(tb, startPoint.X, startPoint.Y, w, h);

            Pen pen = new Pen(frameColor, frameWidth);//创建笔的对象
            pen.DashStyle = dashStyle;  //画虚线
            g.DrawRectangle(pen, startPoint.X, startPoint.Y, w, h);//画边框
        }
    }

    /// <summary>
    /// 曲线类
    /// </summary>
    class SwpuFreeLine : SwpuGeomety
    {
        public List<Point> lstPoints = new List<Point>();


        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Red, 3);
            g.DrawLines(pen, lstPoints.ToArray());
        }
    }

    /// <summary>
    /// 椭圆类
    /// </summary>
    class SwpuEllipse : SwpuGeomety
    {
        public Point startPoint;
        public int w;
        public int h;

        public override void Draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(fillColor);//创建刷子对象
            g.FillEllipse(sb, startPoint.X, startPoint.Y, w, h);

            Pen pen = new Pen(frameColor, frameWidth);//创建笔的对象
            pen.DashStyle = dashStyle;  //画虚线
            g.DrawEllipse(pen, startPoint.X, startPoint.Y, w, h);//画边框
        }
    }

    /// <summary>
    /// 画三角形
    /// </summary>
    class SwpuTriangle : SwpuGeomety
    {
        public Point point1;
        public Point point2;
        public Point point3;

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(frameColor, frameWidth);
            Brush brush = new SolidBrush(fillColor);

            Point[] points = new Point[3] { point1, point2, point3 };
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);

            pen.Dispose();
            brush.Dispose();
        }

    }
    /// <summary>
    /// 菱形
    /// </summary>
    class Diamond : SwpuGeomety
    {
        public Point startPoint;
        public int w;
        public int h;
        public new int frameWidth = 2;
        public Point[] points = new Point[4];

        public override void Draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(fillColor);
            g.FillPolygon(sb, points);

            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            g.DrawPolygon(pen, points);
        }
    }
    /// <summary>
    /// 五角星
    /// </summary>
    class Pentagram : SwpuGeomety
    {
        public Point startPoint;
        public int w;
        public int h;
        public new int frameWidth = 2;
        public Point[] points = new Point[5];

        public override void Draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(fillColor);
            g.FillPolygon(sb, points);


            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            g.DrawPolygon(pen, points);
        }
    }
    /// <summary>
    /// 箭头
    /// </summary>
    class Arrow : SwpuGeomety
    {
        public Point startPoint;
        public int w;
        public int h;
        public new int frameWidth = 2;
        public Point[] points = new Point[7];

        public override void Draw(Graphics g)
        {
            SolidBrush sb = new SolidBrush(fillColor);
            g.FillPolygon(sb, points);


            Pen pen = new Pen(frameColor, frameWidth);
            pen.DashStyle = dashStyle;
            g.DrawPolygon(pen, points);
        }
    }


}


