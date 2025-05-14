namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0.0;
            double num2 = 0.0;
            double result = 0.0;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Welcome to C# Calculator!!");
            Console.WriteLine("-------------------------");

            bool is_Running = true;

            while (is_Running) 
            {
                Console.Write("Enter a 1st number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a 2nd number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an operation:");
                Console.WriteLine("\t+ : ADDITION");
                Console.WriteLine("\t- : SUBTRACT");
                Console.WriteLine("\t* : MULTIPLICATION");
                Console.WriteLine("\t/ : DIVISION");
                Console.WriteLine("\t% : MODULO(REMAINDER)");
                Console.Write(": ");
                String operation = Console.ReadLine().Substring(0,1);

                if ((String.IsNullOrEmpty(operation) || String.IsNullOrWhiteSpace(operation)) || 
                    (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "%"))  
                {
                    Console.WriteLine("Invalid operation\n");
                    continue;
                }


                if ((operation == "/" || operation == "%") && num2 == 0)
                {
                    Console.WriteLine("In the case of division or modulo operator, YOU CAN'T divide by 0\n");
                    continue;
                }

                result = operation switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    "*" => num1 * num2,
                    "/" => num1 / num2,
                    "%" => num1 % num2,
                };

                if (operation == "+")
                {
                    Console.WriteLine($"Result: {num1} + {num2} = {result}\n");
                }
                else if (operation == "-")
                {
                    Console.WriteLine($"Result: {num1} - {num2} = {result}\n");
                }
                else if (operation == "*")
                {
                    Console.WriteLine($"Result: {num1} * {num2} = {result}\n");
                }
                else if (operation == "/")
                {
                    Console.WriteLine($"Result: {num1} / {num2} = {result}\n");
                }
                else if (operation == "%")
                {
                    Console.WriteLine($"Result: {num1} % {num2} = {result}\n");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again!\n");
                    continue;
                }

                    while (true) 
                    {
                        Console.Write("Want to try again? [Y/N]: ");
                        String choice = Console.ReadLine().ToUpper();

                        if ((String.IsNullOrEmpty(choice) || String.IsNullOrWhiteSpace(choice)) || (choice != "Y" && choice != "N"))
                        {
                            Console.WriteLine("Invalid input. Please try again!\n");
                            continue;
                        }

                        if (choice.Substring(0, 1) == "Y")
                        {
                            break;
                        }
                        else 
                        {
                            is_Running = false;
                            break;
                        }

                    }

                Console.Clear();

            }
            Console.WriteLine("END OF PROGRAM!!");
        }
    }
}
