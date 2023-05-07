using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dp
{
    public class fib
    {
        public static int test(int n)
        {
            if (n <= 1)
                return n;

            return test(n - 1) + test(n - 2);
        }
    }
}
