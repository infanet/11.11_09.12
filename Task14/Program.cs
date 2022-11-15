int num1 = Convert.ToInt32(Console.ReadLine());
bool Pod(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
Pod(num1);
Console.WriteLine(Pod(num1) ? "Да" : "Нет");