using System;

namespace SingletonPatternExample
{
    // Singleton Logger Class
    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();

        // Private constructor
        private Logger()
        {
            Console.WriteLine("Logger instance created");
        }

        // Public static method to get the single instance
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }

    // Main class to test Singleton
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("App started.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("App running...");

            if (logger1 == logger2)
                Console.WriteLine("Same instance of Logger used.");
            else
                Console.WriteLine("Different instances created.");
        }
    }
}
