using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndOverloadConstructor
{
    public class Car
    {
        
        string model;
        public static int numberOfCars;
        public Car(string model) 
        {
            this.model = model;
            numberOfCars++;
        }

        public string getModel()
        {
            return model;
        }

        public static int getNumberOfCars()
        {
            return numberOfCars;
        }
    }
}
