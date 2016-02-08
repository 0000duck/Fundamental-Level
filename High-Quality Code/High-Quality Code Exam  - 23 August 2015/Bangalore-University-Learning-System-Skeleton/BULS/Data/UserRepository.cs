using System.Collections.Generic;
using BangaloreUniversityLearningSystem.Models;

namespace BangaloreUniversityLearningSystem.Data
{
    public class UsersRepository : Repository<User>
    {
        private Dictionary<string, User> usersByUsername;

        public UsersRepository()
        {
            this.usersByUsername = new Dictionary<string, User>();
        }

        public User GetByUsername(string username)
        {
            if (!this.usersByUsername.ContainsKey(username))
            {
                return null;
            }

            return this.usersByUsername[username];
            //// return this.items.FirstOrDefault(u => u.Username == username);
        }

        public override void Add(User user)
        {
            base.Add(user);
            this.usersByUsername[user.Username] = user;
        }
    }
}
