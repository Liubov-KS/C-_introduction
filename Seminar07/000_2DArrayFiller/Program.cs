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

void PrinterArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0) Console.Write($"[{array[i,j]}, ");
            else if (j == array.GetLength(1) - 1) Console.Write($"{array[i,j]}]");
            else Console.Write($"{array[i,j]}, ");        
        }
    }
}

int[,] result = MatrixOfRandomInt(3,4,1,10);
PrinterArray(result);