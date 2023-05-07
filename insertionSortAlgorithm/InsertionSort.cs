using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionSortAlgorithm
{
    internal class InsertionSort
    {
        public static void Sort(int[] array)
        {
            int i, j, key;
            for ( i = 1; i < array.Length; i++)
            {
                //i=array.Length-1 hold true!
                key = array[i];
                j = i - 1;

                while (j >= 0 && array[j] < key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
                //at this point array[1..i+1] is sorted!
            }

            //at this point array[0..i] is sorted!
        }
    }
}
