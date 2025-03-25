using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class FacebookAccountFactory : SocialAccountFactory
    {
        public override SocialAccount Create()
        {
            return new FacebookAccount();
        }
    }
}

