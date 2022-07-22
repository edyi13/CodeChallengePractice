using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizingBoxWeights
{
    internal class Solution
    {
        /*
         * Optimizing box weights (example question) an amazon fulfillment associate has a set of items that need to be packed into two boxes. 
         * Given an integer array of the item weights (arr) to be packed, divide the item weights into two subsets, A and B,
         * for packing into the associated boxes, while respecting the following conditions: 
            The intersection of a and b is null the union a and b is equal to the original array.
            The number of elements in subset a is minimal.
            The sum of A's weights is greater than the sum of B's weights. 
         
        * Return the subset a in increasing order where the sum of a's weights is greater than the sum of b's weights.
        * If more than one subset a exists, return the one with the maximal total weight. 
        * Example 
            n=5 
            arr = [13,7,5,6, 2]
        * The 2 subsets in arr that satisfy the conditions for A are (5, 7) and (6, 7]: 
            A is minimal (size 2)  
            Sum(A) = (5 + 7) = 12 > Sum(B) = (2+ 3+6) = 11  
            Sum(A) + (6 + 7) = 13 > sum(B) = (2 + 3 + 5) = 10  
            The intersection of a and b is null and their union is equal to arr.
            The subset a where the sum of its weight is maximal is [6.7).
        * Function description 
            Complete the minimal heaviest set a function in the editor below.
        */
        //WRONG SOLUTION
        public static List<int> minimalHeaviestSetA(List<int> arr)
        {
            var orderedArr = arr.OrderByDescending(i => i).ToArray();
            var result = new List<int>();
            int sumA = 0;
            int sumB = 0;
            int index = 0;
            for (int i = 0; i< orderedArr.Length; i++)
            {
                sumA += orderedArr[i];
                result.Add(orderedArr[i]);
                index = i+1;
                sumB = orderedArr[index..].Sum();
                if (sumA > sumB)
                {
                    if (result.ToArray().Intersect(orderedArr[index..]).Count() == 0)
                    {
                        return result.ToList();
                    }
                }
            }

            return arr;
        }



        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 2, 4, 1, 2 };
            int[] arr2 = { 10, 10, 10, 9, 8, 8 };

            List<int> result = minimalHeaviestSetA(arr2.ToList());

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
