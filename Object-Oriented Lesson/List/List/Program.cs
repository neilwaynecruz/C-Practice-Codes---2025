using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list = data structure that represents a collection of objects that can be accessed by index.
            //       similar to an array but can grow and shrink in size.
            //       use System.Collections.Generic;

            // syntax : List<type> listName = new List<type>();


            //List<String> listNames = new List<String>();

            //listNames.Add("John");
            //listNames.Add("Jane");
            //listNames.Add("Jack");
            //listNames.Add("Anna");
            //listNames.Add("Jill");
            //listNames.Add("Joe");
            //listNames.Add("John");
            //listNames.Add("Jim");

            //listNames.Remove("Jim"); // removes Jim from the list
            //listNames.Insert(1,"Wayne"); // inserts Wayne at index 1
            //listNames.RemoveAt(2); // removes the element at index 2
            //listNames.Clear(); // clears the list but does not remove the list itself
            //listNames.Sort(); // sorts the list in ascending order / if string in alphabetical order
            //listNames.Reverse(); // reverses the order of the list
            //listNames.Contains("John"); // returns true if the list contains John
            //listNames.IndexOf("John"); // returns the index of John in the list
            //listNames.Count; // returns the number of elements in the list
            //listNames.LastIndexOf("John"); // returns the last index of John in the list
            //listNames.Capacity; // returns the number of elements that can be stored in the list before it needs to resize
            //listNames.TrimExcess(); // reduces the capacity of the list to the number of elements in the list
            //listNames.AddRange(new List<String> { "Wayne", "Bruce" }); // adds a range of elements to the list
            //listNames.RemoveRange(0, 2); // removes a range of elements from the list, exclusive of the last index (2 in this case)
            //listNames.ForEach(Console.WriteLine); // prints each element in the list
            //listNames.CopyTo(0, new String[5], 0, 5); // copies the elements of the list to an array
            //listNames.Last(); // returns the last element in the list
            //listNames.First(); // returns the first element in the list
            //listNames.Find(x => x.StartsWith("A")); // returns the first element that starts with J
            //listNames.FindAll(x => x.StartsWith("J")); // returns all elements that start with J
            //listNames.RemoveAll(x => x.StartsWith("J")); // removes all elements that start with J
            //listNames.Exists(x => x.StartsWith("J")); // returns true if any element starts with J
            //listNames.TrueForAll(x => x.StartsWith("J")); // returns true if all elements start with J
            //listNames.GetRange(0, 2); // returns a range of elements from the list, exclusive of the last index (2 in this case)
            //String[] namesArr = listNames.ToArray(); // converts the list to an array

            //Console.WriteLine("[" + String.Join(",",listNames)+"]");


            // list of objects

            List<Player> players = new List<Player>();

            players.Add(new Player("John"));
            players.Add(new Player("Jane"));
            players.Add(new Player("Anna"));
            players.Add(new Player("Wayne"));
            players.Add(new Player("Robert"));

            players.ForEach(Console.WriteLine);



        }
    }

    public class Player
    {
        public string username;
        public Player(string username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return $"This is {username}";
        }
    }
}
