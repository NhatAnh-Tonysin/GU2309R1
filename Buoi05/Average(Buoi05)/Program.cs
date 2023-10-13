using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Buoi05_
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Xếp loại học sinh theo điểm trung bình
            /// >=8.5:Giỏi // >=7:Khá // >=6.5:Trung Bình Khá // >=5:Trung Bình // >=3.5:Yếu // >=0:Kém
            /// 

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            Console.Write("Nhập số điểm trung bình: ");
            float diemtb = float.Parse(Console.ReadLine());


            /////C1
            if (diemtb>=0 && diemtb<3.5)
                Console.WriteLine("Học lực Kém");
            else if (diemtb>=3.5 && diemtb<5)
                Console.WriteLine("Học lực Yếu");
            else if (diemtb>=5 && diemtb<6.5)
                Console.WriteLine("Học lực Trung Bình");
            else if (diemtb >= 6.5 && diemtb < 7)
                Console.WriteLine("Học lực Trung Bình Khá");
            else if (diemtb >= 7 && diemtb < 8.5)
                Console.WriteLine("Học lực Khá");
            else
                Console.WriteLine("Học lực Giỏi");
            


            /////C2: cách tối giản của C1(Phần điểu kiện của C1 bị dư thừa), sẽ giản lược lại như sau
            if (diemtb >= 0 && diemtb < 3.5)
                Console.WriteLine("Học lực Kém");
            else if (diemtb < 5)
                Console.WriteLine("Học lực Yếu");
            else if (diemtb < 6.5)
                Console.WriteLine("Học lực Trung Bình");
            else if (diemtb < 7)
                Console.WriteLine("Học lực Trung Bình Khá");
            else if (diemtb < 8.5)
                Console.WriteLine("Học lực Khá");
            else
                Console.WriteLine("Học lực Giỏi");








            Console.ReadKey();
        }
    }
}
