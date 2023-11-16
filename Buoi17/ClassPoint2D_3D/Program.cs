using System;
using System.Collections.Generic;

namespace ClassPoint2D_3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D p2 = new Point2D(5, 6);
            Console.WriteLine(p2.ToString());

            Point3D p3 = new Point3D(6, 7, 9);
            Console.WriteLine(p3.ToString());


            Console.ReadKey();
        }
    }



}
