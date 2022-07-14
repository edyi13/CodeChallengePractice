using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    internal class Solution
    {
        /*
         * Given an integer array nums, move all 0's to the end of it while maintaining 
         * the relative order of the non-zero elements.
            Note that you must do this in-place without making a copy of the array.
            Example 1:

            Input: nums = [0,1,0,3,12]
            Output: [1,3,12,0,0]
            Example 2:

            Input: nums = [0]
            Output: [0] 

            Constraints:

            1 <= nums.length <= 104
            -231 <= nums[i] <= 231 - 1
         */

        //TODO move each zero to the end by moving each non zero element to the start
        //from the position of the first zero start moving each non zero element ahead of the first zero

        public static int[] moveElementsToEnd(int[] arr, int element)
        {
            //counting how many times the element appears in the array
            int count = arr.Where(item => item == (int)element).Count();

            //getting just the values that are different to the element
            arr = arr.Where(item => item != (int)element).ToArray();

            //initializing the array that will contains the elements
            int[] elemArr = new int[count];

            //filling th elemArr with the element
            for (int i = 0; i < count; i++) elemArr[i] = 0;

            //Array.ForEach(result, Console.WriteLine);
            //Console.WriteLine("****");
            //retunring the two arrays concatenated
            return arr.Concat(elemArr).ToArray();
        }

        public static int[] moveZeros(int[] arr)
        {
            //validating the array
            if (arr.Length < 0) return arr;
            if (!arr.Contains(0)) return arr;
            int[] result = moveElementsToEnd(arr, 0);
            return result;
        }

        //leet code solution not mine
        public static void moveZeros2(int[] nums)
        {
            int lastNonZeroFoundAt = 0;
            // If the current element is different from 0, then we will
            // append it in front of last item that is non 0 element founded. 
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZeroFoundAt++] = nums[i];
                }
            }
            // all the non-zero elements are already at beginning of array.
            // We just need to fill remaining array with 0's.
            for (int i = lastNonZeroFoundAt; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            Array.ForEach(nums, Console.WriteLine);
        }
        static void Main(String[] args)
        {
            int[] input = { 0, 1, 0, 4, -1, 2, 1, -5, 0, 0, 0 };
            int[] input2 = { 0,1,0,3,12};
            int[] input3 = { -2, 0, -1, 1 };
            int[] input4 = { 0 };
            int[] input5 = { };

            Array.ForEach(moveZeros(input2), Console.WriteLine);

            moveZeros2(input3);
        }
    }
}
