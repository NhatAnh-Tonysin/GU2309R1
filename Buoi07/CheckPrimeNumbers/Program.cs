using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            int numb;
            while (choice !=0) 
            {
            
                Console.WriteLine("CHECK PRIME NUMBER");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Check number");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your number: ");
                        numb = Convert.ToInt32(Console.ReadLine());

                        if (numb < 2)
                        {
                            Console.WriteLine(numb + " is not a prime");
                            Console.WriteLine(Environment.NewLine);
                        }
                        else
                        {
                            int i = 2;
                            bool check = true;

                            while (i <= Math.Sqrt(numb))
                            {
                                if (numb % i == 0)
                                {
                                    check = false;
                                    break;
                                }
                                i++;
                            }

                            if (check)
                            {
                                Console.WriteLine(numb + " is a prime");
                                Console.WriteLine(Environment.NewLine);
                            }
                            else
                            {
                                Console.WriteLine(numb + " is not a prime");
                                Console.WriteLine(Environment.NewLine);
                            }
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("No choice!");
                        Console.WriteLine(Environment.NewLine);
                        break;
                }
            }
        }
    }
}

