using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTacing
{
    /// <summary>
    /// 方向向量
    /// </summary>
    internal class Vector3D
    {
        double a;
        double b;
        double c;


        /// <summary>
        /// 向量归一化
        /// </summary>
        /// <param name="n"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        /// 
        public double Length()
        {
            return Math.Sqrt( a*a + b*b + c*c);
        }
        public void Normalize()
        {
            double len = Length();
            a /= len;
            b /= len;
            c /= len;
        }




        /// <summary>
        /// 运算符重载
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>

        //数字乘以向量
        public static  Vector3D operator* (double n,Vector3D v)
        {
            return new Vector3D(n*v.A,n*v.B,n*v.C); 
        }
        //向量乘以数字
        public static  Vector3D operator* (Vector3D v, double n)
        {
            return new Vector3D(n*v.A,n*v.B,n*v.C); 
        }

        //向量的点乘
        public static double operator* (Vector3D v1, Vector3D v2)
        {
            return v1.C*v2.A+v1.B*v2.B+v1.C*v2.C;
        }
        //向量的叉乘
        public static Vector3D operator ^ (Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.B * v2.C - v1.C * v2.B, v1.A * v2.C - v1.C * v2.A, v1.A * v2.B - v1.B * v2.A);
        }
        //还有加减法


        /// <summary>
        /// 点与向量相加左
        /// </summary>
        /// <param name="a">点a</param>
        /// <param name="b">向量b</param>
        /// <returns>结果是一个向量</returns>
        public static Vector3D operator +(Point3D a, Vector3D b)
        {
            return new Vector3D(a.X + b.A, a.Y + b.B, a.Z + b.C);
        }
        /// <summary>
        /// 点与向量相加右
        /// </summary>
        /// <param name="a">向量a</param>
        /// <param name="b">点b</param>
        /// <returns>结果是一个向量</returns>
        public static Vector3D operator +(Vector3D a, Point3D b)
        {
            return new Vector3D(a.A + b.X, a.B + b.Y, a.C + b.Z);
        }
        //构造函数
        public Vector3D()
        {
            a = 0;
            b = 0;
            c = 1;
        }
        public Vector3D(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
    }
}
