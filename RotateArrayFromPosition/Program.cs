public class Program
{
    public static void Rotate(int[] nums, int k)
    {
        //si el tamaño del array es menor que 2 o es igual que k 
        //no hay que realizar nada por que va a quedar en el mismo orden
        if (nums.Length < 2 || nums.Length == k)
            return;
        //determinar el numero de rotaciones
        k = k % nums.Length;
        if (k < 0) k += nums.Length;

        ReverseArray(nums, nums.Length - k, nums.Length - 1);
        ReverseArray(nums, 0, nums.Length - k - 1);
        ReverseArray(nums, 0, nums.Length - 1);
    }

    //metodo para reversar el array
    private static void ReverseArray(int[] nums, int start, int end)
    {
        for (int i = start, j = end; i < j; i++, j--)
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
        }
    }

    public static void Main()
    {
        Rotate([6, 6, 6, 7, 7], 2);
    }
}