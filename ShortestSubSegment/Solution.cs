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
         * Given a paragraph of text, write a program to find the first shortest sub-segment that 
         * contains each of the given k words at least once. A segment is said to be shorter than other
         * if it contains less number of words.
         * Ignore characters other than [a-z][A-Z] in the text. Comparison between the strings should be case-insensitive. 
         * If no sub-segment is found, then the program should display “NO SUBSEGMENT FOUND”.

            Input format :

            First line of the input contains the text.

            Next line contains k , the number of words to be searched.

            Each of the next k lines contains a word.

            Output format :

            Print first shortest sub-segment that contains given k words , ignore special characters, numbers. If no sub-segment is found, print “NO SUBSEGMENT FOUND”

            Sample Input :

            This is a test. This is a programming test. This is a programming test in any language.

            4

            this

            a

            test

            programming

            Sample Output :

            a programming test This

            Explanation :

            Here, segment "a programming test. This" contains given four words. You have to print without special characters or numbers. So output is "a programming test This".  Another segment "This is a programming test." also contains the given four words, but has more number of words. 

            Constraint :

            Total number of characters in a paragraph will not be more than 200,000.
            0 < k <= no. of words in paragraph.
            0 < Each word length < 15
         */

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

        //Modularization of the solution
        //Returns true or false whether an item exists in the array
        public static bool itemExistsInArray(string [] arr, string item)
        {
            return Array.Exists(arr, element => element.ToLower() == item.ToLower());
        }
        //Return the dictionary with the founded words
        public static Dictionary<string, bool> getArraysFounds (string[] arr1, string[] arr2, int countWords)
        {
            int flag = 0;
            var found = new Dictionary<string, bool>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (itemExistsInArray(arr2, arr1[i]))
                {
                    if (flag == 0)
                        found.Clear();

                    if (!found.ContainsKey(arr1[i]))
                    {
                        flag = 1;
                        found.Add(arr1[i], true);
                    }
                }
                else
                {
                    flag = 0;
                }

                if (found.Count == countWords)
                    break;
            }

            return found;
        }

        public static string getShortestSubSegment(string paragraph)
        {
            string result = "NO SUBSEGMENT FOUND";
            if (paragraph.Length > 200000)
                return result;

            if (paragraph.Length == 0)
                return result;

            var foundIt = new Dictionary<string, bool>();
            var arrSplit = paragraph.Split(new char[] { '\n' });
            Regex rgx = new Regex("[^a-zA-Z -]");
            string removeCharac = rgx.Replace(arrSplit[0], "");
            var arrWords = removeCharac.Split(new char[] { ' ' });
            int countWords = Convert.ToInt32(arrSplit[1]);
            if (countWords <= paragraph.Length)
            {
                foundIt = getArraysFounds(arrWords, arrSplit, countWords);
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

        //Return the dictionary with the founded words
        public static Dictionary<string, bool> getArraysFounds2(string[] arr1, string[] arr2, int countWords)
        {
            int flag = 0;
            int start = 0;
            int end = 0;
            int count = 0;
            var found = new Dictionary<string, bool>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (itemExistsInArray(arr2, arr1[i]))
                {
                    if (flag == 0)
                        found.Clear();

                    if (!found.ContainsKey(arr1[i]))
                    {
                        count++;
                        if (count == 1)
                            start = i;

                        flag = 1;
                        found.Add(arr1[i], true);
                    }
                }
                else
                {
                    flag = 0;
                }

                if (found.Count == countWords)
                {
                    end = i;
                    break;
                }
            }

            if (found.Count >= 1)
            {
                for (int i = start; i <= end; i++)
                {
                    found.Add(arr1[i], true);
                }
            }

            return found;
        }

        //Trying to improve the function
        public static string getShortestSubSegment2(string paragraph)
        {
            string result = "NO SUBSEGMENT FOUND";
            if (paragraph.Length > 200000)
                return result;

            if (paragraph.Length == 0)
                return result;

            var foundIt = new Dictionary<string, bool>();
            var arrSplit = paragraph.Split(new char[] { '\n' });
            Regex rgx = new Regex("[^a-zA-Z -]");
            string removeCharac = rgx.Replace(arrSplit[0], "");
            var arrWords = removeCharac.Split(new char[] { ' ' });
            int countWords = Convert.ToInt32(arrSplit[1]);
            if (countWords <= paragraph.Length)
            {
                foundIt = getArraysFounds2(arrWords, arrSplit, countWords);
            }

            if (foundIt.Count >= countWords)
            {
                result = "";
                foreach (var item in foundIt)
                {
                    result += item.Key + " ";
                }

            }

            return result;
        }

        //Trying to improve the function
        public static string[] getShortestSubSegment3(string paragraph)
        {
            string[] result = { "NO SUBSEGMENT FOUND" };
            if (paragraph.Length > 200000)
                return result;

            if (paragraph.Length == 0)
                return result;
            var arrSplit = paragraph.Split(new char[] { '\n' });
            Regex rgx = new Regex("[^a-zA-Z -]");
            string removeCharac = rgx.Replace(arrSplit[0], "");
            var arrParagraph = removeCharac.Split(new char[] { ' ' });
            //int countWords = Convert.ToInt32(arrSplit[1]);
            string[] arrWords = new string[arrSplit.Length-2];
            Array.Copy(arrSplit, 2, arrWords, 0, arrSplit.Length - 2);
            for (int i = 0; i < arrParagraph.Length; i++)
            {

            }

            return arrWords;

        }

        //best option for now
        public static string getShortestSubSegment4(string paragraph)
        {
            string result = "NO SUBSEGMENT FOUND" ;
            if (paragraph.Length > 200000)
                return result;

            if (paragraph.Length == 0)
                return result;
            var arrSplit = paragraph.Split(new char[] { '\n' });
            Regex rgx = new Regex("[^a-zA-Z -]");
            string removeCharac = rgx.Replace(arrSplit[0], "");
            string[] arrParagraph = removeCharac.Split(new char[] { ' ' });
            var arrParagraph2 = new List<string>(arrParagraph);
            //int countWords = Convert.ToInt32(arrSplit[1]);
            string[] arrWords = new string[arrSplit.Length-2];
            Array.Copy(arrSplit, 2, arrWords, 0, arrSplit.Length - 2);
            arrWords = arrWords.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            var arrWords2 = new List<string>(arrWords);
            var min = 0;
            var max = 0;
            var bingo = arrParagraph2;
            var found = false;
            for (int i = 0; i < arrParagraph2.Count; i++)
            {
                var tempSearch = new List<string>(arrWords2).Select(t => t.ToLower()).ToList();
                if (tempSearch.Contains(arrParagraph2[i], StringComparer.OrdinalIgnoreCase))
                {
                    min = i;
                    max = min;
                    tempSearch.Remove(arrParagraph2[i].ToLower());
                    for (int j = min + 1; j < arrParagraph2.Count; j++)
                    {
                        if (tempSearch.Contains(arrParagraph2[j], StringComparer.OrdinalIgnoreCase))
                        {
                            max = j;
                            tempSearch.Remove(arrParagraph2[j].ToLower());
                            if (tempSearch.Count == 0)
                            {
                                if (max != min && max - min + 1 < bingo.Count)
                                {
                                    bingo = arrParagraph2.GetRange(min, max - min + 1);
                                    found = true;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            return !found ? result : string.Join(" ", bingo);
        }
        static void Main(String[] args)
        {
            string input = "This is a test. This is a programming test. This is a programming test in any language." +
                "\n" + "4" + "\n" + "this" + "\n" + "a" + "\n" + "test" + "\n" + "programming" + "\n";
            Console.WriteLine(getShortestSubSegment4(input));

            string input2 = "This is a test. This is a programming test. This is a programming test in any language." +
                "\n" + "4" + "\n" + "a" + "\n" + "test" + "\n" + "this" + "\n" + "program";
            Console.WriteLine(getShortestSubSegment4(input2));

            string input3 = "smqh drlu ncgtleccmf qcruue gnhvtg fshmiq m gjrrv isuxqeelki ktrwrnrf a ocp ncgtleccmf ly hf bhwnbr unkuvni nygavmka." +
                            "\n" + "5" +
                            "\n" + "hf" +
                            "\n" + "m" +
                            "\n" + "ly" +
                            "\n" + "qcruue" +
                            "\n" + "ktrwrnrf";
            Console.WriteLine(getShortestSubSegment4(input3));
            //Array.ForEach(getShortestSubSegment3(input3), Console.WriteLine);
            //qcruue gnhvtg fshmiq m gjrrv isuxqeelki ktrwrnrf a ocp ncgtleccmf ly hf 
            //qcruue gnhvtg fshmiq m gjrrv isuxqeelki ktrwrnrf a ocp ncgtleccmf ly hf
        }
    }
}

