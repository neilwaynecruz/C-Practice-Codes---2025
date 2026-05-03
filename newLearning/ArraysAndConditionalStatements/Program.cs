namespace ArraysAndConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            // ARRAYS

            // declare with values
            //string[] names = new string[4];
            //names[0] = Console.ReadLine();
            //names[1] = Console.ReadLine();
            //names[2] = Console.ReadLine();
            //names[3] = Console.ReadLine();

            //// declare with size and assign values later
            //int[] numbers = new int[3];
            //numbers[0] = Convert.ToInt32(Console.ReadLine());
            //numbers[1] = Convert.ToInt32(Console.ReadLine());
            //numbers[2] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Names: {{ {names[0]},{names[1]},{names[2]},{names[3]} }}");
            //Console.WriteLine($"Numbers: {{ {numbers[0]},{numbers[1]},{numbers[2]} }}\n\n");

            //Console.ReadKey();

            //string[] email = { "neil@gmail.com", "wayne@gmail.com", "tubillara@gmail.com" };
            //string[] username = { "neil14", "wayne15", "tubillara16" };
            //string[] password = { "neil0514", "wayne0515", "tubillara0516" };

            //Console.Write("Enter index number: ");
            //int index = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Index    : {index}");
            //Console.WriteLine($"email    : {email[index]}");
            //Console.WriteLine($"username : {username[index]}");
            //Console.WriteLine($"password : {password[index]}\n\n\n\n");
            //Console.ReadKey();


            // CONDITIONAL STATEMENTS

            // relational operators: ==, !=, >, <, >=, <=
            // conditional operators: &&, ||, !


            //Console.Write("Enter your age: ");
            //string ageInput = Console.ReadLine();
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //if (int.TryParse(ageInput, out int age) && (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrEmpty(name)))
            //{
            //    if (age >= 18)
            //    {
            //        Console.WriteLine($"You are an adult {name}.");
            //    }
            //    else if (age >= 13)
            //    {
            //        Console.WriteLine($"You are a teenager {name}.");
            //    }
            //    else if (age >= 0)
            //    {
            //        Console.WriteLine($"You are a child {name}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}
            //Console.WriteLine("\n\n\n\n");
            //Console.ReadKey();
            //string[] arrUsernames = { "neil14", "wayne15", "tubillara16" };
            //Console.WriteLine("Enter Username: ");
            //string username = Console.ReadLine();

            //if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrEmpty(username))
            //{
            //    if (username.Equals(arrUsernames[0], StringComparison.OrdinalIgnoreCase) || 
            //        username.Equals(arrUsernames[1], StringComparison.OrdinalIgnoreCase) ||
            //        username.Equals(arrUsernames[0], StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"Welcome {username}!");
            //    }
            //    else 
            //    {                     
            //        Console.WriteLine("Username not found.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            // GRADE AVERAGE PROGRA
            double[] grades = new double[4];
            Console.WriteLine("Grade Average Program\n");
            Console.Write("English : ");
            grades[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Math    : ");
            grades[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Science : ");
            grades[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Computer: ");
            grades[3] = Convert.ToDouble(Console.ReadLine());

            double ave = (grades[0] + grades[1] + grades[2] + grades[3]) / grades.Length;
            Console.WriteLine($"\nAverage: {ave:F2}");
            if (ave > 100) Console.WriteLine("Invalid Grade");
            else if (ave >= 98.00) Console.WriteLine("Remarks: With Highest Honors");
            else if (ave >= 95.00) Console.WriteLine("Remarks: With High Honors");
            else if (ave >= 90.00) Console.WriteLine("Remarks: With Honors");
            else if (ave >= 75.00) Console.WriteLine("Remarks: Passed");
            else if (ave >= 0.00)  Console.WriteLine("Remarks: Failed");
            else Console.WriteLine("Invalid Grade");
        }
    }
}
