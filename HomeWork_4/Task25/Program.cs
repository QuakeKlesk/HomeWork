// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A для возведения его в степень B");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Exponent(num1, num2));

int Exponent(int A, int B)
{
    int result= A;
    for (int i = 2; i < B; i++)
    {
        result = result * A;
    }
    return result;
}


// Console.WriteLine(Math.Pow(num1, num2));
