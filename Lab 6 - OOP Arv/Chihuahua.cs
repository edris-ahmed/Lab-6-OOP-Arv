using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Chihuahua : Dog
    {
        public bool IsAggressive { get; set; } = true;

        public Chihuahua(string name, int age, bool isAggressive) : base(name, age, "Chihuahua") 
        {
            IsAggressive = isAggressive;
        }

        public void EatMyFingers() 
        {
            Console.WriteLine($"{Name} the Chihuahua is {(IsAggressive ? "very aggressive and will eat my fingers" : "very chill and loves to get pets")}.");
        }
    }
}
