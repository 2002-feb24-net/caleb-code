/*There are 267 Fizz's.
There are 134 Buzz's.
There are 66 FizzBuzz's.*/
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables initialized, will count each type
            int f = 0;
            int b = 0;
            int fb = 0;
            //For each number from 1 to 1000 in order,
            for(int i = 1; i <= 1000; i++)
            {
                //print "Fizz" for the ones divisible by 3 (& not 5)
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine(i + ", Fizz");
                    f++;
                }
                //print "Buzz" for the ones divisible by 5 (& not 3)
                else if ((i % 5 == 0) && (i % 3 != 0))
                {
                    Console.WriteLine(i + ", Buzz");
                    b++;
                }
                //print "Fizzbuzz" for the ones divisible by both 3 and 5
                else if ((i % 5 == 0) && (i % 3 == 0))
                {
                    Console.WriteLine(i + ", FizzBuzz");
                    fb++;
                }
                //print the number itself, for all the rest of the numbers
                else
                {
                    Console.WriteLine(i);
                }
            }
            /*Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.
            Your code should calculate that, and, put the numbers you get in a comment, so I
            can see them without running the code.*/
            Console.WriteLine("There are " + f + " Fizz's.");
            Console.WriteLine("There are " + b + " Buzz's.");
            Console.WriteLine("There are " + fb + " FizzBuzz's.");
            /*There are 267 Fizz's.
            There are 134 Buzz's.
            There are 66 FizzBuzz's.*/
        }
    }
}
