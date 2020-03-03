using System;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        public static void PlayRound()
        {
            Console.WriteLine("Enter a hand (rock, paper, scissors): ");
            string inputHand = Console.ReadLine();

            Random r = new Random();
            //returns non negative random int less than specified max
            int compHand = r.Next(1, 4);

            //win counter
            int wins = 0;
            int losses = 0;
            int ties = 0;

            /*int[] winLoss = new int[10];
            int round = 0;*/

            if (compHand = 1)
            {
                if (inputHand == "rock")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("It is a tie. ");
                    /*winLoss[round] = 0;
                    round++;*/
                    ties++;
                }
                else if (inputHand == "paper")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("You win, paper beats rock. ");
                    /*winLoss[round] = 1;
                    round++;*/
                    wins++;
                }
                else if (inputHand == "scissors")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("You lose, rock beats scissors. ");
                    /*winLoss[round] = -1;
                    round++;*/
                    losses++;
                }
                else
                {
                    Console.WriteLine("You must choose \"rock\", \"paper\" or \"scissors\"!");
                }

            }

            else if (compHand = 2)
            {
                if (inputHand == "rock")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("You lose, paper beats rock.");
                    /*winLoss[round] = -1;
                    round++;*/
                    losses++;
                }
                else if (inputHand == "paper")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("It is a tie. ");
                    /*winLoss[round] = 0;
                    round++;*/
                    ties++;
                }
                else if (inputHand == "scissors")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("You win, scissors beats paper. ");
                    /*winLoss[round] = 1;
                    round++;  */  
                    wins++;                 
                }
                else
                {
                    Console.WriteLine("You must choose \"rock\", \"paper\" or \"scissors\"!");        
                }
            }
            else if (compHand = 3)
            {
                if (inputHand == "rock")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("You win, rock beats scissors.");
                    /*winLoss[round] = 1;
                    round++;*/
                    wins++;

                }
                else if (inputHand == "paper")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("You lose, scissors beats paper.");
                    /*winLoss[round] = -1;
                    round++;*/
                    losses++;
                }
                else if (inputHand == "scissors")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("It is a tie.");
                    /*winLoss[round] = 0;
                    round++;*/
                    ties++;
                }
                else
                {
                    Console.WriteLine("You must choose \"rock\", \"paper\" or \"scissors\"!");
                }
            }
            else if(round >= 10)
            {
                Console.WriteLine("You've hit the game limit!");
            }
        }

        public static void PrintSummary(bool[] record)
        {
            Console.WriteLine("Summary: \n You won " + wins + " games, lost " + losses + " games, and tied " + ties + " games.");
            /*for(int i = 0; i < record.Length; i++)
            {
                string result;
                if(record[i] = 1)
                {
                    result = "Win";
                }
                else if(record[i] = 0)
                {
                    result = "Tie";
                }
                else if(record[i] = -1)
                {
                    result = "Loss";
                }
                Console.WriteLine("Round " + (i+1) + ": " + result);
            }*/
        }
    }
}
