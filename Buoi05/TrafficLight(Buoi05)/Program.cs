using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight_Buoi05_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

        nhap:
            Console.Write("Nhập màu tín hiệu đèn: ");
            string den = Console.ReadLine();



            ///// C1 IF ELSE
            if (den == "đỏ")
            {
                Console.WriteLine("Dừng Lại!!!");
            }
            else if (den == "vàng")
            {
                Console.WriteLine("Chú Ý!!!");
            }
            else if (den == "xanh")
            {
                Console.WriteLine("Được di chuyển");
            }
            else
                Console.WriteLine("Không có điện!!!");


            goto nhap;

            ///// C2 SWITCH CASE
            
            switch (den)
            {
                case "đỏ": Console.WriteLine("Dừng Lại!!!"); break;
                case "vàng": Console.WriteLine("Chú Ý!!!"); break;
                case "xanh": Console.WriteLine("Được di chuyển"); break;
                default: Console.WriteLine("Không có điện!!!");
            }


            
            Console.ReadKey();
        }
    }
}
