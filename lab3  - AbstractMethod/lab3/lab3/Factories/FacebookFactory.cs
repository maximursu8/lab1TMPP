using System;
using System.Collections.Generic;
using System.Text;
using lab3.Accounts;
using lab3.Bios;

namespace lab3.Factories
{
    public class FacebookFactory : ISocialFactory
    {
        public SocialAccount CreateAccount() => new FacebookAccount();
        public SocialBio CreateBio() => new FacebookBio();
    }
}

