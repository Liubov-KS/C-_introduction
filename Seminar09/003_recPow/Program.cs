Console.Write("Задайте основание степени: ");
int basis = int.Parse(Console.ReadLine());
Console.Write("Задайте степень: ");
int power = int.Parse(Console.ReadLine());

int RecPower(int a, int b)
{
    if (b == 0) return 1;
    else return RecPower(a, b-1)*a;
}

int res = RecPower(basis, power);
Console.Write($"{res} ");