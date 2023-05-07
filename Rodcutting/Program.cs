using Rodcutting;

//int[] p = { 1, 5, 8, 9, 10, 17, 17, 30 };
////int cutRod(int[] p,int n)
////{
////    if (n == 0)
////        return 0;
////    int q = int.MinValue;
////    for(int i =0;i<n;i++)
////    {
////        q = Math.Max(q, p[i] + cutRod(p, n - i-1));
////    }
////    return q;
////}

//Console.WriteLine(memoizedCutRod.MEMOIZED_CUT_ROD(p,4));

factorial factorial = new();

Console.WriteLine(factorial.factorialRecursion(5));
