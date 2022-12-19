Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void OutputOfNaturalNumbers(int num)
{
    if (num != 1)
    {
        Console.Write($"{num} ");
        OutputOfNaturalNumbers(num - 1);
    }
    else
    {
        Console.Write($"{num} ");
    }
}
OutputOfNaturalNumbers(number);