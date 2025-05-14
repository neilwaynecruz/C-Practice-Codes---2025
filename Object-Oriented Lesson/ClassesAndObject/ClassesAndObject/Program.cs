

using System.ComponentModel;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // class = a bundle of related code.
            //         Can be used as a blueprint to create objects (OOP)


            //Messages.Hello();
            //Messages.Waiting();
            //Messages.Bye();


            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)


            //Human human = new Human("Neil Wayne Cruz",20,1.25, "26, Banuyo Street, Project 3, Quezon City");


            //human.Eat();
            //human.Sleep();
            //human.Describe();
            //Console.WriteLine();

            //Human human2 = new Human("Berto Tililing",44,1.00, "123 Street, Project 69, Quezon City");

            //human2.Eat();
            //human2.Sleep();
            //human2.Describe();
            //Console.WriteLine();

            Car car1 = new Car("Ford", "Mustang",2022,"Blue");
            car1.Drive();
            car1.Describe();

            Console.WriteLine();

            Car car2 = new Car("Toyota", "Land Cruiser", 2023, "Dark Grey");
            car2.Drive();
            car2.Describe();


        }
    }
}
