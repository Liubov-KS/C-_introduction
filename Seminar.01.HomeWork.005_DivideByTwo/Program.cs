Console.Write("Ведите число: ");
double number = Convert.ToDouble(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write("Да, делиться на 2");
}
else
{
    Console.Write("Нет, не делиться на 2");
}