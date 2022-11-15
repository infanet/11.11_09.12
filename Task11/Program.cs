int ran = new Random().Nex(100, 1000);
Console.WriteLine($"Случайное число из 100 - 1000 --> {ran}");

int Pod(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

Console.WriteLine(Pod(number));