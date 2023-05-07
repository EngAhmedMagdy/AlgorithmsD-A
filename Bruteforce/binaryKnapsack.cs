using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Bruteforce
{
    internal class binaryKnapsack
    {
        public static int[,] memo = new int[4,31]; 
        public static int FindMaxVal(int n ,int[] wt, int[] val, int c , int i)
        {
            int result;
            if(memo[i, c] != 0)
            {
                return memo[i, c];
            }
            if(i==n || c==0)
            {
                result = 0;
                memo[i, c] = result;
                return result;

            }
                
            if (wt[i]<=c)
            {
                var vin = FindMaxVal(n, wt, val, c - wt[i], i+1) + val[i];
                var vout = FindMaxVal(n, wt, val, c, i+1);
                result = Math.Max(vin, vout);
            }
            else
            {
                var vout = FindMaxVal(n, wt, val, c, i+1);
                result = vout;
            }
            memo[i, c] = result;
            return result;
        }
    }
}
