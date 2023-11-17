using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShapes
{
    public class CircleComparator : IComparer<Circle>
    {
        public int Compare(Circle x, Circle y)
        {
            if (x.GetRadius() > y.GetRadius()) return 1;
            else if (x.GetRadius()<y.GetRadius()) return -1;
            else return 0;
        }
    }
}
