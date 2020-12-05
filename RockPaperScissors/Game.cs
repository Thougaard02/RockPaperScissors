using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{

    class Game
    {
        public int playerCount = 0;
        public int ComputerCount = 0;
        public void Gameplay()
        {
            try
            {
                string[] choice = new string[3] { "rock", "paper", "scissor" };
                //int[] choice = new int[3] { 1, 2, 3 };
                //0 = rock, 1 = paper, 2 = scissor

                int userinput = Convert.ToInt32(Console.ReadLine());
                userinput--;

                Random r = new Random();
                int computerInput = r.Next(choice.Length);
                //0 = rock, 1 = paper, 2 = scissor

                Console.WriteLine($"You chose {choice[userinput]}");
                Console.WriteLine($"Computer chose {choice[userinput]}");

                for (int i = 0; i < 1; i++)
                {
                    if (userinput == 0 && computerInput == 2 || userinput == 1 && computerInput == 0 || userinput == 2 && computerInput == 1)
                    {
                        playerCount += 1;
                        Console.WriteLine("You won");
                    }
                    else if (userinput == 0 && computerInput == 1 || userinput == 1 && computerInput == 2 || userinput == 2 && computerInput == 0)
                    {
                        ComputerCount += 1;
                        Console.WriteLine("Computer Won");
                    }
                    else if (userinput == computerInput)
                    {
                        Console.WriteLine("Tie");
                    }
                }
            }
            catch (Exception)
            {
                Gameplay();
            }
           
        }
    }
}
