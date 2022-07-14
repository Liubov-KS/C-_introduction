/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Давайте создадим таблицу из случайны вещественных чисел. Cколько в таблице будет строк?");
int amountOfStr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cколько в таблице будет колонок?");
int amountOfCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какое минимальное значение элемента будет в таблице?");
int lowerBound = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А максимальное?");
int upperBound = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Длинные числа. До какого знака округлить?");
int accuracy = Convert.ToInt32(Console.ReadLine());

double[,] MatrixOfRandomDouble(int lines, int columns, int min , int max, int rounder)
{
    double[,] matrix = new double[lines, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round((rnd.NextDouble() * (max - min) + min), rounder);
        }
    }
    return matrix;
}

void PrinterMatrix(double[,] matrix)
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

double[,] result = MatrixOfRandomDouble(amountOfStr, amountOfCol, lowerBound, upperBound, accuracy);
Console.WriteLine("А вот и наша таблица!");
PrinterMatrix(result);