using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElement2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //[Bài tập] Thêm phần tử vào mảng có sẵn , sau khi thêm vào thì giá trị cũ của vị trí đó sẽ dồn về phía sau và các giá trị của vị trí sau đó cũng vậy

            Random rd = new Random();

            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());
            int[] val = new int[n];

            for(int i =0; i<val.Length;i++)
            {
                val[i] = rd.Next(1, 50);
            }


            Console.Write("\nElements of Array:     ");
            Console.WriteLine(string.Join(" | ", val));

            int index;

            do
            {
                Console.Write("Enter position to add new value: ");
                index = int.Parse(Console.ReadLine());

                if (index < 1 || index > val.Length)
                    Console.WriteLine("Over/Under array size - Can not add new to array!!!");
            } while (index < 1 || index > val.Length);



            int posMax = val.Length - 1;
            int vt = index - 1;
            Console.Write("The position of " + val[vt] + " will be add by: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = posMax; i < val.Length && i > vt; i--)
            {
                val[posMax] = val[posMax - 1];
                posMax--;
            }
            val[vt] = x;


            Console.Write("\nElements of New Array: ");
            Console.WriteLine(string.Join(" | ", val));












            Console.ReadKey();
        }
    }
}
