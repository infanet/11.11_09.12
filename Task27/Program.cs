int NumberSeparation(int number)
{
    int separation = default;
    int sum = default;
    while (number > 0)
    {
        separation = number % 10;
        sum = sum + separation;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numberSeparation = NumberSeparation(num);
Console.WriteLine($"Число {num} будет сложено между собой -> {numberSeparation}");