/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8
*/


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

// выдернули строку, отсортировали, запихали обратно.
// можно сортировать элементы "не вынимая" из массива. 
// но представленный вариант легко переделать под другие задачи, связанные с измением строк/столбцов т.к. сортировка вынесена за пределы циклов.

void LinesSorter(int[,] matrix)
{
    int[] temp = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            temp[i] = matrix[j, i];
        }
        Array.Sort(temp);
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[j, i] = temp[i];
        }
    }
    return;
}

int[,] matr = MatrixOfRandomInt(5, 5, 1, 5);
PrinterMatrix(matr);
LinesSorter(matr);
Console.WriteLine();
PrinterMatrix(matr);

