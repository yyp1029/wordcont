using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTacing
{
    /// <summary>
    /// Hit方法返回值类
    /// </summary>
    internal class HitRecord
    {
        private bool isHit;  //是否击中
        private double t;    //击中点参数
        private Vector3D normalVector;//法线向量
        private Point3D hitpoint; //击中点
       
        public bool IsHit { get => isHit; set => isHit = value; }
        public double T { get => t; set => t = value; }
        internal Vector3D NormalVector { get => normalVector; set => normalVector = value; }
        internal Point3D Hitpoint { get => hitpoint; set => hitpoint = value; }

        public HitRecord() { }
    } 
}
