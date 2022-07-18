using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanLetterToInteger
{
    internal class Solution
    {
        /*
         * Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

            Symbol       Value
            I             1
            V             5
            X             10
            L             50
            C             100
            D             500
            M             1000
            For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

         * Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.
            Given a roman numeral, convert it to an integer.

 

         * Example 1:

            Input: s = "III"
            Output: 3
            Explanation: III = 3.
            Example 2:

            Input: s = "LVIII"
            Output: 58
            Explanation: L = 50, V= 5, III = 3.
            Example 3:

            Input: s = "MCMXCIV"
            Output: 1994
            Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

         * Constraints:

            1 <= s.length <= 15
            s contains only the characters ("I", "V", "X", "L", "C", "D", "M").
            It is guaranteed that s is a valid roman numeral in the range [1, 3999].
        */

        public static int RomanToInt(string s)
        {
            Dictionary<string, int> roman = new Dictionary<string, int>();
            var arr = s.ToArray();
            roman.Add("I", 1);
            roman.Add("V", 5);
            roman.Add("X", 10);
            roman.Add("L", 50);
            roman.Add("C", 100);
            roman.Add("D", 500);
            roman.Add("M", 1000);
            roman.Add("IV", 4);
            roman.Add("IX", 9);
            roman.Add("XL", 40);
            roman.Add("XC", 90);
            roman.Add("CD", 400);
            roman.Add("CM", 900);
            int amount = 0;
            int val = 0;

            if (arr.Length == 0) return 0;
            if (arr.Length == 1)
            {
                roman.TryGetValue(arr[0].ToString(), out val);
                return val;
            }


            for (int i = 0; i < arr.Length-1; i++)
            {
                if (roman.TryGetValue(arr[i].ToString() + arr[i+1].ToString(), out val))
                {
                    Console.WriteLine(arr[i] + " " + arr[i+1]);
                    if (val != 0) amount += val;
                    i++;
                    if (i == arr.Length-2)
                    {
                        if (roman.TryGetValue(arr[i+1].ToString(), out val))
                        {
                            Console.WriteLine(i+1);
                            Console.WriteLine(arr[i+1]);
                            if (val != 0) amount += val;
                        }
                    }
                    continue;
                }

                if (roman.TryGetValue(arr[i].ToString(), out val))
                {
                    Console.WriteLine(i);
                    Console.WriteLine(arr[i]);
                    if (val != 0) amount += val;
                }

                if (i == arr.Length-2)
                {
                    if (roman.TryGetValue(arr[i+1].ToString(), out val))
                    {
                        Console.WriteLine(i+1);
                        Console.WriteLine(arr[i+1]);
                        if (val != 0) amount += val;
                    }
                }

            }

            return amount;
        }

        static void Main(String[] args)
        {
            //string input = "MCMXCIV";
            //string input2 = "LVIII";
            string input3 = "III";
            string input4 = "MDCXCV";
            //Console.WriteLine(getMaxSubArray(input));
            //Console.WriteLine(getMaxSubArray(input2));
            //Console.WriteLine(RomanToInt(input));
            //Console.WriteLine(RomanToInt(input2));
            Console.WriteLine(RomanToInt(input4));
            //Array.ForEach(TwoSum(input, 9), Console.WriteLine);
            //Array.ForEach(TwoSum(input3, 8), Console.WriteLine);
        }
    }
}
