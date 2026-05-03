
using System;
using System.Collections.Generic;

namespace VariablesDatatypesUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Welcome to Variables and Datatypes in {(char) Console.Read()}!\n");// display ascii value if not casted or converted to char
            //Console.Write("Enter your name: ");
            //String name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter your GWA: ");
            //float gwa = Convert.ToSingle(Console.ReadLine()); // lower precision than double
            //Console.Write("Enter value of pi (3.14159265358979): ");
            //double pi = Convert.ToDouble(Console.ReadLine()); // higher precision than float
            //Console.Write("Enter your sex [M/F]: ");
            //char sex = Convert.ToChar(Console.ReadLine()); 

            //Console.WriteLine($"\nHi my name is {name}\ni'm already {age} Year/s old.\nMy GWA is {gwa}\nMy sex is {sex}\n" +
            //    $"and the value of PI for is {pi}");


            Console.WriteLine("Enter a letter: ");
            char letter = Console.ReadKey().KeyChar;

            Console.WriteLine("\n" + letter);
        }
    }
}
