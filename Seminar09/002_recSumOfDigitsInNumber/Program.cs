Console.Write("Задайте число: ");
int number = int.Parse(Console.ReadLine());

int Collector(int num, int sum)
{
    sum += num % 10;
    if (num / 10 == 0) return sum;
    else return Collector(num / 10, sum);
}

int Collector(int num, int sum)
{
    if (sum<10) return;
    {
        sum += num % 10;
        Collector(sum / 10, sum);
    }
}

int result = Collector(number, 0);
Console.Write($"{result} ");

