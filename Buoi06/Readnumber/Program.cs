using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Giả sử bạn đang tham gia viết chương trình cho máy đo chiều cao cân nặng, hãy viết một chương trình có khả năng đọc các số nguyên không âm có tối đa 3 chữ số.

            Ví dụ, với số 261, chương trình in ra màn hình two hundred and sixty one.
            */


            Console.WriteLine("Number Reading Program");
        input:
            Console.Write("Please enter the number with 3 numbers to read: ");
            int so = int.Parse(Console.ReadLine());


            int tram = so / 100;
            int chuc = (so / 10) % 10;
            int donvi = so % 10;
            int so_vt2 = so % 100;

            string spc = "No number";
            switch (so_vt2)
            {
                case 10: spc = "ten"; break;
                case 11: spc = "eleven"; break;
                case 12: spc = "twelve"; break;
                case 13: spc = "thirteen"; break;
                case 14: spc = "fourteen"; break;
                case 15: spc = "fifteen"; break;
                case 16: spc = "sixteen"; break;
                case 17: spc = "seventeen"; break;
                case 18: spc = "eightteen"; break;
                case 19: spc = "nineteen"; break;

            }


            string hunds = "No number";
            switch (tram)
            {
                case 1: hunds = "one hundred "; break;
                case 2: hunds = "two hundred "; break;
                case 3: hunds = "three hundred "; break;
                case 4: hunds = "four hundred "; break;
                case 5: hunds = "five hundred "; break;
                case 6: hunds = "six hundred "; break;
                case 7: hunds = "seven hundred "; break;
                case 8: hunds = "eight hundred "; break;
                case 9: hunds = "nine hundred "; break;
                default: hunds = "?"; break;
            }

            string tens = "No number";
            switch (chuc)
            {
                case 2: tens = "twenty "; break;
                case 3: tens = "thirty "; break;
                case 4: tens = "forty "; break;
                case 5: tens = "fifty "; break;
                case 6: tens = "sixty "; break;
                case 7: tens = "seventy "; break;
                case 8: tens = "eightty "; break;
                case 9: tens = "ninety "; break;
                default: tens = "?"; break;
            }


            string units = "No number";
            switch (donvi)
            {
                case 0: units = "zero "; break;
                case 1: units = "one "; break;
                case 2: units = "two "; break;
                case 3: units = "three "; break;
                case 4: units = "four "; break;
                case 5: units = "five "; break;
                case 6: units = "six "; break;
                case 7: units = "seven "; break;
                case 8: units = "eight "; break;
                case 9: units = "nine "; break;
                default: units = "?"; break;
            }



            if (so >= 100 && so < 1000)
            {
                if (so_vt2 >= 10 && so_vt2 < 20)
                {
                    Console.WriteLine(hunds + "and " + spc);
                }
                else if (so_vt2 >= 20)
                {
                    Console.WriteLine(hunds + "and " + tens + units);
                }
                else if (donvi < 10 && donvi != 0)
                {
                    Console.WriteLine(hunds + "and " + units);
                }
            }
            else
            {
                Console.WriteLine("out of ability");
            }




            if (so < 100 && so >= 20)
            {
                if (donvi > 0)
                {
                    Console.WriteLine(tens + units);
                }
                else
                    Console.WriteLine(tens);
            }




            if (so < 20 && so >= 10)
            {
                Console.WriteLine(spc);
            }




            if (so < 10 && so >= 0)
            {
                Console.WriteLine(units);
            }


            goto input;








        }
    }
}
