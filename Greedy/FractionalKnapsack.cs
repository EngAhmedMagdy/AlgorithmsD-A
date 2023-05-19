using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    public class FractionalKnapsack
    {

        class item
        {
            public int profit;
            public int weight;

            public item(int profit, int weight)
            {
                this.profit = profit;
                this.weight = weight;
            }
        }

        public class MyComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return x > y ? 1 : 0;
            }
        }
        // Main greedy function to solve problem
        public static double FracKnapSack(int n, int[] wts, int[] vals, int w)
        {
            int[] ratio= new int[n];
            int[] orginal = new int[n];

            for(int i = 0;i<n;i++)
            {
                ratio[i] = vals[i] / wts[i];
                orginal[i] = i;
            }
            // Sort items based
            // on cost per units
            Array.Sort(ratio, orginal);
            orginal.Reverse();

            // Traverse items, if it can fit,
            // take it all, else take fraction
            double totalVal = 0f;
            int currW = 0;

            for(int i = n-1;i>=0;i--)
             {
                var index = orginal[i];
                float remaining = w - currW;

                // If the whole item can be
                // taken, take it
                if (wts[index] <= remaining)
                {
                    totalVal += (double)vals[index];
                    currW += wts[index];
                }

                // dd fraction until we run out of space
                else
                {
                    if (remaining == 0)
                        break;

                    double fraction
                        = remaining / (double)wts[index];
                    totalVal += fraction * (double)vals[index];
                    currW += (int)(fraction * (double)wts[index]);
                }
            }
            return totalVal;
        }

        // Driver code
        
    }

    // This code is contributed by Mohamed Adel


}
