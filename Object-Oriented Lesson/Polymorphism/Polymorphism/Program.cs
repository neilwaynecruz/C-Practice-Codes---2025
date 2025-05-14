namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // polymorephism = A greek word that means to "Have many forms"
            //                 Objects can be identified by more than one type
            //                 ex: A Dog is also: Canine, Animal, Organism. In this case it has 4 forms, being a dog,canine,animal, and organism

            Vehicle[] vehicles = {new Car(), new Boat(), new Bicycle()}; 

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
        
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {
        }
        
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is going");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is going");
        }

    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is going");
        }
    }
}
