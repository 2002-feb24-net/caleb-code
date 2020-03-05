using System;
using System.Collections.Generic;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //randomizer b/t 1 & 5
            Random rand = new Random();
            int rnd = rand.Next(4);

            //initialize array with random number of arrays
            int[][] jaggedArray = new int[rnd][];  //Cannot implicitly convert type 'System.Random' to 'int'

            //fill out jagged array
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                //creates each level of the jagged array w/ random length
                jaggedArray[i] = new int[rnd];  //Cannot implicitly convert type 'System.Random' to 'int'
                
                //nested for loop
                for (int x = 0; x < jaggedArray[i].Length; x++)
                {
                    //to create randomized numbers for each element in each array
                    jaggedArray[i][x] = rnd;  //Cannot implicitly convert type 'System.Random' to 'int'
                }
            }

            //prints each array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", jaggedArray[i][j], j == (jaggedArray[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();            
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}