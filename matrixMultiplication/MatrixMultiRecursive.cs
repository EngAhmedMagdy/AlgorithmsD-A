using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixMultiplication
{
    internal class MatrixMultiRecursive
    {
        public static int[,] multiply_matrix(int[,] a, int[,] b)
        {
            int n = a.GetLength(0);
            int row_1 = a.GetLength(0);
            int col_2 = b.GetLength(1);
            int[,] c = new int[row_1, col_2];
            if (n==1)
            {
                c = new int[1, 1];
                c[0, 0] = a[0, 0] * b[0, 0];
                return c;

            }
            else
            {
                int split_index = n / 2;
                int[,] c00 = new int[split_index, split_index];
                int[,] c01 = new int[split_index, split_index];
                int[,] c10 = new int[split_index, split_index];
                int[,] c11 = new int[split_index, split_index];
                int[,] a00 = new int[split_index, split_index];
                int[,] a01 = new int[split_index, split_index];
                int[,] a10 = new int[split_index, split_index];
                int[,] a11 = new int[split_index, split_index];
                int[,] b00 = new int[split_index, split_index];
                int[,] b01 = new int[split_index, split_index];
                int[,] b10 = new int[split_index, split_index];
                int[,] b11 = new int[split_index, split_index];

                //divide
                for (int i = 0; i < split_index; i++)
                {
                    for (int j = 0; j < split_index; j++)
                    {
                        a00[i, j] = a[i, j];
                        a01[i, j] = a[i, j + split_index];
                        a10[i, j] = a[split_index + i, j];
                        a11[i, j] = a[i + split_index, j + split_index];
                        b00[i, j] = b[i, j];
                        b01[i, j] = b[i, j + split_index];
                        b10[i, j] = b[split_index + i, j];
                        b11[i, j] = b[i + split_index, j + split_index];
                    }
                }
                //conquer
                add_matrix(multiply_matrix(a00, b00), multiply_matrix(a01, b10), c00, split_index);
                add_matrix(multiply_matrix(a00, b01), multiply_matrix(a01, b11), c01, split_index);
                add_matrix(multiply_matrix(a10, b00), multiply_matrix(a11, b10), c10, split_index);
                add_matrix(multiply_matrix(a10, b01), multiply_matrix(a11, b11), c11, split_index);

                //merge
                for (int i = 0; i < split_index; i++)
                {
                    for (int j = 0; j < split_index; j++)
                    {
                        c[i, j] = c00[i, j];
                        c[i, j + split_index] = c01[i, j];
                        c[split_index + i, j] = c10[i, j];
                        c[i + split_index, j + split_index] = c11[i, j];
                    }
                }

                return c;
            }
        }
        public static void add_matrix(int[,] matrix_A, int[,] matrix_B, int[,] matrix_C, int split_index)
        {
            for (int i = 0; i < split_index; i++)
            {
                for (int j = 0; j < split_index; j++)
                {
                    matrix_C[i, j] = matrix_A[i, j] + matrix_B[i, j];
                }
            }
        }
    }
}
