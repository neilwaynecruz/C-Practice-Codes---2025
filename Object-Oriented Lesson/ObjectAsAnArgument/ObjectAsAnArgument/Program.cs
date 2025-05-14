namespace ObjectAsAnArgument
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Chevrolet", "Corvette", "Blue");

            changeColor(car1, "Red");

            Console.WriteLine($"Car1 make: {car1.make}, model: {car1.model}, color: {car1.color}");

            Car car2 = Copy(car1);
            changeColor(car2, "Indigo");
            Car car3 = Copy(car2);
            changeColor(car3, "Violet");
            Console.WriteLine($"Car2 make: {car2.make}, model: {car2.model}, color: {car2.color}");
            Console.WriteLine($"Car3 make: {car3.make}, model: {car3.model}, color: {car3.color}");

        }

    public static void changeColor(Car car, String color)
        {
            car.color = color;
        }

    public static Car Copy(Car car)
        {
            return new Car(car.make, car.model, car.color);
        }
    }

    public class Car
    {
        public String make;
        public String model;
        public String color;
        public Car(String make, String model, String color)
        {
            this.make = make;
            this.model = model;
            this.color = color;
        }
    }
}
