namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Methods 

            String fullname = "Neil Wayne T. Cruz";
            String greeting = "        Hello,            World!         ";

            Console.WriteLine("Length: " + fullname.Length); // return the number of characters in the string including spaces
            Console.WriteLine("Replace 'Wayne' with 'Smith': " + fullname.Replace("Wayne", "Smith")); // return a new string with all occurrences of the specified substring replaced with another substring
            Console.WriteLine("Trim: " + greeting.Trim()); // return a new string with all leading and trailing white-space characters removed
            Console.WriteLine("Trim Start: " + greeting.TrimStart()); // return a new string with all leading white-space characters removed
            Console.WriteLine("Trim End: " + greeting.TrimEnd()); // return a new string with all trailing white-space characters removed
            Console.WriteLine("Trim with characters: " + greeting.Trim(' ', 'H', 'd', '!')); // return a new string with all leading and trailing occurrences of the specified characters removed
            Console.WriteLine("Replace 'T.' with 'A.': " + fullname.Replace("T.", "A.")); // return a new string with all occurrences of the specified substring replaced with another substring
            Console.WriteLine("To Upper: " + fullname.ToUpper()); // return a new string with all characters in uppercase
            Console.WriteLine("To Lower: " + fullname.ToLower()); // return a new string with all characters in lowercase
            Console.WriteLine("Contains 'Wayne': " + fullname.Contains("Wayne")); // return true or false
            Console.WriteLine("Starts with 'Neil': " + fullname.StartsWith("Wayne"));// return true or false
            Console.WriteLine("Ends with 'Cruz': " + fullname.EndsWith("Cruz")); // return true or false
            Console.WriteLine("Index of 'T.': " + fullname.IndexOf("T.")); // return the index of the first occurrence of the specified substring
            Console.WriteLine("Substring from index 5: " + fullname.Substring(5)); // return a substring starting from the specified index to the end of the string
            Console.WriteLine("Substring from index 5 with length 5: " + fullname.Substring(5, 5)); // return a substring starting from the specified index with the specified length
            Console.WriteLine("Insert 'Mr. ' at index 0: " + fullname.Insert(0, "Mr. ")); // return a new string with the specified substring inserted at the specified index




        }
    }
}
