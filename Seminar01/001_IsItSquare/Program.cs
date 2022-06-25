double number1 = double.Parse(Console.ReadLine());
double number2 = double.Parse(Console.ReadLine());
if (number2 == number1 * number2)
{
    Console.WriteLine($"{number1} это квадрат {number2}");
}
else
{
    Console.WriteLine($"{number1} это не квадрат {number2}");
}