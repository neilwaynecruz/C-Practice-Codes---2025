namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] cars = { {"Mustang", "F-150", "Explorer"},
                               {"Corvette", "Camaro", "Silvarado"},
                               { "Corolla","Camry","Rav4"} };


            for (int i = 0; i < cars.GetLength(0); i++) 
            {
                for (int j = 0; j < cars.GetLength(1); j++) 
                {
                    Console.Write(cars[i,j] + " ");
                }
                Console.WriteLine();
            }