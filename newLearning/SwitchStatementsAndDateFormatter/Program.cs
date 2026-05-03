namespace SwitchStatementsAndDateFormatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Traditional Switch Statement. Can't float or double, can't use pattern matching, can't use relational patterns, can't use logical patterns, can't use switch expressions
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your letter Grade: ");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A': 
                    Console.WriteLine("Outstanding");
                    break;
                case 'B':
                    Console.WriteLine("Excellent");
                    break;
                case 'C':
                    Console.WriteLine("Satisfactory");
                    break;
                case 'D':
                    Console.WriteLine("Good");
                    break;
                case 'E':
                    Console.WriteLine("Needs Improvement");
                    break;
                case 'F':
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.WriteLine("\n\n\n");

            // DATE FORMATTER PROGRAM
            string[] validMonths = { "January", "February", "March", "April", "May", "June", "July",
                                     "August", "September", "October", "November", "December" };

            Console.Write("Month in number[1-12]:");
            int month = Convert.ToInt32(Console.ReadLine());

            if(month < 1 || month > 12)
            {
                Console.WriteLine("Invalid Month");
                return;
            }

            Console.Write("Date  :");
            int date = Convert.ToInt32(Console.ReadLine());

            if (date < 1 || date > 31)
            {
                Console.WriteLine("Invalid Date");
                return;
            }

            Console.Write("Year  :");
            int year = Convert.ToInt32(Console.ReadLine());


            switch (month) 
            {
                case 1:
                    Console.WriteLine($"{validMonths[0]} {date}, {year}");
                    break;
                case 2:
                    Console.WriteLine($"{validMonths[1]} {date}, {year}");
                    break;
                case 3:
                    Console.WriteLine($"{validMonths[2]} {date}, {year}");
                    break;
                case 4:
                    Console.WriteLine($"{validMonths[3]} {date}, {year}");
                    break;
                case 5:
                    Console.WriteLine($"{validMonths[5]} {date}, {year}");
                    break;
                case 6:
                    Console.WriteLine($"{validMonths[6]} {date}, {year}");
                    break;
                case 8:
                    Console.WriteLine($"{validMonths[7]} {date}, {year}");
                    break;
                case 9:
                    Console.WriteLine($"{validMonths[8]} {date}, {year}");
                    break;
                case 10:
                    Console.WriteLine($"{validMonths[9]} {date}, {year}");
                    break;
                case 11:
                    Console.WriteLine($"{validMonths[10]} {date}, {year}");
                    break;
                case 12:
                    Console.WriteLine($"{validMonths[11]} {date}, {year}");
                    break;
                default:
                    Console.WriteLine("Invalid Inputs");
                    break;

            }

        }
    }
}
