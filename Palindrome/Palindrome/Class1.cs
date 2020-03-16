using System;

namespace Palindrome
{
    public class Class1 : Interface1
    {
        public void Main()
        {
            string inputStr = GetInput();
            bool result = IsPalindrome(inputStr);
            PrintResult(result);
        }

        // Determines if the string is a palindrome, returns bool
        public bool IsPalindrome(string value)
        {
            int first = 0;
            int second = value.Length - 1;
            // keeps looping as long as compared chars are equal
            while (true)
            {
                if (first > second)
                {
                    return true;
                }
                char a = value[first];
                char b = value[second];
                // breaks loop if compared chars are not equal
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                first++;
                second--;
            }
        }

        public string GetInput()
        {
            Console.WriteLine("Enter a string to be evaluated: ");
            string input = Console.ReadLine();
            return input;
        }

        public void PrintResult(bool outputBool)
        {
            if(outputBool == true)
            {
                Console.WriteLine("The input is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The input is not a Palindrome.");
            }
        }
    }
}
