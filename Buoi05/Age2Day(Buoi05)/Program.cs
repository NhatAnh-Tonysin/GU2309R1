using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age2Day_Buoi05
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Xây dựng chương trình nhập vào số tuổi và chuyển đổi sang số ngày đã sống.
           
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            Console.WriteLine("Xin chào bạn");
            int age=-1; // qua bài while, do_while sẽ giải thích tại sao phải gán giá trị liền cho biến, trong bài này thì biến age không cần gán trước giá trị cũng được
            int luotnhap = 3;// ngoài lần đầu thì có 3 lần nhập lại
        nhap_so_tuoi:
            Console.Write("Vui lòng nhập số tuổi của bạn: ");
            //int age = int.Parse(Console.ReadLine()); // khi nhập chữ kèm số sẽ báo lỗi, treo chương trình thay bằng int.TryParse(int.TryParse(Console.ReadLine(), out age)
            
            if (int.TryParse(Console.ReadLine(), out age) && age > 0 && age <= 120)
            {
                Console.WriteLine("Số ngày bạn đã sống là: " + (age * 365) + " ngày");
            }

            else
            {                
                if (luotnhap > 0)
                {
                    Console.WriteLine("Thông tin nhập không hơp lệ, vui lòng nhập lại");
                    Console.WriteLine("Số lần thử lại còn: " + luotnhap--); // thông thường để bảo mật sẽ không hiển thị cho người dùng số lần thử lại
                }

                else
                { 
                    Console.WriteLine("Quá số lần thử lại.Chương trình sẽ kết thúc");
                    goto ket_thuc;
                }
              
                goto nhap_so_tuoi;
            }

            ket_thuc:
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");












            Console.ReadKey();
        }
    }
}
