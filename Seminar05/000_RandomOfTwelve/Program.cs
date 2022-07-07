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

int[] Adder(int[] massive)
{
    int summofplus = 0;
    int summofminus = 0;
    foreach (int i in massive)
    {
        if (i > 0) summofplus += i;
        if (i < 0) summofminus += i;
    }
    return new[] {summofplus, summofminus};
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

int [] array = ArrayOfRandom(12, -9, 10);
int [] summ = Adder(array);
PrinterArray(array);
PrinterArray(summ);