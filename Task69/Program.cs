Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num1, int num2)
{
    return num2 == 0 ? 1 : SumDigits(num1, num2 - 1) * num1;
}
Console.WriteLine(SumDigits(number1, number2));