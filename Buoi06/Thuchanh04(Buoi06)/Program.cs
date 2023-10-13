using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh04_Buoi06_
{
    class Program
    {
        static void Main(string[] args)
        {



            ///////Nhập vào 2 số nguyên và 1 phép toán. Yêu cầu xuất ra kết quả phép tính dựa trên phép toán(là 1 trong 4 phép toán: +,-,*,%)

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a = 0;
            int b = 0;
        nhapso:
            Console.Write("Nhập số a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Nhập phép toán: ");
            string pheptoan = (Console.ReadLine());

            if (pheptoan == "nhân" || pheptoan == "x")
                Console.WriteLine("a x b = " + (a * b));
            else if (pheptoan == "cộng" || pheptoan == "+")
                Console.WriteLine("a + b = " + (a + b));
            else if (pheptoan == "trừ" || pheptoan == "-")
                Console.WriteLine("a - b = " + (a - b));
            else if (pheptoan == "chia" || pheptoan == "/")
                Console.WriteLine("a / b = " + (a / b));
            else
                Console.WriteLine("Không có phép toán");

            goto nhapso;
        }
    }
}
