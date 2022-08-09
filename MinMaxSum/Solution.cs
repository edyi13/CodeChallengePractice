using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    internal class Solution
    {
        /*
         * Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

         * Example
            The minimum sum is  and the maximum sum is . The function prints

            16 24

         * Function Description
            Complete the miniMaxSum function in the editor below.

            miniMaxSum has the following parameter(s):

            arr: an array of  integers
            Print

            Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

         * Input Format
            A single line of five space-separated integers.

         * Output Format
            Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by 
              summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)
         
         * Sample Input

            1 2 3 4 5
         * Sample Output

            10 14

         * Explanation
            The numbers are , , , , and . Calculate the following sums using four of the five integers:

            Sum everything except , the sum is .
            Sum everything except , the sum is .
            Sum everything except , the sum is .
            Sum everything except , the sum is .
            Sum everything except , the sum is .
            Hints: Beware of integer overflow! Use 64-bit Integer.
         */


        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            var array = arr.ToArray();

            //int max = arr.Max(x => result + x);
            //int min = arr.Min(x => result + x);

            Int64 max = 0;
            Int64 min = 0;

            for (int i = 0; i < array.Length-1; i++)
            {
                min += array[i];
            }

            for (int i = array.Length - 1; i >= 1; i--)
            {
                max += array[i];
            }

            Console.Write(min);
            Console.Write(" ");
            Console.Write(max);
        }

        static void Main(String[] args)
        {
            List<int> arr1 = new List<int>();
            arr1.AddRange(new int[] { 1, 3, 5, 7, 9 });
            List<int> arr2 = new List<int>();
            arr2.AddRange(new int[] { 1, 2, 3, 4, 5 });
            List<int> arr3 = new List<int>();
            arr3.AddRange(new int[] { 7, 69, 2, 221, 8974 });
            List<int> arr4 = new List<int>();
            arr4.AddRange(new int[] { 793810624, 895642170, 685903712, 623789054, 468592370 });
            //miniMaxSum(arr1);
            //miniMaxSum(arr2);
            miniMaxSum(arr4);
            //Array.ForEach(getArrTwoSum(input, 9), Console.WriteLine);
            //Array.ForEach(getArrTwoSum(input3, 8), Console.WriteLine);

        }
    }
}
