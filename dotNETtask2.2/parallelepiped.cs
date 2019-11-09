using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask2._2
{
    class Parallelepiped : Body3D
    {
        
        public double EdgeWidth { get; set; }
        public double EdgeHeight { get; set; }
        public double EdgeLength { get; set; }

        public Parallelepiped(int v1, int v2, int v3):
            base("Прямоугольник")
        {
            EdgeHeight = v1;
            EdgeLength = v2;
            EdgeWidth = v3;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Shpere");
        }

        public override double SurfaceArea()
        {
            return 2 * (EdgeHeight * EdgeLength + EdgeWidth * EdgeLength + EdgeHeight * EdgeWidth);
        }

        public override double Volume()
        {
            return EdgeHeight * EdgeLength * EdgeWidth;
        }
    }
}
