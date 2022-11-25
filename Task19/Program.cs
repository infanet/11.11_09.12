Console.WriteLine("Введи число:");
int num = Convert.ToInt32(Console.ReadLine());

void Palindrome(int n)
{
    int copiend_num = n;
    int modified_num = 0;
    int divided_num = 0;
    while (n > 0)
    {
        divided_num = n % 10;
        modified_num = modified_num * 10 + divided_num;
        n = n / 10;
    }
    if (copiend_num == modified_num)
    {
        Console.WriteLine($"{copiend_num} -> да");
    }
    else
    {
        Console.WriteLine($"{copiend_num} -> нет");
    }
}

Palindrome(num);