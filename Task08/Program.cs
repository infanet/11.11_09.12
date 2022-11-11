Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
if (number > 0)
{
    while (index <= number - 2)
    {
        if (index % 2 == 0)
        {
            Console.Write($"{index}, ");
        }
        index++;
    }
    while (index <= number)
    {
        if (index % 2 == 0)
        {
            Console.Write($"{index}");
        }
        index++;
    }
}
else if (number < 0)
{

    while (index >= number + 2)
    {
        if (index % 2 == 0)
        {
            Console.Write($"{index}, ");
        }
        index--;
    }
    while (index >= number)
    {
        if (index % 2 == 0)
        {
            Console.Write($"{index}");
        }
        index--;
    }
}
else
{
    Console.Write("Ошибка так как вы указали 0");
}