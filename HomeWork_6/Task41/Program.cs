// 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine($"Сколько чисел будем выводить?");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = UserInputNumbers(m);
int result = MoreThan0Counter(array);
Console.WriteLine($"{result} чисел(а) больше 0 ");


int[] UserInputNumbers(int input)
{
    int[] arrNew = new int[input];
    for (int i = 0; i < input; i++)
    {
        Console.Write($"число -> ");
        arrNew[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrNew;
}

int MoreThan0Counter(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) counter++;
    }
    return counter;
}
