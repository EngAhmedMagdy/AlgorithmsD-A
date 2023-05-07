using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce
{
    internal class Art
    {
        public static bool solution(int a1,int b1,int a2,int b2,int a3,int b3)
        {
            //evalute the solution
            int m = Math.Max(b2, b3);
            //next to each other
            if(a2+a3 <= a1 && m <= b1 )
            {
                return true;
            }
            m = Math.Max(a2, a3);
            //under each other
            if (b2 + b3 <= b1 && m <=a1 )
            {
                return true;
            }
            return false;
        }
    }
}
