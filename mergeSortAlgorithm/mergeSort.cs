using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeSortAlgorithm
{
    internal class mergeSort
    {
        public static void msort(int[] a, int p, int r)
        {
            int q;
            if(p<r)
            {
                q = (p + r) / 2;
                msort(a, p, q);
                msort(a, q+1, r);
                sort(a, p,q, r);
 
            }

        }
        public static void sort(int[] a, int p,int q, int r)
        {
            int n1, n2,i,j,k;
            int[] L, R;
            n1 = q - p + 1;
            n2 = r - q;
            L = new int[n1+1];
            R = new int[n2+1];
            L[n1] = int.MaxValue;
            R[n2] = int.MaxValue;
            for( i = 0; i < n1; i++)
            {
                L[i] = a[i+p];
            }
            for ( i = 0; i < n2; i++)
            {
                R[i] = a[i+q+1];
            }
            i = 0;
            j = 0;
            for (k = p; k <= r; k++)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
            }

        }
    }
}
