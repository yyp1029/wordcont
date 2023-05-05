using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            Point3D org = new Point3D(1,-2,-1);
            Vector3D dir= new Vector3D(1,2,4);
            dir.Normalize();
            Ray ray = new Ray(org, dir);

            Point3D center = new Point3D(3,0,5);
            Sphere sphere = new Sphere(center,3);

            HitRecord hr = ray.Hit(sphere);*/

            //成像平面
            ViewPlan vp= new ViewPlan();
            vp.leftTopLoc = new Point3D(-1, 1, 0);
            vp.w = 2;
            vp.h = 2;
            vp.resH = 800;
            vp.resW = 800;

            //x方向，y方向每个像素点所占的长度
            double xStep = vp.w / vp.resW;
            double yStep = vp.h / vp.resH;

            //球体
            Point3D center = new Point3D(0,0,-10);
            double radius = 1;
            Sphere sphere = new Sphere(center,radius);

            //图片
            Bitmap bmp = new Bitmap(vp.resW,vp.resH);

            //摄像机
            Point3D eye = new Point3D(0,0,20);

            //从摄像机所在位置，向成像平面的每个像素点生成一条光线
            for(int i = 0;i<vp.resW;i++)
            {
                for(int j = 0;j<vp.resH;j++)
                {
                    Point3D pixeLoc = new Point3D(vp.leftTopLoc.X+xStep *i,vp.leftTopLoc.Y - yStep *j,0);
                    Vector3D dir = pixeLoc - eye;
                    dir.Normalize();
                    Ray ray = new Ray(eye,dir);

                    //每条光线与球体求交
                    HitRecord hr = ray.Hit(sphere);

                    //根据求交结果，设置图片每个像素点的颜色
                    if (hr.IsHit == true)
                    {
                        bmp.SetPixel(i, j, Color.Red);
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.White); 
                    }
                }
            }
            //设置为背景图片
            this.BackgroundImage= bmp;
        }
    }
}
