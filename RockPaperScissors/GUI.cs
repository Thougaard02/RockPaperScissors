using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class GUI
    {
        //Object of classes
        Game rps = new Game();
        Gameplay gameplay = new Gameplay();
        Player player = new Player("Rasmus", 0);
        Player computer = new Player("Computer", 0);
        public void Game()
        {
            try
            {
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
                    gameplay.RockPaperScissors(player, computer, rps);


                    //Shows players selections
                    Console.WriteLine($"\n{player.Name} chose {player.choice}");
                    Console.WriteLine($"{computer.Name} chose {computer.choice}");
                    Console.WriteLine(rps.Result);

                    Console.ReadKey();
                    Console.Clear();
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Wrong input");
                Thread.Sleep(1000);
                Console.Clear();
                Game();
            }
        }
    }
}
