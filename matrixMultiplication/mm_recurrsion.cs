using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixMultiplication
{
    internal class mm_recurrsion
    {
        public static int[,] tbt_mm_rec(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int[,] c = new int[n, n];
            //divide
            //matrix a
            int i=0, j=0;
            var split = n / 2;
            int a00 = a[i,j];
            int a01 = a[i,j+ split];
            int a10 = a[i+ split, j];
            int a11 = a[i+ split, j+ split];
            //matrix b
            int b00 = b[i, j];
            int b01 = b[i, j + split];
            int b10 = b[i + split, j];
            int b11 = b[i + split, j + split];
            //result c
            //conquer
            int c00 = a00 * b00 + a01 * b10;
            int c01 = a00 * b01 + a01 * b11;
            int c10 = a10 * b00 + a11 * b10;
            int c11 = a10 * b01 + a11 * b11;
            //assemble / merge
            i = 0; j = 0;
            c[i, j] = c00;
            c[i, j+ split] = c01;
            c[i+ split, j] = c10;
            c[i+ split, j+ split] = c11;
            return c;

        }
    }
}
