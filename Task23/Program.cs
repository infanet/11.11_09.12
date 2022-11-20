Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

string str(int num)
{
    string stri = "";
    for (int i = 1; i <= num; i++)
    {
        stri = stri + $"{i} | {i * i * i} \n";
    }
    return stri;
}
Console.WriteLine(str(num));