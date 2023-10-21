using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Cat : Animal
    {
        public bool IsAsshole { get; set; } = true;

        public Cat(string name, int age, bool isAsshole) : base(name, age, "Cat", "Various", true)
        {
            IsAsshole = isAsshole;
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purring.");
        } 

        public void makeSound()
        {
            Console.WriteLine($"{Name} {(IsAsshole ? "the asshole cat" : "the not so asshole cat")} meows: Meow!");
        }
    }
}
