using System;

namespace Exercise01_SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("Application Started");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("Application Running");

            if (logger1 == logger2)
            {
                Console.WriteLine("\nSingleton Pattern Verified!");
                Console.WriteLine("Both logger1 and logger2 refer to the same object.");
            }
            else
            {
                Console.WriteLine("Singleton Pattern Failed!");
            }

            Console.ReadKey();
        }
    }
}