int[] array = new int[8];
void RandomArray(int[] array)
{
    Random ran = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ran.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

RandomArray(array);

PrintArray(array);