using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp
{
    internal class fibonacci
    {
        public static long[] val = new long[101];
        public static long solution(long n)
        {
            if (n<=1) //base case
            { return n; }
            if (val[n] != 0)
                return val[n];
            else
            {//recursive call n-1 , n-2
                val[n] = solution(n - 1) + solution(n - 2);
            }
            return val[n];
        }
    }
}
