using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh02_Buoi06_
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Nhập vào 1 số và kiểm tra số đó có phải là số chính phương không? Xuất: yes hoặc no.
            ///Số chính phương về bản chất là bình phương của một số tự nhiên nào đó.
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

        nhapso:
            Console.Write("Kiểm tra có phải số chính phương hay không - Nhập vào 1 số bất kì: ");
            int so = int.Parse(Console.ReadLine());

            int a = (int)Math.Sqrt(so);
            if (a * a == so)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            goto nhapso;
        }
    }
}
