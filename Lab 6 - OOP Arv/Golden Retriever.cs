using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    internal class Golden_Retriever : Dog
    {
        public bool Drooling { get; set; } = true;

        public Golden_Retriever(string name, int age, bool drooling) : base(name, age, "Golden Retriever")
        {
            Drooling = drooling;
        }

        public void Shed()
        {
            Console.WriteLine($"{Name} the Golden Retriever {(Drooling ? "is drooling a lot and also" : "doesn't drool at all but")} sheds a lot.");
        }
    }
}
