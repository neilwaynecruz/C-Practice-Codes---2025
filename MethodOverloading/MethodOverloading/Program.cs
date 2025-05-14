using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overloading = methods share name but, different parameters
            //                      name + parameters = signature
            //                      methods must have unique signature


            //double total = Multiply(2,4);
            //double total2 = Multiply(2,4,6);

            //Console.WriteLine(total);
            //Console.WriteLine(total2);


            // params keyword = a method parameter that takes a variable number of arguments.

            double total = CheckOut(1,2,3,4,5,6,7,8,9,10);
            Console.WriteLine(total);


        }

        //static double Multiply(double a, double b) 
        //{
        //    return a * b;
        //}

        //static double Multiply(double a, double b, double c) // same name different parameters
        //{
        //    return a * b * c;
        //}


        static double CheckOut(params double[] prices) 
        {
            double M_Total = 0;

            foreach (double price in prices)
            {
                M_Total += price;
            }

            return M_Total;
        }

    }
}
