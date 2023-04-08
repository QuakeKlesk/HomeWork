    //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* 
Console.WriteLine("Введите первое число для сравнения");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine(number1 + " больше чем " + number2);
}
else
{
    Console.WriteLine(number2 + " больше чем " + number1);
} 
*/

    //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите три числа для сравнения");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int result = number1;
if (number2 > result)
{
    result = number2;
}
if (number3 > result)
{
    result = number3;
}
Console.WriteLine(result + " наибольшее число");
*/

    //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
*/

    // ЗАДАЧА 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= num)
{
    if (index % 2 == 0)
    {
        Console.Write(index + ", "); 
    }
    index++;
}
*/

