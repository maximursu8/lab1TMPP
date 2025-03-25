using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    class SocialAccount
    {
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Bio { get; private set; }
        public int Followers { get; private set; }
        public string Platform { get; private set; }

        private SocialAccount() { }

        public static AccountBuilder With()
        {
            return new AccountBuilder();
        }

        public void Display()
        {
            Console.WriteLine($"\n[{Platform} ACCOUNT]");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Bio: {Bio}");
            Console.WriteLine($"Followers: {Followers}");
        }

        public class AccountBuilder
        {
            private readonly SocialAccount _account = new SocialAccount();

            public AccountBuilder Username(string username)
            {
                _account.Username = username;
                return this;
            }

            public AccountBuilder Email(string email)
            {
                _account.Email = email;
                return this;
            }

            public AccountBuilder Bio(string bio)
            {
                _account.Bio = bio;
                return this;
            }

            public AccountBuilder Followers(int followers)
            {
                _account.Followers = followers;
                return this;
            }

            public AccountBuilder Platform(string platform)
            {
                _account.Platform = platform;
                return this;
            }

            public SocialAccount Build()
            {
                if (_account.Followers < 0)
                    throw new InvalidOperationException("Numărul de followers nu poate fi negativ.");

                return _account;
            }
        }
    }
}
