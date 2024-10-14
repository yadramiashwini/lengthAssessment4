namespace lengthAssessment4
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Define maximum length for input
            const int maxLength = 100;

            Console.Write("Enter the string: ");
            string input = Console.ReadLine();

            // Check for length validity
            if (input.Length > maxLength)
            {
                Console.WriteLine("Invalid length");
                return;
            }

            // Split the input string by colons
            string[] items = input.Split(':');
            Dictionary<string, int> itemCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            // Count occurrences of each item
            foreach (string item in items)
            {
                if (!itemCounts.ContainsKey(item))
                {
                    itemCounts[item] = 0;
                }
                itemCounts[item]++;
            }

            // Print the results
            foreach (var pair in itemCounts)
            {
                Console.WriteLine($"{pair.Key.ToUpper()}:{pair.Value}");
            }
        }
    }
}
