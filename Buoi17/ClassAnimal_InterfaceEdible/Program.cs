using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal_InterfaceEdible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Tiger();
            animals[1] = new ChickenA();
            animals[2] = new ChickenB();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());

                if (animal is ChickenB)
                {
                    Edible edibler = (ChickenB)animal;
                    Console.WriteLine(edibler.HowToEat());
                }
            }

            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Apple();
            fruits[1] = new Orange();

            foreach (Fruit fruid in fruits)
            {
                Console.WriteLine(fruid.HowToEat());
            }

            Console.ReadKey();
        }
    }
}
