using System.ComponentModel;
using System;

namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size.
            // methods = performs a section of code, whenever it's called "invoked"
            //           benefit = let's us reuse code w/o writing it multiple times

            int[] nums = new int[6];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("nums = [" + String.Join(",", nums) + "]\n");

            Console.WriteLine("High: " + GetHigh(nums));
            Console.WriteLine("Low: " + GetLow(nums));


        }

        static int GetHigh(int[] arr1) 
        {
            int high = arr1[0];

            if (arr1 == null || arr1.Length == 0) 
            {
                return -1;
            }

            foreach (int num in arr1) 
            {
                if (num > high) 
                {
                    high = num;
                }
            }

            return high;
        }

        static int GetLow(int[] arr1)
        {
            int low = arr1[0];

            if (arr1 == null || arr1.Length == 0)
            {
                return -1;
            }

            foreach (int num in arr1)
            {
                if (num < low)
                {
                    low = num;
                }
            }

            return low;
        }

    }
}
