using System;

namespace SingletonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicatia a pornit...");

            // Obținem instanța Singleton a Loggerului
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            // logare a unui mesaj folosind instanța logger1
            logger1.Log("Primul mesaj de log.");
            logger2.Log("Al doilea mesaj de log.");

            // Verificăm dacă este același obiect
            Console.WriteLine(logger1 == logger2 ? "Singleton functionează corect!" : "Singleton NU functionează!");

            Console.ReadLine();
        }
    }
}
