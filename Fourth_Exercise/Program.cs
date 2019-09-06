using System;
using System.Linq;

namespace Fourth_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            bool isInputValid;

            Console.Write("Please enter word: ");

            do
            {
                input = Console.ReadLine();
                isInputValid = false;

                if (input.Any(x => !Char.IsLetter(x)))
                {
                    Console.WriteLine("Only a single word, compose of letters and with no spaces, is allowed. Try again.");
                    Console.Write("Please enter word: ");
                    isInputValid = true;
                }
            } while (isInputValid);

            Console.Write("Output is: ");
            Console.WriteLine(input.SequenceEqual(input.OrderBy(x => x)) ? "IN ORDER" : "NOT IN ORDER");
            Console.ReadLine();

            // Note: .SequenceEqual will compare the output of input.OrderBy(x => x) to input if the letters are in the same order
        }
    }
}
