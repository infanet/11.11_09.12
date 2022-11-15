int ran = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное значное числа = {ran}");
int Counting(int ran)
{
    int n1 = ran / 10;
    int n2 = n1 % 10;
    return n2;
}
Console.WriteLine(Counting(ran));