using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task4
{
    public class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other)
        {
            if (other == null)
                return 1;

            return Score.CompareTo(other.Score);
        }
    }
}
