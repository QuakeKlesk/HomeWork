
/* // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] ArrayCreator(int N)
{
  int[] array = new int[N];                                                     //создаем массив с нулями
  for (int i = 0; i < N; i++) array[i] = new Random().Next(100, 1000);          //заполняем рандомом
  Console.Write("[");                                                       
  for (int i = 0; i < N-1; i++) Console.Write($"{array[i]}, ");                 //выводим на экран
  Console.Write($"{array[N-1]}]");
  return array;
}
int EvenSearcher(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2==0)
    {
      count++;
    } 
  }
  return count;
}
Console.WriteLine("Введите длинну массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(EvenSearcher(ArrayCreator(n)));
*/

/* // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

Console.WriteLine("задайте диапазон рандомных значений. От 1 до ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = new int[123];                                                 //создаем массив с нулями
for (int i = 0; i < 123; i++) array[i] = new Random().Next(1, max);          //заполняем рандомом
Console.Write("[");                                                       
for (int i = 0; i < 123-1; i++) Console.Write($"{array[i]}, ");             //выводим на экран
Console.Write($"{array[123-1]}]");
int count = 0;
for (int i = 0; i < 123; i++)
{
  if (array[i] >= 10 && array[i] < 100)
  {
    count++;
  }
}
Console.WriteLine();
Console.WriteLine("Количество значений в диапазоне от 10 до 99 = " + count);
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Задайте диапазон рандомных значений. От");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("до");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте размер массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];                                                 
for (int i = 0; i < length; i++) array[i] = new Random().Next(min, max);          //заполняем рандомом
Console.Write("[");                                                       
for (int i = 0; i < length-1; i++) Console.Write($"{array[i]}, ");             //выводим на экран
Console.Write($"{array[length-1]}]");
int count = 0;
for (int i = 0; i < length; i++)
{
  if (i % 2 != 0)
  count = count + array[i];
}

Console.WriteLine();
Console.WriteLine("Сумма значений лежащих на нечетных позициях = " + count);
*/

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.