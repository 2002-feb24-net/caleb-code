using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsGame game = new RockPaperScissorsGame();
            
            string input = "y";
            while(input == "y")
            {
                //method should play a round and print the result
                game.PlayRound();
                //method should print out a summary of the rounds - w/l
                game.PrintSummary();
                Console.WriteLine("Do you want to play a round? (y/n)");
                input = Console.ReadLine();
            }
        }
    }
}
