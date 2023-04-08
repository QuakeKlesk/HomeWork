    // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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