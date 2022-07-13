using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            //string player = "", computer = "", answer = "";

            while (playAgain)
            {
                string player = "", computer = "", answer = "";
                while (player !="ROCE" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCE, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                
                switch(random.Next(1,4))
                {
                    case 1:
                        computer = "ROCE";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");

                if ((player == "ROCE" && computer == "PAPER") || (player == "PAPER" && computer == "SCISSORS") || (player == "SCISSORS" && computer == "ROCE"))
                {
                    Console.WriteLine($"Computer Wins");
                }
                if ((computer == "ROCE" && player == "PAPER") || (computer == "PAPER" && player == "SCISSORS") || (computer == "SCISSORS" && player == "ROCE"))
                {
                    Console.WriteLine($"Player Wins");
                }
                if ((player == "ROCE" && computer == "ROCE") || (player == "PAPER" && computer == "PAPER" ) || (player == "SCISSORS" && computer == "SCISSORS"))
                {
                    Console.WriteLine($"It's a drae!");
                }

                Console.Write("Do you ike to play again (Y/N); ");
                answer = Console.ReadLine();
                answer = player.ToUpper();

                if (answer == "N")
                {
                    playAgain = false;
                }
            }

            Console.ReadKey();
        }
    }
}
