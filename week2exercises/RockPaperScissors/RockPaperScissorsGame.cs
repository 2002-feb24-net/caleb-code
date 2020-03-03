using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        //win counter
            int wins = 0;
            int losses = 0;
            int ties = 0;
            int count = 0;
            List<string> resultStringList = new List<string>();
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
                    resultStringList.Add("Tie");
                }
                else if (inputHand == "paper")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("You win, paper beats rock. ");
                    wins++;
                    count++;
                    resultStringList.Add("Win");
                }
                else if (inputHand == "scissors")
                {
                    Console.WriteLine("The computer chose rock.");
                    Console.WriteLine("You lose, rock beats scissors. ");
                    losses++;
                    count++;
                    resultStringList.Add("Loss");
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
                    resultStringList.Add("Loss");
                }
                else if (inputHand == "paper")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("It is a tie. ");
                    ties++;
                    count++;
                    resultStringList.Add("Tie");
                }
                else if (inputHand == "scissors")
                {
                    Console.WriteLine("The computer chose paper.");
                    Console.WriteLine("You win, scissors beats paper. ");
                    wins++;
                    count++;
                    resultStringList.Add("Win");   
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
                    resultStringList.Add("Win");
                }
                else if (inputHand == "paper")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("You lose, scissors beats paper.");
                    losses++;
                    count++;
                    resultStringList.Add("Loss");
                }
                else if (inputHand == "scissors")
                {
                    Console.WriteLine("The computer chose scissors.");
                    Console.WriteLine("It is a tie.");
                    ties++;
                    count++;
                    resultStringList.Add("Tie");
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
            string resultString = "";
            foreach(string str in resultStringList)
            {
                resultString += str + " ";
            }
            Console.WriteLine(resultString);
            Console.WriteLine("You won " + wins + " games, lost " + losses + 
            " games, and tied " + ties + " games, out of a total " + count + " games played.");
            if (wins > losses)
            {
                Console.WriteLine("You've won more than you lost, congrats!");
            }
            else if (losses > wins)
            {
                Console.WriteLine("You've lost more than you won, bummer!");
            }
            else
            {
                Console.WriteLine("On average, you and the computer tied!");
            }
        }
    }
}
