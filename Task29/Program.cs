int[] NumberOfArrayElements(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.WriteLine($"Придай число к индексу {i}:");
        number[i] = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}
void OutputOfTheArrayNumber(int[] output)
{
    for (int i = 0; i < output.Length; i++)
    {
        Console.Write($"{output[i]} "); ; ;
    }
}
Console.WriteLine("Укажи колиесто элемента массива:");
int[] numberArray = new int[Convert.ToInt32(Console.ReadLine())];
NumberOfArrayElements(numberArray);
OutputOfTheArrayNumber(numberArray);