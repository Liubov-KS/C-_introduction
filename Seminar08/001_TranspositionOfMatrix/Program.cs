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

int[,] TranspositionOfMatrix (int[,] matrix)
{

    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i, j] = matrix[j, i];
        }
    }
    return result;
}

int[,] matr = MatrixOfRandomInt(5,5,1,5);
PrinterMatrix(matr);
Console.WriteLine();
if (matr.GetLength(0) == matr.GetLength(1))
{
    int[,] res = TranspositionOfMatrix(matr);
    PrinterMatrix(res);
}
else
{
    Console.WriteLine("Таблица не квадратная, транспонирование невозможно.");
}