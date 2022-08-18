using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class MergeSortSolution
    {
        //Input: Int array unordered 
        //Ouput: Int array ordered
        //Example:
        //array = {99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0}
        //array = {0, 1, 2, 4, 5, 6, 44, 63, 87, 99, 283}
        //Most of the solution comes from the course and youtube
        public int[] MergeSort(int[] array)
        {
            if(array.Length == 1) return array;

            //split array in into right and left

            var halfWay = array.Length/2;

            var leftArr = array.Take(halfWay).ToArray();
            var rightArr = array.Skip(halfWay).ToArray();

            return MergeArrays(
                MergeSort(leftArr), MergeSort(rightArr)
            );
        }

        public int[] MergeArrays(int[] arrayL, int[] arrayR)
        {
            
            List<int> result = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (arrayL.Length > leftIndex && arrayR.Length > rightIndex)
            {
                if (arrayL[leftIndex] <= arrayR[rightIndex])
                {
                    result.Add(arrayL[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(arrayR[rightIndex]);
                    rightIndex++;
                }
            }

            while (arrayL.Length > leftIndex)
            {
                result.Add(arrayL[leftIndex]);
                leftIndex++;
            }

            while (arrayR.Length > rightIndex)
            {
                result.Add(arrayR[rightIndex]);
                rightIndex++;
            }
            //Console.WriteLine("**************Left**************");
            //Console.WriteLine(JsonConvert.SerializeObject(arrayL, Formatting.Indented));
            //Console.WriteLine("**************Right**************");
            //Console.WriteLine(JsonConvert.SerializeObject(arrayR, Formatting.Indented));


            return result.ToArray();
        }

    }
}
