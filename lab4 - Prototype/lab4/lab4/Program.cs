using System;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creăm contul original Instagram
            InstagramAccount igOriginal = AccountCloner.CreateInstagramAccount();
            igOriginal.DisplayInfo();

            // Clonăm contul Instagram
            InstagramAccount igClone = (InstagramAccount)igOriginal.Clone();
            igClone.Username = "maxim.clone.ig";
            igClone.Followers = 50;
            igClone.DisplayInfo();

            // Creăm contul original Facebook
            FacebookAccount fbOriginal = AccountCloner.CreateFacebookAccount();
            fbOriginal.DisplayInfo();

            // Clonăm contul Facebook
            FacebookAccount fbClone = (FacebookAccount)fbOriginal.Clone();
            fbClone.Username = "maxim.clone.fb";
            fbClone.Followers = 25;
            fbClone.DisplayInfo();

            Console.ReadLine();
        }
    }
}
