using System;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        //win counter
            int wins = 0;
            int losses = 0;
            int ties = 0;
            int count = 0;
        public void PlayRound()
        {
            Console.WriteLine("Enter a hand (rock, paper, scissors): ");
            string inputHand = Console.ReadLine();

            Random r = new Random();
            //returns non negative random int less than specified max
            int compHand = r.Next(1, 4);

            if (compHand == 1)
            {
                if (inputHand == "rock")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("It is a tie. ");
                    ties++;
                    count++;
                }
                else if (inputHand == "paper")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("You win, paper beats rock. ");
                    wins++;
                    count++;
                }
                else if (inputHand == "scissors")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("You lose, rock beats scissors. ");
                    losses++;
                    count++;
                }
                else
                {
                    Console.WriteLine("You must choose \"rock\", \"paper\" or \"scissors\"!");
                }

            }

            else if (compHand == 2)
            {
                if (inputHand == "rock")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("You lose, paper beats rock.");
                    losses++;
                    count++;
                }
                else if (inputHand == "paper")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("It is a tie. ");
                    ties++;
                    count++;
                }
                else if (inputHand == "scissors")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("You win, scissors beats paper. ");
                    wins++;    
                    count++;             
                }
                else
                {
                    Console.WriteLine("You must choose \"rock\", \"paper\" or \"scissors\"!");        
                }
            }
            else if (compHand == 3)
            {
                if (inputHand == "rock")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("You win, rock beats scissors.");
                    wins++;
                    count++;
                }
                else if (inputHand == "paper")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("You lose, scissors beats paper.");
                    losses++;
                    count++;
                }
                else if (inputHand == "scissors")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("It is a tie.");
                    ties++;
                    count++;
                }
                else
                {
                    Console.WriteLine("You must choose \"rock\", \"paper\" or \"scissors\"!");
                }
            }
            else if(count >= 10)
            {
                Console.WriteLine("You've hit the game limit!");
            }
        }

        public void PrintSummary()
        {
            Console.WriteLine("Summary: \nYou won " + wins + " games, lost " + losses + 
            " games, and tied " + ties + " games, out of a total " + count + " games played.");
        }
    }
}
