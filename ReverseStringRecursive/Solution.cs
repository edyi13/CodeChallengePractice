using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringRecursive
{
    public class Solution
    {
        public static string reverseRecursive(string word)
        {
            if (word.Length<=1)
                return word[0].ToString();

            string result = word[word.Length-1].ToString();           

            result+= reverseRecursive(word.Substring(0, word.Length-1));
            return result;
        }


        public static string reverseIterative(string word)
        {
            if (word.Length<=1)
                return word[0].ToString();

            string result = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }
        static void Main(String[] args)
        {
            //int result = findFactorialRecursive(5);
            //int result2 = findFactorialIterator(5);
            //Console.WriteLine(result);
            Console.WriteLine(reverseRecursive("yoyo mastery"));
            Console.WriteLine(reverseIterative("yoyo mastery"));
        }
    }
}
