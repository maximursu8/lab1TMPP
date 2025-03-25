using System;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialAccount instagramAccount = SocialAccount.With()
                .Username("maxim.ig")
                .Email("maxim@ig.com")
                .Bio("Student & coder.")
                .Followers(1200)
                .Platform("Instagram")
                .Build();

            SocialAccount facebookAccount = SocialAccount.With()
                .Username("maxim.fb")
                .Email("maxim@fb.com")
                .Bio("Frontend Developer")
                .Followers(800)
                .Platform("Facebook")
                .Build();

            instagramAccount.Display();
            facebookAccount.Display();

            Console.ReadLine();
        }
    }
}
