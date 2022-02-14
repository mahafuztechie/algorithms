using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            string text = "this is merge sort program";
            int[] arr = { 1, 2, 3 , 67, 45, 12, 90, 42};
            string[] textArray = text.Split();

            //BubbleSort<int> bubble = new BubbleSort<int>();
            //bubble.BubbleSorting(arr);
            //bubble.Display(arr);

            InsertionSort<int> insertion = new InsertionSort<int>();
            insertion.InsertionSorting(arr);
            insertion.Display(arr);

            int start = 0;
            int end = textArray.Length;
            MergeSort<string> mergeSort = new MergeSort<string>();
            mergeSort.MergeSorting(textArray, start, end - 1);
            mergeSort.Display(textArray);

        }
    }
}
