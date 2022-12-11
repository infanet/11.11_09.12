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

void SmallString(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];
    int sum = 0;
    int min = 0;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumArray[i] = sum;
        sum = 0;
    }
    for (int l = 0; l < sumArray.Length - 1; l++)
    {
        for (int s = 1 + l; s < sumArray.Length; s++)
        {
            if (sumArray[l] > sumArray[s])
            {
                min = sumArray[s];
            }
            else
            {
                min = sumArray[l];
            }
        }
    }
    Console.Write("Строка с наименьшим суммой элементов: ");
    for (int i = 0; i < sumArray.Length; i++)
    {
        if (min == sumArray[index = i])
        {
            Console.Write($"{++index} ");
        }
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array2D);
SmallString(array2D);