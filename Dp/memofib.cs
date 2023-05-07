using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp
{
    internal class memofib
    {
        static int MAX = 100;
        static int NIL = -1;
        static int[] lookup = new int[MAX];

        /* Function to initialize NIL
        values in lookup table */
        static void initialize()
        {
            for (int i = 0; i < MAX; i++)
                lookup[i] = NIL;
        }

        /* function for nth Fibonacci number */
        static int fib(int n)
        {
            if (lookup[n] == NIL)
            {
                if (n <= 1)
                    lookup[n] = n;
                else
                    lookup[n] = fib(n - 1) + fib(n - 2);
            }
            return lookup[n];
        }
        
    }
}
