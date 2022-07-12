using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximunSubArray
{
    internal class Solution
    {
        public static int getMaxSubArray(int[] nums)
        {
            int result = 0;
            int max = 0;

            if (nums.Max() < 0)
            {
                return nums.Max();
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
                if (result > max)
                    max = result;

                if (result < 0)
                {
                    result = 0;
                }
            }
            return result > max ? result : max;
        }

        static void Main(String[] args)
        {
            int[] input = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int[] input2 = { 5, 4, -1, 7, 8 };
            int[] input3 = { -2, -1 };
            //Console.WriteLine(getMaxSubArray(input));
            //Console.WriteLine(getMaxSubArray(input2));
            Console.WriteLine(getMaxSubArray(input3));
            //Array.ForEach(TwoSum(input, 9), Console.WriteLine);
            //Array.ForEach(TwoSum(input3, 8), Console.WriteLine);
        }
    }
}
