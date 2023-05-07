using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionSortAlgorithm
{
    internal class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            for(int i=0;i<arr.Length; i++)
            {
                var index = i;// value of the index which will keep track of the smalled value in the list
                for (int j= i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[index])
                    {
                        index = j;
                    }

                }
                var temp = arr[i]; // we keep track of the value that we going to change in the next step
                arr[i] = arr[index];
                arr[index] = temp;
            }
        }
    }
}
