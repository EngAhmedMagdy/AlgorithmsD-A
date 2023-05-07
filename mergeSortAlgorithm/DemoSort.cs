using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeSortAlgorithm
{
    internal class DemoSort //merge sort algorithm
    {
        public static void Sort(int[] array,int l,int r)
        {
            if(r>l)
            {
                int m =(r + l)/2;
                Sort(array, l, m);
                Sort(array, m+1, r);
                mergeSort(array, l,m+1, r);
            }
        }
        public static void mergeSort(int[] array, int l,int m, int r)
        {
            int i, j;
            int n1, n2;
            n1 = m - l;
            n2 = r - m +1;
            int[] L = new int[n1+1];
            int[] R = new int[n2+1];
            L[n1] = int.MaxValue;
            R[n2] = int.MaxValue;
            for (i=0;i< n1; i++)
            {
                L[i] = array[i+l];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = array[j+m];
            }

            i = 0;
            j = 0;
            for(int k=l; k<=r; k++)
            {
                if(L[i] < R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                    
            }
        }
    }
}
