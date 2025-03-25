using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class FacebookAccount : SocialAccount
    {
        public override string AccountName(string name)
        {
            Console.WriteLine($"Facebook account Name: {name}");
            return name;
        }

        public override string AccountTag(string tag)
        {
            Console.WriteLine($"Facebook tag: @{tag}");
            return tag;
        }
    }
}

