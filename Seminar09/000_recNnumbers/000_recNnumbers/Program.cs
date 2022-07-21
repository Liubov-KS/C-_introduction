Console.Clear();

Console.Write("Задайте число: ");
int num = int.Parse(Console.ReadLine());

void NaturalNumber(int n)
{
    if (n == 0) return;
    NaturalNumber(n - 1);
    Console.Write($"{n} ");
}

NaturalNumber(num);