using HashTableAlgorthim;
using System.Collections;

Dictionary<int, int> d = new();

d.Add(99999999, 2);
d.Add(1, 3);

foreach(var k in d.Keys)
{
    Console.WriteLine(k + ",");
}

Hashtable h = new Hashtable();
h.Add(99999999, 2);
h.Add(1, 3);
foreach (var k in h.Keys)
{
    Console.WriteLine(k + ",");
}