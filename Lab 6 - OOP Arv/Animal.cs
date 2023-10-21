using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Animal
    {
        public string Name { get; set; } = "Animal";
        public int Age { get; set; } = 0;
        public string Color { get; set; } = "Unknown";
        public string Species { get; set; } = "Unknown";
        public bool IsMammal { get; set; } = true;

        public Animal(string name, int age, string color, string species, bool isMammal)
        {
            Name = name;
            Age = age;
            Color = color;
            Species = species;
            IsMammal = isMammal;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
        
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public void Reproduce()
        {
            Console.WriteLine($"{Name} is reproducing.");
        }
    }
}
