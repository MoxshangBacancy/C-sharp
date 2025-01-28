using System;

namespace Task1
{
    public class day
    {
        public static int CalculateSumOfDigits(int number)
        {
            int sum = 0;
            int temp = Math.Abs(number); 

            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;     
            }

            return sum;
        }
    }
}
