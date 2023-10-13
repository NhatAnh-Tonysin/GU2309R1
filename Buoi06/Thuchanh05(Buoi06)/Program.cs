using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuchanh05_Buoi06_
{
    class Program
    {
        static void Main(string[] args)
        {
            /////Giải phương trình Ax + B = 0. Với A, B là hệ sô được nhập vào từ bàn phím
            /////• Nếu phương trình vô nghiệm xuất kết quả: VN
            /////• Nếu phương trình VSN xuất ra : VSN
            /////• Nếu phương có nghiệm, xuất ra nghiệm(Lưu ý: lấy 2 chữ số thập phân)

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
        nhapso:
            Console.Write("Nhập số a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập số b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double x = -b / a;

            if (a==0 && b==0)
            {
                Console.WriteLine("VSN");
            }
            else if (a == 0 && b != 0 )
                {
                Console.WriteLine("VN");
                }
            else
                Console.WriteLine("Kết quả là: " + Math.Round(x,2)); ///C1
                Console.WriteLine("Kết quả là: " + String.Format("{0:0.00}", x)); ///C2
                Console.WriteLine("Kết quả là: " + x.ToString("0.00")); ///C3
                Console.WriteLine("Kết quả là: {0:0.0000}",x); ///C4
            goto nhapso;
        }
    }
}
