namespace _2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2d array

            // true 2d array - each row has the same number of columns
            int[,] numbers =
            {
                {1, 2, 3},
                {4, 5, 6}
            };


            // jagged 2d array - array of arrays - each row can have different number of columns
            // you need to use 'new' keyword to initialize each row of the jagged array
            string[][] names = 
                {
                  new string[] {"Neil","Wayne","Cruz"},
                  new string[] {"Nathan", "Weil", "Winter","Cruz"} 
                };

            // multidimensional 2d array - each row has the same number of columns
            int[][,] age =
            {
                new int[,] { { 1, 2 }, { 3, 4 } },
                new int[,] { { 5, 6 }, { 7, 8 } }
            };

            // for loop to iterate through the 2d array - true 2d array
            // GetLength(dimension). 0 = outer, 1 = inner

            for(int i = 0;  i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (j == numbers.GetLength(1) - 1) 
                    {
                        Console.Write(numbers[i, j] + "|");
                        break;
                    }
                    Console.Write(numbers[i, j] + "||");
                }
                Console.WriteLine("");
                Console.WriteLine("========");
            }

            // foreach
            int INDEX = 1;
            foreach(int num in numbers)
            {
                
                Console.Write(num + " ");
                if (INDEX % 3 == 0) Console.WriteLine();
                INDEX++;
            }


        }
    }
}
