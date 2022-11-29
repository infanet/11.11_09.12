System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int NumberLength(int num)
{
    int n = 1;
    while (num > 0)
    {
        num = num /10;
        if (num != 0)
        {
            n++;
        }
    }
    return n;
}

int nmberLength = NumberLength(number);
System.Console.WriteLine(nmberLength);