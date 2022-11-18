Console.WriteLine("Введите координаты тички Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты тички Y");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;
    if (xc < 0 && yc > 0) return 2;
    if (xc < 0 && yc < 0) return 3;
    if (xc > 0 && yc < 0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter > 0
? $"Указанные координаты четверти -> {quarter}" 
: "Введены некоректные координаты";
Console.WriteLine(result);