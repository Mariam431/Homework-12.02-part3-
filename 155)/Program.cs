namespace _155_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int n = 10; n <=99; n++)
            {
               if (n % 3 == 0)
               {
                   sum = sum + n;
               }
            }
            Console.WriteLine("The sum of all two-digit numbers which are divisible by 3 is " + sum + ".");
        }
    }
}