using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask2._2
{
    class Tetrahedron : Body3D
    {
        public double Edge { get; set; }
        
        public override void Draw()
        {
            Console.WriteLine("Draw Shpere");
        }

        public override double SurfaceArea()
        {
            return Math.Sqrt(3) * Edge * Edge;
        }
    }
}
