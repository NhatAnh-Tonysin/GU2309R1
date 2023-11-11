using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    class Fan_Class
    {
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;
        bool on = false;
        private double radius = 5;
        private string color = "blue";

        public static int SLOW1 => SLOW;
        public static int MEDIUM1 => MEDIUM;
        public static int FAST1 => FAST;



        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public Fan() { }
        private int Speed(int sp)
        {
            sp = SLOW;
        }

        private void TurnOn()
        {
            on = true;
        }

        private void TurnOff()
        {
            on = false;
        }

        public void ToString()
        {
            Console.WriteLine("")
        }
    }
}
