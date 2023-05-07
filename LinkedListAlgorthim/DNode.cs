using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAlgorthim
{
    internal class DNode
    {
        internal int data;
        internal DNode prev;
        internal DNode next;
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
}
