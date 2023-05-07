using maxSubarray;

int[] a = { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
(int low, int high, int sum) = FindMaxSubarray.maxSubarray(a, 0, a.Length - 1);
Console.WriteLine(low);
Console.WriteLine(high);
Console.WriteLine(sum);
