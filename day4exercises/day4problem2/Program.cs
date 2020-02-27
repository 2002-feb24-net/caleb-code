using System;
//given a string and a number, print all the substrings of that length, ex: if string abcd and 2, should print ab, bc, cd
namespace day4problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = GetString();
            int inputNumber = GetNum();
            SubstringDisplay(inputString, inputNumber);
        }

        static string GetString()
        {
            Console.WriteLine("Please enter a string.");
            return Console.ReadLine();
        }

        static int GetNum()
        {
            Console.WriteLine("Please enter a number.");
            return int.Parse(Console.ReadLine());
        }

        static void SubstringDisplay(string inputStr, int inputNum)
        {
            char[] charArr = inputStr.ToCharArray();
            for(int i = 0; i < (inputStr.Length - inputNum + 1); i++)
            {
                string retString = inputStr.Substring(i, inputNum);
                Console.WriteLine(retString);
            }
        }
    }
}
