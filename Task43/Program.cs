double FindingsX(int b1, int k1, int b2, int k2)
{
    double withX = k1 + k2 * -1;
    double withoutX = b2 + b1 * -1;
    double x = withoutX / withX;
    return x;
}
void FindingsY(int b1, int k1, int b2, int k2, double x)
{
    double B1 = b1;
    double K1 = k1;
    double B2 = b2;
    double K2 = k2;
    double y1 = K1 * x + B1;
    double y2 = K2 * x + B2;
    Console.WriteLine($"Точки пересеченя будут -> ({y1}; {y2})");
}
Console.WriteLine("y = k1*x + b1, y = k2*x + b2");
Console.WriteLine("Введи число под b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число под k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число под b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число под k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
double x = FindingsX(b1, k1, b2, k2);
FindingsY(b1, k1, b2, k2, x);