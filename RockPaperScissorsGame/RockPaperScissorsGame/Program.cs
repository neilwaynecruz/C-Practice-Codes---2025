
using System;

namespace RockPaperScissorsGame
{
    public class Program {

        public static void Main(string[] args)
        {

            Random random = new Random();

            var is_playing = true;

            while (is_playing)
            {
                Console.Write("Enter [ROCK,PAPER,SCISSORS]: ");
                String choice = Console.ReadLine().ToUpper();

                if ((String.IsNullOrEmpty(choice) || String.IsNullOrWhiteSpace(choice)) || (choice != "ROCK" && choice != "PAPER" && choice != "SCISSORS"))
                {
                    Console.WriteLine("Please try again!\n");
                    continue;
                }

                Console.WriteLine("\nPlayer choose...: " + choice);

                var compChoice = random.Next(1,4) switch
                {
                    1 => "ROCK",
                    2 => "PAPER",
                    3 => "SCISSORS"
                };

                Console.WriteLine("Computer choose...: " + compChoice);

                if (choice == compChoice)
                {
                    Console.WriteLine("It's a DRAW!!" + " Both are " + choice + "\n");
                }
                else if ((choice == "ROCK" && compChoice == "SCISSORS") || (choice == "PAPER" && compChoice == "ROCK") || (choice == "SCISSORS" && compChoice == "PAPER"))
                {
                    Console.WriteLine("You WIN!\n");
                }
                else if ((choice == "ROCK" && compChoice == "PAPER") || (choice == "PAPER" && compChoice == "SCISSORS") || (choice == "SCISSORS" && compChoice == "ROCK"))
                {
                    Console.WriteLine("You LOSE!!\n");
                }

                    do
                    {
                        Console.Write("Would you like to play again? [Y/N]: ");
                        var response = Console.ReadLine();

                        if (String.IsNullOrEmpty(response) || String.IsNullOrWhiteSpace(response))
                        {
                            Console.WriteLine();
                            continue;

                        }

                        if (response.Substring(0, 1).ToUpper() == "Y")
                        {
                            break;
                        }
                        else if (response.Substring(0, 1).ToUpper() == "N")
                        {
                            is_playing = false;
                            break;
                        }
                        else 
                        { 
                            Console.WriteLine("Please try again\n");
                        continue;
                        }

                    } while (true);

                Console.Clear();
            }

            Console.WriteLine("Thank you for playing!!!");

        }
    }
}