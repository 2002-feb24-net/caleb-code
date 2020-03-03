using System;

namespace RockPaperScissors
{
    class Rounds
    {
        static void PlayRound()
        {
            Console.WriteLine("Enter a hand (rock, paper, scissors): ");
            string inputHand = Console.ReadLine();

            Random r = new Random();
            //returns non negative random int less than specified max
            int compHand = r.Next(4);

            bool[] winLoss = new bool[];
        }

        static void RoundsSummary()
        {

        }
    }
}
