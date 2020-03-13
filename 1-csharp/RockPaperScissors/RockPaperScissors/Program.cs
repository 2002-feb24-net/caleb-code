using RockPaperScissors;
using RPS.Library;
using System;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            InputterOutputter inputOutputSpecific = new InputterOutputter();
            IInputterOutputter inputOutputGeneral = inputOutputSpecific;

            RPSStrategy compStratGeneral = new RPSStrategy();
            IRPSStrategy compStratSpecific = compStratGeneral;

            var game = new RockPaperScissorsGame(inputOutputGeneral, compStratSpecific);
            Console.WriteLine("What strategy do you wish to play against? (Enter 1 for Copy Strat, Enter 2 for Counter Strat)");
            int stratInput = Convert.ToInt32(Console.ReadLine());

            bool readyToQuit = false;

            while (!readyToQuit)
            {
                Console.Write("Do you want to play a round? (y/n)");
                var input = Console.ReadLine();

                if (input == "n")
                {
                    readyToQuit = true;
                }
                else
                {
                    game.PlayRound(stratInput);
                    // that method should play a round and print the result.
                }
            }

            game.PrintSummary();
            // that method should print out a summary of the rounds.
            // (how many wins, how many losses)
        }
    }
}
