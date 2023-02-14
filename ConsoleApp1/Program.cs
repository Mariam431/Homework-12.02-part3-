using System;

namespace LargestFourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestNumber = 0;
            for (int i = 999; i >= 100; i--)
            {
                int n = i * 18;
                int sqrt = (int)Math.Sqrt(n);
                if (sqrt * sqrt == n && i > largestNumber)
                {
                    largestNumber = i;
                }
            }

            Console.WriteLine("The largest four-digit number is: " + largestNumber);
        }
    }
}
