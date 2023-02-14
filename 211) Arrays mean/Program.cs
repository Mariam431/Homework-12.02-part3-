namespace _211__Arrays_mean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural n number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int[] Array = new int[] {};
            for (int i = 0; i<=n; i++ )
            {
                if (Array[i] > 0)
                {
                    sum += Array[i];
                }

            }
            double mean = sum / n;
            Console.WriteLine(mean);
        }
    }
}