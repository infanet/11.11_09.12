int[,] CreateMatrixRndInt(int x, int y)
{
    int[,] matrix = new int[y, x];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Укажи какой индекс массива тебя интересует под \"У\": ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажи какой индекс массива тебя интересует под \"X\": ");
    int x = Convert.ToInt32(Console.ReadLine());
    bool Y = false;
    bool X = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (y == i) Y = true;
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
            if (x == j) X = true;
        }
        Console.WriteLine("]");
    }
    if (Y == true && X == true)
    {
        Console.WriteLine($"{y},{x} -> Такой элемент в массиве есть");
    }
    else
    {
        Console.WriteLine($"{y},{x} -> Такой элемента в массиве нет");
    }
}

Random rdX = new Random();
Random rdY = new Random();
int[,] array2D = CreateMatrixRndInt(rdX.Next(0, 9), rdY.Next(0, 9));
PrintMatrix(array2D);