using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    abstract class SocialAccount
    {
        public string Username;
        public string Email;
        public string Bio;
        public int Followers;

        public abstract void DisplayInfo();
        public abstract SocialAccount Clone();
    }
}
