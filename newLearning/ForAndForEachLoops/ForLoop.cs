namespace ForAndForEachLoops
{
    internal class ForLoop
    {
        public static void Main(string[] args)
        {
            // For loop

            //Console.WriteLine("Count 1 to 10");

            //for(int i = 1; i<=10; i++)
            //{
            //    if(i==10)
            //    {
            //        Console.Write(i);
            //        break;
            //    }

            //    Console.Write(i + ",");
            //}

            //string[] names = new string[5];

            //for(int j = 0; j < names.Length; j++)
            //{
            //    Console.Write("Enter a name: ");
            //    names[j] = Console.ReadLine();
            //}

            //Console.WriteLine("");
            //Console.ReadKey();

            //for (int k = 0; k < names.Length; k++)
            //{
            //    Console.WriteLine($"Index {k} = {names[k]}");
            //}

            //Console.WriteLine();
            //Console.ReadKey();

            string[] username = { "Neil14", "Wayne14", "Cruz14" };
            string[] password = { "neil14", "wayne14", "cruz14" };

            Console.Write("Enter a username: ");
            string uName = Console.ReadLine();

            Console.Write($"Enter a password for '{uName}': ");
            string pName = Console.ReadLine();
            bool isFound = false;

            Console.WriteLine();
            for (int i = 0; i < username.Length; i++)
            {
                if (uName.Equals(username[i]) && pName.Equals(password[i]))
                {
                    Console.WriteLine($"Welcome {username[i]}!!");
                    isFound = true;
                    break;
                }
            }

            if (!isFound) Console.WriteLine("Account not Found!!");
            

        }
    }
}