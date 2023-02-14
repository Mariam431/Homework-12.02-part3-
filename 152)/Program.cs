namespace _152_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int mult = 1;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    mult *= i;
                }
            }
            Console.WriteLine(mult);
        }
    }
}