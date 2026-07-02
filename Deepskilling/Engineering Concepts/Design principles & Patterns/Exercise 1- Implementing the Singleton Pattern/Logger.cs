using System;

namespace Exercise01_SingletonPattern
{
    public class Logger
    {
        // Single instance of Logger
        private static Logger instance;

        // Private constructor
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        // Method to get the single instance
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        // Logging method
        public void Log(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }
}
