using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETtask2._2
{
    abstract class Body3D
    {
        public Body3D(string name = "NoName")
        {
            PetName = name;
        }

        public string PetName { get; set; }

        public abstract void Draw();
        public abstract double SurfaceArea();
    }
}
