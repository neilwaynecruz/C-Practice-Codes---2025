namespace WhileAndDo_WhileLoops 
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            // while loop - executes the block of code as long as the condition is true
            // continue statement - skips the current iteration and moves to the next one
            // break statement - exits the loop immediately, regardless of the condition

            //int count = 0;
            //string[] names = { "Alice", "Bob", "Charlie", "Wayne", "Diana", "Eve"};

            //while (count < names.Length) 
            //{
            //    if (count == names.Length-1)
            //    {
            //        Console.Write(names[count]);
            //        break;
            //    }
            //    Console.Write(names[count] + ",");
            //    count++;
            //}

            //Console.WriteLine("\n\n");

            //do-while loop - executes the block of code AT LEAT ONCE, even if the condition is false
            //int i = 0;

            //do
            //{
            //    Console.WriteLine(names[i] + "\n\n");
            //    i++;
            //} while (false);



            //searching - linear


            //Console.Write("Enter a name to search:");
            //string searchName = Console.ReadLine();
            //int index = 0;

            //while (index < names.Length)
            //{
            //    if (index  == names.Length - 1)
            //    {
            //        Console.WriteLine("Name not found");
            //        break;
            //    }

            //    if (searchName.Equals(names[index], StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"{names[index]} found at index = {index}");
            //        break;
            //    }
            //    index++;
            //}

            //Quiz game w/ lives

            Console.WriteLine("QUIZ GAME w/ LIVES");
            Console.WriteLine("===============================");
            string[] questions = { "What does GPU stand for?", "What data structure uses FIFO (First In First Out)?", 
                                 "What symbol is used for comments in Python (single line)?", "What does CPU stand for?",
                                 "What does RAM stand for?","What symbol is used to end a statement in C++?",
                                 "What is the brain of the computer?" };

            string[] answers = { "GRAPHICAL PROCESSING UNIT","QUEUE","#","CENTRAL PROCESSING UNIT","RANDOM ACCESS MEMORY", 
                                 ";","CPU"};

            int lives = 3;
            int score = 0;
            int INDEX = 0;

            while (true) 
            {
                Console.WriteLine($"Life: {lives}");
                Console.WriteLine($"Score: {score}/{questions.Length}");
                Console.WriteLine("===============================");

                if (lives == 0) 
                {
                    Console.WriteLine("You lost!");
                    break;
                }

                if (INDEX == questions.Length) break;

                if (score >= 4)
                {
                    Console.WriteLine("You've Won!");
                    break;
                }

                Console.Write($"Q{INDEX+1}: {questions[INDEX]}: ");
                string userAns = Console.ReadLine().ToUpper();

                if (userAns.Equals(answers[INDEX]))
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                    
                }
                else
                {
                    Console.WriteLine("Wrong!\n");
                    lives--;
                }
                Console.WriteLine("===============================");
                INDEX++;
            }




            Console.ReadKey();


        }
    }
}