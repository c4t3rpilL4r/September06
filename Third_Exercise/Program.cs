using System;
using System.Collections.Generic;
using System.Linq;

namespace Third_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter word: ");

            string input = "";
            string result = "";
            bool isLetterValid;

            do
            {
                input = Console.ReadLine();
                isLetterValid = false;

                if (input.Any(x => !(Char.ToLower(x).Equals('a')
                    || Char.ToLower(x).Equals('b')
                    || Char.ToLower(x).Equals('c')
                    || Char.ToLower(x).Equals('d')
                    || Char.ToLower(x).Equals('e'))))
                {
                    Console.WriteLine($"Input is invalid. Only letters \"a/A\", \"b/B\", \"c/C\", \"d/D\", \"e/E\" are allowed to be entered. Try again.");
                    Console.Write("Please enter word: ");
                    isLetterValid = true;
                }

            } while (isLetterValid);

            Dictionary<char, int> inputDict = new Dictionary<char, int>();
            inputDict.Add('a', input.Count("a".Contains) - input.Count("A".Contains));
            inputDict.Add('b', input.Count("b".Contains) - input.Count("B".Contains));
            inputDict.Add('c', input.Count("c".Contains) - input.Count("C".Contains));
            inputDict.Add('d', input.Count("d".Contains) - input.Count("D".Contains));
            inputDict.Add('e', input.Count("e".Contains) - input.Count("E".Contains));

            foreach (var item in inputDict.OrderByDescending(x => x.Value))
            {
                result += $"{item.Key}:{item.Value}, ";
            }

            Console.WriteLine($"Output is: {result}");
            Console.ReadLine();
        }
    }
}
