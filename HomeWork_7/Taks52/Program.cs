// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArray(m, n, -10, 10);
Print2DArray(resultArray);
double[] columnAverageResult =  ColumnAverage(resultArray);
Console.WriteLine("Среднее арифметическое каждого столбца:");
Print1DArray(columnAverageResult);


double[] ColumnAverage(int[,] arr)
{
    double[] ArithmeticMeanArray = new double[arr.GetLength(1)];
    double SummColumn = 0;
    for (int i = 0; i < ArithmeticMeanArray.Length; i++)
    {
        SummColumn = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            SummColumn += arr[j, i];
        }
        ArithmeticMeanArray[i] = SummColumn / arr.GetLength(0);
    }
    return ArithmeticMeanArray;
}

int[,] CreateArray(int rows, int colum, int min, int max)
{
    int[,] arr = new int[rows, colum];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void Print2DArray(int[,] arr)
{
    Console.WriteLine("Итоговая Матрица:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i, j],3} ");
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }

}
void Print1DArray(double[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
         Console.Write($"{Math.Round(arr[j],2),  6}");
    }
    Console.WriteLine();
}