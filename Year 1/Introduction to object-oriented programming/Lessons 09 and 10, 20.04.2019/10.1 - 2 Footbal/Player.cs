using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1___2_Footbal
{
    class Player
    {
        private string name;
        private int skill;

        private Dictionary<string, byte> statistics;
        private byte endurance;
        private byte sprint;
        private byte dribble;
        private byte passes;
        private byte shoot;

        public Player(string name, int[] stats)
        {
            Name = name;

            statistics = new Dictionary<string, byte>
            {
                {"Endurance", (byte)stats[0] },
                {"Sprint", (byte)stats[1]},
                {"Dribble", (byte)stats[2] },
                {"Passes", (byte)stats[3] },
                {"Shoot", (byte)stats[4] }
            };

            if (statistics.Values.Any(s => s < 0 || s > 100))
            {
                throw new ArgumentException($"{statistics.Where(pair => pair.Value < 0 || pair.Value > 100).First().Key} should be between 0 and 100.");
            }

            skill = (int)Math.Round(stats.Average());
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

        public int Skill { get => skill; private set => skill = value; }
    }
}
