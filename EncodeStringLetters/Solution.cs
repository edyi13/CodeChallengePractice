using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeStringLetters
{
    internal class Solution
    {
        public static string encodeLetters(string input)// Big 0 notation ---> 0(n)
        {
            StringBuilder sh = new StringBuilder();
            char[] arr = input.ToCharArray();
            char prevChar = ' ';
            int counter = 0;

            foreach (var item in arr)
            {
                if(item == prevChar)
                {
                    counter++;
                }
                else
                {
                    if(prevChar != ' ')
                        sh.Append(counter).Append(prevChar);
                    prevChar = item;
                    counter = 1;
                }
            }

            sh.Append(counter).Append(prevChar);
            return sh.ToString();
        }
        static void Main(String[] args)
        {
            //int result = findFactorialRecursive(5);
            //int result2 = findFactorialIterator(5);
            //Console.WriteLine(reverseRecursive("yoyo mastery"));
            Console.WriteLine(encodeLetters("aabbbccccdddddabcd"));
        }
    }
}
