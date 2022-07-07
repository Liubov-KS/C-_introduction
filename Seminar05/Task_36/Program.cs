/*
 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write($"Введите количество элементов:");
int amountOfElements = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите нижнюю (включая) границу диапазона случайных значений элементов:");
int lowline = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите верхнюю (не включая) границу диапазона случайных значений элементов:");
int highline = Convert.ToInt32(Console.ReadLine());

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

void PrinterArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");        
    }
}

int SummOfOddIndex(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result += array[i];
    }
    return result;
}

int[] massive = ArrayOfRandom(amountOfElements, lowline, highline);
int result = SummOfOddIndex(massive);
PrinterArray(massive);
Console.Write($"Сумма элементов случайно сгенерированного массива в пределах от [{lowline};{highline}) стоящих на нечетных позициях равна {Convert.ToString(result)}.");