using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeSortAlgorithm
{
    internal class mergesortdemo
    {
        public static void Sort(int[] array,int p ,int r)
        {
            if (p < r)
            {
                int m = (r + p) / 2;
                Sort(array, p, m);
                Sort(array, m + 1, r);
                merge(array, p, m, r);
            }
            
        }
        public static void merge(int[] arr,int p ,int m , int r)
        {
            int i, j;
            int n1, n2;
            int[] R, L;
            n1 = m - p +1;
            n2 = r - m;
            L = new int[n1+1];
            R = new int[n2+1];
            L[n1] = int.MaxValue;
            R[n2] = int.MaxValue;
            for (i =0; i < n1; i++)
            {
                L[i] = arr[i+p]; //copy the left elements to they L array
            }
            for (i = 0; i < n2; i++)
            {
                R[i] = arr[i + m +1]; //copy the right elements to they R array
            }
            //sort and merge
            int k;
            i = 0;
            j = 0;
            for(k=p;k<=r;k++)
            {
                if (L[i] < R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
            }
        }
    }
}
