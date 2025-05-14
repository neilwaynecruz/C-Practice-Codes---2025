using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine($"This vehicle is moving");
        }
    }
}
