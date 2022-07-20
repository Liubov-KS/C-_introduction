/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();
void PrinterArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
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


// я не вывез. дошел до понимая того, что нужно 3 цикла, но как правильно итераторы по индексам расставить меня уже не хватило,
// пришлось смотреть stackoverflow. 

int[,] MultiplicatorOf2Matrix(int[,] leftmatrix, int[,] rigthmatrix)
{
    int[,] product = new int[leftmatrix.GetLength(0), rigthmatrix.GetLength(1)];
    for (int i = 0; i < leftmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < rigthmatrix.GetLength(1); j++)
        {
            for (int k = 0; k < rigthmatrix.GetLength(0); k++)
            {
                product[i, j] += leftmatrix[i, k] * rigthmatrix[k, j];
            }
        }
    }
    return product;
}

int[,] left = MatrixOfRandomInt(2, 2, 1, 5);
int[,] rigth = MatrixOfRandomInt(2, 2, 1, 5);
PrinterMatrix(left);
Console.WriteLine();
PrinterMatrix(rigth);
Console.WriteLine();
int[,] result = MultiplicatorOf2Matrix(left, rigth);
PrinterMatrix(result);