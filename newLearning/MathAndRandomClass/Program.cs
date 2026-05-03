namespace MathAndRandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Math class
            double x = 3;
            double y = 3;

            Console.WriteLine($"Pow = {Math.Pow(x,y)}");
            Console.WriteLine($"Sqrt = {Math.Sqrt(x)}");
            Console.WriteLine($"Abs = {Math.Abs(-3)}");
            Console.WriteLine($"Round = {Math.Round(3.136,2)}");
            Console.WriteLine($"Floor = {Math.Floor(3.54)}");
            Console.WriteLine($"Ceiling = {Math.Ceiling(3.14)}");
            Console.WriteLine($"Max = {Math.Max(2,3)}");
            Console.WriteLine($"Min = {Math.Min(2,3)}");
            Console.WriteLine($"Sign = {Math.Sign(-3)}");
            Console.WriteLine($"Truncate = {Math.Truncate(3.14)}");
            Console.WriteLine($"PI = {Math.PI}");
            Console.WriteLine($"E = {Math.E}");
            Console.WriteLine($"Cos = {Math.Cos(x)}");
            Console.WriteLine($"Sin = {Math.Sin(x)}");
            Console.WriteLine($"Tan = {Math.Tan(x)}");
            Console.WriteLine($"Log = {Math.Log(x)}");
            Console.WriteLine($"Log10 = {Math.Log10(x)}");
            Console.WriteLine($"Exp = {Math.Exp(x)}");

            Console.ReadKey();
            Console.ReadKey();

            // Random class
            Random rand = new Random();
            
            Console.WriteLine(rand.Next(1,6)); // returns a non-negative random integer (1, 2, 3, 4, or 5). 6 is exclusive
            Console.WriteLine(rand.NextDouble()); // returns a random floating-point number between 0.0 and 1.
            Console.WriteLine(Convert.ToInt32(rand.NextDouble() * 100 + 1)); // returns a random integer between 1 and 100. The expression rand.NextDouble() * 100 generates a random floating-point number between 0.0 and 100.0, and adding 1 shifts the range to be between 1.0 and 101.0. Finally, Convert.ToInt32 rounds it down to the nearest integer, resulting in a value between 1 and 100.

        }
    }
}
