int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int Pod(int num1, int num2)
{
    int os = 0;
    if (num1 % num2 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        os = num1 % num2;
        Console.WriteLine($"не кратно, остаток {os}");
    }
    return os;
}

Console.WriteLine(Pod(num1, num2));