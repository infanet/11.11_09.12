int[] InputNumber(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введи какое число будет под индексом {arr[i]}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void Outputting(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    for (int i = arr.Length - 1; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} Числа больше 0 -> {count}");
    }
}
Console.Write("Введи количество в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] inputNumber = InputNumber(num);
Outputting(inputNumber);