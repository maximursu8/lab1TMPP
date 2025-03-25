using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class InstagramAccount : SocialAccount
    {
        public override string AccountName(string name)
        {
            Console.WriteLine($"Instagram account Name: {name}");
            return name;
        }

        public override string AccountTag(string tag)
        {
            Console.WriteLine($"Instagram tag: @{tag}");
            return tag;
        }
    }
}

