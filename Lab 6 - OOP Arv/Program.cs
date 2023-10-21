namespace Lab_6___OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal("Generic Animal", 5, "Various", "Various", true);
            Horse myHorse = new Horse("Spirit", 5, "blonde");
            Dog myDog = new Dog("Max", 8, "German Shepherd");
            Cat myCat = new Cat("Milo", 13, false);
            Chihuahua chihuahua = new Chihuahua("Coco", 1, true);
            Golden_Retriever golden_Retriever = new Golden_Retriever("Rex", 5, false);


            genericAnimal.Reproduce();
            myDog.makeSound();
            myCat.makeSound();
            chihuahua.makeSound();
            chihuahua.EatMyFingers();
            myHorse.makeSound();
            golden_Retriever.makeSound();
            golden_Retriever.Shed();



            

        }
    }
}