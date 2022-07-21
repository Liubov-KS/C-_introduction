Console.Clear();

Console.Write("Задайте начальное число: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Задайте конечное число: ");
int finish = int.Parse(Console.ReadLine());

void NaturalNumberFormMtoN(int m, int n)
{
    
    if (m > n) 
    {
        NaturalNumberFormMtoN(m-1, n);
        Console.Write($"{m} ");
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNumberFormMtoN(m+1, n);
    }
    else
    {
        Console.Write($"{n} ");
    }
}

NaturalNumberFormMtoN(start, finish);