public class Program
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int j = 0;
        for (int i = m; i < nums1.Length; i++)
        {
            nums1[i] = nums2[j];
            j++;
        }
        Array.Sort(nums1);
        Array.ForEach(nums1, Console.WriteLine);
    }

    public static void Main()
    {
        Merge([0, 1, 2, 0, 0, 0], 3, [2, 5, 6], 3);
        Console.WriteLine("Hello World");
    }
}