using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp
{
    internal class tabfib
    {
        static int fib(int n)
        {
            int[] f = new int[n + 1];
            f[0] = 0;
            f[1] = 1;
            for (int i = 2; i <= n; i++)
                f[i] = f[i - 1] + f[i - 2];
            return f[n];
        }
    }
}
