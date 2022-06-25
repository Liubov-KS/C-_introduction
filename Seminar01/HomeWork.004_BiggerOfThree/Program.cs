/*Плохо масштабируется. Для произвольного количества чисел стоило бы писать из ввода массив и искать циклом 
(раз конструкции вроде Enumerable.Max() запрещены) максимум в нем. Наверное.*/
Console.Write("Ведите первое число: ");
double max = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите второе число: ");
double number2 =  Convert.ToDouble(Console.ReadLine());
if (number2 > max)
{
    max = number2;
}
Console.Write("Ведите третье число: ");
double number3 =  Convert.ToDouble(Console.ReadLine());
if (number3 > max)
{
    max = number3;
}
Console.Write($"Максимальное число: {max}");