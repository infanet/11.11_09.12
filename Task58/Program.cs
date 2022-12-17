int[,] Matrix1(int[,] Matrix_1)
{
    int count = 0;
    for (int i = 0; i < Matrix_1.GetLength(0); i++)
    {
        for (int y = 0; y < Matrix_1.GetLength(1); y++)
        {
            Console.WriteLine($"Введи число 1й матрицы в {++count} ячейки: ");
            Matrix_1[i, y] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return Matrix_1;
}

int[,] Matrix2(int[,] Matrix_2)
{
    int count = 0;
    for (int t = 0; t < Matrix_2.GetLength(0); t++)
    {
        for (int e = 0; e < Matrix_2.GetLength(1); e++)
        {
            Console.WriteLine($"Введи число 2й матрицы в {++count} ячейки: ");
            Matrix_2[t, e] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return Matrix_2;
}

int[,] SumMatrix(int[,] matrix_1, int[,] matrix_2)
{
    int[,] sumMatrix = new int[matrix_1.GetLength(0), matrix_2.GetLength(1)];
    for (int i = 0; i < matrix_1.GetLength(0); i++)
    {
        for (int y = 0; y < matrix_2.GetLength(1); y++)
        {
            for (int k = 0; k < matrix_2.GetLength(0); k++)
            {
                sumMatrix[i, y] += matrix_1[i, k] * matrix_2[k, y];
            }
        }
    }
    return sumMatrix;
}

void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            Console.Write($"{matrix[i, y]} ");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}
bool Check(int[,] arrMatrix_1, int[,] arrMatrix_2)
{
    bool check = true;
    if (arrMatrix_1.GetLength(1) != arrMatrix_2.GetLength(0)) check = false;
    return check;
}
void Messages()
{
    Console.WriteLine("Перемножить нельзя!");
}

Console.WriteLine("Введите количество столбцов 1 матрицы: ");
int columns_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк 1 матрицы: ");
int line_1 = Convert.ToInt32(Console.ReadLine());
int[,] Matrix_1 = new int[columns_1, line_1];
int[,] matrix_1 = Matrix1(Matrix_1);

Console.WriteLine("Введите количество столбцов 2 матрицы: ");
int columns_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк 2 матрицы: ");
int line_2 = Convert.ToInt32(Console.ReadLine());
int[,] Matrix_2 = new int[columns_2, line_2];
int[,] matrix_2 = Matrix1(Matrix_2);


OutputMatrix(matrix_1);
OutputMatrix(matrix_2);
bool checkMatrix = Check(matrix_1, matrix_2);
if (checkMatrix == true)
{
    int[,] sumMatrix = SumMatrix(Matrix_1, Matrix_2);
    OutputMatrix(sumMatrix);
}
else
{
    Messages();
}