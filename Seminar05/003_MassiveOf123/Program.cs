int[] ArrayOfRandom(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rnd.Next();
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

int ElemCounter(int[] array)
{
    int counter = 0;
    foreach (int i in array)
    {
        if (i >= 10 && i <= 99)
        {
            counter++;
        }
    }
    return counter;
}

int[] massive = ArrayOfRandom(123);
// PrinterArray(massive);
string result =Convert.ToString(ElemCounter(massive));
Console.Write(result);