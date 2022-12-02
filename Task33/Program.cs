int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            System.Console.Write($"{array[i]}, ");
        }
        else
        {
            System.Console.WriteLine($"{array[i]}");
        }
    }
    Console.Write($"]\n");
}

int[] array = CreateArrayRndInt(5, 0, 1000);
PrintArray(array);

bool FindNumberArray(int[] arr, int numb)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numb)
        {
            return true;
        }
    }
    return false;
}

System.Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Заданное число присутствует в массиве?");
System.Console.WriteLine(FindNumberArray(array, number) == true ? "да" : "нет");