﻿bool Triagnle(int a1, int b1, int c1)
{
    return a1 < b1+c1 && b1 < a1+c1 && c1 < a1+b1;
}

Console.WriteLine("Введите первую сторону треугольника");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника");
int c = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Triagnle(a, b, c) ? "Треугольник может существовать" : "Треугольник не может существовать");