// f(n) = f(n-2) + f(n-1)
Console.Write($"Укажите количество чисел Фибоначчи для вывода: ");
int N = Convert.ToInt32(Console.ReadLine());

int first = 0;
int second = 1;

if (N == 1) Console.Write($"{first}");
if (N == 2) Console.Write($"{first}, {second}");
if (N > 2)
{
    Console.Write($"{first} ");
    int temp1 = 0;
    int temp2 = 1;
    int fibo = 0;
    for (int i = 2; i < N; i++)
    {
        fibo = temp2 + temp1;
        Console.Write($"{fibo} ");
        temp2 = temp1;
        temp1 = fibo;
    }
}
