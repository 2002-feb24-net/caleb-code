using System;
//2. make a program that prints a staircase of any size, taking the number from Console.ReadLine.
namespace day2exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string hashtag = "#";
            char space = ' ';

            //try
            //{
                Console.WriteLine("Enter size of staircase: ");
                int input = Convert.ToInt32(Console.ReadLine());
            //}
            /*catch(Exception e)
            {
                Console.WriteLine("{0} Please input an integer.", e);
                Console.WriteLine("Enter size of staircase: ");
                i = Convert.ToInt32(Console.ReadLine());
            }*/

            for(int i = input; i > 0; i--)
            {
                //space is padding element, input is total width
                Console.WriteLine(hashtag.PadLeft(input, space));
                hashtag += "#";
            }
        }
    }
}
