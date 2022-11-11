Console.WriteLine("Напиши число дня недели которое тебя интересует");
int chislo = Convert.ToInt32(Console.ReadLine());
if (chislo == 1)
{
    Console.WriteLine("Это Понедельник");
}
else if (chislo == 2)
{
    Console.WriteLine("Это Вторник");
}
else if (chislo == 3)
{
    Console.WriteLine("Это Среда");
}
else if (chislo == 4)
{
    Console.WriteLine("Это Четверг");
}
else if (chislo == 5)
{
    Console.WriteLine("Это Пятница");
}
else if (chislo == 6)
{
    Console.WriteLine("Это Суббота");
}
else if (chislo == 7)
{
    Console.WriteLine("Это Воскресенье");
}
else
{
    Console.WriteLine("Не то написал");
}