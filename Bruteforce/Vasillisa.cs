using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce
{
    public class Vasillisa
    {
        public static int solution()
        {
            int r1, r2, c1, c2, d1, d2;
            HashSet<int> set = new();
            int[] ints;
            ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            r1 = ints[0];
            r2 = ints[1];
            ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            c1 = ints[0];
            c2 = ints[1];
            ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            d1 = ints[0];
            d2 = ints[1];
            for(int i=1;i<=9;i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int e = 1; e <= 9; e++)
                    {
                        for (int f = 1; f <= 9; f++)
                        {
                            set.Clear();
                            set.Add(i);
                            set.Add(j);
                            set.Add(e);
                            set.Add(f);
                            if(set.Count()==4)
                            {
                                if (i + j == r1 && e + f == r2 && i + e == c1 && j + f == c2 && i + f == d1 && j + e == d2)
                                {
                                    Console.WriteLine("{0} {1}", i, j);
                                    Console.WriteLine($"{e} {f}");
                                    return 1;
                                }
                            }
                            
                        }
                    }
                }
            }
            Console.WriteLine("-1");
            return 0;
        }
        
       
    }
}
