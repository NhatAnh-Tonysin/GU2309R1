using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxIn2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            Console.Write("Enter array row: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter array col: ");
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];
            var max = -1;

            #region Cấp phát số ngẫu nhiên cho mảng không trùng lặp, dò tìm số lớn nhất của mảng
            Console.Write("\nElements of array: \n");
            for (int i = 0, j = 0; i < n; i++, j = 0)
            {
                while (j < m)
                {
                    max = a[i, j];
                    int item = rd.Next(10, 100);
                    foreach (int temp in a)
                    {
                        if (temp == item)
                            item = rd.Next(10, 100);
                    }
                    a[i, j] = item;
                    Console.Write(a[i, j] + " ");
                    j++;
                }

                foreach (int temp in a)
                {
                    if (temp > max)
                        max = temp;
                }
                Console.WriteLine("\nMax number until now :" + max + "\n");
            }
            #endregion Cấp phát số ngẫu nhiên cho mảng không trùng lặp, dò tìm số lớn nhất của mảng

            #region Xuất số lớn nhất của mảng và vị trí của nó
            Console.Write("Max number of array :" + max);

            int r = a.GetLength(0);
            int c = a.GetLength(1);
            int elm = r * c;

            for (int pos = 0; pos < elm; pos++)
            {
                int iM = pos / c;
                int jM = pos % c;
                if (a[iM, jM] == max)
                    Console.Write(" at position a[{0},{1}], row: {2},column: {3}", iM, jM, (iM + 1), (jM + 1));
            }
            #endregion Xuất số lớn nhất của mảng và vị trí của nó

            #region Nhập mới giá trị của lần lượt các phần tử của mảng
            Console.WriteLine("\n\nEnter new value for array");
            for (int i = 0, j = 0; i < n; i++, j = 0)
            {
                while (j < m)
                {
                    Console.Write("Element - [{0},{1}]: ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    j++;
                }
            }
            #endregion Nhập mới giá trị của lần lượt các phần tử của mảng

            #region Xuất mảng mới
            Console.Write("\nElements of array: \n");
            for (int i = 0, j = 0; i < n; i++, j = 0)
            {
                Console.Write("\n");
                while (j < m)
                {
                    Console.Write("{0}\t", a[i, j]);
                    j++;
                }
            }
            #endregion Xuất mảng mới




            Console.ReadKey();

        }
    }
}

