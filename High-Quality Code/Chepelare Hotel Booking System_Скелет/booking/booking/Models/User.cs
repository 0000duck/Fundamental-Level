namespace HotelBookingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Utilities;

    public class User : IDbEntity
    {
        private string username;
        private string passwordHash;

        public User(string username, string password, Roles role)
        {
            this.Username = username;
            this.PasswordHash = password;
            this.Role = role;
            this.Bookings = new List<Booking>();
        }

        public int Id { get; set; }

        public Roles Role { get; private set; }

        public ICollection<Booking> Bookings { get; private set; }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < Constants.MinUsernameLength)
                {
                    throw new ArgumentException(string.Format("The username must be at least {0} symbols long.", Constants.MinUsernameLength));
                }

                this.username = value;
            }
        }

        public string PasswordHash
        {
            get
            {
                return this.passwordHash;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < Constants.MinPasswordLength)
                {
                    throw new ArgumentException(string.Format("The password must be at least {0} symbols long.", Constants.MinPasswordLength));
                }

                this.passwordHash = HashUtilities.GetSha256Hash(value);
            }
        }
    }
}
