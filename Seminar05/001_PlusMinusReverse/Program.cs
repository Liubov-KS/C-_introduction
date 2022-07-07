int[] ArrayOfRandom(int length, int bottomline, int upperline)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rnd.Next(bottomline, upperline);
    }
    return array;
}

int[] SignReverse(int[] array)
{
    int[] massive = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        massive[i] = -array[i];
    }
    return massive;
}   

void PrinterArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");        
    }
}

int[] massive = ArrayOfRandom(5, -10, 11);
int[] reversedmassive = SignReverse(massive);
PrinterArray(massive);
PrinterArray(reversedmassive);