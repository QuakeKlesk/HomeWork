    // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Task29(int N)
{
  int[] array = new int[N];                                                 //создаем массив с нулями
  for (int i = 0; i < N; i++) array[i] = new Random().Next(1, 99);          //заполняем рандомом
  Console.Write("[");                                                       
  for (int i = 0; i < N-1; i++) Console.Write($"{array[i]}, ");             //выводим на экран
  Console.Write($"{array[N-1]}]");
}
Console.WriteLine("Введите длинну массива");
int n = Convert.ToInt32(Console.ReadLine());
Task29(n);