namespace DatatypeConversionAndTypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type-casting
            // implicit type-casting (widening conversion bool -> char -> short -> int -> long -> float -> double). Automatic conversion of a smaller data type to a larger data type. No data loss occurs during this conversion.
            // explicit type-casting (narrowing conversion double -> float -> long -> int -> short -> char -> bool). Manual conversion of a larger data type to a smaller data type. Data loss may occur during this conversion if the value being converted exceeds the range of the target data type.


            // implicit type-casting example
            int num1 = 10;
            double num2 = num1; // implicit type-casting from int to double

            char acii_1 = 'A';
            int acii_num1 = acii_1; // implicit type-casting from char to int (ASCII value of 'A' is 65) 

            // explicit type-casting example
            double pi = 3.14159;
            int pi_int = (int)pi; // explicit type-casting from double to int (data loss occurs, pi_int will be 3)

            int acii_num2 = 65;
            char acii_2 = (char)acii_num2; // explicit type-casting from int to char (ASCII value of 65 is 'A')4

            Console.WriteLine(Convert.ToInt32(Console.ReadLine()).GetType());
            
        }
    }
}
