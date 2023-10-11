using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currencyconversion_buoi04_
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Xây dựng một ứng dụng chuyển đổi tiền tệ, cho phép tính giá trị tiền VNĐ dựa trên một tỉ giá cho trước và giá trị tiền USD được nhập vào.
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Xin chào - Vui lòng nhập tỉ giá VNĐ/USD: ");
            float tigia = float.Parse(Console.ReadLine());

            Console.Write("Vui lòng nhập số USD cần đổi sang VNĐ: ");
            float usd = float.Parse(Console.ReadLine());

            double tien = usd * tigia;
            Console.Write("Số tiền USD sau khi quy đổi ra VNĐ là: " + tien + " VNĐ");



            Console.ReadKey();
        }
    }
}
