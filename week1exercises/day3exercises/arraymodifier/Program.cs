using System;

namespace ArrayModifier
{
    class Program
    {
        // accept input from user, list of numbers separated by spaces
        // interpret that as an int array
        // print the array's values back to the user
        // ask the user for some operation
        // print the array's new values to the user.
        static void Main(string[] args)
        {
            string input = GetInput();
            int[] array = InterpretStringAsArray(input);
            PrintArray(array);
            string inop = AskUserOp();
            int innum = AskUserNum();
            NewValues(array, inop, innum);
        }

        static void PrintArray(int[] a)
        {
            Console.WriteLine("This is the input array: ");
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static int[] InterpretStringAsArray(string str)
        {
            
            string[] strArray = str.Split(' ');
            int[] array = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
                {
                    array[i] = Int32.Parse(strArray[i]);
                }
            return array;
        }

/*
        static int[] InterpretStringAsArray2(string str)
        {
            return Array.ConvertAll(str.Split(' '), int.Parse);
        }
*/

/*
        static int[] InterpretStringAsArray3(string str)
        {
            //split array on space characters
            string[] parts = str.Split(' ');
            //make a new int array with the right size
            int[] nums = new int[parts.Length];
            //loop, for each string, convert it to an int
            for(int i = 0; i < parts.Length; i++)
            {
                //before this line, nums[i] is at its default of 0
                nums[i] = int.Parse(parts[i]);
                //now, it has the numerical value of parts[i]
            }
            // send the new array back to the code that is using InterpretStringAsArray
            return nums;
        }
*/

        // any method is going to have
        // 1. a name
        // 2. a return value: either nothing (void), or some type e.g. int
            // what result does the method need to send back to the code that uses this method.
        // 3. a list of parameters (maybe empty)
            // does the method need any input from the code that uses it to do its job.
        static string GetInput()
        {
            Console.WriteLine("Please enter a list of numbers separated by spaces: ");
            string input = Console.ReadLine();
            return input;
        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
            // you use "return" to send the return value back to the
            // code that calls this method.
        }

        static string AskUserOp()
        {
            Console.WriteLine("Please enter an operator (*, /, +, -) with which to modify the array: ");
            string inop = Console.ReadLine();
            return inop;
        }

        static int AskUserNum()
        {
            Console.WriteLine("Please enter an integer to modify the array in conjunction with the operator: ");
            int innum = int.Parse(Console.ReadLine());
            return innum;
        }

        static void NewValues(int[] modArray, string op, int num)
        {
            if(op == "*")
            {
                for (int i = 0; i < (modArray.Length); i++)
                {
                    int opResult = modArray[i] * num;
                    Console.Write(opResult + " ");
                }
            }
            else if(op == "/")
            {
                for (int i = 0; i < (modArray.Length); i++)
                {
                    decimal opResult = modArray[i] / num;
                    Console.Write(opResult + " ");
                }
            }
            else if(op == "+")
            {
                for (int i = 0; i < (modArray.Length); i++)
                {
                    int opResult = modArray[i] + num;
                    Console.Write(opResult + " ");
                }
            }
            else if(op == "-")
            {
                for (int i = 0; i < (modArray.Length); i++)
                {
                    int opResult = modArray[i] - num;
                    Console.Write(opResult + " ");
                }
            }
        }
    }
}
