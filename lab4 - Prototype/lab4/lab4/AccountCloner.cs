using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class AccountCloner
    {
        public static InstagramAccount CreateInstagramAccount()
        {
            Console.WriteLine("Creare cont Instagram original...");
            return new InstagramAccount("maxim.ig", "maxim@mail.com", "Student pasionat de cod.", 1300);
        }

        public static FacebookAccount CreateFacebookAccount()
        {
            Console.WriteLine("Creare cont Facebook original...");
            return new FacebookAccount("maxim.fb", "maxim.fb@mail.com", "Front-end Developer.", 800);
        }
    }
}

