int OutputToTheCube(int number, int degree)
{
    int n = number;
    int sum = 1;
    for (int i = 0; i < degree; i++)
    {
        sum = sum * n;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("В какую степень хотите возвести: ");
int deg = Convert.ToInt32(Console.ReadLine());

int outputToTheCube = OutputToTheCube(num, deg);
Console.WriteLine($"{num} в степени {deg} будет -> {outputToTheCube}");