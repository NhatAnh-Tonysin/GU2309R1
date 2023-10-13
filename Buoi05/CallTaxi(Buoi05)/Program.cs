using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallTaxi_Buoi05_
{
    class Program
    {
        static void Main(string[] args)
        {
            /////Gọi Taxi
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            Console.WriteLine("Nhập có hoặc không vào chỗ điều kiện để xác nhận xem có nên gọi Taxi hay không");

            Console.Write("Trời mưa: ");
            string sky = Console.ReadLine();
            Console.Write("Xe hỏng: ");
            string xe = Console.ReadLine();

            if (sky == "co" || xe = "khong")
            {
                Console.WriteLine("Gọi Taxi");
            }
            else if ((sky == "không" || xe = "có"))
            {
                Console.WriteLine("Gọi Taxi");
            }
            else
            {
                Console.WriteLine("Không Gọi Taxi");
            }















            Console.ReadKey();
        }
    }
}
