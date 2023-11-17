using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Console.WriteLine(shape);

            shape = new Shape("red", false);
            Console.WriteLine(shape);

            Console.WriteLine("Hello World!\n");

            ////////////////////////////////////////

            Circle circle = new Circle();
            Console.WriteLine(circle);

            circle = new Circle(3.5);
            circle.Resize(2);
            Console.WriteLine(circle);

            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);

            Console.WriteLine();
            ///////////////////////////////////////

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.3, 5.8);
            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.5, 3.8, "orange", true);
            Console.WriteLine(rectangle);


            Console.WriteLine();
            /////////////////////////////////////////

            Square square = new Square();
            Console.WriteLine(square);

            square = new Square(2.3);
            Console.WriteLine(square);

            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);


            Console.WriteLine();
            /////////////////////////////////////////
            //triển khai interface ‘IComparable’ cho các lớp hình học
            Console.WriteLine("Interface IComparable");
            ComperableCircle[] circles = new ComperableCircle[3];
            circles[0] = new ComperableCircle(3.6);
            circles[1] = new ComperableCircle();
            circles[2] = new ComperableCircle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (ComperableCircle hinhtron in circles)
            {
                Console.WriteLine(hinhtron);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle hinhtron in circles)
            {
                Console.WriteLine(hinhtron);
            }


            Console.WriteLine();
            //////////////////////////////////////////////
            ///triển khai interface ‘IComparer’ để so sánh cách lớp hình học
            Console.WriteLine("Interface IComparer");
            Circle[] h_tron = new Circle[3];
            h_tron[0] = new Circle(5.8);
            h_tron[1] = new Circle();
            h_tron[2] = new Circle(4.3, "amigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle ht in h_tron)
            {
                Console.WriteLine(ht);
            }


            IComparer<Circle> circleComparator = new CircleComparator();
            Array.Sort(h_tron, circleComparator);

            Console.WriteLine("After-sorted:");
            foreach (Circle ht in h_tron)
            {
                Console.WriteLine(ht);
            }


            Console.WriteLine();
            //////////////////////////////////////////////
            ///Triển khai interface ‘Resizeable’ cho các lớp hình học
            Console.WriteLine("Interface Resizeable");

            Circle cir = new Circle();
            cir = new Circle(5.5);
            Console.WriteLine(cir);

            cir.Resize(0.5);
            Console.WriteLine(cir);


            Rectangle rec = new Rectangle();
            rec = new Rectangle(3, 6.5);
            Console.WriteLine(rec);

            rec.Resize(0.5);
            Console.WriteLine(rec);

            Square vuong = new Square();
            vuong = new Square(7);
            Console.WriteLine(vuong);
            vuong.Resize(0.5);
            Console.WriteLine(vuong);


            Console.WriteLine();
            //////////////////////////////////////////////
            ///Triển khai interface ‘IColorable’ cho các lớp hình học
            Console.WriteLine("Interface IColorable");
            List<Shape> list = new List<Shape>();
            list.Add(new Square(5));
            list.Add(new Circle(3));
            list.Add(new Rectangle(2, 3));

            foreach (Shape s in list)
            {
                if (s is Square)
                {
                    IColorable color = (Square)s;
                    color.HowToColor();
                }
                else if (s is Circle)
                {
                    Circle c = (Circle)s;
                    Console.WriteLine(c.GetArea());
                }
                else if (s is Rectangle)
                {
                    Rectangle r = (Rectangle)s;
                    Console.WriteLine(r.GetArea());
                }
            }

            Console.ReadKey();
        }
    }
}
