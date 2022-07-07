Console.WriteLine("Введите число для поиска: ");
int number =  Convert.ToInt32(Console.ReadLine());

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

bool Finder(int[] array, int request)
{
    foreach (int i in array)
    {
        if (i == request) return true;
    }
    return false;
}

int[] massive = ArrayOfRandom(10, -5, 6);
PrinterArray(massive);
bool answer = Finder(massive, number);

if (answer == true) Console.WriteLine($"В массиве есть элемент {number}.");
if (answer == false) Console.WriteLine($"В массиве нет элемента {number}.");
