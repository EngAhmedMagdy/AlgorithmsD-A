
using Greedy;


    
    //item[] arr = { new item(60, 10), new item(100, 20),
    //                new item(120, 30) };
int[] val = { 100, 60, 120 };
int[] wt = { 20, 10, 30 };
int n = 3;
int W = 50;
// Function call
Console.WriteLine(FractionalKnapsack.FracKnapSack(n,wt,val, W));
