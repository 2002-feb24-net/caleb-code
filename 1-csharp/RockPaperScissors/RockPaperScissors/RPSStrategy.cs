using RPS.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RPSStrategy : IRPSStrategy
    {
        //with the counterstrategy, if the computer lost or tied, it will get the players previous hand, and play the hand that counters it next round
        //ISSUE: IT SEEMS AS THOUGH COUNTERSTRATEGY IS ALWAYS DEFAULTING TO R
        public string CounterStrategy(List<string> result, string playerHand)  //changed result from string to List<string>
        {
            string compHand = "R";
            if (playerHand == null)
            {
                compHand = "R";
                return compHand;
            }
            else
            {
                //if the result does not contain loss, than player won & comp lost - or both tied, and the computer will counter the previous player hand
                if (!result.Contains("loss"))
                {
                    if (playerHand == "P")
                    {
                        compHand = "S";
                    }
                    else if (playerHand == "R")
                    {
                        compHand = "P";
                    }
                    else if (playerHand == "S")
                    {
                        compHand = "R";
                    }
                }
                else    //if the computer won - or if there is no previous hand - then it will default to rock
                {
                    compHand = "R";;
                }
                return compHand;
            }
        }
        public string CopyStrategy(string playerHand)
        {
            string compHand;
            if (playerHand == null)
            {
                compHand = "R";
                return compHand;
            }
            else
            {
                //regardless of previous wins or losses, the computer will copy the player's most recent hand
                if (playerHand == "P")
                {
                    compHand = "P";
                }
                else if (playerHand == "R")
                {
                    compHand = "R";
                }
                else if (playerHand == "S")
                {
                    compHand = "S";
                }
                else
                {
                    compHand = "R";
                }
                return compHand;
            }
        }
    }
}
