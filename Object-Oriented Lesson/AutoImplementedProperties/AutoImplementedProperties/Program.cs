using System.Reflection;

namespace AutoImplementedProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // atuto-implemented properties = shortcut when no additional logic is needed in the getter or setter
            //                                you don't need to define a field for the property
            //                                you only have to write get; and set; inside the property

            Car car1 = new Car("BMW M3");
            Car car2 = new Car("BMW M4");

            car1.Model = "Lambo";
            car2.Model = "Ferrari";

            Console.WriteLine(car1.Model);
            Console.WriteLine(car2.Model);  

        }
    }

    class Car
    {

        public string Model { get; set; }
        public Car(string model)
        {
            Model = model;
        }
    }
}
