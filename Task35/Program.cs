int[] CreateArray(int size, int min, int max)
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
    Console.Write($"]\n");
}

int CountElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateArray( 123, 0, 1000);
PrintArray(array);
int countElements = CountElements(array);
if (countElements > 0)
{
    Console.WriteLine($"Количество двухзначных элементов массивов равно {countElements}");
}
else
{
    Console.WriteLine($"Двузначных чисел в массиве нет");
}