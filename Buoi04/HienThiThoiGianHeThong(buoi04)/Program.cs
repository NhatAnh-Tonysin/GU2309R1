using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HienThiThoiGianHeThong_buoi04_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Xin chào");

            DateTime Thoigian = DateTime.Now;
            Console.WriteLine("Thời gian hiện tại là: " + Thoigian);


            Console.ReadKey();
        }
    }
}
