using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace insertionSortAlgorithm
{
    internal class BubbleSort
    {
        public static void sort(int[] arr)
        {
            bool swap = true;
            while(swap)
            {
                swap = false;
                for (var j=0; j<arr.Length -1; j++)
                {
                    
                    if(arr[j] > arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        swap = true;
                    }
                }
            }
        }
        public void Main()
        {
            Console.WriteLine("str");
        }
    }

}
