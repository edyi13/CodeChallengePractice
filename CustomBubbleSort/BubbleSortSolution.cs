using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class BubbleSortSolution
    {
        //Input: Int array unordered 
        //Ouput: Int array ordered
        //Example:
        //array = {99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0}
        //array = {0, 1, 2, 4, 5, 6, 44, 63, 87, 99, 283}
        public int[] BubbleSort(int[] array)
        {
            int counter = 0;
            int pos = 0;
            while (counter+1 < array.Length)
            {
                counter++;
                if (pos+1 == array.Length) pos = 0;

                if (array[pos] > array[pos+1])
                {
                    counter = 0;
                    SwapItems(array, pos);
                }
                pos++;
            }
            return array;
        }

        public int[] SwapItems(int[] array, int position)
        {
            for (int i = position; i < array.Length-1; i++)
            {
                var temp = array[i];
                if (array[i] > array[i+1])
                {
                    array[i] = array[i+1];
                    array[i+1] = temp;
                }
            }

            return array;
        }

        public int[] BubbleSortCourse(int[] array)
        {
            int length = array.Length-1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
