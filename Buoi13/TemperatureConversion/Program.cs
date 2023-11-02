using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        public static double F2C(double f)
        {
            double c = (f - 32) * 5 / 9;
            return c;
        }

        public static double C2F(double c)
        {
            double f = (c * 9 / 5) + 32;
            return f;
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
            input:
                Console.WriteLine("Temperature Convertion");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit ");
                Console.Write("Select Function: ");
                //choice = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Fahrenheit: ");
                            double f = double.Parse(Console.ReadLine());
                            Console.WriteLine("Celsius: {0}", F2C(f));
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.Write("Enter Celsius: ");
                            double c = double.Parse(Console.ReadLine());
                            Console.WriteLine("Fahrenheit: {0}", C2F(c));
                            Console.WriteLine();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("No choice!!!");
                            Console.WriteLine();
                            break;
                    }
                }

                else
                {
                    Console.WriteLine();
                    goto input;
                }
            } while (choice != 0);



            Console.ReadLine();
        }
    }
}
