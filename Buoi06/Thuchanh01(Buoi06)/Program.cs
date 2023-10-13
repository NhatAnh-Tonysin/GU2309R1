using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh01_Buoi06_
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Nhập vào 1 số và kiểm tra số đó có phải là số chẵn không? Xuất: yes hoặc no.
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

        nhapso:
            Console.Write("Kiểm tra số chẵn - Nhập vào 1 số bất kì: ");
            double so = double.Parse(Console.ReadLine());

            if (so % 2 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            goto nhapso;
        }
    }
}
