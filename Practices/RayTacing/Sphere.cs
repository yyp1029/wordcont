using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTacing
{
    /// <summary>
    /// 球体
    /// </summary>
    internal class Sphere
    {
        //球心加半径
        Point3D center;
        double radius;

        //构造函数
        public Sphere()
        {
            center=new Point3D();
            radius=1;
        }
        public Sphere(Point3D center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        //属性
        public double Radius { get => radius; set => radius = value; }
        internal Point3D Center { get => center; set => center = value; }
    }
}
