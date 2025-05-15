namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics = "not specific" to a particular data type
            //            add <T> to: class, struct, interface, method, delegate, and, etc.
            //            T is a placeholder for the data type
            //            T can be replaced with any data type when the class is instantiated
            //            allows for code reusability and type safety

            int[] nums1 = { 1, 2, 3, 4, 5 };
            double[] nums2 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            string[] nums3 = { "1", "2", "3", "4", "5" };

            displayAndSum(nums1);
            displayAndSum(nums2);
            displayAndSum(nums3);


        }

        static void displayAndSum<T>(T[] arr)
        {
            {
                dynamic sum = 0; // dynamic allows for runtime type resolution
                foreach (T item in arr)
                {
                    Console.WriteLine(item);
                    sum += item;
                }
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine();
            }
        }

    }
}