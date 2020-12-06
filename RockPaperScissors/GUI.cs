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
            //Object of classes
            Game game = new Game();
            Gameplay gameplay = new Gameplay();
            Player player = new Player("Rasmus", 0);
            Player computer = new Player("Computer", 0);

            //Rock, paper, scissors gameplay
            while (true)
            {
                //Players score point
                Console.WriteLine($"Player wins { player.wins}");
                Console.WriteLine($"Computer wins {computer.wins}\n");
                
                //Selection
                Console.WriteLine("Rock = 1");
                Console.WriteLine("Paper = 2");
                Console.WriteLine("Scissor = 3");

                //Rock, paper, scissors methoed
                gameplay.RockPaperScissors(player, computer, game);

                //Shows players selections
                Console.WriteLine($"{player.Name} chose {player.choice}");
                Console.WriteLine($"{computer.Name} chose {computer.choice}");
                Console.WriteLine(game.Result);

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
