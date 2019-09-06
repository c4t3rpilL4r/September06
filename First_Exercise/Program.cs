using System;

namespace First_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter word: ");

            string input = Console.ReadLine();
            int middle = input.Length / 2;
            Console.WriteLine(input.Length % 2 == 1 ? $"Output is: {input[middle]}" : $"Output is: {input[middle - 1]}{input[middle]}");
            Console.WriteLine(input.Length % 2 == 1 ? $"Output is: {input[input.Length / 2]}" : $"Output is: {input[(input.Length / 2) - 1]}{input[input.Length / 2]}");
            Console.WriteLine($"Output is: {(input.Length % 2 == 1 ? input[middle] : input[middle - 1] + input[middle])}");
            Console.WriteLine($"Output is: {(input.Length % 2 == 1 ? input[middle] : input.Substring(middle - 1, 2))}");
            Console.ReadLine();
        }
    }
}
