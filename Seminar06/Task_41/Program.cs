/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4

*/

Console.WriteLine("Сколько чисел будем вводить? ");
int length = Convert.ToInt32(Console.ReadLine());

int[] ArrayFiller(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}

int GreaterThenZero(int[] array)
{
    int result = 0;
    foreach (int i in array)
    {
        if (i > 0) result++; 
    }
    return result;
}

int[] result = ArrayFiller(length);
int counter = GreaterThenZero(result);
Console.Write($"Количество чисел, превышающих 0, равно {counter}.");