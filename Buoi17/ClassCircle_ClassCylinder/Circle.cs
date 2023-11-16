using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCircle_ClassCylinder
{
    public class Circle
    {
        private double radius = 1.0;
        private string color = "White";

        public double GetRadius() { return radius; }
        public void SetRadius(double radius) { this.radius = radius; }
        public string GetColor() { return color; }
        public void SetColor(string color) { this.color = color; }

        public Circle() { }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public override string ToString()
        {
            return string.Format("BanKinh: {0},Mau: {1}", radius, color);
        }
    }
}
