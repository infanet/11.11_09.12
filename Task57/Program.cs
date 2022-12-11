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

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k++] = matrix[i, j];
        }
    }
    return arr;
}

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int j = 0; j < arr.Length; j++)
//     {
//         if (j < arr.Length - 1) Console.Write($"{arr[j]}, ");
//         else Console.Write(arr[j]);
//     }
//     Console.WriteLine("]");
// }

void CountValue(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{num} встречается {count} раз.");
            count = 1;
            num = arr[i];
        }
    }
    Console.WriteLine($"{num} встречается {count} раз.");
}

int[,] arr2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(arr2D);
int[] arr = MatrixToArray(arr2D);
Array.Sort(arr);
Console.WriteLine();
CountValue(arr);