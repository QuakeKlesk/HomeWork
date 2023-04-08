    // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Pow(num1, num2));
*/

    // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
     advance = numberN - numberN % 10;                                  // обнуляем последнюю цифру в числе
     result = result + (numberN - advance);                             // последняя цифра + результат
     numberN = numberN / 10;                                            // Убираем ноль из числа
    }
Console.WriteLine($"Сумма цифр в заданном числе: {result}");
return result;
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
SumNumber(N);
*/

    // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/* 
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
 */
