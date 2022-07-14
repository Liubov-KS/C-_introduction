/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.WriteLine("Давайте создадим таблицу из случайных чисел. Cколько в таблице будет строк?");
int amountOfStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cколько в таблице будет колонок?");
int amountOfCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какое минимальное значение элемента будет в таблице?");
int lowerBound = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А максимальное?");
int upperBound = Convert.ToInt32(Console.ReadLine());

int[,] MatrixOfRandomInt(int lines, int columns, int min , int max)
{
    int[,] matrix = new int[lines, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max+1);
        }
    }
    return matrix;
}

// элементарно переделывается в сетчик по строкам, кстати. можно запилить селектор и этот код в практически неизменном виде будет делать и так и сяк.
// есть ощущение, что это можно сделать проще.

double[] AverageByColumns(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)]; // результирующий массив размером = количество столбцов в матрице
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++) // перебираем элементы в одном столбце...
        {
             result[i] += matrix[j, i]; // ... и просто складываем в результирующий массив...
        }
        result[i] = Math.Round(result[i]/matrix.GetLength(0), 2); // ...превращаем суммы в среднее значение.
    }
    return result;
}

void PrinterMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j]}, ");
            else Console.Write($"{matrix[i,j]}]");    
        }
        Console.WriteLine();
    }
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

int[,] matrix = MatrixOfRandomInt(amountOfStr, amountOfCol, lowerBound, upperBound);
double[] result = AverageByColumns(matrix);
Console.WriteLine("Волею ГСЧ мы получили таблицу!");
PrinterMatrix(matrix);
Console.WriteLine("Средний результат по колонкам:");
PrinterArray(result);