using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class InstagramAccount : SocialAccount
    {
        public InstagramAccount(string username, string email, string bio, int followers)
        {
            Username = username;
            Email = email;
            Bio = bio;
            Followers = followers;
        }

        public override SocialAccount Clone()
        {
            return new InstagramAccount(this.Username, this.Email, this.Bio, this.Followers);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\n[INSTAGRAM ACCOUNT]\nUsername: {Username}\nEmail: {Email}\nBio: {Bio}\nFollowers: {Followers}\n");
        }
    }
}

