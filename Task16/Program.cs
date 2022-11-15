int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
bool Pod(int num1, int num2)
{
    return (num1 * num1 == num2) || (num2 * num2 == num1);
}
Pod(num1, num2);
Console.WriteLine(Pod(num1, num2) ? "Да" : "Нет");