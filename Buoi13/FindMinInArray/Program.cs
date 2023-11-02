using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinInArray
{
    class Program
    {
        public static int MinInArr(int[] arr)
        {
            int min = arr[0];
            int index = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    index = i;
                }
            }
            return index;
        }

        static void Main(string[] args)
        {
        input:
            int n;
            Console.Write("Enter size of array: ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0 && n < 100)
            {
                Random rd = new Random();
                int[] arr = new int[n];

                Console.Write("Numbers of Array: ");
                for (int i = 0; i < n; i++)
                {
                    int temp = rd.Next(100);
                    if (arr.Contains(temp))
                    {
                        i--;
                    }
                    else
                    {
                        arr[i] = temp;
                    }
                }

                Console.WriteLine(string.Join(" | ", arr));

                int min = MinInArr(arr);
                Console.WriteLine("\nMin number of array: {0}", arr[min]);
            }
            else
            {
                Console.Write("\nOut of number!!!\n");
                goto input;
            }


            Console.ReadKey();
        }
    }
}
