using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {


            //Variables and Datatypes

            //Numbers Dataypes
            // int = all whole numbers (example: 1, 2, 3, 4, 5 and so on)
            // float = all decimal numbers (example: 1.0, 2.0, 3.0, 4.0, 5.0 and so on )
            // double = all decimal numbers (example: 1.0, 2.0, 3.0, 4.0, 5.0 and so on ) with high precision

            // Letters Datatypes
            // char = single character (example: 'a', 'b', 'c', 'd', 'e' and so on)
            // string = all characters (example: "hello", "world", "my name is Neil Wayne Cruz")

            // Boolean Datatypes
            // bool = true or false (example: true, false)

            // Object Datatypes
            // var = variable (example: var name = "Neil Wayne Cruz") automatically detects the datatype

            // Constants
            // const = constant (example: const int num = 10) cannot be changed/ immutable 

            // Nullable types
            // int? = nullable int (example: int? num = null) can be null
            // Nullable types are used when you want to assign a null value to a variable

            // DATATYPES
            //int num1; //declaration variable
            //num1 = 10; //initialization variable
            //int num2 = 20; //declaration and initialization of  variable
            //String name = "Neil Wayne Cruz";
            //double gpa = 1.25; // a floating point number like float but with more precision
            //char g_letter = 'A';
            //bool isAdult = true;
            //int sum = num1 + num2; //sum of two numbers

            //Console.WriteLine("The value for num1 is: " + num1);
            //Console.WriteLine("The value for num2 is: " + num2);
            //Console.WriteLine("My name is: " + name);
            //Console.WriteLine("My gpa is: " + gpa);
            //Console.WriteLine("My grade letter is: " + g_letter);
            //Console.WriteLine("Am I an adult? " + isAdult);
            //Console.WriteLine("The sum of num1 and num2 is: " + sum);

            //Console.ReadKey(); // this is like getche in c


            // CONSTANTS

            //const double pi = 3.14; // pi is a constant value. As well as in real life, the value of pi is constant, it's not changing at all.

            //Console.WriteLine("The value of PI is: " + pi);

            //pi = 3.14159; // this will give an error because pi is a constant value and cannot be changed


            // TYPECASTING

            // type casting = converting one data type to another. It is useful when we accept user input (String)
            //                different data types are used in different things/situations

            // implicit type casting = converting a smaller data type to a larger data type (example: int to float)
            // explicit type casting = converting a larger data type to a smaller data type (example: float to int)

            // when converting a larger data type to a smaller data type, we need to use explicit type casting ex: int b = (int)a;
            // when converting a smaller data type to a larger data type, we can use implicit type casting ex: double y = x;


            double a = 3.14;
            //int b = (int)a; // explicit type casting (or)
            int b = Convert.ToInt32(a); 

            int x = 14;
            //double y = x; // implicit type casting (or)
            double y = Convert.ToDouble(x); 

            int e = 123456789;
            String f = Convert.ToString(e); // explicit type casting

            String symbol = "$";
            char letter = Convert.ToChar(symbol);// explicit type casting

            String h = "true";
            bool i = Convert.ToBoolean(h); // explicit type casting


            Console.WriteLine("The value of a is: " + a);
            Console.WriteLine("The value of b is: " + b);
            Console.WriteLine("The value of x is: " + x);
            Console.WriteLine("The value of y is: " + y);
            Console.WriteLine("The value of e is: " + e);
            Console.WriteLine("The value of f is: " + f);
            Console.WriteLine("The value of symbol is: " + symbol);
            Console.WriteLine("The value of letter is: " + letter);
            Console.WriteLine("The value of h is: " + h);
            Console.WriteLine("The value of i is: " + i);

            Console.WriteLine("\n");

            Console.WriteLine("Type of a: " + a.GetType());
            Console.WriteLine("Type of b: "+ b.GetType());
            Console.WriteLine("Type of x: " + x.GetType());
            Console.WriteLine("Type of y: " + y.GetType());
            Console.WriteLine("Type of e: " + e.GetType());
            Console.WriteLine("Type of f: " + f.GetType());
            Console.WriteLine("Type of symbol: " + symbol.GetType());
            Console.WriteLine("Type of letter: " + letter.GetType());
            Console.WriteLine("Type of h: " + h.GetType());
            Console.WriteLine("Type of i: " + i.GetType());

            Console.ReadKey();

        }
    }
}
