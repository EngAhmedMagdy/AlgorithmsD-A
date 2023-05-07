using Bruteforce;

int[] val = { 10, 20,30 };
int[] wt = {1,1,1};
int n = 3;
int c = 2;
var Maxval = binaryKnapsack.FindMaxVal(n, wt, val, c, 0);

Console.WriteLine(Maxval);

//c = 30;
//Maxval = binaryKnapsack.FindMaxVal(n, wt, val, c, 0);
//Console.WriteLine(Maxval);
//c = 10;
//Maxval = binaryKnapsack.FindMaxVal(n, wt, val, c, 0);
//Console.WriteLine(Maxval);