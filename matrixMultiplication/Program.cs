using matrixMultiplication;

int[,] matrix_A = { { 1, 1, 1,1 },
                        { 2, 2, 2,2},
                        { 3,3, 3,3},
                        { 4,4, 4,4},
                       };


int[,] matrix_B = { { 1, 1, 1,1 },
                        { 2, 2, 2,2},
                        { 3,3, 3,3},
                        { 4,4, 4,4},
                      };

int[,] matrix_2A = { { 1, 1 },
                        { 2, 2},
                        
                       };


int[,] matrix_2B = { { 1, 1 },
                        { 2, 2},
                      };

//var c = matrixMultiplication.MatrixMultiRecursive.multiply_matrix(matrix_A, matrix_B);
//for (int i =0; i< c.GetLength(0); i++)
//{
//    for (int j = 0;j < c.GetLength(1); j++)
//    {
//        Console.Write(c[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//var r = mm_brutefroce.tbt_mm_bf(matrix_2A, matrix_2B);
//for (int i = 0; i < r.GetLength(0); i++)
//{
//    for (int j = 0; j < r.GetLength(1); j++)
//    {
//        Console.Write(r[i, j] + " ");
//    }
//    Console.WriteLine();
//}

var r = mm_recurrsion.tbt_mm_rec(matrix_A, matrix_2B);

for (int i = 0; i < r.GetLength(0); i++)
{
    for (int j = 0; j < r.GetLength(1); j++)
    {
        Console.Write(r[i, j] + " ");
    }
    Console.WriteLine();
}
