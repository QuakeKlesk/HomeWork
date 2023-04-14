    // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine($"Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = CountSummDigits(userNumber);
Console.WriteLine($"Сумма цифр введенного числа {result}");

int CountSummDigits(int num)
{
    int sum = 0;
    while (num!=0)
    {
        sum +=num % 10;
        num = num / 10;
    }
    return sum;
}