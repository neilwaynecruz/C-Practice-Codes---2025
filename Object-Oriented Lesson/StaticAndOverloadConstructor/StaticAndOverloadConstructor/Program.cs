namespace StaticAndOverloadConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static = a modifier used to declare a static member, which belongs to the class itself
            //         rather than to any specific object

            //        all static variables and method belongs to it's class and can be called/accessed by
            //        the name of the class rather than the object name.

            //Car car1 = new Car("Mustang");
            //Car car2 = new Car("Corvette");
            //Car car3 = new Car("Dodge Challenger");

            //Console.WriteLine(car1.getModel());
            //Console.WriteLine(car2.getModel());
            //Console.WriteLine(Car.getNumberOfCars());


            //overload constructor = technique to create multiple constructors, with a different set of parameters.
            //                       name + parameters = signature



            // without arguments
            Pizza pizza1 = new Pizza();
            Console.WriteLine($"Pizza 1: {pizza1.getPizza()}");

            Pizza pizza2 = new Pizza("stuffed crust");
            Console.WriteLine($"Pizza 2: {pizza2.getPizza()}");

            Pizza pizza3 = new Pizza("stuffed crust","tomato sauce");
            Console.WriteLine($"Pizza 3: {pizza3.getPizza()}");

            Pizza pizza4 = new Pizza("stuffed crust", "tomato sauce","mozzarella cheese");
            Console.WriteLine($"Pizza 4: {pizza4.getPizza()}");

            Pizza pizza5 = new Pizza("stuffed crust", "tomato sauce", "mozzarella cheese","Pepperoni");
            Console.WriteLine($"Pizza 5: {pizza5.getPizza()}");
        }
    }
}
