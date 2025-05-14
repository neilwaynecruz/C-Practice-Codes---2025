namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Car car = new Car();
            Bike bike = new Bike();
            Boat boat = new Boat();

            car.speed = 60;
            bike.speed = 20;
            boat.speed = 40;

            Console.WriteLine($"Car speed: {car.speed}");
            Console.WriteLine($"Car wheel: {car.wheel}");
            car.Go();

            Console.WriteLine();
            Console.WriteLine($"Bike speed: {bike.speed}");
            Console.WriteLine($"Bike wheel: {bike.wheel}");
            bike.Go();


            Console.WriteLine();
            Console.WriteLine($"Boat speed: {boat.speed}");
            Console.WriteLine($"Boat wheel: {boat.wheel}");
            boat.Go();

        }
    }
}
