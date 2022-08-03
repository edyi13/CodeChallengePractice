using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    internal class Solution
    {
        public static List<int> fibonacciSequenceRecursive(int number)
        {
            List<int> fibo = new List<int>();

            return fibo;
        }

        public static int fibonacciRecursive(int number)// Big 0 notation ---> 0(2^n)
        {
            if(number < 2) return number;

            return  fibonacciRecursive(number-1) + fibonacciRecursive(number-2);
        }

        public static int fibonacciIterator(int number)// Big 0 notation ---> 0(n)
        {
            int fibo = 1;
            int count = 2;
            int[] visited = new int[number+1];
            visited[0] = 0;
            visited[1] = 1;
            while (number > 1)
            {
                fibo = visited[count-2] + visited[count-1];
                visited[count] = fibo;
                number--;
                count++;
            }
            return fibo;

        }

        public static int fibonacciIterator2(int number)// Big 0 notation ---> 0(n)
        {
            int[] arrFibo = new int[number+1];
            arrFibo[0] = 0;
            arrFibo[1] = 1;
            for (int i = 2; i < number; i++)
            {
                arrFibo[i] = arrFibo[i-2] + arrFibo[i-1];
            }
            return arrFibo[number];

        }

        static void Main(String[] args)
        {
            Console.WriteLine("fibonacci index of 8 = " + fibonacciIterator(8));
            Console.WriteLine("fibonacci index of 10 = " + fibonacciRecursive(10));
            Console.WriteLine("fibonacci index of 12 = " + fibonacciIterator(12));
        }
    }
}
