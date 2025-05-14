using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Human
    {
        public String name;
        public int age;
        public double GWA;
        public String address;

        public Human()
        {
            this.name = "Unkown";
            this.age = 0;
            this.GWA = 0.0;
            this.address = "Uknown";
        }

        public Human(String name, int age, double GWA,String address)
        {
            this.name = name;
            this.age = age;
            this.GWA = GWA;
            this.address = address;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }

        public void Describe()
        {
            Console.WriteLine($"{name} is {age} years old with {GWA} Gwa and lived at {address}");
        }

    }
}
