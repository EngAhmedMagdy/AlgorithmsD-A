using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodcutting
{
    internal class memoizedCutRod
    {
        public static int MEMOIZED_CUT_ROD(int[] p,int n)
        {
            int[] r = new int[n+1];
            for(int i = 0; i < n+1; i++)
            {
                r[i] = int.MinValue;
            }
            return MEMOIZED_CUT_ROD_AUX(p, n, r);

        }
        static int MEMOIZED_CUT_ROD_AUX(int[] p, int n, int[] r)
        {
            int q;
            if (n == 0)
                return 0;
            if (r[n] >= 0 )
            {
                return r[n];
            }
            
            
            else
            {
                q = int.MinValue;
                for (int i = 0; i < n; i++)
                {
                    q = Math.Max(q, p[i] + MEMOIZED_CUT_ROD_AUX(p, n - i - 1, r));
                }
            }
                
            r[n] = q;
            return q;
        }
    }
}
