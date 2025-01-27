using System;
using Task1; // Import the Task1 namespace to access the Task class

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");

        // Take input from the user and parse it to an integer
        int number = int.Parse(Console.ReadLine());

        // Call the method from the Task1.Task class
        int sum = day.CalculateSumOfDigits(number);

        // Display the result
        Console.WriteLine($"The sum of the digits of {number} is: {sum}");
    }
}
