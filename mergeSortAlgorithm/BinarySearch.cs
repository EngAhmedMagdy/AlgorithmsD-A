using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeSortAlgorithm
{
    internal class BinarySearch
    {
        public static int Search(int[] array ,int l,int r,int x)
        {
            
            if(r>=l)
            {
                int mid = l + (r - l) / 2;
                if (x == array[mid])
                {
                    return mid;
                }
                else if (x < array[mid])
                {
                    Search(array, l, mid - 1, x);
                }
                else
                {
                    Search(array, mid + 1, r, x);
                }
            }
            
            return -1;
        }
    }
}
