using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();

            List<int> numbers = input.Split(' ')
                                     .Select(n => int.Parse(n.Trim()))
                                     .ToList();

            ConcurrentDictionary<int, int> results = new ConcurrentDictionary<int, int>();

            Parallel.ForEach(numbers, number =>
            {
                try
                {
                    int squared = number * number; 
                    results[number] = squared; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing number {number}: {ex.Message}");
                }
            });

    
            Console.WriteLine("Squared results:");
            foreach (var key in numbers) 
            {
                Console.WriteLine($"{key}^2 = {results[key]}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter only numbers separated by spaces.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
