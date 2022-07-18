void PrinterArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");        
    }
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

int[] FromMatrixToArray (int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)*matrix.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count] = matrix[i,j];
            count++;
        }
    }
    return result;
}

int[,] Dictionary(int[] array)
{ 
    int amountOfLines = array.Distinct().ToArray().Length;
    int[,] result = new int[2, amountOfLines];
    // заполняем ключи словаря
    for (int i = 0; i < result.GetLength(1); i++)
    {
        result[0, i] = array.Distinct().ToArray()[i];
    }
    // заполняем значения словаря
    int currentElem = array[0];
    int positionOfvalue = 0;
    int counterOfuniqes = 1;
    for (int j = 1; j < array.Length; j++)
    {
        if (currentElem == array[j])
        {
            counterOfuniqes++;
        }
        if (currentElem != array[j] || j == array.Length-1)
        {
                currentElem = array[j];
                result[1, positionOfvalue] = counterOfuniqes;
                counterOfuniqes = 1;
                positionOfvalue++;
        }
    }
    return result;
}


int[,] matr = MatrixOfRandomInt(3, 3, 1, 5);
int[] res = FromMatrixToArray(matr);
Array.Sort(res);

PrinterMatrix(matr);
Console.WriteLine();
PrinterArray(res);
int[,] dict = Dictionary(res);
Console.WriteLine();
PrinterMatrix(dict);