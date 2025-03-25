// Logger.cs
using System;

namespace SingletonExample
{
    public class Logger
    {
        // crearea unei variabile statice pentru instanța unică
        private static Logger? _instance;
        // obiect folosit pentru blocare în context multi-thread
        private static readonly object _lock = new object();

        // Constructor privat
        private Logger()
        {
            Console.WriteLine("Logger instance created!");
        }

        // Metodă statică pentru a obține instanța unică
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
            Console.WriteLine($"[LOG - {DateTime.Now:HH:mm:ss}] {message}");
        }
    }
}
