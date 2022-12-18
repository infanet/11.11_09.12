int[,,] CreateMatrixRndInt(int rows, int colums, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, colums, depth];
    Random rnd = new Random();
    int numRnd = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2);)
            {
                bool True = false;
                numRnd = rnd.Next(min, max + 1);
                for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
                {
                    for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
                    {
                        for (int z1 = 0; z1 < matrix.GetLength(2); z1++)
                        {
                            if (matrix[i1, j1, z1] == numRnd)
                            {
                                True = true;
                            }
                        }
                    }
                }
                if (!True)
                {
                    matrix[i, j, z] = numRnd;
                    z++;
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[");
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                if (z < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, z]}, ");
                else Console.Write(matrix[i, j, z]);
            }

            Console.WriteLine($"]");
        }
        Console.WriteLine();
    }
}
int[,,] createMatrixRndInt = CreateMatrixRndInt(2, 2, 2, 0, 10);
PrintMatrix(createMatrixRndInt);