Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int SumDigits(int num)
{
    return num != 0 ? num % 10 + SumDigits(num / 10) : 0;
}
Console.WriteLine(SumDigits(number1));
