using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHaveSameLetters
{
    internal class Solution
    {
        public static bool CanConstruct(string textA, string textB)
        {
            //Input: 2 strings, 1 string should be able to be constructed with letters from string 2
            //Output: true or false
            //Constraint: string are letters in lowercase
            //Example: dog - god should be true
            if(textA.Length == 0 && textB.Length == 0) return false;
            if(textA.Length == 1 && textB.Length == 1)
                if (textA.Contains(textB))
                {
                    return true;
                }else return false;

            char[] charsA = textA.ToCharArray();
            char[] charsB = textB.ToCharArray();
            int countA = 0;
            int countB = 0;
            int count = 0;
            for (int i = 0; i < charsA.Length; i++)
            {
                countA = charsA.Count(item => item == charsA[i]);
                countB = charsB.Count(item => item == charsA[i]);
                if (countA <= countB)
                {
                    count++;
                }
            }
            if (count != charsA.Length) return false;
            return true;
        }


        public static bool CanConstruct2(string textA, string textB)
        {
            //Input: 2 strings, 1 string should be able to be constructed with letters from string 2
            //Output: true or false
            //Constraint: string are letters in lowercase
            //Example: dog - god should be true
            if (textA.Length == 0 && textB.Length == 0) return false;
            if (textA.Length == 1 && textB.Length == 1)
                if (textA.Contains(textB))
                {
                    return true;
                }
                else return false;

            char[] charsA = textA.ToCharArray();
            char[] charsB = textB.ToCharArray();
            int count = 0;
            for (int i = 0; i < charsA.Length; i++)
            {
                var element = charsB.FirstOrDefault(item => item == charsA[i]);
                if(Char.IsLetter(element))
                {
                    count++;
                    int index = new String(charsB).IndexOf(element);
                    charsB = new String(charsB).Remove(index,1).ToCharArray();

                }
            }
            if (count != charsA.Length) return false;
            return true;
        }

        public static bool CanConstruct3(string textA, string textB)
        {
            //Input: 2 strings, 1 string should be able to be constructed with letters from string 2
            //Output: true or false
            //Constraint: string are letters in lowercase
            //Example: dog - god should be true
            if (textA.Length == 0 && textB.Length == 0) return false;
            if (textA.Length == 1 && textB.Length == 1)
                if (textA.Contains(textB))
                {
                    return true;
                }
                else return false;

            //char[] charsA = textA.ToCharArray();
            //char[] charsB = textB.ToCharArray();
            int count = 0;
            for (int i = 0; i < textA.Length; i++)
            {
                if (textB.Contains(textA[i]))
                {
                    count++;
                    int index = textB.IndexOf(textA[i]);
                    textB = textB.Remove(index, 1);
                }
            }
            if (count != textA.Length) return false;
            return true;
        }
        static void Main(String[] args)
        {
            Console.WriteLine(CanConstruct3("aa","ab"));
        }
    }
}
