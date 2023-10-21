using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Dog : Animal
    {
        public string Breed { get; set; } = "Unknown";

        public Dog(string name, int age, string breed) : base(name , age, "Dog", "Various", true)
        {
            Breed = breed;
        }

        public void makeSound()
        {
            Console.WriteLine($"{Name} the {Breed} is barking: Woof! Woof!");
        }
    }
}
