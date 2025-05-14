using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            // String Methods
            String str1 = "Neil Wayne Cruz";
            String str2 = "Polytechnic University of the Philippines - SJ";
            String str3 = "         POGI AKO BRO!!      ";

            // 1. Length
            Console.WriteLine("Length of str1: " + str1.Length);
            Console.WriteLine("Length of str2: " + str2.Length);

            // 2. ToUpper
            Console.WriteLine("str1 in uppercase: " + str1.ToUpper());
            Console.WriteLine("str2 in uppercase: " + str2.ToUpper());

            // 3. ToLower
            Console.WriteLine("str1 in lowercase: " + str1.ToLower());
            Console.WriteLine("str2 in lowercase: " + str2.ToLower());

            // 4. Trim
            Console.WriteLine("str3 trimmed: " + str3.Trim());

            // 5. Substring
            Console.WriteLine("Substring of str1 (0, 4): " + str1.Substring(0, 4));
            Console.WriteLine("Substring of str2 (0, 4): " + str2.Substring(0, 4));

            // 6. IndexOf
            Console.WriteLine("Index of 'Wayne' in str1: " + str1.IndexOf("Wayne"));
            Console.WriteLine("Index of 'University' in str2: " + str2.IndexOf("University"));

            // 7. LastIndexOf
            Console.WriteLine("Last index of 'o' in str2: " + str2.LastIndexOf("o"));
            Console.WriteLine("Last index of 'P' in str2: " + str2.LastIndexOf("P"));

            // 8. Replace
            Console.WriteLine("str1 with 'Neil' replaced by 'John': " + str1.Replace("Neil", "John"));
            Console.WriteLine("str2 with 'Philippines' replaced by 'PUP': " + str2.Replace("Philippines","PUP"));

            // 9. Split
            String[] str2Words = str2.Split(' ');
            Console.WriteLine("Words in str2:");
                foreach (String word in str2Words)
            {
                Console.Write(word + "-");
            }

            Console.WriteLine();

            // 10. Join
            String[] words = { "Hello", "World", "from", "C#" };
            String joinedString = String.Join(" ", words);
            Console.WriteLine("Joined string: " + joinedString);

            // 11. Contains
            Console.WriteLine("Does str1 contain 'Wayne'? " + str1.Contains("Wayne"));
            Console.WriteLine("Does str2 contain 'SJ'? " + str2.Contains("PH"));

            // 12. StartsWith
            Console.WriteLine("Does str1 start with 'Neil'? " + str1.StartsWith("Weil"));
            Console.WriteLine("Does str2 start with 'Polytechnic'? " + str2.StartsWith("Polytechnic"));

            //13. Insert
            Console.WriteLine("str1 with 'POGI' inserted at index 4: " + str1.Insert(4, " POGI "));
            Console.WriteLine("str2 with 'POGI' inserted at index 4: " + str2.Insert(4, " POGI "));
        }
    }
}
