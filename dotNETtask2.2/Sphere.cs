using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask2._2
{
    class Sphere : Body3D
    {
        private double Radius { get; set; }

        public Sphere(double radius=1):
            base("Сфера")
        {
            Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Shpere");
        }

        public override double SurfaceArea()
        {
            return 4 * Math.PI * Radius * Radius;
        }

        public override double Volume()
        {
            return 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
        }
    }
}
