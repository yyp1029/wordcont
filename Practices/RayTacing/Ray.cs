using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTacing
{
    /// <summary>
    /// 光线类
    /// </summary>
    internal class Ray
    {
        // 起点 和 方向
        Point3D org;

        Vector3D dir;

        public Ray(Point3D org, Vector3D dir)
        {
            this.org = org;
            this.dir = dir;
        }
        
        /// <summary>
        /// 计算光线球体是否相交
        /// </summary>
        /// <param name="sphere"></param>
        /// <returns></returns>
        public HitRecord Hit(Sphere sphere)
        {

            HitRecord hr = new HitRecord();
            double A = 1;
            double B = 2 * (dir.A * (org.X - sphere.Center.X)
                            + dir.B * (org.Y - sphere.Center.Y)
                            + dir.C * (org.Z - sphere.Center.Z));
            double C = Math.Pow((org.X - sphere.Center.X), 2)
                     + Math.Pow((org.Y - sphere.Center.Y), 2)
                     + Math.Pow((org.Z - sphere.Center.Z), 2)
                     - Math.Pow(sphere.Radius, 2);
            double delta = B * B - 4 * A * C;

            double t0 = (-1 * B - Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
            double t1 = (-1 * B + Math.Sqrt(B * B - 4 * A * C)) / (2 * A);
            double t = Math.Min(t0, t1);

            if (delta < 0)
            {
                hr.IsHit = false;
            }
            else
            {
                hr.IsHit = true;
                hr.T = t;
                Point3D hitPoint = new Point3D
                {
                    X = org.X + dir.A * t,
                    Y = org.Y + dir.B * t,
                    Z = org.Z + dir.C * t
                };
                hr.Hitpoint = hitPoint;
                Vector3D normalVector = hitPoint - sphere.Center;
                hr.NormalVector = normalVector;
            }
            return hr;  //返回值为交点信息
        }
    }
}
