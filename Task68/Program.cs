Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Ackerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0) return Ackerman(numM - 1, 1);
    else return Ackerman(numM - 1, Ackerman(numM, numN - 1));
}
Console.WriteLine(Ackerman(3, 1));