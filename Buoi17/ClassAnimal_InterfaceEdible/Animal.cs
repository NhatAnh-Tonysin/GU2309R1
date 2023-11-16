using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal_InterfaceEdible
{
    public abstract class Animal
    {
        public abstract string MakeSound();
    }

    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrrr...";
        }

    }

    public class ChickenA : Animal
    {
        public override string MakeSound()
        {
            return "ChickenA: cluck-cluck....";
        }
    }

    public class ChickenB : Animal, Edible
    {
        public override string MakeSound()
        {
            return "ChickenB: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }

}
