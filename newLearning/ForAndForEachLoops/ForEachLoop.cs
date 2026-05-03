using System;
using System.Collections.Generic;
using System.Text;

namespace ForAndForEachLoops
{
    internal class ForEachLoop
    {
        public static void Main(string[] args)
        {
            //foreach loop

            //string[] names = { "Neil", "Wayne", "Winter", "Nathan" };



            //foreach(var name in names) 
            //{
            //    Console.WriteLine(name);
            //}

            int sum = 0;

            int[] numbers = {1,2,3,4,5,6,7,8,9,10};

            foreach (int i in numbers) 
            {
                sum += i;
            }

            Console.WriteLine("Total: " + sum);
        }
    }
}
