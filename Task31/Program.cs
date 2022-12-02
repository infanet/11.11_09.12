int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            System.Console.Write($"{array[i]}, ");
        }
        else
        {
            System.Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}

int GetSumNegativeElem(int[] arr)
{
    int sumNegativ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sumNegativ += arr[i];
        }
    }
    return sumNegativ;
}

int GetSumPositiveElem(int[] arr)
{
    int sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPositive += arr[i];
        }
    }
    return sumPositive;
}

int[] array = CreateArrayRndInt( 12, -9, 9);
PrintArray(array);
int sunNegative = GetSumNegativeElem(array);
int sumPositive = GetSumPositiveElem(array);
Console.WriteLine($"Сумма положительных чисел = {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел = {sumPositive}");