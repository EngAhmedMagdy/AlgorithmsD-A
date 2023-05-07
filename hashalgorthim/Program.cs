
using hashalgorthim;
using System.Collections;

Dictionary<int, int> d = new();
d.Add(2, 4);
d.Add(1, 3);

foreach (var k in d.Keys)
{
    Console.WriteLine(k + ",");
}

Hashtable h = new Hashtable();
h.Add(2, 2);
h.Add(1, 3);
foreach (var k in h.Keys)
{
    Console.WriteLine(k + ",");
}

myHashTable myh = new myHashTable(100);
myh.Insert(12, 12);
myh.Insert(112, 12);
myh.Insert(7, 7);
