public class Program
{
    //201 / 212 testcases passed
    public static int MaxProfitWrong(int[] prices)
    {
        if (prices.Length <= 1) return 0;

        int min = prices[0];
        int max = prices[1];
        int result = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (i < prices.Length - 1 && prices[i] < min)
            {

                Console.WriteLine("min: " + min);
                Console.WriteLine("max: " + max);
                if ((max - min) <= (prices[i + 1] - prices[i]))
                {
                    min = prices[i];
                    max = 0;
                }
            }

            if (prices[i] > 0 && prices[i] > max && prices[i] > min)
            {
                if ((max - min) < (prices[i] - min))
                {
                    max = prices[i];
                }
            }
        }
        Console.WriteLine("end min: " + min);
        Console.WriteLine("end max: " + max);
        result = max - min;
        return result < 0 ? 0 : result;
    }

    //passes all the test
    public static int MaxProfit(int[] prices)
    {
        int minPrice = 10001;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                int profit = prices[i] - minPrice;

                if (profit > maxProfit) maxProfit = profit;
            }
        }
        return maxProfit;
    }

    public static void Main()
    {
        MaxProfit([6, 1, 6, 7, 5]);
    }
}