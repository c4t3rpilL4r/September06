using System;

namespace First_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter word: ");

            string input = Console.ReadLine();
            Console.WriteLine($"Output is: {(input.Length % 2 == 1 ? input[input.Length / 2].ToString() : input.Substring((input.Length / 2) - 1, 2))}");
            Console.ReadLine();
        }
    }
}
