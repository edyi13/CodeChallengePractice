using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFactorial
{
    public class Solution
    {
        public static int findFactorialRecursive(int number)// Big 0 notation ---> 0(n)
        {
            if (number == 2) return 2;

            return number * findFactorialRecursive(number-1);
        }

        public static int findFactorialIterator(int number)// Big 0 notation ---> 0(n)
        {
            int result = number;
            for (int i = 1; i < number; i++)
            {
                result *= i;
            }

            return result;
        }

        public static int findFactorialIterator2(int number)// Big 0 notation ---> 0(n)
        {
            if (number == 2) return 2;

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        static void Main(String[] args)
        {
            int result = findFactorialRecursive(5);
            int result2 = findFactorialIterator(5);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}