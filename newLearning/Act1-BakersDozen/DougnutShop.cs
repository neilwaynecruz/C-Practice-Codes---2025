using System;

// main program - this is where everything starts
// the user picks 12 doughnuts and we give them the total bill

public class DougnutShop
{
    static void Main(string[] args)
    {
        // just a simple welcome header
        Console.WriteLine("=====================================");
        Console.WriteLine("   Welcome to the Doughnut Shop!");
        Console.WriteLine("   Order a Baker's Dozen (12 pcs)");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        // we'll keep adding to this as the user picks doughnuts
        double totalAmountDue = 0;

        // these arrays will remember what the user ordered
        // so we can show a summary at the end
        string[] orderNames = new string[12];
        double[] orderPrices = new double[12];

        // loop 12 times since a dozen means 12
        for (int i = 1; i <= 12; i++)
        {
            // show the menu each time so the user knows their options
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Doughnut #" + i + " of 12");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("[1] Plain Doughnut");
            Console.WriteLine("[2] Plain Choco");
            Console.WriteLine("[3] Plain Strawberry");
            Console.WriteLine("[4] Choco Crunch");
            Console.WriteLine("[5] Strawberry Sprinkles");
            Console.WriteLine("[6] Cinnamon Crunch");
            Console.Write("\nEnter your choice (1-6): ");

            // get what the user typed and turn it into a number
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // we use PlainDoughnut as the type here because all doughnuts
            // are basically a PlainDoughnut at their core (polymorphism)
            PlainDoughnut doughnut = null;

            // this will hold the name of whatever they picked
            string doughnutName = "";

            // figure out which doughnut the user wants
            if (choice == 1)
            {
                doughnut = new PlainDoughnut();
                doughnutName = "Plain Doughnut";
            }
            else if (choice == 2)
            {
                doughnut = new PlainChoco();
                doughnutName = "Plain Choco";
            }
            else if (choice == 3)
            {
                doughnut = new PlainStrawberry();
                doughnutName = "Plain Strawberry";
            }
            else if (choice == 4)
            {
                doughnut = new ChocoCrunch();
                doughnutName = "Choco Crunch";
            }
            else if (choice == 5)
            {
                doughnut = new StrawberrySprinkles();
                doughnutName = "Strawberry Sprinkles";
            }
            else if (choice == 6)
            {
                doughnut = new CinnamonCrunch();
                doughnutName = "Cinnamon Crunch";
            }
            else
            {
                // if they type something weird just give them a plain one
                Console.WriteLine("Invalid choice! Defaulting to Plain Doughnut.");
                doughnut = new PlainDoughnut();
                doughnutName = "Plain Doughnut";
            }

            // get the price of the doughnut they just picked
            double doughnutCost = doughnut.ComputeCost();

            // show them how much that one costs
            Console.WriteLine($"Cost: Php {doughnutCost:F2}");
            Console.WriteLine();

            // save the name and price so we can show it in the summary later
            // i-1 because arrays start at 0 but our loop starts at 1
            orderNames[i - 1] = doughnutName;
            orderPrices[i - 1] = doughnutCost;

            // add it to the running total
            totalAmountDue = totalAmountDue + doughnutCost;
        }

        // now lets show them everything they ordered in a nice summary
        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine("         ORDER SUMMARY");
        Console.WriteLine("==========================================");
        Console.WriteLine();

        // go through all 12 and print each one with its price
        for (int i = 0; i < 12; i++)
        {
            // prints something like: #1  Plain Choco              Php 25.00
            Console.WriteLine($"  #{i + 1,-3} {orderNames[i],-25} Php {orderPrices[i]:F2}");
        }

        // show the total at the bottom
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"         AMOUNT DUE:           Php {totalAmountDue:F2}");
        Console.WriteLine("==========================================");

        // so the console window doesnt close right away
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}