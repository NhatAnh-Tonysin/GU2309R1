using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCircle_ClassCylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine(c);

            c = new Circle(4.5, "Yellow");
            Console.WriteLine(c);

            Console.WriteLine();
            /////////

            Cylinder cylinder = new Cylinder();
            Console.WriteLine(cylinder);

            cylinder = new Cylinder(2.0,"red",3.0);
            Console.WriteLine(cylinder);

            Console.ReadKey();
        }
    }
}
