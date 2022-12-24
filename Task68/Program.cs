int AckermanСalculation(int m, int n)
{
    if (n == 0) return AckermanСalculation(m - 1, n + 1);
    else if (m == 0) return n + 1;
    else return AckermanСalculation(m - 1, AckermanСalculation(m, n - 1));
}
Console.WriteLine("Введи первое число для Аккермана: ");
int ackermanNumbersM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число для Аккермана: ");
int ackermanNumbersN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\n" + AckermanСalculation(ackermanNumbersM, ackermanNumbersN));