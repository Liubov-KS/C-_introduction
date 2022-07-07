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

void PrinterArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");        
    }
}

int[] Multiplicator(int[] array)
{
    int length = 0;
    int[] result = new int[length];
    if (array.Length % 2 == 0) 
    {
        length = array.Length / 2;
        result = new int[length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[array.Length-(1+i)];
        }

    }
    if (array.Length % 2 != 0)
    {
        length = array.Length / 2 + 1;
        result = new int[length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[array.Length-(1+i)];
        }
        result[result.Length-1] = array[array.Length/2];
    }
    return result;
}

int[] massive = ArrayOfRandom(7, 1, 5);
int[] result = Multiplicator(massive);
PrinterArray(massive);
PrinterArray(result);
