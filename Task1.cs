using System;

namespace Task1
{
    // Public class to allow access from other files
    public class day
    {
        // Public static method to calculate the sum of digits
        public static int CalculateSumOfDigits(int number)
        {
            int sum = 0;
            int temp = Math.Abs(number); // Use absolute value to handle negative numbers

            while (temp != 0)
            {
                sum += temp % 10; // Add the last digit to the sum
                temp /= 10;       // Remove the last digit
            }

            return sum;
        }
    }
}
