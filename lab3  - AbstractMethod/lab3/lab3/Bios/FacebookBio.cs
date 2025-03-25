using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Bios
{
    public class FacebookBio : SocialBio
    {
        public override void DisplayBio(string bio)
        {
            Console.WriteLine($"Facebook bio: {bio}");
        }
    }
}

