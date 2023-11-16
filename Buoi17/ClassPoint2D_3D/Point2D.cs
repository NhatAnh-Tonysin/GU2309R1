using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint2D_3D
{
    class Point2D
    {
        private double x, y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Point2D(double x = 0, double y = 0)
        {
            this.x = x; this.y = y;
        }

        public void SetXY(double x = 0, double y = 0)
        {
            this.x = x; this.y = y;
        }

        public List<double> GetXY()
        {
            List<double> result = new List<double>();
            result.Add(this.X);
            result.Add(this.Y);

            return result;
        }

        public override string ToString()
        {
            return string.Format("X:{0},Y:{1}", x, y);
        }



    }
}
