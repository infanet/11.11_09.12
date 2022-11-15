string str = Console.ReadLine();
float num = float.Parse(str);
char Void(string str, int num)
{
    char[] ch = str.ToCharArray();
    int i = 0;
    for (; i <= ch.Length; i++)
    {
        if (i == num - 1)
        {
            break;
        }
    }
    return ch[i];
}
bool Remainder(float rem)
{
    return rem / 100 < 0.9;
}
Console.WriteLine(Remainder(num) ? "Третьей цифры нет" : Void(str, 3));