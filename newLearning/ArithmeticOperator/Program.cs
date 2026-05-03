using System.Numerics;

namespace ArithmeticOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators (highest precedence to lowest)
            // 1. Parentheses ( )
            // 2. Unary operators: +, -, ++, -- (right to left)
            // 3. Multiplicative operators: *, /, % (left to right)
            // 4. Additive operators: +, - (left to right)
            // 5. Assignment operators: =, +=, -=, *=, /=, %= (right to left)
            // 6. Conditional operator: ? : (right to left)
            // 7. Null-coalescing operator: ?? (right to left)
            // 8. Null-coalescing assignment operator: ??= (right to left)
            // 9. Lambda operator: => (right to left

            float a = 5f;
            float b = 10f;
            float c = 15f;

            Console.WriteLine($"a = {a} and b = {b}");
            Console.WriteLine("Sum: " + (a + b));
            Console.WriteLine("Difference: " + (a - b));
            Console.WriteLine("Product: " + (a * b));
            Console.WriteLine("Quotient: " + (a / b));
            Console.WriteLine("Remainder: " + (a % b));
            Console.WriteLine("Post-Increment plus: " + (a++));
            Console.WriteLine("Pre-Increment plus: " + (++a));
            Console.WriteLine("Post-Decrement minus: " + (b--));
            Console.WriteLine("Pre-Decrement minus: " + (--b));
            Console.WriteLine("c+=2: " + (c += 2));
            Console.WriteLine("c-=2: " + (c -= 2));
            Console.WriteLine("c*=2: " + (c *= 2));
            Console.WriteLine("c/=2: " + (c /= 2));
            Console.WriteLine("c%=2: " + (c %= 2));
            Console.ReadKey();

            Console.WriteLine("\n\nAvarage Calculator\n");
            Console.Write("English : ");
            float engGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Math    : ");
            float mathGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Science : ");
            float sciGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Computer: ");
            float compGrade = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Average: {((engGrade + mathGrade + sciGrade + compGrade) / 4)}");



        }
    }
}
