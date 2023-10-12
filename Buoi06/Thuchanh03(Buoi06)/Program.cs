using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh03_Buoi06_
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Nhập vào 3 sô nguyên a,b,c. Tìm sô lớn nhất và sô nhỏ nhất trong 3 số đó.

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int a, b, c;
        nhapso:
            Console.Write("Nhập số a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Nhập số c: ");
            c = int.Parse(Console.ReadLine());



            if (a > b && a > c)
                Console.WriteLine("lớn nhất: " + a);
            if (b > c && b > a)
                Console.WriteLine("lớn nhất: " + b);
            if (c > a && c > b)
                Console.WriteLine("lớn nhất: " + c);

            if (a < b && a < c)
                Console.WriteLine("nhỏ nhất: " + a);
            if (b < c && b < a)
                Console.WriteLine("nhỏ nhất: " + b);
            if (c < a && c < b)
                Console.WriteLine("nhỏ nhất: " + c);

           ////Cach2

            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"so lon nhat la {max}");
            Console.WriteLine($"so be nhat la {min}");



            goto nhapso;
        }
    }
}
