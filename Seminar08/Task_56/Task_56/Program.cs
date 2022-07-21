/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] MatrixOfRandomInt(int lines, int columns, int min, int max)
{
    int[,] matrix = new int[lines, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrinterMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}]");
        }
        Console.WriteLine();
    }
}

int LineWithLesserSumOfElems(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i, j];
        }
    }

    int min = result[0];
    int index = 0;
    for (int j = 1; j < result.Length; j++)
    {
        if (result[j] < min)
        {
            index = j;
            min = result[j];
        }
    }
    return index;
}

int[,] matr = MatrixOfRandomInt(2, 4, 1, 5);
PrinterMatrix(matr);
Console.WriteLine();
int res = LineWithLesserSumOfElems(matr);
Console.WriteLine($"Строка с наименьшей суммой элементов имеет индекс {res}.");