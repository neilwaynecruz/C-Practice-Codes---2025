namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // exception = errors that occur during program execution. it is a unexpected error
            //             situation

            // try = try some code that is considered "dangerous" like file handling,multi-threading
            // catch = catches and handles exception when they occur
            // finally = always executes regardless if exception is caught or not

            try
            {
                Console.Write("Enter a 1st number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a 2nd number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int quotient = num1 / num2;
                Console.WriteLine(quotient);
            }
            catch (FormatException e)
            {
                Console.WriteLine("You haven't input anything yet DUMMY!!");
                Console.WriteLine("Error: " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by 0 DUMMY!!");
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!!");
                Console.WriteLine("Error: " + e.Message);
            }
            finally 
            {
                Console.WriteLine("THIS WILL ALWAYS BE EXECUTED!!");
            }

        }
    }
}
