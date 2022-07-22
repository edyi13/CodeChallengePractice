using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryStringSwapPalindrome
{
    internal class Solution
    {
        /*
         * You are given a binary string, s, consisting of characters 'O' and '1'. Transform this string into a palindrome by performing some operations.
         * In one operation, swap any two characters, s[i] and s[j].
         * Determine the minimun number of swaps required to make the sring palindrome. If it is impossible to do so, then return -1.
         * 
         * Note: A palindrome is a string that reads the same backwards as forward, for example, strings "0", "111", "010", "10101" are palindromes, but strings "001", "10", "11101" are not.
         * 
         * Example
         * String s="0100101". The following shows the minimun number of steps required. It uses 1-based indexing.
            Swap charaters with indies (4,5) ---> original "0100101" ---> swapped "0101001".
            Swap charaters with indies (1,2) ---> previous swapped "0101001".
            Swap charaters with indies (1,2) ---> previous swapped "1001001"  ---> Palindrome found with 2 swaps.
            Return 2 as count swaps
        * Function description
            Input = string with '0' and '1'.
            output = count of swaps or -1 if it is not possible.
        */

        public static string swap(string val, int pos, int pos1)
        {
            var arr = val.ToCharArray();

            var temp = arr[pos];
            arr[pos] = arr[pos1];
            arr[pos1] = temp;
            return new string(arr);
        }

        public static int minSwapsRequired(string s)
        {
            int result = 0;
            if (s.Length == 0 || s.SequenceEqual(s.Reverse()))
            {
                return result;
            }
            int n = s.Length;
            int left = 0;
            int right = n-1;

            while (left < right)
            {
                int swapR = right;
                while (left < swapR && s[left] != s[swapR])
                {
                    swapR--;
                }

                int diff = right - swapR;

                int swapL = left;
                while (left < right && s[swapL] != s[right])
                {
                    swapL++;
                }

                int diff1 = swapL - swapL;

                var temp = s;
                var temp1 = s;

                if (diff < diff1)
                {
                    while (swapR != right)
                    {
                        temp += swap(s, swapR, swapR+1);
                        ++swapR;
                    }
                    s = temp;
                }
                else
                {
                    while (swapL != left)
                    {
                        temp1 += swap(s, swapL, swapL-1);
                        ++swapL;
                    }
                    s = temp1;
                }
                result += Math.Min(diff, diff1);
                ++left;
                --right;
            }
            return result;
        }

        static void Main(String[] args)
        {
        }
    }
}
