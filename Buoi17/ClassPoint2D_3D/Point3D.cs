using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint2D_3D
{
    class Point3D : Point2D
    {
        private double z;

        public double Z { get => z; set => z = value; }

        public Point3D(double x, double y, double z = 0) : base(x, y)
        {
            this.z = z;
        }

        public void SetXYZ(double x, double y, double z = 0)
        {
            base.SetXY(x, y);
            this.z = z;
        }

        public List<double> GetXYZ()
        {
            List<double> result = new List<double>();
            result = base.GetXY();
            result.Add(z);

            return result;
        }

        public override string ToString()
        {
            return string.Format("X:{0},Y:{1},Z:{2}", X, Y, Z);
        }
    }
}
