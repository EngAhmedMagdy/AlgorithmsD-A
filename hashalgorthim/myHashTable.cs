using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hashalgorthim
{
    internal class myHashTable
    {
        private Node[] universe;
        private readonly int tableSize = 7;

        public myHashTable(int maxTableSize)
        {
            //tableSize = maxTableSize;
            universe = new Node[tableSize];
        }
        private int HashFuncation(int key)
        {

            return key % tableSize;
        }

        public void Insert(int key, object value)
        {
            int genIndex = HashFuncation(key);
            Node node = universe[genIndex];

            if (node == null)
            {
                universe[genIndex] = new Node() { Key = key, Value = value };
                return;
            }

            if (node.Key == key)
                throw new Exception("Can't use same key!");

            while (node.Next != null)
            {
                node = node.Next;
                if (node.Key == key)
                    throw new Exception("Can't use same key!");
            }

            Node newNode = new Node() { Key = key, Value = value, Previous = node, Next = null };
            node.Next = newNode;
        }
        public object GetValue(int key)
        {
            int genIndex = HashFuncation(key);
            Node node = universe[genIndex];
            while (node != null)
            {
                if (node.Key == key)
                {
                    return node.Value;
                }
                node = node.Next;
            }

            throw new Exception("Don't have the key in hash!");
        }
    }
}
