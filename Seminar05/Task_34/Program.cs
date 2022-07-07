/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Write($"Введите количество элементов: ");
int amountOfElements = Convert.ToInt32(Console.ReadLine());

void PrinterArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");        
    }
}

int[] ArrayOfRandom(int length, int bottomline, int upperline)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rnd.Next(bottomline, upperline);
    }
    return array;
}

int EvenCounter(int[] array)
{
    int result = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0) result++; 
    }
    return result;
}

int[] massive = ArrayOfRandom(amountOfElements, 100, 1000);
int result = EvenCounter(massive);
PrinterArray(massive);
Console.Write($"Количество четных чисел в случайно сгенерированном массиве получилось равно {Convert.ToString(result)}.");