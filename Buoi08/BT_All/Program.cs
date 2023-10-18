using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_All
{
    class Program
    {
        static void Main(string[] args)
        {
            BT05();
            Console.ReadKey();
        }

        private static void BT01()
        {
        ///// Nhập số nguyên A và kiểm tra xem A có phải là số nguyên tố hay không ?

        input:
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            bool check = true;
            int i;

            if (a < 2)
            {
                Console.WriteLine(a + " is not a prime number");
            }

            else
            {
                for (i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    Console.WriteLine(a + " is a prime number");
                }
                else
                {
                    Console.WriteLine(a + " is not a prime number");
                }
            }
            goto input;
        }
        private static void BT02()
        {
        //In ra tất cả số chẵn trong khoảng (M,N). Với N, M nhập từ bàn phím.

        input:
            Console.WriteLine("Finding an even number between M and N");
            Console.Write("Enter number M: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter number N: ");
            int n = int.Parse(Console.ReadLine());
            int max = Math.Max(m, n);
            int min = Math.Min(m, n);
            int x;

            Console.Write("Even numbers from min to max: ");
            for (x = min; x <= max;)
            {
                for (; x % 2 == 0 && x != 0; x++)
                {
                    Console.Write(x + "|");
                }
                x++;
            }

            Console.WriteLine("\n");
            goto input;


        }
        private static void BT03()
        {
        /*
        Nhập vào 1 số nguyên và xuất là Yes nếu nó là số hoàn hảo, ngược lại xuất No.
        Gợi ý: số hoàn hảo là số mà tổng ước số của nó(không tính nó) bằng chính nó.
        */
        input:
            Console.WriteLine("Finding a perfect number");
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            int x;
            int total = 0;

            Console.Write(a + " has divisors: " + "\n");
            for (x = 1; x <= a;)
            {
                for (; a % x == 0; x++)
                {
                    Console.Write(x + "_");
                    total = total + x;
                }
                x++;
            }


            if (total - a == a)
            {
                Console.WriteLine("\n" + a + " is a perfect number" + "\n");
            }
            else
            {
                Console.WriteLine("\n" + a + " is not a perfect number" + "\n");
            }

            goto input;
        }
        private static void BT04()
        {
        //Nhập vào 2 số nguyên a và b. Yêu cầu tìm UCLN của 2 số đó.

        input:
            Console.WriteLine("Finding greatest common divisor of 2 numbers");
            Console.Write("Enter a number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number B: ");
            int b = int.Parse(Console.ReadLine());

            int min = Math.Min(a, b); //biến tìm số nhỏ nhất giữa A và B

            int xab = 1;    //biến ước số chung của A và B
            int xmax = 0;   //biến ước số chung lớn nhất của A và B

            Console.Write("Common divisors of " + a + " and " + b + ": ");
            while (xab <= min)
            {
                while (a % xab == 0 && b % xab == 0 && xab <= min)
                {
                    Console.Write(xab + "| ");
                    xmax = xab;
                    xab++;
                }
                xab++;
            }

            Console.WriteLine("\n" + xmax + " is a greatest common divisor of " + a + " and " + b + "\n");

            goto input;
        }
        private static void BT05()
        {
            //Nhập vào 1 số nguyên n, xuất ra n!(n giai thừa)
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

        start:

            Console.WriteLine("\nTính giai thừa của N\n");
            Console.Write("Enter number N: ");
            int n = int.Parse(Console.ReadLine());

            int x = 1;
            int i = 1;

            while (i <= n)
            {
                x = x * i;
                i++;
            }

            Console.WriteLine("Giai thừa của N: " + x);

            goto start;
        }
        private static void BT06()
        {
        //Nhập vào số i, yêu cầu xuất ra bảng cửu chương thứ i

        input:
            Console.WriteLine("Multiplication Table");
            Console.Write("Enter tables of: ");
            int i = int.Parse(Console.ReadLine());

            int n = 1;
            Console.WriteLine(i + " Times Table");
            while (n > 0 && n <= 10)
            {
                int result = i * n;
                Console.WriteLine(@"{0} x {1} = {2}", i, n, result);
                n++;
            }
            Console.WriteLine();

            goto input;

        }
        private static void BT07()
        {

        //In ra bảng cửu chương từ 2 tới 10

        input:
            int a;
            int b;


            Console.WriteLine("Multiplication Table" + "\n");

        inputa:
            Console.Write("Enter table- from : ");
            if (int.TryParse(Console.ReadLine(), out a))
            { }
            else
            {
                Console.WriteLine("\nPlease enter the number");
                goto inputa;
            }

        inputb:
            Console.Write("\t       to : ");
            if (int.TryParse(Console.ReadLine(), out b))
            { }
            else
            {
                Console.WriteLine("\nPlease enter the number");
                goto inputb;
            }

            int max = Math.Max(a, b);
            int min = Math.Min(a, b);

            int i;
            int n = 1;

            #region a=min
            if (a == min)
            {
                for (i = min; i >= min && i <= max;)
                {
                    Console.WriteLine(i + " Times Table:");
                    while (n > 0 && n <= 10)
                    {
                        int result = i * n;
                        Console.WriteLine(@"{0} x {1} = {2}", i, n, result + "\n");
                        n++;
                    }
                    i++;
                    n = 1;
                }
            }
            #endregion a=min
            #region a=max
            if (a == max)
            {
                for (i = max; i >= min && i <= max;)
                {
                    Console.WriteLine(i + " Times Table");
                    while (n > 0 && n <= 10)
                    {
                        int result = i * n;
                        Console.WriteLine(@"{0} x {1} = {2}", i, n, result + "\n");
                        n++;
                    }
                    i--;
                    n = 1;
                }
            }
            #endregion a=max

            Console.WriteLine();

            goto input;
        }
        private static void BT08()
        {
        //Nhập vào 1 số nguyên n.
        //Xuất ra kết quả phép tính theo công thức sau kết quả lấy 3 chữ số thập phân: 1 + 1/2^3 + 1/3^3 + ... +1/n^3

        input:
            Console.Write("\nEnter number: ");
            int n = int.Parse(Console.ReadLine());

            int m = 1;
            double x = 0;

            while (m <= n)
            {
                double i = 1.0 / Math.Pow(m, 3);
                Console.Write("1/" + m + "^3 ");
                x = x + i;
                m++;
            }

            Console.WriteLine("\nResult is: {0:0.000}", x);

            goto input;
        }
        private static void BT09()
        {
            /*Nhập vào 2 số nguyên dương N,M (N > M). Yêu cầu kiểm tra tích các chữ số của N có bằng tổng các ước của M hay không?
                Nếu có xuất YES ngược lại xuất NO. Ví dụ:
                    • Nhập N = 23, M = 6 => NO
                    • Nhập N = 34, M = 6 => YES
            */

            int n;
            int m;
        inputa:
            Console.Write("Enter number(N): ");
            if (int.TryParse(Console.ReadLine(), out n) && n < 10000 & n > 0)
            { }
            else
            {
                Console.WriteLine("\nPlease enter number < 10000 and > 0");
                goto inputa;
            }

        inputb:
            Console.Write("Enter number(M): ");
            if (int.TryParse(Console.ReadLine(), out m) && m > 0)
            { }
            else
            {
                Console.WriteLine("\nPlease enter the number > 0");
                goto inputb;
            }

            if (n > m)
            {
                #region divisor total of M
                int x;
                int total_div_m = 0;

                Console.Write("M has divisors: ");
                for (x = 1; x <= m;)
                {
                    for (; m % x == 0; x++)
                    {
                        Console.Write(x + "_");
                        total_div_m = total_div_m + x;
                    }
                    x++;
                }

                Console.Write("\ndivisors total of M: " + total_div_m + "\n");
                #endregion divisor total of M

                #region numbers multiplication of N
                int ng = n / 1000;
                int tr = (n / 100) % 10;
                int ch = (n / 10) % 10;
                int dv = n % 10;
                int mul = 1;
                Console.Write("\nnumbers of N: ");
                Console.Write(ng + "_");
                Console.Write(tr + "_");
                Console.Write(ch + "_");
                Console.Write(dv);

                if (ng > 0 && tr > 0 && ch > 0 && dv > 0)
                {
                    mul = ng * tr * ch * dv;
                    Console.WriteLine("\nnumbers multiplication of N: " + mul + "\n");
                }
                else if (tr > 0 && ch > 0 && dv > 0)
                {
                    mul = tr * ch * dv;
                    Console.WriteLine("\nnumbers multiplication of N: " + mul + "\n");
                }
                else if (ch > 0 && dv > 0)
                {
                    mul = ch * dv;
                    Console.WriteLine("\nnumbers multiplication of N: " + mul + "\n");
                }
                else
                {
                    mul = dv;
                    Console.WriteLine("\nnumbers multiplication of N: " + mul + "\n");
                }
                #endregion numbers multiplication of N

                if (mul == total_div_m)
                {
                    Console.WriteLine("YES\n");
                }
                else
                {
                    Console.WriteLine("NO\n");
                }
            }
            else
            {
                Console.WriteLine("(N>M) Please try again!\n");
            }

            goto inputa;


        }
        private static void BT10()
        {
            //Nhập vào 3 số nguyên dương N,M,K. Kiểm tra tổng các chữ số của N cộng với chữ số đầu tiên của M có bằng K hay không?
            //Nếu có xuất Yes ngược lại xuất No.

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

        start:

            Console.WriteLine("\nSo Sánh tổng các chữ số của N + số M với số K (mỗi số đều lớn hơn 0 và tối đa 4 chữ số)\n");

            #region 3 Numbers
            int n;
            int m;
            int k;

        inputn:
            Console.Write("Enter number N: ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0 && n < 10000)
            { }
            else
            {
                Console.WriteLine("\nPlease enter number >0 and < 10000");
                goto inputn;
            }

        inputm:
            Console.Write("Enter number M: ");
            if (int.TryParse(Console.ReadLine(), out m) && m > 0 && m < 10000)
            { }
            else
            {
                Console.WriteLine("\nPlease enter number >0 and < 10000");
                goto inputm;
            }

        inputk:
            Console.Write("Enter number K: ");
            if (int.TryParse(Console.ReadLine(), out k) && k > 0 && k < 10000)
            { }
            else
            {
                Console.WriteLine("\nPlease enter number >0 and < 10000");
                goto inputk;
            }
            #endregion 3 Numbers

            #region Digit total of N
            int ng = n / 1000;
            int tr = (n / 100) % 10;
            int ch = (n / 10) % 10;
            int dv = n % 10;
            int total_d_N = ng + tr + ch + dv;

            Console.Write("\nNumbers of N: ");
            Console.Write(ng + "_");
            Console.Write(tr + "_");
            Console.Write(ch + "_");
            Console.Write(dv);
            Console.Write("\nDigits total of N: " + total_d_N + "\n");
            #endregion Digit total of N

            #region First digit of M
            //công thức này có thể tìm được số đầu tiên của chuỗi số mà không cần giới hạn số lượng chữ số

            int x = 1;
            int firstm = -1;

            while (m >= x)
            {
                firstm = (m / x) % 10;
                x *= 10;
            }

            Console.Write("First digit of M: " + firstm + "\n");

            int totalnm = total_d_N + firstm;

            #endregion First digit of M

            if (totalnm == k)
            {
                Console.Write("\nYES\n");
            }
            else
            {
                Console.Write("\nNO\n");
            }


            goto start;
        }
    }
}
