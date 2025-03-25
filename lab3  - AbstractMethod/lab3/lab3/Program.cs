using lab3.Accounts;
using lab3.Bios;
using lab3.Factories;
using System;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Facebook
            ISocialFactory facebookFactory = new FacebookFactory();
            SocialAccount fbAccount = facebookFactory.CreateAccount();
            SocialBio fbBio = facebookFactory.CreateBio();

            fbAccount.DisplayUsername("maxim.fb");
            fbBio.DisplayBio("Web developer pasionat de tehnologie si fotografie.");

            Console.WriteLine();

            // Instagram
            ISocialFactory instagramFactory = new InstagramFactory();
            SocialAccount igAccount = instagramFactory.CreateAccount();
            SocialBio igBio = instagramFactory.CreateBio();

            igAccount.DisplayUsername("maxim.ig");
            igBio.DisplayBio("Student la informatică si creator de continut.");

            Console.ReadLine();
        }
    }
}