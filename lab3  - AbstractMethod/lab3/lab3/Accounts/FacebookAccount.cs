using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Accounts
{
    public class FacebookAccount : SocialAccount
    {
        public override void DisplayUsername(string username)
        {
            Console.WriteLine($"Facebook username: {username}");
        }
    }
}
