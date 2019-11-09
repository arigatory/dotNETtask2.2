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

        public Tetrahedron(double v):
            base("Тетраэдр")
        {
            Edge = v;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Shpere");
        }

        public override double SurfaceArea()
        {
            return Math.Sqrt(3) * Edge * Edge;
        }

        public override double Volume()
        {
            return Edge * Edge / 6.0 / Math.Sqrt(2);
        }
    }
}
