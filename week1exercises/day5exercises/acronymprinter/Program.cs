using System;

namespace acronymprinter
{
    class Program
    {
        static void Main(string[] args)
        {
            string multiWord = GetMultiWord();
            string acronymStr = MakeAcronym(multiWord);
            PrintAcronym(multiWord, acronymStr);
        }

        static string GetMultiWord()
        {
            Console.WriteLine("Please enter a phrase you would like to turn into an acronym.");
            string input = Console.ReadLine();
            return input;
        }

        static string MakeAcronym(string phrase)
        {
            //split input phrase into array of words
            string[] words = phrase.Split(' ');
            //initialize char array for letters
            char[] firstLetters = new char[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                //placing first letter of each words array item into firstLetters char array
                firstLetters[i] = words[i][0];
                //capitalize letters for acronym
                firstLetters[i] = char.ToUpper(firstLetters[i]);
            }
            string acronym = new string(firstLetters);
            return acronym;

        }

        static void PrintAcronym(string phrase, string acronym)
        {
            Console.WriteLine("The acronym for \"" + phrase + "\" is " + acronym + ".");
        }
    }
}
