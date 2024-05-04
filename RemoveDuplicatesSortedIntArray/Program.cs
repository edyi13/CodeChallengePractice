public class Program
{
    public static int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i != nums.Length - 1 && nums[i] == nums[i + 1])
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

    public static int RemoveIfMoreThanTwo(int[] nums)
    {
        if (nums.Length <= 2)
        { // If array length is 2 or less, no duplicates to remove
            return nums.Length;
        }

        int count = 2;

        for (int i = 2; i < nums.Length; i++)
        { // Iterate through the array starting from the third element
            if (nums[i] != nums[count - 2])
            { // If current element is different from element at count-2, it is a non-duplicate
                nums[count] = nums[i]; // Overwrite duplicates with non-duplicates
                count++; // Increment count of non-duplicates
            }
        }

        return count; // Length of modified array with duplicates removed
    }

    public static void Main()
    {
        RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
        Console.WriteLine("Hello World");
    }
}