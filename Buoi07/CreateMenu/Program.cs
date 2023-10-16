using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice=-1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                int length;             // biến độ dài cạnh
                int times;              // biến số lần dấu "*" xuất hiện
                int turn;               // biến số lượt xuống dòng
                string s = " * ";       // biến dấu "*"

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(@"Draw the triangle with * ");
                        Console.Write("Enter short edge length: ");           //nhập vào số độ dài mong muốn, đơn vị là dấu "*"
                        length = int.Parse(Console.ReadLine());


                        for (turn = 1; turn <= length; length--)     // vòng lặp cho số lượt xuống dòng
                        {
                            for (times = 1; times <= length; times++)       //vòng lặp cho số lần dấu "*" xuất hiện trong 1 dòng
                            {
                                Console.Write(s);                           //in ra dấu "*" trên dòng
                            }
                            Console.WriteLine(Environment.NewLine);         // tạo dòng mới
                        }
                        break;

                    case 2:
                        Console.WriteLine(@"Draw the square with * ");
                        Console.Write("Enter edge length: ");           //nhập vào số độ dài mong muốn, đơn vị là dấu "*"
                        length = int.Parse(Console.ReadLine());

                        s = " *  ";
                        for (turn = 1; turn <= length; turn++)    // vòng lặp cho số lượt xuống dòng

                        {
                            for (times = 1; times <= length; times++)       //vòng lặp cho số lần dấu "*" xuất hiện trong 1 dòng
                            {
                                Console.Write(s);                           //in ra dấu "*" trên dòng
                            }
                            Console.WriteLine(Environment.NewLine);         // tạo dòng mới
                        }
                        break;

                    case 3:
                        Console.WriteLine(@"Draw the rectangle with * ");
                        Console.Write("Enter long edge length: ");           //nhập vào số độ dài mong muốn, đơn vị là dấu "*"
                        length = int.Parse(Console.ReadLine());

                        s = " *  ";
                        for (turn = 1; turn <= (length - 3); turn++)    // vòng lặp cho số lượt xuống dòng

                        {
                            for (times = 1; times <= length; times++)       //vòng lặp cho số lần dấu "*" xuất hiện trong 1 dòng
                            {
                                Console.Write(s);                           //in ra dấu "*" trên dòng
                            }
                            Console.WriteLine(Environment.NewLine);         // tạo dòng mới
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}
