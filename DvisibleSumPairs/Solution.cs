using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    internal class Solution
    {
        /*
         * Given an array of integers and a positive integer K, determine the number of (i,j) pairs where I < J and ar[i] + ar[j] is divisible by k.
         * Example
         * ar =[1,2,3,4,5,6]
         * k = 5
         * 3 paurs meet the criteria: [1,4], [2,3] and [4,6]
         * Function Description
            Complete the divisibleSumPairs function in the editor below.
            divisibleSumPairs has the following parameter(s):

            int n: the length of array ar
            int ar[n]: an array of integers
            int k: the integer divisor
        * Returns
            - int: the number of pairs

        * Input Format
            The first line contains 2 space-separated integers, n and k.
            The second line contains n space-separated integers, each a value of arr[i].
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int divisibleSumPairs(int k, List<int> ar)
        {
            var arr = ar.ToArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i+1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    int mod = sum%k;
                    if (mod == 0)
                    {
                        count++;
                    }
                }
            return count;
        }

        static void Main(String[] args)
        {
            var arr = new List<int>() { 8, 10 };
            int k = 2;
            //Console.WriteLine(getMaxSubArray(input));
            //Console.WriteLine(getMaxSubArray(input2));
            Console.WriteLine(divisibleSumPairs(k, arr));
            //Array.ForEach(TwoSum(input, 9), Console.WriteLine);
            //Array.ForEach(TwoSum(input3, 8), Console.WriteLine);
        }
    }
}
