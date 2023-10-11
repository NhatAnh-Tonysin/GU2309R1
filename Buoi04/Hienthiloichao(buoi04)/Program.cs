using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hienthiloichao_buoi04_
{
    class Program
    {
        static void Main(string[] args)
        {


            ///// phát triển một ứng dụng cho phép nhập tên của người dùng từ bàn phím, sau đó hiển thị lời chào kèm theo tên của người đó.
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Vui lòng nhập tên: ");

            string ten = Console.ReadLine();
            Console.WriteLine("Xin chào mừng bạn " + ten + " đến với khóa học C#");


            Console.ReadKey();



        }
    }
}
