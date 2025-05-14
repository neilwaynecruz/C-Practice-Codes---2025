using System;

namespace NumberGuessingGame 

{
    public class Program
    {
        public static void Main(String[] args)
        {

            Random random = new Random();

            bool playing = true;

            while (playing)
            {
                int numberToGuess = random.Next(1, 101);
                Console.WriteLine(numberToGuess);

                while (true) 
                {
                    Console.Write("Enter a number between 1 to 100: ");
                    int userGuess = Convert.ToInt32(Console.ReadLine());
                    

                    if (userGuess > 100 || userGuess < 1) 
                    {
                        Console.WriteLine("The number are within 1 to 100 only, Try Again!\n");
                        continue;
                    }


                    if (userGuess > numberToGuess)
                    {
                        Console.WriteLine(userGuess + " is too high!\n");
                        continue;
                    }
                    else if (userGuess < numberToGuess)
                    {
                        Console.WriteLine(userGuess + " is too low!\n");
                        continue;
                    }
                    else 
                    {
                        Console.WriteLine($"Correct!!");
                        Console.WriteLine($"Number to guess: {numberToGuess}");
                        Console.WriteLine($"User guess: {userGuess}\n");
                    }

                        while (true) 
                        {
                            Console.Write("Play Again?[Y/N]: ");
                            string choice = Console.ReadLine().Substring(0,1).ToUpper();
                            Console.WriteLine();

                            if (choice == "Y")
                            {
                                break;
                            }
                            else if (choice == "N") {
                                playing = false;
                                break;
                            }
                            else 
                                continue;
                        }
                    Console.Clear();
                    break;

                }

            }

            Console.WriteLine("Thank you for playing!!!");

        }
    }
}
