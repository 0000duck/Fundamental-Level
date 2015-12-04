using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague.Models
{
    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateFounded;
        private List<Player> players;

        public Team(string name, string nickname, DateTime dateFounded)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateFounded = dateFounded;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Name should be at least 5 characters long");
                }

                name = value;
            }
        }

        public string Nickname
        {
            get { return nickname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Nickname should be at least 5 characters long");
                }

                nickname = value;
            }
        }

        public DateTime DateFounded
        {
            get { return dateFounded; }
            set
            {
                if (value.Year < 1850)
                {
                    throw new ArgumentException("Year should be after 1850");
                }

                dateFounded = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get { return players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists for that team");
            }

            players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }

        public override string ToString()
        {
            return this.name + "(" + this.nickname + ") - " + "Founded: " + this.dateFounded.ToShortDateString() +
                   "\nPlayers:\n" + String.Join("\n", this.players);
        }
    }
}