using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class InstagramAccountFactory : SocialAccountFactory
    {
        public override SocialAccount Create()
        {
            return new InstagramAccount();
        }
    }
}
