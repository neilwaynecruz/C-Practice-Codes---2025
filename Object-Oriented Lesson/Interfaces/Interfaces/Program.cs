namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that every classes that inheriting should implement it
            // interface = a reference type similar to class that can contain only constants, method signatures, events and indexers
            // you cannot create an instance of an interface

            // An interface declares "What a class should have and do"
            // an inheriting class define "How a class should do it"

            // benefit = security + multiple inheritance + "plug-and-play" + polymorphism


            Rabbit rabbit = new Rabbit();
            rabbit.Eat();
            rabbit.Run();
            rabbit.Sleep();

            Wolf wolf = new Wolf();
            wolf.Eat();
            wolf.Hunt();
            wolf.Sleep();

            Fish fish = new Fish();
            fish.Eat();
            fish.Hunt();
            fish.Run();
            fish.Sleep();




        }
    }

    interface IAnimal
    {
        // interface members are public by default
        void Eat();
        void Sleep();
    }

    interface IPredator : IAnimal
    {
        void Hunt();
    }

    interface IPrey : IAnimal
    {
        void Run();
    }

    public class Rabbit : IPrey
    {
        public void Eat()
        {
            Console.WriteLine("Rabbit is eating");
        }
        public void Run()
        {
            Console.WriteLine("Rabbit is running");
        }
        public void Sleep()
        {
            Console.WriteLine("Rabbit is sleeping");
        }
    }

    public class Wolf : IPredator
    {
        public void Eat()
        {
            Console.WriteLine("Wolf is eating");
        }
        public void Hunt()
        {
            Console.WriteLine("Wolf is hunting");
        }
        public void Sleep()
        {
            Console.WriteLine("Wolf is sleeping");
        }

    }
    public class Fish : IPredator, IPrey
    {
        public void Eat()
        {
            Console.WriteLine("Fish is eating");
        }
        public void Hunt()
        {
            Console.WriteLine("Fish is hunting");
        }
        public void Run()
        {
            Console.WriteLine("Fish is running");
        }
        public void Sleep()
        {
            Console.WriteLine("Fish is sleeping");
        }
    }

}
