using System;
using System.Collections.Generic;
using System.Text;
using lab3.Accounts;
using lab3.Bios;

namespace lab3.Factories
{
    public interface ISocialFactory
    {
        SocialAccount CreateAccount();
        SocialBio CreateBio();
    }
}

