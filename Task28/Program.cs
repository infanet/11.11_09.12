int number = 0;
while (number <= 0)
{
    System.Console.WriteLine("Введите число");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 0) 
    {
        System.Console.WriteLine("Введены данные не коректно");
    }
}

int MultDigits(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        mult = mult *i;
    }
    return mult;
}

int multDigits = MultDigits(number);
System.Console.WriteLine($"Произведение чисел от 1 до {number} = {multDigits}");