using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce
{
    internal class peakfinder
    {
        public static int peakfindertest(int[] array,int n)
        {
            //only one element exist
            if (n == 1)//O(1)
                return array[n - 1];
            //evaulate the first element for the solution
            if (array[0] >= array[1])//O(1)
                return array[0];
            //evaulate the last element for the solution
            if (array[n-1] >= array[n-2]) //O(1)
                return array[n - 1];
            //evaulate the all elements for the solution from second to before last
            for (int i=1;i<n-1;i++) //O(n-2)
            {
                if (array[i] >= array[i+1] && array[i] >= array[i-1])
                {
                    return array[i];
                }
            }
            return -1;
        }
    }
}
