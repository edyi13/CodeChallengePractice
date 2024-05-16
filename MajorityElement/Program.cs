public class Program
{
    public static int MajorityElement(int[] nums)
    {
        if (nums.Length < 2) return nums[0];
        Array.Sort(nums);
        if (nums.Length <= 5) return nums[(nums.Length / 2)];
        int count = 0;
        int countTemp = 0;
        int result = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (i >= (nums.Length / 2))
            {
                return nums[i];
            }
            if (nums[i] == nums[i - 1])
            {
                countTemp++;
                if (countTemp > count)
                    result = nums[i];
            }
            else if (nums[i] != nums[i - 1] && countTemp > 0 && countTemp > count)
            {
                count = countTemp;
                countTemp = 0;
            }
        }
        return result;
    }

    public static void Main()
    {
        MajorityElement([6, 6, 6, 7, 7]);
        Console.WriteLine("Hello World");
    }
}