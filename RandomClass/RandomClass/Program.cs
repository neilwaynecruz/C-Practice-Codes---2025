using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            //here the random class is used to generate random numbers

            // here both return integers between 1 and 10, and between 11 and 20
            //int random1 = random.Next(1, 11); // 1 inclusive, 11 
            //int random2 = random.Next(11, 21); // 11 inclusive, 21 exclusive

            // return a double between 0.0 and 1.0
            //double random3 = random.NextDouble(); // returns a double between 0.0 and 1.0 
            //double random4 = random.NextDouble() * (10.0 - 1.0) + 1.0; // returns a double between 1.0 and 10.0

            //Console.WriteLine(random1);
            //Console.WriteLine(random2);
            //Console.WriteLine(random3);
            //Console.WriteLine(random4);

            double a;
            double b;

            do
            {
                // Determine the hypotenuse of the right triangle

                Console.Write("Enter the value of a (leg): ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the value of b (leg): ");
                b = Convert.ToDouble(Console.ReadLine());

                // Calculate the hypotenuse using the Pythagorean theorem
                double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                // Display the result
                Console.WriteLine($"The hypotenuse is approximately: {Math.Round(c, 5)}\n");
                Console.ReadKey();

            } while (a != 0 && b != 0);



        }
    }
}
