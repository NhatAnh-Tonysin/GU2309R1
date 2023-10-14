using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            /////Chỉ số khối cơ thể (Body mass index-BMI) là một thước đo sức khoẻ dựa trên cân nặng và chiều cao. Nó được tính bằng cách lấy cân nặng đơn vị tính kilogam chia cho bình phương của chiều cao đơn vị tính mét. Công thức: bmi = weight / height^2
            ///

            double bmi,height, weight;

        nhap:
            Console.WriteLine("Body mass index-BMI");
            Console.Write("Please enter a height: ");
            height = float.Parse(Console.ReadLine());

            Console.Write("Please enter a weight: ");
            weight = float.Parse(Console.ReadLine());


            bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);


            Console.Write("BMI: " + bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine(" Underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine(" Normal");
            }
            else if (bmi < 30)
            {
                Console.WriteLine(" Overweight");
            }
            else
            {
                Console.WriteLine(" Obese");
            }

            goto nhap;
        }
    }
}
