using System;
using System.Linq;

namespace Second_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool inputIsInvalid;
            int numberOfVowels = 0;

            Console.Write("Please enter word: ");
            
            do
            {
                input = Console.ReadLine();
                inputIsInvalid = false;

                if (input.Any(x => !(Char.IsLetter(x) || Char.IsWhiteSpace(x)) || Char.IsUpper(x)))
                {
                    Console.WriteLine(@"Word is invalid. Word should only include lowercase letters and/or spaces. Try again.");
                    Console.Write("Please enter word: ");
                    inputIsInvalid = true;
                }
            } while (inputIsInvalid);

            numberOfVowels = input.Count("aeiou".Contains);

            Console.WriteLine(numberOfVowels);
            Console.ReadLine();
        }
    }
}
