using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTacing
{
    /// <summary>
    /// 三维点类
    /// </summary>
    internal class Point3D
    {
        //字段
        double x;

        double y;

        double z;

        //构造函数
        public Point3D() 
        {
            x= 0;
            y= 0;
            z= 0;
        }
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point3D(double a) //三个坐标相等时的构造函数，可以少传两个参数
        {
            x=a;
            y=a;
            z=a;
        }

        //属性
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }



        /// <summary>
        /// 重载运算符，点之间的减法，返回向量值
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Vector3D operator -(Point3D p1, Point3D p2)
        {
            Vector3D v = new Vector3D(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
            return v;
        }

    }
}
