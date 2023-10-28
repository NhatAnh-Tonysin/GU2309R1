using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalOfDiagonalLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            Console.Write("Enter array row: ");
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];

            #region Cấp phát số ngẫu nhiên cho mảng không trùng lặp, dò tìm số lớn nhất của mảng
            Console.Write("\nElements of array: \n");
            for (int i = 0, j = 0; i < n; i++, j = 0)
            {
                while (j < n)
                {
                    int item = rd.Next(1, 10);
                    foreach (int temp in arr)
                    {
                        if (temp == item)
                            item = rd.Next(1, 10);
                    }
                    arr[i, j] = item;
                    Console.Write(arr[i, j] + " ");
                    j++;
                }
                Console.WriteLine();
            }
            #endregion Cấp phát số ngẫu nhiên cho mảng không trùng lặp, dò tìm số lớn nhất của mảng

            #region Tính tổng mảng
            int totalAll = 0;
            for (int i = 0, j = 0; i < n && j < n; i++, j = 0)
            {
                while (j < n)
                {
                    totalAll = totalAll + arr[i, j];
                    j++;
                }
            }
            Console.WriteLine("Total Of Array: {0}", totalAll);
            #endregion Tính tổng mảng

            #region Tính tổng đường chéo chính
            int totalC = 0;
            for (int i = 0, j = 0; i < n && j < n; i++, j++)
            {
                totalC = totalC + arr[i, j];
            }
            Console.WriteLine("Total Of Main Diagonal Line: {0}", totalC);
            #endregion Tính tổng đường chéo chính

            #region Tính tổng đường chéo phụ
            int totalP = 0;
            for (int i = 0, j = n - 1; i < n && j < n; i++, j--)
            {
                totalP = totalP + arr[i, j];
            }
            Console.WriteLine("Total Of Secondary Diagonal Line: {0}", totalP);

            #endregion Tính tổng đường chéo phụ

            #region Nhập mới giá trị của lần lượt các phần tử của mảng
            Console.WriteLine("\n\nEnter new value for array");
            for (int i = 0, j = 0; i < n; i++, j = 0)
            {
                while (j < n)
                {
                    Console.Write("Element - [{0},{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    j++;
                }
            }
            #endregion Nhập mới giá trị của lần lượt các phần tử của mảng

            #region Xuất mảng mới
            Console.Write("\nElements of array: \n");
            for (int i = 0, j = 0; i < n; i++, j = 0)
            {
                Console.WriteLine();
                while (j < n)
                {
                    Console.Write("{0} ", arr[i, j]);
                    j++;
                }
            }
            #endregion Xuất mảng mới
            Console.ReadKey();


        }
    }
}
