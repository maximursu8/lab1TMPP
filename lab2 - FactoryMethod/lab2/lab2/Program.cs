using System;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crearea  a 2 obiecte fabrici
            SocialAccountFactory factory1 = new FacebookAccountFactory();
            SocialAccountFactory factory2 = new InstagramAccountFactory();

            //createa a conturi sociale folosind fabricile
            SocialAccount account1 = factory1.Create();
            SocialAccount account2 = factory2.Create();

            account1.AccountName("Maxim Ursu");
            account1.AccountTag("maximursu8");

            account2.AccountName("Daniel Spinu");
            account2.AccountTag("daniel_spinu17");

            Console.ReadLine();
        }
    }
}

