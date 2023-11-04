using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelFromArray
{
    class Program
    {
        static void Del_Val_Arr(List<int> lst, int n)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] == n)
                    lst.Remove(lst[i]);
            }
        }

        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 6, 9, 2, 1, 3, 5, 23, 2, 6, 7, 29 };
            Console.WriteLine(string.Join(" ", lst));

            Console.WriteLine();
            Console.Write("Enter number need to delete: ");
            int n = int.Parse(Console.ReadLine());

            Del_Val_Arr(lst, n);
            Console.WriteLine(string.Join(" ", lst));
            
            


            Console.ReadKey();
        }
    }
}
