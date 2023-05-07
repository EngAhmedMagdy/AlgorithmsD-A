using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce
{
    internal class peak
    {
        public static int FindPeakElement(int[] array , int n)
        {

            if(n==1) //O(1)
            {
                return array[0];
            }
            if (array[0] >= array[1]) //O(1)
            {
                return array[0];
            }
            if (array[n-1] >= array[n-2]) //O(1)
            {
                return array[n - 1];
            }
            for (int i= 1;i<n-1;i++) //O(n-2)
            {
                if (array[i] >= array[i-1] && array[i] >= array[i+1]) // constant operation c
                {
                    return array[i];
                }
            }
            return -1;

        }

        public static int Peak_RC(int[] array , int l , int r)
        {
            if (r == l)//O(1)
            {
                return array[r];
            }
            int middle = (l + r) / 2;
            if (array[middle] >= array[middle - 1] && array[middle] >= array[middle + 1])//O(1)
            {
                return array[middle];
            }
            if (array[middle + 1] >= array[middle]) //O(1)
            {
                int ans = Peak_RC(array, middle + 1, r); //n/2
                return ans;
            }
            else if (array[middle - 1] >= array[middle])//O(1)
            {
                int ans = Peak_RC(array, l, middle - 1);//n/2
                return ans;
            }
            
            
            return -1;
        }
            
            
    }
}
