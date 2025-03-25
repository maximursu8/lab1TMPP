using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class FacebookAccount : SocialAccount
    {
        public FacebookAccount(string username, string email, string bio, int followers)
        {
            Username = username;
            Email = email;
            Bio = bio;
            Followers = followers;
        }

        public override SocialAccount Clone()
        {
            return new FacebookAccount(this.Username, this.Email, this.Bio, this.Followers);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\n[FACEBOOK ACCOUNT]\nUsername: {Username}\nEmail: {Email}\nBio: {Bio}\nFollowers: {Followers}\n");
        }
    }
}

