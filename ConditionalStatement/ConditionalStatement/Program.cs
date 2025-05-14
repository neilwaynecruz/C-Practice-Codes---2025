using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    public class Program
    {
        static void Main(string[] args)
        {
            // if statement = a basic form of decision making


            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age >= 90)
            //{
            //    Console.WriteLine("Fuck, You're too old!");
            //}
            //else if (age >= 18)
            //{
            //    Console.WriteLine("You're an adult!");
            //}
            //else if (age >= 13)
            //{
            //    Console.WriteLine("You're a teenager!");
            //}
            //else
            //{
            //    Console.WriteLine("You're a minor");
            //}

            //Console.Write("Enter your name: ");
            //String name = Console.ReadLine();
            //String name2 = "Neil";

            //if (name == "")
            //{
            //    Console.WriteLine("You haven't input your name bro");
            //}
            //else
            //{
            //    Console.WriteLine($"Hello, {name}!!!");
            //}

            //Console.ReadKey();


            // switch = an efficient alternative to many else if statements

            Console.Write("What day is it today? ");
            String day = Console.ReadLine();

            if (String.IsNullOrEmpty(day) || String.IsNullOrWhiteSpace(day))
            {
                Console.WriteLine("You haven't input a day");
                return; // return just exit the program because we are in the main method
            }

            day = char.ToUpper(day[0]) + day.Substring(1).ToLower();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine($"It's {day}, the start of the week!");
                    break;
                case "Tuesday":
                    Console.WriteLine($"It's {day}, the second day of the week!");
                    break;
                case "Wednesday":
                    Console.WriteLine($"It's {day}, the middle of the week!");
                    break;
                case "Thursday":
                    Console.WriteLine($"It's {day}, the fourth day of the week!");
                    break;
                case "Friday":
                    Console.WriteLine($"It's {day}, the end of the work week!");
                    break;
                case "Saturday":
                    Console.WriteLine($"It's {day}, the weekend is here!");
                    break;
                case "Sunday":
                    Console.WriteLine($"It's {day}, the last day of the week!");
                    break;
                default:
                    Console.WriteLine($"{day} is not a valid day of the week");
                    break;
            }
        }
    }
}
