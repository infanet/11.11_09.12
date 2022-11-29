Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.Readline());

int SumDigits(int num)
{
    int sum = default;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }

    return sum ;
}

int sumDigits = SumDigits(number);
Console.WriteLine($"Сумма чмсел от 1 до {number} = {sumDigits}");