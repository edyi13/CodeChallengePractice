using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class QuickSortSolution
    {
        //Input: Int array unordered 
        //Ouput: Int array ordered
        //Example:
        //array = {99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 7}
        //array = { 1, 2, 4, 5, 6, 7, 44, 63, 87, 99, 283}
        public int[] QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = Partition(array,start,end);
                //sort left
                QuickSort(array, start, partitionIndex - 1);
                //sort right
                QuickSort(array, partitionIndex + 1, end);
            }
            return array;
        }

        public int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int partitionIndex = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    int temp = array[i];
                    array[i] = array[partitionIndex];
                    array[partitionIndex] = temp;
                    partitionIndex++;
                }
            }
            int temp2 = array[partitionIndex];
            array[partitionIndex] = array[end];
            array[end] = temp2;
            return partitionIndex;
        }
    }
}
