using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1___2_Footbal
{
    class Team
    {
        private string name;
        private int rating;
        private Dictionary<string, Player> players;

        public Team(string name)
        {
            Name = name;
            rating = 0;
            players = new Dictionary<string, Player>();
        }

        private void CalcRating()
        {
            rating = (int)Math.Round(players.Values.Select(p => p.Skill).Average());
        }

        public void AddPlayer(Player toAdd)
        {
            players.Add(toAdd.Name, toAdd);
            CalcRating();
        }

        public void RemovePlayer(string playerName)
        {
            if (!players.ContainsKey(playerName))
            { throw new ArgumentException($"Player {playerName} is not in {Name}"); }

            players.Remove(playerName);
            CalcRating();
        }

        public override string ToString()
        {
            return $"{Name} - {rating}";
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "" || value.All(x => x == ' '))
                { throw new ArgumentException("A name should not be empty."); }

                name = value;
            }
        }

        public int Rating { get => rating; private set => rating = value; }
    }
}
