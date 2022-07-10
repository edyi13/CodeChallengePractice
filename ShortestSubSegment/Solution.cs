using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ShortestSubSegment
{
    internal class Solution
    {
        /*
         * input: string paragraph
         *  The first line of the string contains the text to search
         *  The next line the numbers of words to be searched
         *  The next lines have the words that need to be searched
        */

        /*
         * output: 
         * String of words if founded
         * If not should return the text "NO SUBSEGMENT FOUND"
        */

        /*
         * Example:
         * Input:
         * This is a test. This is a programming test. This is a programming test in any language.
         * 4
         * this
         * a
         * test
         * Output:
         * a programming test This
        */

        /*
         * Constraints:
         * Total number of characters in a paragraph will not be more than 200,000.
         * 0 < k <= no. of words in paragraph.
         * 0 < Each word length < 15
        */

        /*
         *Current solution is not working with largest paragraph, try to implement a better solution, 
         *Current solution have a Big O notation of 0(n) for speed time and for space 
        */

        public static string getShortestSubSegment(string paragraph)
        {
            string result = "NO SUBSEGMENT FOUND";
            if (paragraph.Length > 200000)
                return "Paragraph too long.";

            if (paragraph.Length == 0)
                return result;

            var foundIt = new Dictionary<string, bool>();
            var arrSplit = paragraph.Split(new char[] { '\n' });
            Regex rgx = new Regex("[^a-zA-Z -]");
            string removeCharac = rgx.Replace(arrSplit[0], "");
            var arrWords = removeCharac.Split(new char[] { ' ' });
            int countWords = Convert.ToInt32(arrSplit[1]);
            int flag = 0;
            if (countWords <= paragraph.Length)
            {
                for (int i = 0; i < arrWords.Length; i++)
                {                    
                    if (Array.Exists(arrSplit, element => element.ToLower() == arrWords[i].ToLower()))
                    {
                        if(flag == 0)
                            foundIt.Clear();

                        if (!foundIt.ContainsKey(arrWords[i]))
                        {
                            flag = 1;
                            foundIt.Add(arrWords[i], true);
                        }
                    }
                    else
                    {
                        flag = 0;
                    }

                    if (foundIt.Count == countWords)
                        break;
                }
            }

            if (foundIt.Count == countWords)
            {
                result = "";
                foreach (var item in foundIt)
                {
                    result += item.Key + " ";
                }

            }               

            return result;
        }

        static void Main(String[] args)
        {
            string input = "This is a test. This is a programming test. This is a programming test in any language." +
                "\n" + "4" + "\n" + "this" + "\n" + "a" + "\n" + "test" + "\n" + "programming";
            Console.WriteLine(getShortestSubSegment(input));

            string input2 = "This is a test. This is a programming test. This is a programming test in any language." +
                "\n" + "4" + "\n" + "a" + "\n" + "test" + "\n" + "this" + "\n" + "program";
            Console.WriteLine(getShortestSubSegment(input2));
        }
    }
}

