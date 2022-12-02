int[] RandomArray(int num)
{
    int[] arr = new int[num];
    Random rd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rd.Next(0, 1000);
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

int EvenArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Укажите количество массивов: ");
int numArray = Convert.ToInt32(Console.ReadLine());
int[] randomArray = RandomArray(numArray);
OutputArray(randomArray);
int cout = EvenArray(randomArray);
Console.Write($"Четных чисел {cout}");