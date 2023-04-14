// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Сгенерированный массив");
double[] array = CreateArrayRndDouble(5, 1, 99);
PrintArray(array);
double MinNumInArr = ArrayMin(array);
double MaxNumInArr = ArrayMax(array);
Console.WriteLine($"Максимальное число массива {MinNumInArr}");
Console.WriteLine($"Максимальное число массива {MaxNumInArr}");
double result = FindDiffBtwNum(MaxNumInArr,MinNumInArr);
Console.WriteLine($"Разница между максимальным и минимальынм элементом {result}");

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return arr;
}

double ArrayMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
double ArrayMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double FindDiffBtwNum(double max, double min)
{
    return max-min;
}