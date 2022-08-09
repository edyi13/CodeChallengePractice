using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SortAlgorithms
{
    public class SelectionSortSolution
    {  //Input: Int array unordered 
       //Ouput: Int array ordered
       //Example:
       //array = {99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0}
       //array = {0, 1, 2, 4, 5, 6, 44, 63, 87, 99, 283}

        public int[] SortMovingGreater(int[] array)//Moving greater number, failed attempt to do the selection sort
        {
            int length = array.Length-1;
            int smallerPos = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (array[smallerPos] < array[j+1])
                    {
                        smallerPos = j;
                    }
                    else
                    {
                        smallerPos = j+1;
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }

                    //Console.WriteLine(JsonConvert.SerializeObject(array, Formatting.Indented));
                }
            }
            return array;
        }

        public int[] SelectionSort(int[] array)
        {
            int length = array.Length-1;
            int smallerPos = 0;
            int nextPos = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = nextPos; j < length; j++)
                {
                    if (array[smallerPos] > array[j+1]) { 
                        smallerPos = j+1;
                    }
                }
                nextPos++;
                int temp = array[i];
                array[i] = array[smallerPos];
                array[smallerPos] = temp;

                //Console.WriteLine(JsonConvert.SerializeObject(array, Formatting.Indented));
            }
            return array;
        }

        public int[] SelectionSortCourse(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int min = i;
                int temp = array[i];
                for (int j = i+1; j < length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                array[i] = array[min];
                array[min] = temp;

                //Console.WriteLine(JsonConvert.SerializeObject(array, Formatting.Indented));
            }
            return array;
        }
    }
}
