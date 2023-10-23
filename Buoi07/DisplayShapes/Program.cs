using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayShapes
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Trong phần này, chúng ta sẽ phát triển một ứng dụng hiển thị một menu cho phép người dùng lựa chọn hiển thị các hình. Menu gồm các lựa chọn như sau

            Menu:

                Print the rectangle
                Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)
                Print isosceles triangle
                Exit
            Lưu ý: biểu diễn các hình có thể sử dụng ký hiệu * hoặc một ký hiệu khác. 
            */



            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("DisplayShapes-Menu:");
                Console.WriteLine("1. Draw the rectangle");
                Console.WriteLine("2. Draw the right triangle");
                Console.WriteLine("3. Draw isosceles triangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                int length;             // biến độ dài cạnh
                int times;              // biến số lần dấu "*" xuất hiện
                int bout;              // biến số lần dấu " " xuất hiện
                int turn;               // biến số lượt xuống dòng
                string s = " * ";       // biến dấu "*"
                string t = "   ";       // biến khoảng trắng

                switch (choice)
                {
                    #region Hình Chữ Nhật
                    case 1:
                        Console.WriteLine(@"Draw the rectangle with * ");
                        Console.Write("Enter long edge length number: ");           //nhập vào số độ dài mong muốn, đơn vị là dấu "*"
                        int length_L = int.Parse(Console.ReadLine());
                        Console.Write("Enter short edge length number: ");           //nhập vào số độ dài mong muốn, đơn vị là dấu "*"
                        int length_S = int.Parse(Console.ReadLine());


                        s = " *  ";
                        for (turn = 1; turn <= length_S; turn++)    // vòng lặp cho số lượt xuống dòng

                        {
                            for (times = 1; times <= length_L; times++)       //vòng lặp cho số lần dấu "*" xuất hiện trong 1 dòng
                            {
                                Console.Write(s);                           //in ra dấu "*" trên dòng
                            }
                            Console.WriteLine(Environment.NewLine);         // tạo dòng mới
                        }
                        break;
                    #endregion Hình Chữ Nhật

                    #region Tam Giác Vuông
                    case 2:
                        Console.WriteLine("Choose the right triangle type:");
                        Console.WriteLine("1. Top-Left");
                        Console.WriteLine("2. Bottom-Left");
                        Console.WriteLine("3. Top-Right");
                        Console.WriteLine("4. Bottom-Right");
                        Console.WriteLine("0. Exit");
                        Console.Write("Enter your choice: ");
                        choice = int.Parse(Console.ReadLine());


                        int i = 1;
                        int j;

                        switch (choice)
                        {
                            #region TOP-Left
                            case 1:
                                Console.Write("Enter edge length: ");
                                int lengthS = int.Parse(Console.ReadLine());

                                for (turn = 1; turn <= lengthS; lengthS--)     // vòng lặp cho số lượt xuống dòng
                                {
                                    for (times = 1; times <= lengthS; times++)  //vòng lặp cho số lần dấu "*" xuất hiện
                                    {
                                        Console.Write(s);                           //in ra dấu "*" trên dòng
                                    }
                                    Console.WriteLine(Environment.NewLine);         // tạo dòng mới
                                }
                                break;
                            #endregion TOP-Left

                            #region BOTTOM-Left
                            case 2:
                                Console.Write("Enter edge length: ");
                                lengthS = int.Parse(Console.ReadLine());

                                for (turn = 1; turn <= lengthS; lengthS--)     // vòng lặp cho số lượt xuống dòng
                                {
                                    j = lengthS - (lengthS - i);
                                    for (times = 1; times <= j; times++)
                                    {
                                        Console.Write(s);
                                    }
                                    i++;
                                    Console.WriteLine(Environment.NewLine);         // tạo dòng mới
                                }
                                break;
                            #endregion BOTTOM-Left

                            #region TOP-Right
                            case 3:
                                Console.Write("Enter edge length: ");
                                lengthS = int.Parse(Console.ReadLine());

                                i = 0;
                                for (turn = 1; turn <= lengthS; lengthS--)              // vòng lặp cho số lượt xuống dòng
                                {
                                    j = lengthS - (lengthS - i);
                                    for (bout = 1; bout <= j; bout++)
                                    {
                                        Console.Write(t);                               //in ra dấu " " trên dòng
                                    }
                                    i++;

                                    for (times = 1; times <= lengthS; times++)
                                    {
                                        Console.Write(s);                               //in ra dấu "*" trên dòng
                                    }

                                    Console.WriteLine(Environment.NewLine);             // tạo dòng mới
                                }
                                break;
                            #endregion TOP-Right

                            #region BOTTOM-Right
                            case 4:
                                Console.Write("Enter edge length: ");
                                lengthS = int.Parse(Console.ReadLine());

                                for (turn = 1; turn <= lengthS; lengthS--)          // vòng lặp cho số lượt xuống dòng
                                {
                                    for (bout = 1; bout <= lengthS - 1; bout++)     //vòng lặp cho số lần dấu "*" xuất hiện
                                    {
                                        Console.Write(t);                           //in ra dấu " " trên dòng
                                    }


                                    j = lengthS - (lengthS - i);
                                    for (times = 1; times <= j; times++)
                                    {
                                        Console.Write(s);                           //in ra dấu "*" trên dòng
                                    }
                                    i++;

                                    Console.WriteLine(Environment.NewLine);         // tạo dòng mới
                                }
                                break;
                            #endregion BOTTOM-Right

                            case 0:
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("No choice!");
                                break;
                        }

                        break;

                    #endregion Tam Giác Vuông

                    #region Tam Giác Cân
                    case 3:
                    nhaplai:
                        Console.WriteLine(@"Draw the triangle with * ");
                        Console.Write("Enter short edge length: ");           //nhập vào số độ dài mong muốn, đơn vị là dấu "*"
                        length = int.Parse(Console.ReadLine());

                        if (length % 2 == 0)
                        {
                            Console.WriteLine("Please reEnter, the number must be odd");
                            goto nhaplai;
                        }
                        else
                        {
                            i = 1;
                            for (turn = 1; turn <= length; length-=2)          // vòng lặp cho số lượt xuống dòng
                            {
                                for (bout = 1; bout <= length - 1; bout+=2)     //vòng lặp cho số lần dấu "*" xuất hiện
                                {
                                    Console.Write(t);                           //in ra dấu " "
                                }


                                j = length - (length - i);
                                for (times = 1; times <= j; times++)
                                {
                                    Console.Write(s);                           //in ra dấu "*"
                                }
                                i += 2;

                                Console.WriteLine(Environment.NewLine);         // tạo dòng mới
                            }
                        }
                        break;
                    #endregion Tam Giác Cân

                    #region END
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                        #endregion END
                }
            }

        }
    }
}
