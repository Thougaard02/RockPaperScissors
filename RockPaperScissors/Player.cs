using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {

        public string  Name { get; set; }
        public int wins { get; set; }
        public string choice { get; set; }

        public Player(string name, int wins)
        {
            Name = name;
            this.wins = wins;
            this.choice = choice;
        }
    }
}
