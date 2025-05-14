using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputUser
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hello " + name + "!!");
            //Console.WriteLine("You are " + age + " years old.");

            //Console.ReadKey();

            double num1 = 16.00;
            double num2 = 25.00;
            int num3 = 3;
            int num4 = -23;
            double num5 = 13.456;

            Console.WriteLine("\nSquare root of " + num1 + " is: " + Math.Sqrt(num1));
            Console.WriteLine("The maximum between num1 and num2 is: " + (Math.Max(num1, num2) == num1 ? "num1 = " + num1 : "num2 = " + num2));
            Console.WriteLine("The minimum between num1 and num2 is: " + (Math.Min(num1, num2) == num1 ? "num1 = " + num1 : "num2 = " + num2));
            Console.WriteLine("The 3rd power of " + num3 + " is: " + Math.Pow(num3,3));
            Console.WriteLine("The absolute value of " + num4 + " is: " + Math.Abs(num4)); 
            Console.WriteLine("The rounded value of " + num5 + " is: " + Math.Round(num5,2)); //this round up the number up to the given the number decimal point
            Console.WriteLine("The ceil round of " + num5 + " is: " + Math.Ceiling(num5)); // this always round up
            Console.WriteLine("The floor round of " + num5 + " is: " + Math.Floor(num5)); // this always round 


            Console.ReadKey();
        }
    }
}
