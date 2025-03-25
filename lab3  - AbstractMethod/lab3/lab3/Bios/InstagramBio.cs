using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Bios
{
    public class InstagramBio : SocialBio
    {
        public override void DisplayBio(string bio)
        {
            Console.WriteLine($"Instagram bio: {bio}");
        }
    }
}

