using System;
using System.Collections.Generic;
using System.Threading;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // thread = an execution path through the program
            //          we can use multiple threads to run multiple tasks at the same time
            //          current thread we are using is the main thread

            //          using System.Threading;

            Thread m_thread = Thread.CurrentThread; // get the current thread
            m_thread.Name = "Main Thread"; // set the name of the thread
            //Console.WriteLine("Current thread: " + m_thread.Name); // print the name of the thread

            Thread thread1 = new Thread(CountDown); // create a new thread and set the method to run
            Thread thread2 = new Thread(CountUp);

            thread1.Start(); // start the thread
            thread2.Start(); // start the thread

            Console.WriteLine(m_thread.Name + " Done!!");
        }

        public static void CountDown()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(700); // sleep for 1 second
            }
            Console.WriteLine("Timer #1: Time's up!");
        }

        public static void CountUp()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(700); // sleep for 1 second
            }
            Console.WriteLine("Timer #2: Time's up!");
        }
    }
}
