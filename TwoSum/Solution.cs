using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Solution
    {
        public static int[] getArrTwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> comp = new Dictionary<int, int>();

            for (int i = 0; i<nums.Length; i++)
            {
                if (comp.ContainsValue(nums[i]))
                {
                    result[0] = comp.FirstOrDefault(x => x.Value == nums[i]).Key;
                    result[1] = i;
                    break;
                }
                else
                {
                    comp.Add(i, target - nums[i]);
                }
            }
            return result;
        }

        static void Main(String[] args)
        {
            int[] input = { 2, 7, 11, 15};
            int[] input3 = { 7, 3, 5 };

            Array.ForEach(getArrTwoSum(input, 9), Console.WriteLine);
            Array.ForEach(getArrTwoSum(input3, 8), Console.WriteLine);

        }
    }
}
