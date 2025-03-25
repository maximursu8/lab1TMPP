using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Accounts
{
    public class InstagramAccount : SocialAccount
    {
        public override void DisplayUsername(string username)
        {
            Console.WriteLine($"Instagram username: {username}");
        }
    }
}

