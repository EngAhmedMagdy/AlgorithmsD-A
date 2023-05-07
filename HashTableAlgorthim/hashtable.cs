using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAlgorthim
{
    internal class hashtable
    {
        Hashtable ints;
        public hashtable(int k)
        {
            ints = new(k);
        }
        public void add(int x)
        {
            ints.Add(12,4);
        }
        public void print()
        {
            foreach(var v in ints)
            {
                Console.Write(v + " ");
            }
        }
    }
}
