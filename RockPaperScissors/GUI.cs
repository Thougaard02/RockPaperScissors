using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class GUI
    {
        public void game()
        {
            Game game = new Game();

            while (true)
            {
                Console.WriteLine($"Player wins {game.playerCount }");
                Console.WriteLine($"Computer wins {game.ComputerCount}");
                Console.WriteLine();
                Console.WriteLine("Rock = 1");
                Console.WriteLine("Paper = 2");
                Console.WriteLine("Scissor = 3");
                game.Gameplay();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
