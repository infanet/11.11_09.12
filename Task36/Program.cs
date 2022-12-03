int[] RandomArray(int num)
{
    int[] arr = new int[num];
    Random rd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rd.Next(0, 100);
    }
    return arr;
}

void OutputArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    for (int i = arr.Length - 1; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.Write("] -> ");
}

int SumArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}
Console.WriteLine("Укажите количество массивов: ");
int numArray = Convert.ToInt32(Console.ReadLine());
int[] randomArray = RandomArray(numArray);
OutputArray(randomArray);
int sumArray = SumArray(randomArray);
Console.Write($"Сумма элементов на нечётных позициях будет -> {sumArray}");