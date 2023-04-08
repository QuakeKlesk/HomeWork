    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трехзначное число");
string num = Console.ReadLine();
Console.WriteLine(num[1]);
*/

    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("Введите число");
string num = Console.ReadLine();
int length = num.Length;
if (length <= 2)
{
    Console.WriteLine("цифры нет");
}
else Console.WriteLine(num[2]);
*/

    // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) Console.Write("Понедельник");
if (num == 2) Console.Write("Вторник");
if (num == 3) Console.Write("Среда");
if (num == 4) Console.Write("Четверг");
if (num == 5) Console.Write("Пятница");
if (num == 6) Console.Write("Суббота");
if (num == 7) Console.Write("Воскресенье");
if (num <=5) Console.Write(", работаем :( ");
if (num >=6 ) Console.Write(", отдыхаем :) ");
*/