using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsGame game = new RockPaperScissorsGame();

            Console.WriteLine("Do you want to play a round? (y/n)");
            string input = Console.ReadLine();
            
            do
            {
                //method should play a round and print the result
                game.PlayRound();
            }
            while(input == "y" || input != "n" || input != "no");
            //method should print out a summary of the rounds - w/l
            game.PrintSummary(winLoss);
        }
    }
}
