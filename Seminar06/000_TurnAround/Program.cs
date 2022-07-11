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

void ArrayTurner(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length-(1+i)];
        array[array.Length-(1+i)] = temp;
    }
}

int[] massive = ArrayOfRandom(6, 1, 10);
PrinterArray(massive);
ArrayTurner(massive);
PrinterArray(massive);
