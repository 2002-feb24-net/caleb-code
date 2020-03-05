using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 38, 80, 65, 13, 33, 28, 43, 7 };
            int[] arr = { 3, 2, 1, 4, 6 };

            //instantiate temporary variable for handoff
            int temp = 0;

            //moves through array length
            for (int z = 0; z < arr.Length; z++) {
                for (int x = 0; x < arr.Length - 1; x++) {
                    //evaluates if int1 is less than int2
                    if (arr[x] > arr[x + 1]) {
                        //places int2 into temp variable
                        temp = arr[x + 1];
                        //places int1 into int2
                        arr[x + 1] = arr[x];
                        //places temp variable(int2) into int1
                        arr[x] = temp;
                    }
                }
            }

            //print array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            //keeps program from ending b/f user confirms exit
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
