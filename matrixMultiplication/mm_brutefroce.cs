using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixMultiplication
{
    internal class mm_brutefroce
    {
        public static int[,] tbt_mm_bf(int[,] a,int[,] b)
        {
            int n = a.GetLength(0);
            int x = b.GetLength(1);
            int l = a.GetLength(1);
            int[,] c = new int[n,x];
            for(int i=0;i<n;i++)
            {
                
                for(int j = 0; j <n;j++)
                {
                    c[i, j] = 0;
                    for(int k=0;k<l;k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return c;
        }
    }
}
