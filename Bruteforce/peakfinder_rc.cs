using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce
{
    internal class peakfinder_rc
    {
        public static int findpeak(int[] array,int l,int r)
        {
            if(l==r)
            {
                return array[r];
            }
            if(r-l ==1 && array[l] >= array[r])
            {
                return array[l];
            }
            //compute the index of middle
            int mid = (l+r)/2;
            //evalue the middle possible solution
            if (mid > 0 && mid < r && array[mid] >= array[mid-1] && array[mid] >= array[mid+1])
            {
                return array[mid];
            }
            //take the lft side and evalue all possible solutions
            if (mid > 0 && array[mid-1] >= array[mid])
            {
                int ans = findpeak(array, l, mid - 1);
                return ans;
            }
            //take the right side and evalue all possible solutions
            else if (mid < r && array[mid+1] >= array[mid])
            {
                return findpeak(array, mid + 1, r);
            }
            return -1;
        }
    }
}
