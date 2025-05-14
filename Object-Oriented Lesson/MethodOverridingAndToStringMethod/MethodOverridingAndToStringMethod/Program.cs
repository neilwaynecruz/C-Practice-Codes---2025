namespace MethodOverridingAndToStringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            // method overriding = provides a new version of method inherited from a parent class
            //                     inherited method must be (non-access modifier): abstract, virtual, or already overriden methods
            //                     Used to ToString(), polymorphism, and inheritance

            // ToString() = converts an object to its string representation so that it is suitable for display

            Animal animal = new Animal("Animal", 1);
            Dog dog = new Dog("Winter",3);
            Cat cat = new Cat("Muning",4);

            //dog.Speak();
            //cat.Speak();


            Console.WriteLine(animal.ToString());
            Console.WriteLine(dog.ToString());
            Console.WriteLine(cat.ToString());

        }
    }

   public class Animal
    {
       public String name;
        public int age;
       public Animal(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *BRRRR*");
        }

        public override string ToString()
        {
            return "Animal Class";
        }
    }
   public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) // constructor chaining
        {
        }
        public override void Speak()
        {
            Console.WriteLine("The dog goes *WOOF*");
        }

        public override string ToString()
        {
            return $"Dog: {name} and {age} years old";
        }
    }

   public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) // constructor chaining
        {
        }

        public override void Speak()
        {
            Console.WriteLine("The cat goes *MEOW*");
        }

        public override string ToString()
        {
            return $"Cat: {name} and {age} years old";
        }
    }
}
