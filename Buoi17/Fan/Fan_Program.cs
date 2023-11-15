using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    class Fan_Program
    {
        static void Main(string[] args)
        {
            Fan[] fan = new Fan[3];
            fan[0] = new Fan("Fan01", "Yellow", 10, 3);
            fan[1] = new Fan("Fan02", "BLue", 5, 2, true);
            fan[2] = new Fan();

            foreach (Fan f in fan)
            {
                Console.WriteLine(f.ToString());
            }



            Console.ReadKey();
        }
    }
}
