using mergeSortAlgorithm;
using System;

int[] a = { 5,8,7,3,9,1,6 };
//mergeSort.msort(a,0,a.Length-1);
//foreach (var v in a)
//{
//    Console.Write(v+",");
//}

//DemoSort.Sort(a, 0, a.Length - 1);
//foreach (var v in a)
//{
//    Console.Write(v + ",");
//}


//mergesortdemo.Sort(a, 0, a.Length - 1);
//foreach (var v in a)
//{
//    Console.Write(v + ",");
//}
Array.Sort(a);
int x = BinarySearch.Search(a, 0, a.Length - 1, 8);
Console.WriteLine("element found at {0}", x);