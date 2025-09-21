namespace Assignment11._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfit(new[] { 7, 1, 5, 3, 6, 4 })); // 5
            Console.WriteLine(MaxProfit(new[] { 7, 6, 4, 3, 1 }));     // 0
        }

        static int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int p in prices)
            {
                if (p < minPrice)
                    minPrice = p;                // best buy so far
                else
                    maxProfit = Math.Max(maxProfit, p - minPrice); // sell today
            }
            return maxProfit;
        }
    }
}
