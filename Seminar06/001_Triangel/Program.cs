Console.Write($"Введите первую сторону:");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите вторую сторону:");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите третью сторону:");
int third = Convert.ToInt32(Console.ReadLine());

bool Checker(int a, int b, int c)
{
    int ab = a + b;
    int bc = b + c;
    int ac = a + c;
    if (c >= ab || a >= bc || b >= ac)
    {
        return false;
    }
    else
    {
        return true;
    }
}

bool answer = Checker(first, second, third);
if (answer == true)
{
    Console.WriteLine("Бывает такое треугольник");
}
else
{
    Console.WriteLine("Не бывает такого треугольника");
}