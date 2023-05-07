using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodcutting
{
    internal class factorial
    {
        public int factorialRecursion(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return n * factorialRecursion(n - 1);
        }
    }
}
