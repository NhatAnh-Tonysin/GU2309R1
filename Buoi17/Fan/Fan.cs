using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    public class Fan
    {
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;

        private bool on;
        private int speed;
        private double radius;
        private string color;
        private string name;


        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public string Name { get => name; set => name = value; }

        public static int SLOW1 => SLOW;

        public static int MEDIUM1 => MEDIUM;

        public static int FAST1 => FAST;


        public Fan(string name = "Fan_Default", string color = "Blue", double radius = 5, int speed = SLOW, bool on = false)
        {
            this.name = name;
            this.color = color;
            this.radius = radius;
            this.speed = speed;
            this.on = on;
        }



        public override string ToString()
        {
            if (on)
                return string.Format("Fan Is OFF _TenQuat: {0},Mau: {1},BanKinh: {2}", name, color, radius);
            else
                return string.Format("Fan Is ON  _TenQuat: {0},Mau: {1},BanKinh: {2},TocDo: {3}", name, color, radius, speed);
        }
    }


}
