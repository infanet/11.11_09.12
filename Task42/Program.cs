int[] Bin(int num)
{
    int sum = 0;
    int count = 0;
    while (num > 0)
    {
        sum = sum * 10 + num % 2;
        num = num / 2;
        count++;
    }
    int[] arrBin = new int[count];
    for (int i = 0; i < arrBin.Length; i++)
    {
        int bin = sum % 2;
        arrBin[i] = bin;
        sum = sum / 10;
    }
    return arrBin;
}

void OutputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}
int[] bin = Bin(13);

OutputArray(bin);