using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximunSubArray
{
    internal class Solution
    {
        /*
         * Given an integer array nums, find the contiguous subarray (containing at least one number) 
         * which has the largest sum and return its sum.

            A subarray is a contiguous part of an array. 

            Example 1:

            Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
            Output: 6
            Explanation: [4,-1,2,1] has the largest sum = 6.
            Example 2:

            Input: nums = [1]
            Output: 1
            Example 3:

            Input: nums = [5,4,-1,7,8]
            Output: 23 

            Constraints:

            1 <= nums.length <= 105
            -104 <= nums[i] <= 104
         */
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
