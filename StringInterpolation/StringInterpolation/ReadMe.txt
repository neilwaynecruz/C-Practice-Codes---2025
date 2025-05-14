namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal. It's like prinf in c, System.out.printf in java, f-string in python
            //                        precede a string literal with $
            //                        {} are placeholders

            // ex:                 Console.WriteLine($"{name}, hello!!")



            String firstname = "Neil Wayne";
            String lastname = "Cruz";
            int age = 19;

            Console.WriteLine($"Hello, {firstname} {lastname}!!");
            Console.WriteLine($"You are {Console.ReadLine()} years old");
        }
    }
}
