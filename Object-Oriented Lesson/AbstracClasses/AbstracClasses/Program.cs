namespace AbstracClasses
{
    public class Program
    {
        static void Main(string[] args)
        {

            // abstract class = modifier that makes a class incomplete and forces the user to implement the abstract class
            // you cannot create an object of an abstract class or instantiate it
            Car car = new Car();
            Boat boat = new Boat();
            bike bike = new bike();

        }
    }

   abstract class Vehicle
    {
        public int speed = 0;

        abstract public void Go();
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        public int maxspeed = 500;

        override
            public void Go()
        {
            Console.WriteLine("The car is going");
        }

    }

    class Boat : Vehicle
    {
        public int wheels = 6;
        public int maxspeed = 200;

        override
            public void Go()
        {
            Console.WriteLine("The boat is going");
        }
    }

    class bike : Vehicle
    {
        public int wheels = 8;
        public int maxspeed = 50;


        override
            public void Go()
        {
            Console.WriteLine("The bike is going");
        }

    }
}
