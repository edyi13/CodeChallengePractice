using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    internal class Program
    {
        //#1 - Sort 10 schools around your house by distance:
        //insertion sort ---> because input is small

        //#2 - eBay sorts listings by the current Bid amount:
        //radix or counting sort ---> because a bid is a rounded number

        //#3 - Sport scores on ESPN
        //Quick sort ---> because have decimals and because the time space complexity

        //#4 - Massive database (can't fit all into memory) needs to sort through past year's user data
        //Merge Sort ---> because the performance

        //#5 - Almost sorted Udemy review data needs to update and add 2 new reviews
        //Insertion Sort ---> asssuming previous data is sorted

        //#6 - Temperature Records for the past 50 years in Canada
        //radix or counting Sort ---> if theres nos decimals
        //Quick sort ---> if decimal places

        //#7 - Large user name database needs to be sorted. Data is very random.
        //Quick sort ---> if not worrie by worst cas scenario

        //#8 - You want to teach sorting
        // Bubble, selection, insertion sort
        static void Main(String[] args)
        {
            BubbleSortSolution bubbleSort = new BubbleSortSolution();
            int[] input = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            //Array.ForEach(bubbleSort.BubbleSort(input), Console.WriteLine);
            //Console.WriteLine("/**********************************/");
            //Array.ForEach(bubbleSort.BubbleSortCourse(input), Console.WriteLine);

            SelectionSortSolution selectionSort = new SelectionSortSolution();
            int[] input2 = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            //Array.ForEach(selectionSort.SelectionSort(input), Console.WriteLine);
            //Console.WriteLine("/**********************************/");
            //Array.ForEach(selectionSort.SelectionSortCourse(input2), Console.WriteLine);
            //Console.WriteLine("/**********************************/");

            InsertionSortSolution insertionSort = new InsertionSortSolution();
            int[] input3 = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
            //Array.ForEach(insertionSort.InsertionSort(input3), Console.WriteLine);
            //Array.ForEach(insertionSort.InsertionSortCourse(input3), Console.WriteLine);
            //Console.WriteLine("/**********************************/");

            MergeSortSolution mergeSort = new MergeSortSolution();
            int[] input4 = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };            
            //Array.ForEach(mergeSort.MergeSort(input4), Console.WriteLine);
            //Array.ForEach(insertionSort.InsertionSortCourse(input3), Console.WriteLine);
            //Console.WriteLine("/**********************************/");

            QuickSortSolution quickSort = new QuickSortSolution();
            int[] input5 = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 7 };
            Array.ForEach(quickSort.QuickSort(input5, 0, input5.Length-1), Console.WriteLine);
            //Array.ForEach(insertionSort.InsertionSortCourse(input3), Console.WriteLine);
            //Console.WriteLine("/**********************************/");
        }
    }
}
