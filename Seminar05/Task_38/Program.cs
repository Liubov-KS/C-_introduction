/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write($"Введите количество элементов:");
int amountOfElements = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите нижнюю (включая) границу диапазона случайных значений элементов:");
int lowline = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите верхнюю (не включая) границу диапазона случайных значений элементов:");
int highline = Convert.ToInt32(Console.ReadLine());

double[] ArrayOfRandom(int length, int bottomline, int upperline)
{
    double[] array = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = 
       Math.Round(
       rnd.NextDouble() * (upperline - bottomline) + bottomline, 
       2);
    }
    return array;
}

void PrinterArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");        
    }
}

double MinMaxDiff(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];
    foreach (double i in array)
    {
        if (i > max) max = i;
        if (i < min) min = i;
    }
    result = Math.Round(max - min, 2);
    return result;
}

double[] massive = ArrayOfRandom(amountOfElements, lowline, highline);
PrinterArray(massive);
double result = MinMaxDiff(massive);
Console.Write($"Разница между максимальным и минимальным элементами случаной сгенерированного массива равна {Convert.ToString(result)}");