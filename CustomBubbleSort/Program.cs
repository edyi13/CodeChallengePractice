using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    internal class Program
    {
        static void Main(String[] args)
        {
            BubbleSortSolution bubbleSort = new BubbleSortSolution();
            int[] input = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            //Array.ForEach(bubbleSort.BubbleSort(input), Console.WriteLine);
            //Console.WriteLine("/**********************************/");
            //Array.ForEach(bubbleSort.BubbleSortCourse(input), Console.WriteLine);

            SelectionSortSolution selectionSort = new SelectionSortSolution();
            int[] input2 = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            Array.ForEach(selectionSort.SelectionSort(input), Console.WriteLine);
            Console.WriteLine("/**********************************/");
            Array.ForEach(selectionSort.SelectionSortCourse(input2), Console.WriteLine);
            Console.WriteLine("/**********************************/");
        }
    }
}
