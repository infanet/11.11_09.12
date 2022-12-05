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
    Console.WriteLine($"]");
}

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

int[] CopyArray(int[] arr)
{
    int[] tempArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        tempArray[i] = arr[i];
    }
    return tempArray;
}

int[] arr = CreateArray(5, 1, 10);
PrintArray(arr);
int[] copyarr = CopyArray(arr);
PrintArray(copyarr);