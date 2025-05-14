namespace ArrayOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {new Person("Alice", 30), new Person("Bob", 25), new Person("Charlie", 35)};

            foreach (Person tao in people)
            {
                Console.WriteLine($"Name: {tao.Name}, Age: {tao.Age}");
            }

        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
