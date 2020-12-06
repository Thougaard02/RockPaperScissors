using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Gameplay
    {
        public string[] RockPaperScissors(Player player, Player computer, GameResult game)
        {

            //int[] choice = new int[3] { 1, 2, 3 };
            //0 = rock, 1 = paper, 2 = scissor
            string[] choice = new string[3] { "Rock", "Paper", "Scissor" };
            string[] result = new string[2] { "Won", "Tie" };

            //0 = rock, 1 = paper, 2 = scissor
            Random r = new Random();
            int computerInput = r.Next(choice.Length);

            //Choice of rock, paper or scissors
            int userinput = Convert.ToInt32(Console.ReadLine());
            userinput--;

            //Player and computers choice (Rock, paper or scissors)
            player.choice = choice[userinput];
            computer.choice = choice[computerInput];

            //Player wins
            if (userinput == 0 && computerInput == 2 || userinput == 1 && computerInput == 0 || userinput == 2 && computerInput == 1)
            {
                player.wins += 1;
                game.Result = $"{player.Name} {result[0]}";
            }
            //Computer wins
            else if (userinput == 0 && computerInput == 1 || userinput == 1 && computerInput == 2 || userinput == 2 && computerInput == 0)
            {
                computer.wins += 1;
                game.Result = $"{computer.Name} {result[0]}";
            }
            //Player and computer tie
            else if (userinput == computerInput)
            {
                game.Result = result[1];
            }
            return result;
        }
    }
}
