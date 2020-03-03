using System;
//make a program that prints a staircase of size 8.
//    (it should ascend up to the right, not descend down to the right.)
namespace day2exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hashtag = "#";
            char space = ' ';

            for(int i = 8; i > 0; i--)
            {
                //space is padding element, 8 is total width
                Console.WriteLine(hashtag.PadLeft(8, space));
                hashtag += "#";
            }
            /*
            int length = 8;
            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine(new String(' ', length - i) + new String('#', i));
            }
            */
        }
    }
}
