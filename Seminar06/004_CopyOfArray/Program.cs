/*
Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.
*/

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

int[] CopyOfArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < copy.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] massive = ArrayOfRandom(5, 1, 10);
PrinterArray(massive);
int[] massivecopy = CopyOfArray(massive);
PrinterArray(massivecopy);