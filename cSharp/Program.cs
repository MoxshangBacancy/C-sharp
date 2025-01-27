using System;
using Task1; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");

        int number = int.Parse(Console.ReadLine());


        int sum = day.CalculateSumOfDigits(number);

   
        Console.WriteLine($"The sum of the digits of {number} is: {sum}");
    }
}
