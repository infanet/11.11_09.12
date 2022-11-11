Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Да");
}
if (number == 0)
{
    Console.WriteLine("Ноль не в счет");
}
else
{
    Console.WriteLine("Нет");
}
