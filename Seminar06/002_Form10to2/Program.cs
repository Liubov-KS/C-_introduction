Console.Write($"Введите число для перевода в двоичную систему счисления: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] ConvertorToBasisTwo(int a)
{
    List<int> digits = new List<int>();
    int temp = 0;
    while (a > 0)
    {
        temp = a % 2;
        digits.Add(temp);
        a /= 2;
    }
    digits.Reverse();
    int[] result = digits.ToArray();
    return result;
}

void PrinterArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"{array[i]}");
        else if (i == array.Length - 1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]}");        
    }
}

int[] massive = ConvertorToBasisTwo(number);
PrinterArray(massive);
















/*
{
    string result = string.Empty;
    string temp = string.Empty;
    int k = 0;
    while(a / 2 > 2)
    {
        temp = Convert.ToString(a-(a/2)*2);
        result.Join(temp);
        a = a / 2;
    }
    k = Convert.ToInt32(result);
}

int tobasistwo = ConvertorToBasisTwo(10);
Console.WriteLine(tobasistwo);
*/