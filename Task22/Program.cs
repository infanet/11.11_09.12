int num = Convert.ToInt32(Console.ReadLine());
int Pod(int num)
{
    int i = 1;
    while(i <= num)
    {
        result = i * i;
        Console.WriteLine(result);
        i++;
    }
    return 0;
}
Pod(num);