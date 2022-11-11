Console.WriteLine("Введите Первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2 && number1 > number3 && number2 > number3){
    Console.WriteLine($"Большое число {number1}, среднее число {number2}, малое чило {number3}");
}
else if(number1 > number2 && number1 > number3 && number3 > number2){
    Console.WriteLine($"Большое число {number1}, среднее число {number3}, малое чило {number2}");
}
else if(number2 > number1 && number2 > number3 && number3 > number1){
    Console.WriteLine($"Большое число {number2}, среднее число {number3}, малое чило {number1}");
}
else if(number2 > number1 && number2 > number3 && number1 > number3){
    Console.WriteLine($"Большое число {number2}, среднее число {number1}, малое чило {number3}");
}
else if(number3 > number1 && number3 > number2 && number2 > number1){
    Console.WriteLine($"Большое число {number3}, среднее число {number2}, малое чило {number1}");
}
else if(number3 > number1 && number3 > number2 && number1 > number2){
    Console.WriteLine($"Большое число {number3}, среднее число {number1}, малое чило {number2}");
}

else if(number1 == number2 && number1 > number3)
{
    Console.WriteLine($"Равные числа {number1}, {number2} будут больше числа {number3}");
}
else if(number1 == number2 && number1 < number3)
{
    Console.WriteLine($"Равные числа {number1}, {number2} будут меньше числа {number3}");
}

else if(number1 == number3 && number1 > number2)
{
   Console.WriteLine($"Равные числа {number1}, {number3} будут больше числа {number2}");
}
else if(number1 == number3 && number1 < number2)
{
   Console.WriteLine($"Равные числа {number1}, {number3} будут меньше числа {number2}");
}

else if(number2 == number3 && number2 > number1)
{
    Console.WriteLine($"Равные числа {number2}, {number3} будут больше числа {number1}");
}
else if(number2 == number3 && number2 < number1)
{
    Console.WriteLine($"Равные числа {number2}, {number3} будут меньше числа {number1}");
}

else{
    Console.WriteLine($"Все 3 числа равны между собой: {number1}, {number2}, {number3}");
}