namespace _157_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int n = 100; n <= 999; n++)
            {
                if (!(n % 5 == 0))
                {
                    sum += n;
                }
            }
            Console.WriteLine(sum);
        }
    }
}