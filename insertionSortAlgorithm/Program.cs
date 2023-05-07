//int[] array = { 4,3,3 ,1 };
//int i, j ,key,temp, current_at;
//////insertion sort
////for (i = 1; i < array.Length; i++)
////{
////    //i=array.Length-1 hold true!
////    key = array[i];
////    j = i - 1;

////    while (j >= 0 && array[j] < key)
////    {
////        array[j + 1] = array[j];
////        j--;
////    }
////    array[j+1] = key;
////    //at this point array[1..i+1] is sorted!
////    //at this point array[0..i] is sorted!
////}

////bubble sort
////for (i =0;i<array.Length-1; i++)
////{
////    for(j=i+1;j<array.Length;j++)
////    {
////        if(array[j]<array[i])
////        {
////            temp = array[j];
////            array[j] = array[i];
////            array[i] = temp;
////        }
////    }
////}




//int[] insertsort(int[] arr)
//{
//    int j, i, key,n;
//    n = arr.Length;
//    for(j=1; j<n;j++)
//    {
//        key = arr[j];
//        for(i=j-1;i>=0;i--)
//        {
//            if(arr[i] > key)
//            {
//                arr[i + 1] = arr[i];
//            }
//            else
//            {
//                break;
//            }
//            //the last value of i = -1
//        }
//        arr[i + 1] = key;
//    }
//    return arr;
//}
using insertionSortAlgorithm;

int[] arr = { 9,8,7,6,5,10,1 };
//SelectionSort.Sort(arr);
//for(int j=0;j<arr.Length;j++)
//{
//    Console.WriteLine(arr[j]);
//}
BubbleSort.sort(arr);
for (int j = 0; j < arr.Length; j++)
{
    Console.WriteLine(arr[j]);

}

//SelectionSortDemo.sort(arr);
//for (int j = 0; j < arr.Length; j++)
//{
//    Console.WriteLine(arr[j]);

//}