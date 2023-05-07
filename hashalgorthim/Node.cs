using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashalgorthim
{
    public class Node
    {
        public int Key { get; set; }
        public object Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
}
