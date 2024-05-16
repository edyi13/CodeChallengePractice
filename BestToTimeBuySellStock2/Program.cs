public class Program
{
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length <= 1) return 0;

        int profit = 0, min = prices[0], max = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > max)
            {
                max = prices[i];
                continue;
            }

            if (prices[i] < max)
            {
                profit += max - min;
                min = prices[i];
                max = prices[i];
            }
        }
        profit += max - min;
        return profit < 0 ? 0 : profit;
    }
    public static void Main()
    {
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(MaxProfit(prices));
    }
}