using System;
/*3. make a program that prints the Collatz sequence (up until 1) for a given number,
    taking the number from Console.ReadLine.
    for any number n, the next number in its Collatz sequence is:
    - if n is even, it is n divided by two.
    - if n is odd, it is n times three, plus one.
    for example, for 10, you should print:
10
5
16
8
4
2
1
    the Collatz conjecture says, this process eventually reaches 1 for every number.*/
namespace day2exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            //either conditional works, || demonstrates or
            while(input != 1 || input > 1)
            {
                //- if n is even, it is n divided by two.
                // if dividing by two results in no remainder, number is even
                if(input % 2 == 0)
                {
                    input = input / 2;
                }
                //- if n is odd, it is n times three, plus one.
                else if(input % 2 != 0)
                {
                    input = (input * 3) + 1;
                }
                Console.WriteLine(input);
            }
        }
    }
}
