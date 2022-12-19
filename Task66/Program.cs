Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumOfNaturalNumbers(int numM, int numN)
{
    if (numM != numN)
    {
        return numM + SumOfNaturalNumbers(numM + 1, numN);
    }
    else return numM;
}
Console.WriteLine(SumOfNaturalNumbers(numberM, numberN));