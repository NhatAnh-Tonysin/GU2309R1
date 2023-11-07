using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList kt = NhapMang();
            DemKT(kt);

            Console.ReadKey();
        }
        /// <summary>
        /// Hàm đếm ký tự trong mảng
        /// In ra số lượng ký tự
        /// </summary>
        /// <param name="kt"></param>
        static void DemKT(ArrayList kt)
        {
            ArrayList newkt = new ArrayList();  // tạo mảng động mới để lọc những ký tự trùng trong mảng được nhập
            foreach (char c in kt)              //tìm từng phần tử trong mảng kt
            {
                if (!newkt.Contains(c))         //tìm phần tử của kt không có trong mảng newkt
                    newkt.Add(c);               //nếu không có thì gán cho newkt
            }

            for (int k = 0; k < newkt.Count; k++)   //dò từng phần tử trong mảng newkt
            {
                Console.Write(newkt[k] + " : ");    //in lần lượt từng phần tử trong mảng newkt
                int count = 0;
                for (int j = 0; j < kt.Count; j++)  //dò từng phần tử trong mảng kt
                {
                    if (newkt[k].ToString() == kt[j].ToString())    //nếu phần tử trong mảng newkt trùng với phần tử mảng kt
                        count++;                                    //thì cộng thêm 1
                }
                Console.Write(count);   //in ra số lượng phần tử sau khi đếm
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Hàm nhập chuỗi, gán chuỗi cho mảng
        /// </summary>
        /// <returns></returns>
        static ArrayList NhapMang()
        {
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();  //nhập chuỗi

            ArrayList kt = new ArrayList(); // tạo 1 mảng động
            kt.AddRange(s.ToArray());       // gán từng ký tự vào từng phần tử của mảng vừa tạo
            return kt;
        }




    }
}
