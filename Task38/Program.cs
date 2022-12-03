double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int numInt = Convert.ToInt32(arr[i] * 10);
        double numDouble = Convert.ToDouble(numInt);
        numDouble = numDouble / 10;
        Console.Write($"{numDouble}; ");
    }
    for (int i = arr.Length - 1; i < arr.Length; i++)
    {
        int numInt = Convert.ToInt32(arr[i] * 10);
        double numDouble = Convert.ToDouble(numInt);
        numDouble = numDouble / 10;
        Console.Write($"{numDouble}");
    }
    Console.Write("] Среднее значение между минимальным и максимальным элементами массива -> ");
}

double[] MinMaxArray(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int y = i + 1; y < arr.Length; y++)
        {
            if (min > arr[y])
            {
                min = arr[y];
            }
        }
        for (int y = i + 1; y < arr.Length; y++)
        {
            if (max < arr[y])
            {
                max = arr[y];
            }
        }
    }
    return new double[] { max, min };
}

void SumAverageMinMaxArray(double[] arr)
{
    double sumAverageMinMaxArray = default;
    int[] decimalArray = new int[arr.Length];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int y = i + 1; y < arr.Length; y++)
        {
            if (arr[i] > arr[y])
            {
                sumAverageMinMaxArray = arr[i] - arr[y];
            }
            else
            {
                sumAverageMinMaxArray = arr[y] - arr[i];
            }
        }
    }
    int numInt = Convert.ToInt32(sumAverageMinMaxArray * 10);
    sumAverageMinMaxArray = Convert.ToDouble(numInt);
    sumAverageMinMaxArray = sumAverageMinMaxArray / 10;
    Console.WriteLine($"{sumAverageMinMaxArray}");
}
double[] createArrayRndDouble = CreateArrayRndDouble(5, 2, 100);
PrintArrayDouble(createArrayRndDouble);
double[] minMaxArray = MinMaxArray(createArrayRndDouble);
SumAverageMinMaxArray(minMaxArray);