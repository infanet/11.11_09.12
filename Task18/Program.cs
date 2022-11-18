Console.WriteLine("Укажите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());
string Quarter(int s)
{
    if (s == 1) return "xc > 0 && yc > 0";
    if (s == 2) return "xc < 0 && yc > 0";
    if (s == 3) return "xc < 0 && yc < 0";
    if (s == 4) return "xc < 0 && yc < 0";
    return "Введены неверные данные";
}

string quarter = Quarter(x);
Console.WriteLine(quarter);