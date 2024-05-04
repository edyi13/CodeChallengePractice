public class Program
{
    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                nums[i] = 100;
            }
            else
            {
                k++;
            }
        }
        Array.Sort(nums);
        Array.ForEach(nums, Console.WriteLine);
        return k;
    }



    public static void Main()
    {
        RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2);
        Console.WriteLine("Hello World");
    }
}