int[,] CreateMatrixRndInt(int rows,int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write(matrix[i, j]);
        }
        Console.WriteLine("]");
    }
}

// void SquareEvenNumbersMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] *= matrix[i, j];
//             }
//         }
//     }
// }

int SumDiagonalMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i,j];
            }
        }
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int sumDiagonalMatrix = SumDiagonalMatrix(array2D);
Console.WriteLine($"Сумма элементов, находящтхся на главной диагонали = {sumDiagonalMatrix}");