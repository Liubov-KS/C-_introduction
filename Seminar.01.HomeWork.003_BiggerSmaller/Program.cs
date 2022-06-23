// Условия задачи и пример вывода в презентации конфликтуют.
Console.Write("Ведите первое число: ");
double number1 =  Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите второе число: ");
double number2 =  Convert.ToDouble(Console.ReadLine());
if (number1 > number2)
{
    Console.Write($"max = {number1}, min = {number2}");
}
else if (number1 < number2)
{
    Console.Write($"max = {number2}, min = {number1}");
}
else
{
    Console.Write("Числа равны друг другу.");
}