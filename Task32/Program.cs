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
    Console.Write($"]\n");
}

int[] NegativArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int[] array = CreateArrayRndInt( 12, -9, 9);
PrintArray(array);
int[] arr = NegativArray(array);
PrintArray(arr);