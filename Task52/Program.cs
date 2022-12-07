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

void ArithmeticMeanSum(int[,] matrix)
{
    double[] arithmeticMeanSum = new double[matrix.GetLength(1)];
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        sum /= matrix.GetLength(0);
        arithmeticMeanSum[i] = sum;
        sum = 0;
    }
    Console.Write("Среднее арифметическое значение: ");
    for (int i = 0; i < arithmeticMeanSum.Length; i++)
    {
        if (i < arithmeticMeanSum.Length - 1) Console.Write($"{Math.Round(arithmeticMeanSum[i], 1)}; ");
        else Console.Write($"{Math.Round(arithmeticMeanSum[i], 1)}");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
ArithmeticMeanSum(array2D);