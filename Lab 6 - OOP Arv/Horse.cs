using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Horse : Animal
    {
        public string ManeColor { get; set; } = "Various";

        public Horse(string name, int age, string maneColor) : base(name, age, "Horse", "Various", true)
        {
            ManeColor = maneColor;
        }

        public void makeSound()
        {
            Console.WriteLine($"{Name} the Horse with the {ManeColor} colored mane neighs: Neigh!");
        }
    }
}
