using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace insertionSortAlgorithm
{
    internal class BubbleSort
    {
        public static void sort(int[] arr)
        {
            bool swap = true;
            while(swap)
            {
                swap = false;
                for (var j=0; j<arr.Length -1; j++)
                {
                    
                    if(arr[j] > arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        swap = true;
                    }
                }
            }
        }
    }
    class SelectionSortDemo
    {
        public static void sort(int[] array)
        {
            //step one define the boundary of unsorted list
            //step 2 find the lowest value elemnt in the list
            //step 3 swap the lowest with the begining element
            //repeat steps 1-3 until the array is sorted
            for(int i=0;i< array.Length;i++)
            {
                var min_index = i;
                for(int j=i;j<array.Length;j++)
                {

                    if (comp(array[j], array[min_index]))
                    {
                        min_index = j;
                    }
                }
                var temp = array[i];
                array[i] = array[min_index];
                array[min_index] = temp;
            }
            

        }
        public static bool comp(int a,int b)
        {
            if (a < b)
            {
                return true;
            }
            return false;
        }
    }
}
