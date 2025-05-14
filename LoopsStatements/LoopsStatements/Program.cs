using System;
using System.Xml.Linq;

namespace LoopStatements 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //while loop - repeats some code while some codition (in while condition) remains true:

            //Console.Write("Enter your name: ");
            //String name = Console.ReadLine();

            //while (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)) 
            //{
            //    Console.Write("Please enter your name: ");
            //    name = Console.ReadLine();
            //}

            //Console.WriteLine($"\nHello {name}!");

            //Console.ReadKey();


            //for loop - repeats some code a Finite amount of times

            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine($"i[{(i - 1)}] = {i}");
            //}

            //for (int j = 10; j > 0; j--) 
            //{
            //    Console.WriteLine(j);
            //    Thread.Sleep(1000);
            //}

            //Console.WriteLine("HAPPY BORNDAY!!!");


            //Console.ReadKey();


            //do while loop - repeats some code while some condition (in while condition) remains true, but it will always run AT LEAST once:

            //Console.Write("Enter your name: ");
            //String name2 = Console.ReadLine();
            //do
            //{

            //    if (String.IsNullOrEmpty(name2) || String.IsNullOrWhiteSpace(name2))
            //    {
            //        Console.Write("Please enter your name: ");
            //        name2 = Console.ReadLine();
            //    }

            //} while (String.IsNullOrEmpty(name2) || String.IsNullOrWhiteSpace(name2));

            //Console.WriteLine($"\nHello {name2}!");

            //Console.ReadKey();

            //Nested loop = a loop inside another loop:

            Console.Write("Enter number of rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns?: ");
            int col = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter what symbol to use?: ");
            String symbol = Console.ReadLine().Substring(0, 1);
            Console.WriteLine();

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < col; j++) 
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }
    }
}