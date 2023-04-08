
    // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
if (num[0] == num[4])
{
    if (num[1] == num[3]) Console.WriteLine("да");
}
else Console.WriteLine("нет");
*/

    // Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(int x, int y, int z, int x2, int y2, int z2)
{
    double dis = Math.Sqrt(((x - x2) * (x - x2)) + ((y - y2) * (y - y2)) + ((z - z2) * (z - z2)));
    return dis;
}
Console.WriteLine("Задайте координаты первой точки");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Distance(x, y, z, x2, y2, z2));
*/

    // Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
double Cube(int i)
{
    double cube = Math.Pow(i, 3);
    return cube;
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<n; i++)
{
    Console.Write($"{Cube(i)}, ");
}
Console.Write($"{Cube(n)}.");
*/
