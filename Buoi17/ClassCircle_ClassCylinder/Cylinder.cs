using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCircle_ClassCylinder
{
    public class Cylinder : Circle
    {
        private double height = 1.0;
        public Cylinder() { }
        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            this.height = height;
        }

        public double GetHeight() { return height; }
        public void SetHeight(double height) { this.height = height; }

        public double TheTich()
        {
            return height * Math.PI * Math.Pow(GetRadius(), 2);
        }

        public override string ToString()
        {
            return "Cylinder with height: " + GetHeight() + " " + base.ToString() + " and volume is: " + TheTich();
        }

    }
}
