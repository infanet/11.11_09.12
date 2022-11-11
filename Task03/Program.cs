Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0 - number;
if (number >= 0)
{
    while (index <= number)
    {
        System.Console.WriteLine(index);
        index++;
    }
}
else
{
    while (index >= number)
    {
        System.Console.WriteLine(index);
        index--;
    }
}