using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuchanhToanTu_Buoi04_
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Viết một ứng dụng để tính diện tích của hình chữ nhật dựa vào chiều rộng và chiều cao được nhập vào.
            
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Nhập thông số chiều dài: ");
            float dai = float.Parse(Console.ReadLine());
            Console.Write("Nhập thông số chiều rộng: ");
            float rong = float.Parse(Console.ReadLine());

            float dientich = dai * rong;
            Console.WriteLine("Diện tích hình chữ nhật là: " + dai + "x" + rong + "=" + dientich);
;
            Console.ReadKey();

        }
    }
}
