int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
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

int[,] DeleteRowColumnsMatrix(int[,] matrix, int indexRow, int indexColumn)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] matrix2 = new int[rows-1, columns-1];
    int m = 0;
    for (int i = 0, m = 0; i < rows-1; i++)
    {
        int n = 0;
        if (m == indexRow)
        {
            m++;
        }
        for (int i = 0, n = 0; i < columns; i++)
        {
            if (n == indexColumn)
            {
            n++;
            }
            matrix2[i,j] = matrix[m,n];
            n++;
        }
        m++;
    }
    return matrix2;
}
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write(matrix[i, j]);
        }
        Console.WriteLine("]");
    }
}

int[,] matrix1 = CreateMatrixRndInt(4,4,1,50);
PrintMatrix(matrix1);
System.Console.WriteLine();