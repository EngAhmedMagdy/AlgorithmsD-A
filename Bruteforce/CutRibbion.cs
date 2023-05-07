using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce
{
    internal class CutRibbion
    {
        
        public static int Solution()
        {
            int n, a, b, c;
            int ans;
            int[] i = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            n = i[0];
            a = i[1];
            b = i[2];
            c = i[3];
            int Cut_RC(int n)
            {
                if (n == 0)
                    return 0;
                ans = int.MinValue;
                if (n >= a)
                {
                    ans = Math.Max(ans, Cut_RC(n - a) + 1);
                }
                if (n >= b)
                {
                    ans = Math.Max(ans, Cut_RC(n - b) + 1);
                }
                if (n >= c)
                {
                    ans = Math.Max(ans, Cut_RC(n - c) + 1);
                }
                return ans;
            }
            return Cut_RC(n);

        }
    }
}
