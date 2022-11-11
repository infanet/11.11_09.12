Console.WriteLine("Введите Первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2){
    Console.WriteLine($"Большое число {number1} и малое число {number2}");
}
else if(number1 == number2){
    Console.WriteLine($"Число {number1} равно числу {number2}");
}
else{
    Console.WriteLine($"Большое число {number2} и малое число {number1}");
}