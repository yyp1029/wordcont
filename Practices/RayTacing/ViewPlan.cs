using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTacing
{
    internal class ViewPlan
    {
         public Point3D leftTopLoc;//成像平面左上角位置
         public double w;
         public double h;
         public int resH;//高度分辨率
         public int resW;//宽度分辨率
    }
}
