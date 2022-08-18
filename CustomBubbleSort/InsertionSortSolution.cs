using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class InsertionSortSolution
    {
        //Input: Int array unordered 
        //Ouput: Int array ordered
        //Example:
        //array = {99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0}
        //array = {0, 1, 2, 4, 5, 6, 44, 63, 87, 99, 283}

        public int[] InsertionSort(int[] array)
        {
            List<int> result = new List<int>();
            result.Add(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < result.Count(); j++)
                {
                    if (result[j] > array[i])
                    {
                        result.Insert(j, array[i]);
                        break;
                    }
                    else if (result[j] < array[i])
                    {
                        int pos = j+1;
                        if (pos == result.Count) pos = j;
                        if (result[pos] <  array[i])
                        {
                            continue;
                        }
                        else
                        {
                            result.Insert(j+1, array[i]);
                            break;
                        }
                    }
                }
            }
            return result.ToArray();
        }

        public int[] InsertionSortCourse(int[] array)
        {
            int length = array.Length;
            List<int> result = array.ToList();
            for (int i = 0; i < length; i++)
            {
                if (result[i] < result[0])
                {
                    var temp = result[i];
                    result.RemoveAt(i);
                    result.Insert(0, temp);
                }
                else
                {
                    for (int j = 1; j < i; j++)
                    {
                        if (result[i] > result[j-1] && result[i] < result[j])
                        {
                            //in the course they use splice a javascript function
                            var temp = result[i];
                            result.RemoveAt(i);
                            result.Insert(j, temp);
                        }
                    }
                }
            }
            return result.ToArray();
        }
    }
}
