using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Library
{
    public class RockPaperScissorsGame
    {
        // fields
        // int wins = 0;
        // int losses = 0;
        // int ties = 0;

        IInputterOutputter _io;
        IRPSStrategy _cs;

        //constructor
        public RockPaperScissorsGame(IInputterOutputter io, IRPSStrategy cs)
        {
            _io = io;
            _cs = cs;
        }//we're using a principle called dependency inversion here

        List<string> roundResults = new List<string>();

        // methods
        public void PlayRound(int stratPref)
        {
            int roundNumber = roundResults.Count + 1;

            _io.Output("Round " + roundNumber + ". Enter R, P, or S: ");
            string input = _io.Input();

            string computersMove;
            //setting the counterstrategy as the computer's next move
            if(stratPref == 1)
            {
                computersMove = _cs.CounterStrategy(roundResults, input);
            }
            else
            {
                computersMove = _cs.CopyStrategy(input);
            }
            //string computersMove = _cs.CounterStrategy(roundResults, input);

            _io.Output("Computer chose " + computersMove);

            // e.g... a bunch of nested if-else
            // compare input and computersMove
            if (input == computersMove)
            {
                // if the moves are the same, it's a tie
                roundResults.Add("tie");
                _io.Output("Tie game.");
            }
            else
            {
                // otherwise, it's either a player win or a player loss.
                if (input == "R")
                {
                    // if the player said rock, the computer either said scissors or paper.
                    if (computersMove == "S")
                    {
                        roundResults.Add("win");
                        _io.Output("You won.");
                    }
                    else
                    {
                        roundResults.Add("loss");
                        _io.Output("You lose.");
                    }
                }
                else if (input == "P")
                {
                    // if the player said paper
                    if (computersMove == "R")
                    {
                        roundResults.Add("win");
                        _io.Output("You won.");
                    }
                    else
                    {
                        roundResults.Add("loss");
                        _io.Output("You lose.");
                    }
                }
                else if (input == "S")
                {
                    // if the player said scissors
                    if (computersMove == "P")
                    {
                        roundResults.Add("win");
                        _io.Output("You won.");
                    }
                    else
                    {
                        roundResults.Add("loss");
                        _io.Output("You lose.");
                    }
                }
            }
        }

        public void PrintSummary()
        {
            string output = "";
            // print out the round results list
            foreach (string result in roundResults)
            {
                output += result + " ";
            }
            output += "\n"; // line break
        }

        /*exercise:
         make a IRPSStrategy interface in this project
         which can decide a move
         (if wanted, use round results parameter)
         
         modify this class to use some implementation of this interface
         just like how it now uses some implementation of IInputterOutputter for I/O
         
         write two classes that each implement that strategy interface
         for two strategies
         
         in the program class, instantiate one of your strategies and pass it to the game
         
         extra:  ask the user which strategy he wants to play against and create the corresponding object*/

    }
}

