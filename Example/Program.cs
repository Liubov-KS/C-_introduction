/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
*/

int[,] FillMatrixRndInt(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");
            else Console.Write(array[i, j] + "]");
        }
        Console.WriteLine();
    }
}
void SumAverage(int[,] array)
{
    double averageByCol = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        averageByCol = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            averageByCol += array[j, i];
        }
        averageByCol /= array.GetLength(0);
        Console.Write($"{averageByCol} ");
    }

}

int[,] arrayRes = FillMatrixRndInt(3, 3);
PrintMatrix(arrayRes);
SumAverage(arrayRes);
